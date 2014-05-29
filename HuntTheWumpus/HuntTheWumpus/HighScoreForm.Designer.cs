namespace HuntTheWumpus
{
	partial class HighScoreForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tempScoreLabel = new System.Windows.Forms.Label();
			this.enterNameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.tempScoreTextBox = new System.Windows.Forms.TextBox();
			this.highScoresBox = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.HighScoreTitleLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tempScoreLabel
			// 
			this.tempScoreLabel.AutoSize = true;
			this.tempScoreLabel.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tempScoreLabel.Location = new System.Drawing.Point(95, 126);
			this.tempScoreLabel.Name = "tempScoreLabel";
			this.tempScoreLabel.Size = new System.Drawing.Size(72, 12);
			this.tempScoreLabel.TabIndex = 5;
			this.tempScoreLabel.Text = "Temp Score:";
			// 
			// enterNameLabel
			// 
			this.enterNameLabel.AutoSize = true;
			this.enterNameLabel.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enterNameLabel.Location = new System.Drawing.Point(61, 87);
			this.enterNameLabel.Name = "enterNameLabel";
			this.enterNameLabel.Size = new System.Drawing.Size(106, 12);
			this.enterNameLabel.TabIndex = 6;
			this.enterNameLabel.Text = "Enter Your Name:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(222, 87);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(172, 20);
			this.nameTextBox.TabIndex = 7;
			this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged_1);
			// 
			// tempScoreTextBox
			// 
			this.tempScoreTextBox.Location = new System.Drawing.Point(224, 126);
			this.tempScoreTextBox.Name = "tempScoreTextBox";
			this.tempScoreTextBox.Size = new System.Drawing.Size(169, 20);
			this.tempScoreTextBox.TabIndex = 8;
			// 
			// highScoresBox
			// 
			this.highScoresBox.FormattingEnabled = true;
			this.highScoresBox.Location = new System.Drawing.Point(12, 204);
			this.highScoresBox.Name = "highScoresBox";
			this.highScoresBox.Size = new System.Drawing.Size(177, 251);
			this.highScoresBox.TabIndex = 9;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Vladimir Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(224, 193);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(169, 32);
			this.button2.TabIndex = 10;
			this.button2.Text = "Add High Score";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// HighScoreTitleLabel
			// 
			this.HighScoreTitleLabel.AutoSize = true;
			this.HighScoreTitleLabel.Font = new System.Drawing.Font("Pericles", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HighScoreTitleLabel.Location = new System.Drawing.Point(100, 9);
			this.HighScoreTitleLabel.Name = "HighScoreTitleLabel";
			this.HighScoreTitleLabel.Size = new System.Drawing.Size(245, 45);
			this.HighScoreTitleLabel.TabIndex = 11;
			this.HighScoreTitleLabel.Text = "High Scores";
			// 
			// HighScoreForm
			// 
			this.ClientSize = new System.Drawing.Size(462, 470);
			this.Controls.Add(this.HighScoreTitleLabel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.highScoresBox);
			this.Controls.Add(this.tempScoreTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.enterNameLabel);
			this.Controls.Add(this.tempScoreLabel);
			this.Name = "HighScoreForm";
			this.Load += new System.EventHandler(this.HighScoreForm_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxScore;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label tempScoreLabel;
		private System.Windows.Forms.Label enterNameLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox tempScoreTextBox;
		private System.Windows.Forms.ListBox highScoresBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label HighScoreTitleLabel;
	}
}

