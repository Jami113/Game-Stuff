namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.background = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.red_win = new System.Windows.Forms.Label();
            this.blue_win = new System.Windows.Forms.Label();
            this.player2_win = new System.Windows.Forms.Label();
            this.player1_win = new System.Windows.Forms.Label();
            this.player1_points = new System.Windows.Forms.Label();
            this.player1_score = new System.Windows.Forms.Label();
            this.player2_points = new System.Windows.Forms.Label();
            this.player2_score = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.label3);
            this.background.Controls.Add(this.red_win);
            this.background.Controls.Add(this.blue_win);
            this.background.Controls.Add(this.player2_win);
            this.background.Controls.Add(this.player1_win);
            this.background.Controls.Add(this.player1_points);
            this.background.Controls.Add(this.player1_score);
            this.background.Controls.Add(this.player2_points);
            this.background.Controls.Add(this.player2_score);
            this.background.Controls.Add(this.player2);
            this.background.Controls.Add(this.ball);
            this.background.Controls.Add(this.player1);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(506, 456);
            this.background.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(150, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 110);
            this.label3.TabIndex = 11;
            this.label3.Text = "Press space\r\nto start";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // red_win
            // 
            this.red_win.AutoSize = true;
            this.red_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.red_win.Location = new System.Drawing.Point(249, 337);
            this.red_win.Name = "red_win";
            this.red_win.Size = new System.Drawing.Size(257, 110);
            this.red_win.TabIndex = 10;
            this.red_win.Text = "Red player\r\nwins!!!";
            this.red_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blue_win
            // 
            this.blue_win.AutoSize = true;
            this.blue_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blue_win.Location = new System.Drawing.Point(12, 346);
            this.blue_win.Name = "blue_win";
            this.blue_win.Size = new System.Drawing.Size(264, 110);
            this.blue_win.TabIndex = 9;
            this.blue_win.Text = "Blue player\r\nwins!!!";
            this.blue_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2_win
            // 
            this.player2_win.AutoSize = true;
            this.player2_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_win.Location = new System.Drawing.Point(61, 135);
            this.player2_win.Name = "player2_win";
            this.player2_win.Size = new System.Drawing.Size(310, 165);
            this.player2_win.TabIndex = 8;
            this.player2_win.Text = "Red player \r\ngets 1 point\r\nF1-to resume";
            this.player2_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_win
            // 
            this.player1_win.AutoSize = true;
            this.player1_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_win.Location = new System.Drawing.Point(94, 30);
            this.player1_win.Name = "player1_win";
            this.player1_win.Size = new System.Drawing.Size(310, 165);
            this.player1_win.TabIndex = 7;
            this.player1_win.Text = "Blue player \r\ngets 1 point\r\nF1-to resume";
            this.player1_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_points
            // 
            this.player1_points.AutoSize = true;
            this.player1_points.Location = new System.Drawing.Point(56, 434);
            this.player1_points.Name = "player1_points";
            this.player1_points.Size = new System.Drawing.Size(13, 13);
            this.player1_points.TabIndex = 6;
            this.player1_points.Text = "0";
            // 
            // player1_score
            // 
            this.player1_score.AutoSize = true;
            this.player1_score.Location = new System.Drawing.Point(12, 434);
            this.player1_score.Name = "player1_score";
            this.player1_score.Size = new System.Drawing.Size(38, 13);
            this.player1_score.TabIndex = 5;
            this.player1_score.Text = "Score:";
            // 
            // player2_points
            // 
            this.player2_points.AutoSize = true;
            this.player2_points.Location = new System.Drawing.Point(56, 9);
            this.player2_points.Name = "player2_points";
            this.player2_points.Size = new System.Drawing.Size(13, 13);
            this.player2_points.TabIndex = 4;
            this.player2_points.Text = "0";
            // 
            // player2_score
            // 
            this.player2_score.AutoSize = true;
            this.player2_score.Location = new System.Drawing.Point(12, 9);
            this.player2_score.Name = "player2_score";
            this.player2_score.Size = new System.Drawing.Size(38, 13);
            this.player2_score.TabIndex = 3;
            this.player2_score.Text = "Score:";
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Red;
            this.player2.Location = new System.Drawing.Point(195, 112);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(200, 20);
            this.player2.TabIndex = 2;
            this.player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ball.Location = new System.Drawing.Point(206, 244);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Blue;
            this.player1.Location = new System.Drawing.Point(171, 379);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(200, 20);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 456);
            this.Controls.Add(this.background);
            this.Name = "Form3";
            this.Text = "Form3";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label player2_score;
        private System.Windows.Forms.Label player2_points;
        private System.Windows.Forms.Label player1_win;
        private System.Windows.Forms.Label player1_points;
        private System.Windows.Forms.Label player1_score;
        private System.Windows.Forms.Label player2_win;
        private System.Windows.Forms.Label red_win;
        private System.Windows.Forms.Label blue_win;
        private System.Windows.Forms.Label label3;
    }
}