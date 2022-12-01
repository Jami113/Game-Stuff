using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;

        public Form2()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket_left.Top = playground.Bottom - (playground.Bottom / 10);
            racket_right.Left = racket_left.Right;
            racket_right.Top = racket_left.Top;

            gameover.Left = (playground.Width / 2) - (gameover.Width / 2);
            gameover.Top = (playground.Height / 2) - (gameover.Height / 2);
            gameover.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket_left.Left = Cursor.Position.X;
            racket_right.Left = racket_left.Right;
            Random speed_left = new Random(1, 6);
            ball.Left += speed_left;
            ball.Top += speed_top;
            


            if (ball.Bounds.IntersectsWith(racket_left.Bounds))
            {
                speed_top += 1;
                speed_left += 1;
                speed_top = -speed_top;
                speed_left = -speed_left;
                point += 1;
                points.Text = point.ToString();
            }

            if (ball.Bounds.IntersectsWith(racket_right.Bounds))
            {
                speed_top += 1;
                speed_left += 1;
                speed_top = -speed_top;
                point += 1;
                points.Text = point.ToString();
            }

            

            if (ball.Left <= playground.Left) { speed_left = -speed_left; }
            if (ball.Right >= playground.Right) { speed_left = -speed_left; }
            if (ball.Top <= playground.Top) { speed_top = -speed_top; }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }

           
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Cursor.Show();
            }

            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points.Text = "0";
                point = 0;
                timer1.Enabled = true;
                gameover.Visible = false;
            }
                
        }




    }
}
