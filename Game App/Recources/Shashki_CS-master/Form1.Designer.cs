namespace Shashki_CS
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.player = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.obyect = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // player
      // 
      this.player.Image = ((System.Drawing.Image) (resources.GetObject("player.Image")));
      this.player.Location = new System.Drawing.Point(130, 450);
      this.player.Name = "player";
      this.player.Size = new System.Drawing.Size(99, 96);
      this.player.TabIndex = 0;
      this.player.Click += new System.EventHandler(this.player_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 50;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // obyect
      // 
      this.obyect.Image = ((System.Drawing.Image) (resources.GetObject("obyect.Image")));
      this.obyect.Location = new System.Drawing.Point(130, 10);
      this.obyect.Name = "obyect";
      this.obyect.Size = new System.Drawing.Size(99, 96);
      this.obyect.TabIndex = 2;
      this.obyect.Click += new System.EventHandler(this.obyect_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(380, 600);
      this.label1.TabIndex = 3;
      this.label1.Text = "Вы проиграли!\r\n";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(364, 601);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.obyect);
      this.Controls.Add(this.player);
      this.Name = "Form1";
      this.Text = "Игра";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Click += new System.EventHandler(this.Form1_Click);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    #endregion

        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label obyect;
    }
}

