using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus
{
	public partial class PlayerInstructionsForm : Form
	{
		public PlayerInstructionsForm()
		{
			InitializeComponent();
		}

		private void ArrowDetails_Click(object sender, EventArgs e)
		{
			ArrowsInstructionsForm arrInstructForm = new ArrowsInstructionsForm();
			arrInstructForm.Show();
		}

		private void TriviaDetails_Click(object sender, EventArgs e)
		{
			TriviaInstructionsForm arrInstructForm = new TriviaInstructionsForm();
			arrInstructForm.Show();
		}

		private void NavagationDetails_Click(object sender, EventArgs e)
		{

			NavigationInstructionsForm arrInstructForm = new NavigationInstructionsForm();
			arrInstructForm.Show();

		}

		private void TrapsDetails_Click(object sender, EventArgs e)
		{
			TrapsInstructionsForm arrInstructForm = new TrapsInstructionsForm();
			arrInstructForm.Show();

		}

		private void ScoreDetails_Click(object sender, EventArgs e)
		{

			ScoreInstructionForm arrInstructForm = new ScoreInstructionForm();
			arrInstructForm.Show();

		}

        private void PlayerInstructionsForm_Load(object sender, EventArgs e)
        {

        }

        private void Instruction3_Click(object sender, EventArgs e)
        {

        }




	}
}
