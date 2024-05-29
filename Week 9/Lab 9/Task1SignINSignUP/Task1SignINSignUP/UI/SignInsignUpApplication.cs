using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1SignINSignUP.UI
{
    public partial class SignInsignUpApplication : Form
    {
        public SignInsignUpApplication()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIN moreform = new SignIN();
            moreform.Show();
        }
    }
}
