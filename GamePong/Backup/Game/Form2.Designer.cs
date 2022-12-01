namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.playground = new System.Windows.Forms.Panel();
            this.gameover = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket_left = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.racket_right = new System.Windows.Forms.PictureBox();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket_right)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.racket_right);
            this.playground.Controls.Add(this.gameover);
            this.playground.Controls.Add(this.points);
            this.playground.Controls.Add(this.score);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket_left);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(425, 414);
            this.playground.TabIndex = 0;
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameover.Location = new System.Drawing.Point(68, 52);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(272, 165);
            this.gameover.TabIndex = 6;
            this.gameover.Text = "Game Over\r\nF1-restart\r\nESC-exit";
            this.gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points.Location = new System.Drawing.Point(181, 9);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(51, 55);
            this.points.TabIndex = 5;
            this.points.Text = "0";
            this.points.Click += new System.EventHandler(this.label2_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(163, 55);
            this.score.TabIndex = 4;
            this.score.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(155, 126);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // racket_left
            // 
            this.racket_left.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket_left.Location = new System.Drawing.Point(112, 269);
            this.racket_left.Name = "racket_left";
            this.racket_left.Size = new System.Drawing.Size(100, 20);
            this.racket_left.TabIndex = 2;
            this.racket_left.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // racket_right
            // 
            this.racket_right.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket_right.Location = new System.Drawing.Point(209, 269);
            this.racket_right.Name = "racket_right";
            this.racket_right.Size = new System.Drawing.Size(100, 20);
            this.racket_right.TabIndex = 7;
            this.racket_right.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 414);
            this.Controls.Add(this.playground);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket_right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket_left;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.PictureBox racket_right;

    }
}