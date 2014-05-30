using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HuntTheWumpus
{
	public partial class TriviaUI : Form
	{
		public TriviaUI()
		{
			InitializeComponent();
			LoadQuestions();
			DisplayQuestion(questionList[index]);
		}

		private Trivia _Trivia;
		private List<Question> questionList = new List<Question>();
		private int index = 0;
		private int correctAnswerNumber = 0;
		private int numQuestionsToDisplay = 3;
		int questionsNeeded = 0;

		public void LoadQuestions()
		{
			_Trivia = new Trivia();
			StreamReader sr = new StreamReader("Trivia Questions.txt");
			String line = sr.ReadLine();
			while (line != null)
			{
				//Handle questions
				String[] components = line.Split(',');
				if (components.Length == 5)
				{
					Question newQ = new Question(components);
					questionList.Add(newQ);
				}

				line = sr.ReadLine();
			}
		}

		private void DisplayQuestion(Question displayQ)
		{
			if (index >= questionList.Count)
			{
				return;
			}
			textBox1.Text = displayQ.question;
			button2.Text = displayQ.answers[0];
			button3.Text = displayQ.answers[1];
			button4.Text = displayQ.answers[2];
			button5.Text = displayQ.answers[3];
			index++;

		}

		public void displayQuestions(int number)
		{
			if (numQuestionsToDisplay > 0)
			{
				numQuestionsToDisplay--;
			}
			else
			{
				this.Hide();
			}
			
			numQuestionsToDisplay = number;
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
            index = index % questionList.Count;
            nextQuestion(questionsNeeded);
			DisplayQuestion(questionList[index]);
			
		}

		public int nextQuestion(int questionRequired)
		{
			questionsNeeded = questionRequired - 1;
            if (questionsNeeded == 0)
            {
                this.Hide();
                GameControl.resolveHazard(GetCorrectAnswers());
                GameControl.triviaFinal(GetCorrectAnswers());
            }
			return questionsNeeded;
		}

        public bool finished()
        {
            if (questionsNeeded == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			correctAnswerNumber++;
			

		}

		public int GetCorrectAnswers()
		{
			return correctAnswerNumber;
		}
	}
}
