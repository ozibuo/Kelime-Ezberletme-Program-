using Son.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Son
{
    public partial class Form_test : Form
    {
        public Form_test()
        {
            InitializeComponent();
        }
        Form1 form1 = new Form1();
        Library l = new Library();
        int i;
        SQLiteDatabase sqlite = new SQLiteDatabase();
        private void Form_test_Load(object sender, EventArgs e)
        {
            sqlite.open();
            sqlite.transferMustLearnWords(l.mustLearnWords);
            sqlite.close();
            for (i=0; i< l.mustLearnWords.Count;i++)
            {
                if (l.mustLearnWords[i].process == 1)
                {
                    if (DateTime.Now.Day == ((Convert.ToDateTime(l.mustLearnWords[i].date)).AddDays(1)).Day)
                    {
                        label_english.Text = l.mustLearnWords[i].english;
                        i++;
                        break;
                    }
                }
                else if (l.mustLearnWords[i].process == 2)
                {
                    if (DateTime.Now.Day == ((Convert.ToDateTime(l.mustLearnWords[i].date)).AddDays(7)).Day)
                    {
                        label_english.Text = l.mustLearnWords[i].english;
                        i++;
                        break;
                    }
                }
                else if (l.mustLearnWords[i].process == 3)
                {
                    if (DateTime.Now.Day == ((Convert.ToDateTime(l.mustLearnWords[i].date)).AddDays(30)).Day)
                    {
                        label_english.Text = l.mustLearnWords[i].english;
                        i++;
                        break;
                    }
                }
                else if (l.mustLearnWords[i].process == 4)
                {
                    if (DateTime.Now.Day == ((Convert.ToDateTime(l.mustLearnWords[i].date)).AddDays(180)).Day)
                    {
                        label_english.Text = l.mustLearnWords[i].english;
                        i++;
                        break;
                    }
                }
                else
                    i++;
            }
            if (i == l.mustLearnWords.Count)
            {
                MessageBox.Show("ÖĞRENİLECEK KELİME BULUNMAMAKTADIR");
                label_english.Text = "";
                textBox_turkish.Enabled = false;
                button_check.Enabled = false;
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (l.mustLearnWords[i - 1].turkish.ToLower() == textBox_turkish.Text.ToLower())
            {
                l.mustLearnWords[i - 1].process++;
                MessageBox.Show("CEVABIN DOĞRU");
                textBox_turkish.Clear();
                if (l.mustLearnWords[i - 1].process == 5)
                {
                    sqlite.open();
                    sqlite.MustLearntoLearnedWords(l.mustLearnWords[i - 1].english);
                    sqlite.close();
                    MessageBox.Show("TEBRİKLER BU KELİMEYİ ÖĞRENDİNİZ");
                }
                else
                {
                    sqlite.open();
                    sqlite.MustLearnWordsProcess(l.mustLearnWords[i - 1].english, l.mustLearnWords[i - 1].process);
                    sqlite.close();
                }
            }
            else if (textBox_turkish.TextLength == 0)
            {
                MessageBox.Show("BOŞ DEĞER GİRDİNİZ");
            }
            else
            {
                l.mustLearnWords[i - 1].process = 1;
                MessageBox.Show("CEVABIN YANLIŞ");
                textBox_turkish.Clear();
            }
            if (i == l.mustLearnWords.Count)
            {
                MessageBox.Show("ÖĞRENİLECEK KELİME BULUNMAMAKTADIR");
                this.Hide();
                form1.Show();
            }
            while (i != l.mustLearnWords.Count)
            {
                i++;
                if (l.mustLearnWords[i-1].process == 1)
                {
                    if (DateTime.Now.Day == ((Convert.ToDateTime(l.mustLearnWords[i-1].date)).AddDays(1)).Day)
                    {
                        label_english.Text = l.mustLearnWords[i-1].english;
                        break;
                    }
                }
                else if (l.mustLearnWords[i-1].process == 2)
                {
                    if (DateTime.Now.Day == ((Convert.ToDateTime(l.mustLearnWords[i-1].date)).AddDays(7)).Day)
                    {
                        label_english.Text = l.mustLearnWords[i-1].english;
                        break;
                    }
                }
                else if (l.mustLearnWords[i-1].process == 3)
                {
                    if (DateTime.Now.Day == ((Convert.ToDateTime(l.mustLearnWords[i-1].date)).AddDays(30)).Day)
                    {
                        label_english.Text = l.mustLearnWords[i-1].english;
                        break;
                    }
                }
                else if (l.mustLearnWords[i-1].process == 4)
                {
                    if (DateTime.Now.Day == ((Convert.ToDateTime(l.mustLearnWords[i-1].date)).AddDays(180)).Day)
                    {
                        label_english.Text = l.mustLearnWords[i-1].english;
                        break;
                    }
                }
            }
        }
    }
}