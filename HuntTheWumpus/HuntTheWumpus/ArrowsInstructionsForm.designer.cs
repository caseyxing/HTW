namespace HuntTheWumpus
{
	partial class ArrowsInstructionsForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InstructionLabel1 = new System.Windows.Forms.Label();
            this.InstructionLabel4 = new System.Windows.Forms.Label();
            this.InstructionLabel3 = new System.Windows.Forms.Label();
            this.InstructionLabel2 = new System.Windows.Forms.Label();
            this.backtoPlayerInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(475, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(180, 35);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "ARROWS";
            // 
            // InstructionLabel1
            // 
            this.InstructionLabel1.AutoSize = true;
            this.InstructionLabel1.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel1.Location = new System.Drawing.Point(36, 150);
            this.InstructionLabel1.Name = "InstructionLabel1";
            this.InstructionLabel1.Size = new System.Drawing.Size(656, 28);
            this.InstructionLabel1.TabIndex = 1;
            this.InstructionLabel1.Text = "Why do you need arrows?   To shoot the wumpus!";
            // 
            // InstructionLabel4
            // 
            this.InstructionLabel4.AutoSize = true;
            this.InstructionLabel4.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel4.Location = new System.Drawing.Point(81, 484);
            this.InstructionLabel4.Name = "InstructionLabel4";
            this.InstructionLabel4.Size = new System.Drawing.Size(983, 35);
            this.InstructionLabel4.TabIndex = 6;
            this.InstructionLabel4.Text = "BE CAREFUL: IF YOU RUN OUT OF ARROWS YOU DIE!";
            this.InstructionLabel4.Click += new System.EventHandler(this.label5_Click);
            // 
            // InstructionLabel3
            // 
            this.InstructionLabel3.AutoSize = true;
            this.InstructionLabel3.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel3.Location = new System.Drawing.Point(36, 311);
            this.InstructionLabel3.Name = "InstructionLabel3";
            this.InstructionLabel3.Size = new System.Drawing.Size(998, 28);
            this.InstructionLabel3.TabIndex = 7;
            this.InstructionLabel3.Text = "How to use your arrows?   Shoot into the room you think the wumpus is in!";
            // 
            // InstructionLabel2
            // 
            this.InstructionLabel2.AutoSize = true;
            this.InstructionLabel2.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel2.Location = new System.Drawing.Point(36, 233);
            this.InstructionLabel2.Name = "InstructionLabel2";
            this.InstructionLabel2.Size = new System.Drawing.Size(720, 28);
            this.InstructionLabel2.TabIndex = 8;
            this.InstructionLabel2.Text = "How do you get arrows?   You buy them! (Hotkey is 1)";
            // 
            // backtoPlayerInstructions
            // 
            this.backtoPlayerInstructions.Location = new System.Drawing.Point(980, 639);
            this.backtoPlayerInstructions.Name = "backtoPlayerInstructions";
            this.backtoPlayerInstructions.Size = new System.Drawing.Size(147, 37);
            this.backtoPlayerInstructions.TabIndex = 9;
            this.backtoPlayerInstructions.Text = "Back to Player Instructions";
            this.backtoPlayerInstructions.UseVisualStyleBackColor = true;
            this.backtoPlayerInstructions.Click += new System.EventHandler(this.backtoPlayerInstructions_Click);
            // 
            // ArrowsInstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 692);
            this.Controls.Add(this.backtoPlayerInstructions);
            this.Controls.Add(this.InstructionLabel2);
            this.Controls.Add(this.InstructionLabel3);
            this.Controls.Add(this.InstructionLabel4);
            this.Controls.Add(this.InstructionLabel1);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ArrowsInstructionsForm";
            this.Text = "ArrowsInstructionsForm";
            this.Load += new System.EventHandler(this.ArrowsInstructionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label InstructionLabel1;
		private System.Windows.Forms.Label InstructionLabel4;
		private System.Windows.Forms.Label InstructionLabel3;
		private System.Windows.Forms.Label InstructionLabel2;
		private System.Windows.Forms.Button backtoPlayerInstructions;
	}
}