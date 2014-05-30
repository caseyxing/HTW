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
	public partial class TrapsInstructionsForm : Form
	{
		public TrapsInstructionsForm()
		{
			InitializeComponent();
		}

		private void backtoPlayerInstructions_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void TrapsInstructionsForm_Load(object sender, EventArgs e)
        {

        }
	}
}
