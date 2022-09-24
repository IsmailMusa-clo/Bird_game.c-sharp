namespace BirdGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.bieDown1 = new System.Windows.Forms.PictureBox();
            this.bie2 = new System.Windows.Forms.PictureBox();
            this.bieDown = new System.Windows.Forms.PictureBox();
            this.bie1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bieDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlGame.Controls.Add(this.lblGameOver);
            this.pnlGame.Controls.Add(this.bieDown1);
            this.pnlGame.Controls.Add(this.bie2);
            this.pnlGame.Controls.Add(this.bieDown);
            this.pnlGame.Controls.Add(this.bie1);
            this.pnlGame.Controls.Add(this.ground);
            this.pnlGame.Controls.Add(this.bird);
            this.pnlGame.Location = new System.Drawing.Point(-2, 51);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(898, 562);
            this.pnlGame.TabIndex = 0;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.DimGray;
            this.lblGameOver.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGameOver.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGameOver.Location = new System.Drawing.Point(289, 170);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(273, 45);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "Game Over....";
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // bieDown1
            // 
            this.bieDown1.BackColor = System.Drawing.Color.Transparent;
            this.bieDown1.Image = global::BirdGame.Properties.Resources.pipedown;
            this.bieDown1.Location = new System.Drawing.Point(483, 0);
            this.bieDown1.Name = "bieDown1";
            this.bieDown1.Size = new System.Drawing.Size(105, 153);
            this.bieDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bieDown1.TabIndex = 5;
            this.bieDown1.TabStop = false;
            // 
            // bie2
            // 
            this.bie2.BackColor = System.Drawing.Color.Transparent;
            this.bie2.Image = global::BirdGame.Properties.Resources.pipe;
            this.bie2.Location = new System.Drawing.Point(793, 334);
            this.bie2.Name = "bie2";
            this.bie2.Size = new System.Drawing.Size(105, 137);
            this.bie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bie2.TabIndex = 4;
            this.bie2.TabStop = false;
            // 
            // bieDown
            // 
            this.bieDown.BackColor = System.Drawing.Color.Transparent;
            this.bieDown.Image = global::BirdGame.Properties.Resources.pipedown;
            this.bieDown.Location = new System.Drawing.Point(122, 0);
            this.bieDown.Name = "bieDown";
            this.bieDown.Size = new System.Drawing.Size(105, 153);
            this.bieDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bieDown.TabIndex = 3;
            this.bieDown.TabStop = false;
            // 
            // bie1
            // 
            this.bie1.BackColor = System.Drawing.Color.Transparent;
            this.bie1.Image = global::BirdGame.Properties.Resources.pipe;
            this.bie1.Location = new System.Drawing.Point(689, 334);
            this.bie1.Name = "bie1";
            this.bie1.Size = new System.Drawing.Size(105, 137);
            this.bie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bie1.TabIndex = 2;
            this.bie1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::BirdGame.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 466);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(903, 96);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::BirdGame.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(72, 288);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(79, 74);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(115, 33);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "score:0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 612);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bird game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bieDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox bie2;
        private System.Windows.Forms.PictureBox bieDown;
        private System.Windows.Forms.PictureBox bie1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bieDown1;
        private System.Windows.Forms.Label lblGameOver;
    }
}

