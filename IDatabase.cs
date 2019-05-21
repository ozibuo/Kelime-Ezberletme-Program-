using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Son.Backend
{
	public interface IDatabase
	{
		void open();
		void close();
		void selectWord(ListBox listBox);
		void addWord(ListBox listBox,TextBox t1,TextBox t2,TextBox t3,TextBox t4,TextBox t5);
		void showInListbox(ListBox listBox);
		void transferMustLearnWords(List<Word> mustLearnWords);
		void transferLearnedWords(List<Word> learnedWords);
	}
}
