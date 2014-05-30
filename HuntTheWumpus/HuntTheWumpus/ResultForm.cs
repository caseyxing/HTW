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
	public partial class ResultForm : Form
	{
		public ResultForm()
		{
			InitializeComponent();
		}

		private void ResultForm_Load(object sender, EventArgs e)
		{

		}

		public void setResult(bool Win)
		{
            if (Win)
            {this.BackgroundImage = HuntTheWumpus.Properties.Resources.win; }
            else
            { this.BackgroundImage = HuntTheWumpus.Properties.Resources.lose;}
		}
	}
}
