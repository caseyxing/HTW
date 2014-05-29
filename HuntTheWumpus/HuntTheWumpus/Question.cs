using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
	public class Question  
	{
		public String question;
		public String[] answers = new String[4];

		public Question(String[] strings)
		{
			question = strings[0];
			for (int x = 1; x < 5; x++)
			{
				answers[x - 1] = strings[x];
			}
		}
	}
}
