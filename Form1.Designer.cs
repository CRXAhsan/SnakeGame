namespace SnakeGame
{
    partial class SnakeGame
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_Snap = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txt_Score = new System.Windows.Forms.Label();
            this.txt_HighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Cyan;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(540, 58);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 36);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartGame);
            // 
            // btn_Snap
            // 
            this.btn_Snap.BackColor = System.Drawing.Color.Cyan;
            this.btn_Snap.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_Snap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Snap.Location = new System.Drawing.Point(540, 113);
            this.btn_Snap.Name = "btn_Snap";
            this.btn_Snap.Size = new System.Drawing.Size(75, 36);
            this.btn_Snap.TabIndex = 1;
            this.btn_Snap.Text = "Snap";
            this.btn_Snap.UseVisualStyleBackColor = false;
            this.btn_Snap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TakeSnapShot);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(509, 600);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBox);
            // 
            // txt_Score
            // 
            this.txt_Score.AutoSize = true;
            this.txt_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Score.Location = new System.Drawing.Point(536, 169);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(76, 20);
            this.txt_Score.TabIndex = 3;
            this.txt_Score.Text = "Score: 0";
            // 
            // txt_HighScore
            // 
            this.txt_HighScore.AutoSize = true;
            this.txt_HighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HighScore.Location = new System.Drawing.Point(526, 216);
            this.txt_HighScore.Name = "txt_HighScore";
            this.txt_HighScore.Size = new System.Drawing.Size(98, 20);
            this.txt_HighScore.TabIndex = 3;
            this.txt_HighScore.Text = "High Score";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 625);
            this.Controls.Add(this.txt_HighScore);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btn_Snap);
            this.Controls.Add(this.btn_start);
            this.Name = "SnakeGame";
            this.Text = "Snake Game ";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_Snap;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txt_Score;
        private System.Windows.Forms.Label txt_HighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

