namespace PACMAN
{
    partial class MainGame
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
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.LivesBox = new System.Windows.Forms.TextBox();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverLabel.Location = new System.Drawing.Point(435, 292);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(272, 46);
            this.GameOverLabel.TabIndex = 1;
            this.GameOverLabel.Text = "GAME OVER";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverLabel.Visible = false;
            this.GameOverLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreLabel.Location = new System.Drawing.Point(1085, 29);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(134, 37);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "SCORE";
            // 
            // ScoreBox
            // 
            this.ScoreBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoreBox.BackColor = System.Drawing.Color.Black;
            this.ScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreBox.Location = new System.Drawing.Point(1119, 88);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(100, 37);
            this.ScoreBox.TabIndex = 3;
            this.ScoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScoreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LivesBox
            // 
            this.LivesBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LivesBox.BackColor = System.Drawing.Color.Black;
            this.LivesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LivesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesBox.ForeColor = System.Drawing.Color.Yellow;
            this.LivesBox.Location = new System.Drawing.Point(1119, 554);
            this.LivesBox.Name = "LivesBox";
            this.LivesBox.ReadOnly = true;
            this.LivesBox.Size = new System.Drawing.Size(100, 37);
            this.LivesBox.TabIndex = 5;
            this.LivesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LivesLabel
            // 
            this.LivesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.BackColor = System.Drawing.Color.Transparent;
            this.LivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.ForeColor = System.Drawing.Color.Yellow;
            this.LivesLabel.Location = new System.Drawing.Point(1112, 491);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(112, 37);
            this.LivesLabel.TabIndex = 4;
            this.LivesLabel.Text = "LIVES";
            // 
            // RestartButton
            // 
            this.RestartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestartButton.BackColor = System.Drawing.Color.Black;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.Color.Red;
            this.RestartButton.Location = new System.Drawing.Point(1092, 287);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(127, 46);
            this.RestartButton.TabIndex = 6;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1231, 669);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.LivesBox);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameOverLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1253, 725);
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.TextBox LivesBox;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Button RestartButton;
    }
}

