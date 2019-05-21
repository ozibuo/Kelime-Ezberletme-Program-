using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Son.Backend;

namespace Son
{
	public partial class Form_learnWord : Form
	{
		public Form_learnWord()
		{
			InitializeComponent();
		}

		Library l = new Library();
		int i = 0;

		private void Form_learnWord_Load(object sender, EventArgs e)
		{
			SQLiteDatabase sqlite = new SQLiteDatabase();
			sqlite.open();
			sqlite.transferMustLearnWords(l.mustLearnWords);
			sqlite.close();
			label_turkish.Text = l.mustLearnWords[0].turkish;
			label_english.Text = l.mustLearnWords[0].english;
			label_example.Text = l.mustLearnWords[0].example;
			label_exampleMean.Text = l.mustLearnWords[0].exampleMean;
			label_type.Text = l.mustLearnWords[0].type;
		}

		private void button_next_Click(object sender, EventArgs e)
		{
			i++;
			if (i == l.mustLearnWords.Count)
			{
				i = 0;
				Form1 form1 = new Form1();
				this.Hide();
				form1.Show();
			}
			else
			{
				label_turkish.Text = l.mustLearnWords[i].turkish;
				label_english.Text = l.mustLearnWords[i].english;
				label_example.Text = l.mustLearnWords[i].example;
				label_exampleMean.Text = l.mustLearnWords[i].exampleMean;
				label_type.Text = l.mustLearnWords[i].type;
			}
		}
	}
}
