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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button_Learn_Click(object sender, EventArgs e)
		{
			Form_learnWord form_LearnWord = new Form_learnWord();
			this.Hide();
			form_LearnWord.Show();
		}

		private void button_Test_Click(object sender, EventArgs e)
		{
            Form_test form_Test = new Form_test();
            this.Hide();
            form_Test.Show();
		}

		private void button_SelectAddWord_Click(object sender, EventArgs e)
		{
			Form_addWord form_AddWord = new Form_addWord();
			this.Hide();
			form_AddWord.Show();
		}

		private void button_LearnedWords_Click(object sender, EventArgs e)
		{
			Form_learnedWords form_LearnedWords = new Form_learnedWords();
			this.Hide();
			form_LearnedWords.Show();
		}

		private void button_Exit_Click(object sender, EventArgs e)
		{
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
