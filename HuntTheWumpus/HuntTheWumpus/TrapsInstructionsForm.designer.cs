namespace HuntTheWumpus
{
	partial class TrapsInstructionsForm
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
            this.backtoPlayerInstructions = new System.Windows.Forms.Button();
            this.InstructionLabel2 = new System.Windows.Forms.Label();
            this.InstructionLabel3 = new System.Windows.Forms.Label();
            this.InstructionLabel4 = new System.Windows.Forms.Label();
            this.InstructionLabel1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backtoPlayerInstructions
            // 
            this.backtoPlayerInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtoPlayerInstructions.Location = new System.Drawing.Point(764, 751);
            this.backtoPlayerInstructions.Name = "backtoPlayerInstructions";
            this.backtoPlayerInstructions.Size = new System.Drawing.Size(293, 37);
            this.backtoPlayerInstructions.TabIndex = 25;
            this.backtoPlayerInstructions.Text = "Back to Player Instructions";
            this.backtoPlayerInstructions.UseVisualStyleBackColor = true;
            this.backtoPlayerInstructions.Click += new System.EventHandler(this.backtoPlayerInstructions_Click);
            // 
            // InstructionLabel2
            // 
            this.InstructionLabel2.AutoSize = true;
            this.InstructionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel2.Location = new System.Drawing.Point(12, 326);
            this.InstructionLabel2.Name = "InstructionLabel2";
            this.InstructionLabel2.Size = new System.Drawing.Size(516, 20);
            this.InstructionLabel2.TabIndex = 24;
            this.InstructionLabel2.Text = "Answer it incorrectly... AND YOU DIE. (Or you get moved back, either or)";
            // 
            // InstructionLabel3
            // 
            this.InstructionLabel3.AutoSize = true;
            this.InstructionLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel3.Location = new System.Drawing.Point(12, 500);
            this.InstructionLabel3.Name = "InstructionLabel3";
            this.InstructionLabel3.Size = new System.Drawing.Size(397, 20);
            this.InstructionLabel3.TabIndex = 23;
            this.InstructionLabel3.Text = "But don\'t worry! You\'ll be warned when they are nearby!";
            // 
            // InstructionLabel4
            // 
            this.InstructionLabel4.AutoSize = true;
            this.InstructionLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel4.Location = new System.Drawing.Point(119, 746);
            this.InstructionLabel4.Name = "InstructionLabel4";
            this.InstructionLabel4.Size = new System.Drawing.Size(432, 31);
            this.InstructionLabel4.TabIndex = 22;
            this.InstructionLabel4.Text = "STAY AWAY OR GET OUT FAST!";
            // 
            // InstructionLabel1
            // 
            this.InstructionLabel1.AutoSize = true;
            this.InstructionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel1.Location = new System.Drawing.Point(12, 177);
            this.InstructionLabel1.Name = "InstructionLabel1";
            this.InstructionLabel1.Size = new System.Drawing.Size(384, 20);
            this.InstructionLabel1.TabIndex = 21;
            this.InstructionLabel1.Text = "Answer trivia correctly to get out of the trap! (Just 2/3)";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(488, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(105, 31);
            this.TitleLabel.TabIndex = 20;
            this.TitleLabel.Text = "TRAPS";
            // 
            // TrapsInstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 801);
            this.Controls.Add(this.backtoPlayerInstructions);
            this.Controls.Add(this.InstructionLabel2);
            this.Controls.Add(this.InstructionLabel3);
            this.Controls.Add(this.InstructionLabel4);
            this.Controls.Add(this.InstructionLabel1);
            this.Controls.Add(this.TitleLabel);
            this.Name = "TrapsInstructionsForm";
            this.Load += new System.EventHandler(this.TrapsInstructionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backtoPlayerInstructions;
		private System.Windows.Forms.Label InstructionLabel2;
		private System.Windows.Forms.Label InstructionLabel3;
		private System.Windows.Forms.Label InstructionLabel4;
		private System.Windows.Forms.Label InstructionLabel1;
		private System.Windows.Forms.Label TitleLabel;
	}
}