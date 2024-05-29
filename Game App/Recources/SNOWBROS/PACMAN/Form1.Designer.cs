namespace PACMAN
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
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pb_playerHealth = new System.Windows.Forms.ProgressBar();
            this.lbl_enemyCout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 200;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_score.Location = new System.Drawing.Point(1656, 331);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(113, 39);
            this.lbl_score.TabIndex = 0;
            this.lbl_score.Text = "Score:";
            this.lbl_score.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pb_playerHealth
            // 
            this.pb_playerHealth.Location = new System.Drawing.Point(1655, 265);
            this.pb_playerHealth.Name = "pb_playerHealth";
            this.pb_playerHealth.Size = new System.Drawing.Size(159, 32);
            this.pb_playerHealth.TabIndex = 6;
            this.pb_playerHealth.Value = 100;
            // 
            // lbl_enemyCout
            // 
            this.lbl_enemyCout.AutoSize = true;
            this.lbl_enemyCout.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enemyCout.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_enemyCout.Location = new System.Drawing.Point(1656, 392);
            this.lbl_enemyCout.Name = "lbl_enemyCout";
            this.lbl_enemyCout.Size = new System.Drawing.Size(164, 39);
            this.lbl_enemyCout.TabIndex = 7;
            this.lbl_enemyCout.Text = "Enemies:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1826, 744);
            this.Controls.Add(this.lbl_enemyCout);
            this.Controls.Add(this.pb_playerHealth);
            this.Controls.Add(this.lbl_score);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1124, 732);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ProgressBar pb_playerHealth;
        private System.Windows.Forms.Label lbl_enemyCout;
    }
}

