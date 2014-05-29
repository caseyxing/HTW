namespace HuntTheWumpus
{
    partial class StartForm
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
			this.startButton = new System.Windows.Forms.Button();
			this.hsButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.Black;
			this.startButton.Font = new System.Drawing.Font("Arnprior", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.ForeColor = System.Drawing.Color.Violet;
			this.startButton.Location = new System.Drawing.Point(12, 459);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(275, 50);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
			// 
			// hsButton
			// 
			this.hsButton.BackColor = System.Drawing.Color.Black;
			this.hsButton.Font = new System.Drawing.Font("Arnprior", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hsButton.ForeColor = System.Drawing.Color.Violet;
			this.hsButton.Location = new System.Drawing.Point(12, 521);
			this.hsButton.Name = "hsButton";
			this.hsButton.Size = new System.Drawing.Size(275, 50);
			this.hsButton.TabIndex = 1;
			this.hsButton.Text = "View Highscores";
			this.hsButton.UseVisualStyleBackColor = false;
			this.hsButton.Click += new System.EventHandler(this.hsButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.Black;
			this.exitButton.Font = new System.Drawing.Font("Arnprior", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.Color.Violet;
			this.exitButton.Location = new System.Drawing.Point(326, 521);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(275, 50);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Arnprior", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Violet;
			this.button1.Location = new System.Drawing.Point(326, 459);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(275, 50);
			this.button1.TabIndex = 3;
			this.button1.Text = "Cave Editor";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(588, 133);
			this.label1.TabIndex = 4;
			this.label1.Text = "Hunt The AUTO";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::HuntTheWumpus.Properties.Resources.SplashScreen1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(613, 583);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.hsButton);
			this.Controls.Add(this.startButton);
			this.Name = "StartForm";
			this.Text = "StartForm";
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button hsButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;


	}
}