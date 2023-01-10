namespace DodgeTheRock
{
    partial class carGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.racecar = new System.Windows.Forms.PictureBox();
            this.rock1 = new System.Windows.Forms.PictureBox();
            this.rock2 = new System.Windows.Forms.PictureBox();
            this.rock3 = new System.Windows.Forms.PictureBox();
            this.rock4 = new System.Windows.Forms.PictureBox();
            this.rock5 = new System.Windows.Forms.PictureBox();
            this.raceTrack1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.Timer(this.components);
            this.rollRockTimer = new System.Windows.Forms.Timer(this.components);
            this.rock1Timer = new System.Windows.Forms.Timer(this.components);
            this.rock2Timer = new System.Windows.Forms.Timer(this.components);
            this.rock3Timer = new System.Windows.Forms.Timer(this.components);
            this.rock4Timer = new System.Windows.Forms.Timer(this.components);
            this.rock5Timer = new System.Windows.Forms.Timer(this.components);
            this.gameOverPic = new System.Windows.Forms.PictureBox();
            this.gameOverText = new System.Windows.Forms.Label();
            this.pressEnterText = new System.Windows.Forms.Label();
            this.menuPic = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racecar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = global::DodgeTheRock.Properties.Resources.racetrack;
            this.raceTrack.Location = new System.Drawing.Point(0, 0);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(733, 711);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // racecar
            // 
            this.racecar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.racecar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.racecar.Image = global::DodgeTheRock.Properties.Resources.blue;
            this.racecar.Location = new System.Drawing.Point(330, 555);
            this.racecar.Name = "racecar";
            this.racecar.Size = new System.Drawing.Size(74, 156);
            this.racecar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racecar.TabIndex = 1;
            this.racecar.TabStop = false;
            // 
            // rock1
            // 
            this.rock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rock1.Image = global::DodgeTheRock.Properties.Resources.rock;
            this.rock1.Location = new System.Drawing.Point(12, 68);
            this.rock1.Name = "rock1";
            this.rock1.Size = new System.Drawing.Size(100, 50);
            this.rock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock1.TabIndex = 2;
            this.rock1.TabStop = false;
            this.rock1.Tag = "rock";
            // 
            // rock2
            // 
            this.rock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rock2.Image = global::DodgeTheRock.Properties.Resources.rock;
            this.rock2.Location = new System.Drawing.Point(173, 68);
            this.rock2.Name = "rock2";
            this.rock2.Size = new System.Drawing.Size(100, 50);
            this.rock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock2.TabIndex = 3;
            this.rock2.TabStop = false;
            this.rock2.Tag = "rock";
            // 
            // rock3
            // 
            this.rock3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rock3.Image = global::DodgeTheRock.Properties.Resources.rock;
            this.rock3.Location = new System.Drawing.Point(317, 68);
            this.rock3.Name = "rock3";
            this.rock3.Size = new System.Drawing.Size(100, 50);
            this.rock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock3.TabIndex = 4;
            this.rock3.TabStop = false;
            this.rock3.Tag = "rock";
            // 
            // rock4
            // 
            this.rock4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rock4.Image = global::DodgeTheRock.Properties.Resources.rock;
            this.rock4.Location = new System.Drawing.Point(463, 68);
            this.rock4.Name = "rock4";
            this.rock4.Size = new System.Drawing.Size(100, 50);
            this.rock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock4.TabIndex = 5;
            this.rock4.TabStop = false;
            this.rock4.Tag = "rock";
            // 
            // rock5
            // 
            this.rock5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rock5.Image = global::DodgeTheRock.Properties.Resources.rock;
            this.rock5.Location = new System.Drawing.Point(622, 68);
            this.rock5.Name = "rock5";
            this.rock5.Size = new System.Drawing.Size(100, 50);
            this.rock5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock5.TabIndex = 6;
            this.rock5.TabStop = false;
            this.rock5.Tag = "rock";
            // 
            // raceTrack1
            // 
            this.raceTrack1.Image = global::DodgeTheRock.Properties.Resources.racetrack;
            this.raceTrack1.Location = new System.Drawing.Point(0, -285);
            this.raceTrack1.Name = "raceTrack1";
            this.raceTrack1.Size = new System.Drawing.Size(733, 711);
            this.raceTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack1.TabIndex = 7;
            this.raceTrack1.TabStop = false;
            // 
            // background
            // 
            this.background.Enabled = true;
            this.background.Interval = 10;
            this.background.Tick += new System.EventHandler(this.background_Tick);
            // 
            // rollRockTimer
            // 
            this.rollRockTimer.Enabled = true;
            this.rollRockTimer.Tick += new System.EventHandler(this.rollRockTimer_Tick);
            // 
            // rock1Timer
            // 
            this.rock1Timer.Tick += new System.EventHandler(this.rock1Timer_Tick);
            // 
            // rock2Timer
            // 
            this.rock2Timer.Tick += new System.EventHandler(this.rock2Timer_Tick);
            // 
            // rock3Timer
            // 
            this.rock3Timer.Tick += new System.EventHandler(this.rock3Timer_Tick);
            // 
            // rock4Timer
            // 
            this.rock4Timer.Tick += new System.EventHandler(this.rock4Timer_Tick);
            // 
            // rock5Timer
            // 
            this.rock5Timer.Tick += new System.EventHandler(this.rock5Timer_Tick);
            // 
            // gameOverPic
            // 
            this.gameOverPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameOverPic.Location = new System.Drawing.Point(0, 0);
            this.gameOverPic.Name = "gameOverPic";
            this.gameOverPic.Size = new System.Drawing.Size(733, 711);
            this.gameOverPic.TabIndex = 8;
            this.gameOverPic.TabStop = false;
            this.gameOverPic.Visible = false;
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameOverText.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameOverText.Location = new System.Drawing.Point(63, 230);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(606, 114);
            this.gameOverText.TabIndex = 9;
            this.gameOverText.Text = "Game Over!";
            this.gameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverText.Visible = false;
            // 
            // pressEnterText
            // 
            this.pressEnterText.AutoSize = true;
            this.pressEnterText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pressEnterText.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pressEnterText.Location = new System.Drawing.Point(31, 360);
            this.pressEnterText.Name = "pressEnterText";
            this.pressEnterText.Size = new System.Drawing.Size(671, 57);
            this.pressEnterText.TabIndex = 10;
            this.pressEnterText.Text = "Press Enter to Continue";
            this.pressEnterText.Visible = false;
            // 
            // menuPic
            // 
            this.menuPic.BackgroundImage = global::DodgeTheRock.Properties.Resources.DodgeTheRock;
            this.menuPic.Location = new System.Drawing.Point(0, 0);
            this.menuPic.Name = "menuPic";
            this.menuPic.Size = new System.Drawing.Size(733, 711);
            this.menuPic.TabIndex = 11;
            this.menuPic.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Cyan;
            this.startBtn.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.startBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startBtn.Location = new System.Drawing.Point(261, 282);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(221, 62);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Play Game";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.Cyan;
            this.changeBtn.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.changeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeBtn.Location = new System.Drawing.Point(261, 364);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(221, 62);
            this.changeBtn.TabIndex = 13;
            this.changeBtn.Text = "Change Car";
            this.changeBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Cyan;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitBtn.Location = new System.Drawing.Point(261, 446);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(221, 62);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "Exit Game";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // carGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.menuPic);
            this.Controls.Add(this.pressEnterText);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.gameOverPic);
            this.Controls.Add(this.rock5);
            this.Controls.Add(this.rock4);
            this.Controls.Add(this.rock3);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.rock1);
            this.Controls.Add(this.racecar);
            this.Controls.Add(this.raceTrack1);
            this.Controls.Add(this.raceTrack);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "carGame";
            this.Text = "Dodge The Rock";
            this.Load += new System.EventHandler(this.carGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.carGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racecar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox raceTrack;
        private PictureBox racecar;
        private PictureBox rock1;
        private PictureBox rock2;
        private PictureBox rock3;
        private PictureBox rock4;
        private PictureBox rock5;
        private PictureBox raceTrack1;
        private System.Windows.Forms.Timer background;
        private System.Windows.Forms.Timer rollRockTimer;
        private System.Windows.Forms.Timer rock1Timer;
        private System.Windows.Forms.Timer rock2Timer;
        private System.Windows.Forms.Timer rock3Timer;
        private System.Windows.Forms.Timer rock4Timer;
        private System.Windows.Forms.Timer rock5Timer;
        private PictureBox gameOverPic;
        private Label gameOverText;
        private Label pressEnterText;
        private PictureBox menuPic;
        private Button startBtn;
        private Button changeBtn;
        private Button exitBtn;
    }
}