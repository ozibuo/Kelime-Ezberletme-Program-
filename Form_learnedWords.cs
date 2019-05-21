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
	public partial class Form_learnedWords : Form
	{
		public Form_learnedWords()
		{
			InitializeComponent();
		}

		Library l = new Library();

		private void button_back_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}

		private void Form_learnedWords_Load(object sender, EventArgs e)
		{
			SQLiteDatabase sqlite = new SQLiteDatabase();
			sqlite.open();
			sqlite.transferLearnedWords(l.learnedWords);
			sqlite.close();
			
			for(int i = 0; i < l.learnedWords.Count; i++)
			{
				listBox1_words.Items.Add(l.learnedWords[i].turkish+ "			" + l.learnedWords[i].english+"			"+l.learnedWords[i].date);
			}
		}
	}
}
