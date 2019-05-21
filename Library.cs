using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son.Backend
{
	public class Library
	{
		public List<Word> mustLearnWords;
		public List<Word> learnedWords;

		public Library()
		{
			mustLearnWords = new List<Word>();
			learnedWords = new List<Word>();
		}
	}
}
