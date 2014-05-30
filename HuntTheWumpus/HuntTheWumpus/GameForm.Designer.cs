namespace HuntTheWumpus
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.cappyPanel = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.secretLabel = new System.Windows.Forms.Label();
            this.goldHolder = new System.Windows.Forms.Label();
            this.turnHolder = new System.Windows.Forms.Label();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.arrowHolder = new System.Windows.Forms.Label();
            this.cave0 = new System.Windows.Forms.PictureBox();
            this.cave3 = new System.Windows.Forms.PictureBox();
            this.cave5 = new System.Windows.Forms.PictureBox();
            this.cave4 = new System.Windows.Forms.PictureBox();
            this.cave1 = new System.Windows.Forms.PictureBox();
            this.cave2 = new System.Windows.Forms.PictureBox();
            this.playerSprite = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hazardBox = new System.Windows.Forms.PictureBox();
            this.cappyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cave0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazardBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 12;
            this.UpdateTimer.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // cappyPanel
            // 
            this.cappyPanel.Controls.Add(this.label8);
            this.cappyPanel.Controls.Add(this.actionLabel);
            this.cappyPanel.Controls.Add(this.label7);
            this.cappyPanel.Controls.Add(this.label6);
            this.cappyPanel.Controls.Add(this.notificationLabel);
            this.cappyPanel.Controls.Add(this.secretLabel);
            this.cappyPanel.Controls.Add(this.goldHolder);
            this.cappyPanel.Controls.Add(this.turnHolder);
            this.cappyPanel.Controls.Add(this.arrowLabel);
            this.cappyPanel.Controls.Add(this.goldLabel);
            this.cappyPanel.Controls.Add(this.turnLabel);
            this.cappyPanel.Controls.Add(this.arrowHolder);
            this.cappyPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cappyPanel.Location = new System.Drawing.Point(12, 643);
            this.cappyPanel.Name = "cappyPanel";
            this.cappyPanel.Size = new System.Drawing.Size(641, 248);
            this.cappyPanel.TabIndex = 2;
            this.cappyPanel.TabStop = false;
            this.cappyPanel.Text = "Robotic Panel";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 42);
            this.label8.TabIndex = 13;
            this.label8.Text = "Actions:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // actionLabel
            // 
            this.actionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.actionLabel.Location = new System.Drawing.Point(149, 109);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(486, 40);
            this.actionLabel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notifications:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "Secret:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notificationLabel
            // 
            this.notificationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notificationLabel.Location = new System.Drawing.Point(149, 16);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(486, 40);
            this.notificationLabel.TabIndex = 7;
            // 
            // secretLabel
            // 
            this.secretLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secretLabel.Location = new System.Drawing.Point(149, 65);
            this.secretLabel.Name = "secretLabel";
            this.secretLabel.Size = new System.Drawing.Size(486, 40);
            this.secretLabel.TabIndex = 6;
            // 
            // goldHolder
            // 
            this.goldHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.goldHolder.Location = new System.Drawing.Point(149, 176);
            this.goldHolder.Name = "goldHolder";
            this.goldHolder.Size = new System.Drawing.Size(486, 20);
            this.goldHolder.TabIndex = 4;
            this.goldHolder.Text = "0";
            this.goldHolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // turnHolder
            // 
            this.turnHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.turnHolder.Location = new System.Drawing.Point(149, 198);
            this.turnHolder.Name = "turnHolder";
            this.turnHolder.Size = new System.Drawing.Size(486, 20);
            this.turnHolder.TabIndex = 5;
            this.turnHolder.Text = "0";
            this.turnHolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // arrowLabel
            // 
            this.arrowLabel.Location = new System.Drawing.Point(4, 155);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(113, 20);
            this.arrowLabel.TabIndex = 0;
            this.arrowLabel.Text = "Laser Beams:";
            this.arrowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goldLabel
            // 
            this.goldLabel.Location = new System.Drawing.Point(4, 174);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(113, 20);
            this.goldLabel.TabIndex = 1;
            this.goldLabel.Text = "Gold:";
            this.goldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // turnLabel
            // 
            this.turnLabel.Location = new System.Drawing.Point(4, 195);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(113, 20);
            this.turnLabel.TabIndex = 2;
            this.turnLabel.Text = "Turn:";
            this.turnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // arrowHolder
            // 
            this.arrowHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arrowHolder.Location = new System.Drawing.Point(149, 156);
            this.arrowHolder.Name = "arrowHolder";
            this.arrowHolder.Size = new System.Drawing.Size(486, 20);
            this.arrowHolder.TabIndex = 3;
            this.arrowHolder.Text = "0";
            this.arrowHolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cave0
            // 
            this.cave0.BackColor = System.Drawing.Color.Transparent;
            this.cave0.Location = new System.Drawing.Point(300, 12);
            this.cave0.Name = "cave0";
            this.cave0.Size = new System.Drawing.Size(64, 129);
            this.cave0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cave0.TabIndex = 3;
            this.cave0.TabStop = false;
            this.cave0.Visible = false;
            // 
            // cave3
            // 
            this.cave3.BackColor = System.Drawing.Color.Transparent;
            this.cave3.Location = new System.Drawing.Point(300, 491);
            this.cave3.Name = "cave3";
            this.cave3.Size = new System.Drawing.Size(64, 129);
            this.cave3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cave3.TabIndex = 4;
            this.cave3.TabStop = false;
            this.cave3.Visible = false;
            // 
            // cave5
            // 
            this.cave5.BackColor = System.Drawing.Color.Transparent;
            this.cave5.Location = new System.Drawing.Point(53, 127);
            this.cave5.Name = "cave5";
            this.cave5.Size = new System.Drawing.Size(64, 129);
            this.cave5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cave5.TabIndex = 5;
            this.cave5.TabStop = false;
            this.cave5.Visible = false;
            // 
            // cave4
            // 
            this.cave4.BackColor = System.Drawing.Color.Transparent;
            this.cave4.Location = new System.Drawing.Point(52, 416);
            this.cave4.Name = "cave4";
            this.cave4.Size = new System.Drawing.Size(64, 129);
            this.cave4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cave4.TabIndex = 6;
            this.cave4.TabStop = false;
            this.cave4.Visible = false;
            // 
            // cave1
            // 
            this.cave1.BackColor = System.Drawing.Color.Transparent;
            this.cave1.Location = new System.Drawing.Point(569, 128);
            this.cave1.Name = "cave1";
            this.cave1.Size = new System.Drawing.Size(64, 129);
            this.cave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cave1.TabIndex = 7;
            this.cave1.TabStop = false;
            this.cave1.Visible = false;
            // 
            // cave2
            // 
            this.cave2.BackColor = System.Drawing.Color.Transparent;
            this.cave2.Location = new System.Drawing.Point(568, 414);
            this.cave2.Name = "cave2";
            this.cave2.Size = new System.Drawing.Size(64, 129);
            this.cave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cave2.TabIndex = 8;
            this.cave2.TabStop = false;
            this.cave2.Visible = false;
            // 
            // playerSprite
            // 
            this.playerSprite.BackColor = System.Drawing.Color.Transparent;
            this.playerSprite.BackgroundImage = global::HuntTheWumpus.Properties.Resources.Wall_e;
            this.playerSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerSprite.Location = new System.Drawing.Point(291, 258);
            this.playerSprite.Name = "playerSprite";
            this.playerSprite.Size = new System.Drawing.Size(77, 102);
            this.playerSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerSprite.TabIndex = 0;
            this.playerSprite.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label0
            // 
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(281, 152);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(100, 23);
            this.label0.TabIndex = 10;
            this.label0.Text = "0";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hazardBox
            // 
            this.hazardBox.BackColor = System.Drawing.Color.Transparent;
            this.hazardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hazardBox.Location = new System.Drawing.Point(185, 189);
            this.hazardBox.Name = "hazardBox";
            this.hazardBox.Size = new System.Drawing.Size(288, 245);
            this.hazardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hazardBox.TabIndex = 15;
            this.hazardBox.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HuntTheWumpus.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(660, 868);
            this.Controls.Add(this.cappyPanel);
            this.Controls.Add(this.playerSprite);
            this.Controls.Add(this.cave0);
            this.Controls.Add(this.cave3);
            this.Controls.Add(this.cave5);
            this.Controls.Add(this.cave4);
            this.Controls.Add(this.cave2);
            this.Controls.Add(this.cave1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hazardBox);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.cappyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cave0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cave2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazardBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Timer UpdateTimer;
		private System.Windows.Forms.GroupBox cappyPanel;
		private System.Windows.Forms.Label turnHolder;
		private System.Windows.Forms.Label goldHolder;
		private System.Windows.Forms.Label arrowHolder;
		private System.Windows.Forms.Label turnLabel;
		private System.Windows.Forms.Label goldLabel;
		private System.Windows.Forms.Label arrowLabel;
		private System.Windows.Forms.Label notificationLabel;
		private System.Windows.Forms.Label secretLabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label actionLabel;
		private System.Windows.Forms.PictureBox cave0;
		private System.Windows.Forms.PictureBox cave3;
		private System.Windows.Forms.PictureBox cave5;
		private System.Windows.Forms.PictureBox cave4;
		private System.Windows.Forms.PictureBox cave1;
		private System.Windows.Forms.PictureBox cave2;
		private System.Windows.Forms.PictureBox playerSprite;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label0;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox hazardBox;
    }
}