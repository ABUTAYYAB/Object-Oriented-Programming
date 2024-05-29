using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Challenge1
{
    public partial class Form1 : Form
    {
        private Color[] colors = { Color.Red, Color.Green, Color.Blue };
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.BackColor = colors[currentIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % colors.Length;
            textBox1.BackColor = colors[currentIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + colors.Length) % colors.Length;
            textBox1.BackColor = colors[currentIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
