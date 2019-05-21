using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Son.Backend;

namespace Son
{
	public partial class Form_addWord : Form
	{
		public Form_addWord()
		{
			InitializeComponent();
		}

		SQLiteDatabase sqlite = new SQLiteDatabase();

		private void button_back_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
			sqlite.close();
		}

		private void Form_addWord_Load(object sender, EventArgs e)
		{
			sqlite.open();
			sqlite.showInListbox(listBox_library);
		}

		private void button_select_Click(object sender, EventArgs e)
		{
			sqlite.selectWord(listBox_library);
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			sqlite.addWord(listBox_library, textBox_turkish, textBox_english, textBox_example, textBox_exampleMean,textBox_type);
		}

        private void label_english_Click(object sender, EventArgs e)
        {

        }

        private void label_example_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_add_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_turkish_Click(object sender, EventArgs e)
        {

        }

        private void textBox_turkish_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_example_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_exampleMean_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_type_Click(object sender, EventArgs e)
        {

        }

        private void label_exampleMean_Click(object sender, EventArgs e)
        {

        }

        private void textBox_english_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
