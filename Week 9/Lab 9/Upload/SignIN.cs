using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1SignINSignUP.BL;
using Task1SignINSignUP.DL;

namespace Task1SignINSignUP.UI
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInsignUpApplication signInsignUpApplication = new SignInsignUpApplication();
            signInsignUpApplication.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            User u = new User(username,password);
            string role = UserDL.signIN(u);
            MessageBox.Show(role);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
