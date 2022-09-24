using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdGame
{
    public partial class Form1 : Form
    {

        int Speed = 8;
        int score = 0;
        int gravey = 6;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravey; 
            bie1.Left -= Speed;
            bie2.Left -= Speed;
            bieDown.Left -= Speed;
            bieDown1.Left -= Speed;
            score++;
             lblScore.Text = "Score:" + score/2;
            for (int i = 0; i <10000; i+=100)
            {
                if (score/2 == i) { Speed +=2; }
            }
            if (bie1.Left < -bieDown.Width)
            {
                bie1.Visible = false;
                if (bie1.Left != bie2.Left)
                { bie1.Left += r.Next(pnlGame.Width, pnlGame.Width * 2);
                    bie1.Height = r.Next(120, 150);
                }
                else
                    bie1.Left += pnlGame.Width;

                bie1.Visible = true;
            }
            if (bie2.Left < -bieDown.Width)
            {
                bie2.Visible = false;
                bie2.Left += r.Next(pnlGame.Width, pnlGame.Width * 2);
                bie2.Height = r.Next(120, 150);
                bie2.Visible = true;
            }
            if (bieDown.Left <-bieDown.Width)
            {
                bieDown.Visible = false;
                if (bieDown.Left != bieDown1.Left)
                { bieDown.Left += r.Next(pnlGame.Width, pnlGame.Width * 2);
                    bieDown.Height = r.Next(130, 170);
                }
                else
                    bieDown.Left += pnlGame.Width; 

                bieDown.Visible = true;
            }
            if (bieDown1.Left < -bieDown.Width)
            {
                bieDown1.Visible = false;
                bieDown1.Left += r.Next(pnlGame.Width, pnlGame.Width * 2);
                bieDown1.Height = r.Next(130, 170);
                bieDown1.Visible = true;
            }

            if(bird.Bounds.IntersectsWith(bie1.Bounds)|| bird.Bounds.IntersectsWith(bie2.Bounds) ||
                bird.Bounds.IntersectsWith(bieDown.Bounds) || bird.Bounds.IntersectsWith(bieDown1.Bounds) 
                ||bird.Top<0||bird.Top>pnlGame.Height-bird.Height)
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;

            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravey = -6; 
            }
            if (e.KeyCode == Keys.Enter)
            {
                                score = 0;
                this.bie2.Left = 793;
                this.bieDown.Location = new System.Drawing.Point(122, 0);
                this.bie1.Left = 689;
                this.bird.Location = new System.Drawing.Point(72, 288);
                this.bieDown1.Location = new System.Drawing.Point(482, 0);
                lblGameOver.Visible = false;
                timer1.Enabled = true;

            }

        }
            private void Form1_KeyUp(object sender, KeyEventArgs e)
            {

         
           
                gravey = 6;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }
    }
    }

