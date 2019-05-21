using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Son.Backend
{
	public class SQLiteDatabase : IDatabase
	{
		SQLiteConnection con = new SQLiteConnection("Data source=database.db");

		public void open()
		{
			con.Open();
		}

		public void close()
		{
			con.Close();
		}

		public void selectWord(ListBox listBox)
		{
            //Kelimelerden seçilen kelime MustLearn tablosuna aktarılır.
			string str = listBox.SelectedItem.ToString();
			SQLiteCommand cmd1 = con.CreateCommand();
			cmd1.CommandText = "select * from table_words where english=@english,turkish=@turkish";
			cmd1.Parameters.AddWithValue("@english", str);
			cmd1.CommandText = "insert into table_mustLearn (english, turkish,example,exampleMean,type) SELECT english ,turkish,example,exampleMean,type FROM table_words WHERE english=@english";
			SQLiteCommand cmd2 = con.CreateCommand();
			cmd2.Parameters.AddWithValue("@english", str);
			cmd2.CommandText = "delete from table_words where english=@english";
            SQLiteCommand cmd3 = con.CreateCommand();
            cmd3.CommandText = "update table_mustLearn set date=@date,process=@process where english=@english";
            cmd3.Parameters.AddWithValue("@english", str);
            cmd3.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            cmd3.Parameters.AddWithValue("@process", 1);
            cmd1.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
			listBox.Items.Clear();
			showInListbox(listBox);
		}

		public void addWord(ListBox listBox, TextBox t1, TextBox t2, TextBox t3, TextBox t4,TextBox t5)
		{
            //Veritabanına kelime eklenir.
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "insert into table_words(turkish,english,example,exampleMean,type) values('"+t1.Text+"','"+t2.Text+ "','"+t3.Text+"','"+t4.Text+"','"+t5.Text+"')";
			cmd.Connection = con;
			cmd.ExecuteNonQuery();
			listBox.Items.Clear();
			showInListbox(listBox);
		}

		public void showInListbox(ListBox listBox)
		{
            //Kelimeler listbox a aktarılır.
			SQLiteCommand cmd = con.CreateCommand();
			cmd.CommandText = "select*from table_words";
			cmd.ExecuteNonQuery();
			SQLiteDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				listBox.Items.Add(dr["english"]);
			}
		}

		public void transferMustLearnWords(List<Word> mustLearnWords)
		{
            //MustLearnWords tablosu veritabanından list e aktarılır.
            SQLiteCommand com = new SQLiteCommand("select * from table_mustLearn", con);
			SQLiteDataReader rdr = com.ExecuteReader();
			while (rdr.Read())
			{
				Word word = new Word();
				word.turkish = rdr["turkish"].ToString();
				word.english = rdr["english"].ToString();
				word.example = rdr["example"].ToString();
				word.exampleMean = rdr["exampleMean"].ToString();
				word.type = rdr["type"].ToString();
                word.date = rdr["date"].ToString();
                word.process = Convert.ToInt16(rdr["process"]);
				mustLearnWords.Add(word);
			}
		}

        public void MustLearnWordsProcess(string english,int process)
        {
            //Tablodaki kelimenin process i değiştirilir.
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "update table_mustLearn set process=@process where english=@english";
            cmd.Parameters.AddWithValue("@english", english);
            cmd.Parameters.AddWithValue("@process", process);
            cmd.ExecuteNonQuery();
        }
        public void MustLearntoLearnedWords(string english)
        {
            //MustLearn den LearnedWords e sözcük ve bilgileri kopyalanır.
            SQLiteCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "select * from table_mustLearn where english=@english,turkish=@turkish";
            cmd1.Parameters.AddWithValue("@english", english);
            cmd1.CommandText = "insert into table_learnedWords (english,turkish,example,exampleMean,type,date) SELECT english,turkish,example,exampleMean,type,date FROM table_mustLearn WHERE english=@english";
            SQLiteCommand cmd2 = con.CreateCommand();
            cmd2.Parameters.AddWithValue("@english", english);
            cmd2.CommandText = "delete from table_mustLearn where english=@english";
            SQLiteCommand cmd3 = con.CreateCommand();
            cmd3.CommandText = "update table_learnedWords set date=@date where english=@english";
            cmd3.Parameters.AddWithValue("@english", english);
            cmd3.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
        }
        
        public void transferLearnedWords(List<Word> learnedWords)
		{
            //LearnedWords tablosu veritabanından list e aktarılır.
			SQLiteCommand com = new SQLiteCommand("select * from table_learnedWords", con);
			SQLiteDataReader rdr = com.ExecuteReader();
			while (rdr.Read())
			{
				Word word = new Word();
				word.turkish = rdr["turkish"].ToString();
				word.english = rdr["english"].ToString();
				word.example = rdr["example"].ToString();
				word.exampleMean = rdr["exampleMean"].ToString();
				word.type = rdr["type"].ToString();
				word.date = rdr["date"].ToString();
				learnedWords.Add(word);
			}
		}
	}
}