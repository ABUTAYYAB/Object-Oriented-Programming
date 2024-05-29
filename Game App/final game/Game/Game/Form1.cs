using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instructions form = new Instructions();
            this.Hide();
            form.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1();
            this.Hide();
            level1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Level2 level2 = new Level2();   
            this.Hide();
            level2.Show(); 
        }
    }
}
