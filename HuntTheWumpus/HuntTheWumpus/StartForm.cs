using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void startButton_Click_1(object sender, EventArgs e)
		{
			//TODO: Tell GameControl to start.
		}

		private void hsButton_Click(object sender, EventArgs e)
		{
			//TODO: Tell GameControl to display HS form
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
    }
}
