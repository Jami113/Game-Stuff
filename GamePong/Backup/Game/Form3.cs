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
    public partial class Form3 : Form
    {
        bool player1_move_left;
        bool player1_move_right;
        bool player2_move_left;
        bool player2_move_right;
        public int speed_left = 10;
        public int speed_top = 10;
        public int point1 = 0;
        public int point2 = 0;

        public Form3()
        {
            InitializeComponent();
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            player2.Left = (background.Width / 2) - (player2.Width / 2);
            player1.Left = (background.Width / 2) - (player1.Width / 2);
            player1.Top = background.Bottom - (background.Bottom / 10);

            player1_win.Left = (background.Width / 2) - (player1_win.Width / 2);
            player1_win.Top = (background.Height / 2) - (player1_win.Height / 2);
            player2_win.Left = (background.Width / 2) - (player2_win.Width / 2);
            player2_win.Top = (background.Height / 2) - (player2_win.Height / 2);

            label3.Left = (background.Width / 2) - (label3.Width / 2);
            label3.Top = (background.Height / 2) - (label3.Height / 2);

            blue_win.Left = (background.Width / 2) - (blue_win.Width / 2);
            blue_win.Top = (background.Height / 2) - (blue_win.Height / 2);
            red_win.Left = (background.Width / 2) - (red_win.Width / 2);
            red_win.Top = (background.Height / 2) - (red_win.Height / 2);

            ball.Top = 200;
            ball.Left = 200;

            player1_score.Top = 1000;
            player1_points.Top = 1000;

            player1_win.Hide();
            player2_win.Hide();

            blue_win.Hide();
            red_win.Hide();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;
                label3.Hide();
            }

            if (e.KeyCode == Keys.F1)
            {
                player1_win.Hide();
                player2_win.Hide();
                ball.Top = 200;
                ball.Left = 200;
                timer1.Enabled = true;
                speed_top = 6;
            }

            if (e.KeyCode == Keys.Escape) { this.Close(); }

            if (e.KeyCode == Keys.Right) { player1_move_right = true; }
            if (e.KeyCode == Keys.Left) { player1_move_left = true; }

            if (e.KeyCode == Keys.D) { player2_move_right = true; }
            if (e.KeyCode == Keys.A) { player2_move_left = true; }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Cursor.Show();
            }

            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;
                label3.Hide();
            }

            if (e.KeyCode == Keys.F1)
            {
                player1_win.Hide();
                player2_win.Hide();
                ball.Top = 200;
                ball.Left = 200;
                timer1.Enabled = true;
                speed_top = 6;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (player1_move_left == true) { player1.Left -= 8; }
            if (player1_move_right == true) { player1.Left += 8; }

            if (player2_move_left == true) { player2.Left -= 8; }
            if (player2_move_right == true) { player2.Left += 8; }

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (player1.Bounds.IntersectsWith(ball.Bounds))
            {
                speed_top = -speed_top;
            }

            if (player2.Bounds.IntersectsWith(ball.Bounds))
            {
                speed_top = -speed_top;
            }

            if (ball.Left <= background.Left) { speed_left = -speed_left; }
            if (ball.Right >= background.Right) { speed_left = -speed_left; }

            if (ball.Bottom >= background.Bottom)
            {
                timer1.Enabled = false;
                point2 += 1;
                player2_points.Text = point2.ToString();
                player2_win.Show();

            }
            if (ball.Top <= background.Top)
            {
                timer1.Enabled = false;
                point1 += 1;
                player1_points.Text = point1.ToString();
                player1_win.Show();
            }

            if (point1 == 5)
            {
                timer1.Enabled = false;
                player1_win.Hide();
                blue_win.Show();
                ball.Hide();
            }
            if (point2 == 5)
            {
                timer1.Enabled = false;
                player2_win.Hide();
                red_win.Show();
                ball.Hide();
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { player1_move_right = false; }
            if (e.KeyCode == Keys.Left) { player1_move_left = false; }

            if (e.KeyCode == Keys.D) { player2_move_right = false; }
            if (e.KeyCode == Keys.A) { player2_move_left = false; }
        }


    }
}
