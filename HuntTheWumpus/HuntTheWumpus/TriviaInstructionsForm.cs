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
	public partial class TriviaInstructionsForm : Form
	{
		public TriviaInstructionsForm()
		{
			InitializeComponent();
		}

		private void backtoPlayerInstructions_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void TriviaInstructionsForm_Load(object sender, EventArgs e)
        {

        }
	}
}
