using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1SignINSignUP.BL;
using Task1SignINSignUP.DL;

namespace Task1SignINSignUP.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignInsignUpApplication signInsignUpApplication = new SignInsignUpApplication();
            signInsignUpApplication.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sign = new SignUp();
            sign.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = comboBox1.Text;
            if(textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
            User user = new User(username, password, role);
            UserDL.AddUserIntoList(user);
            MessageBox.Show("Data Entered Successfully:");
                reset();

            }
            else
            {
                MessageBox.Show("please Enter All The data \n Unsuccessfull");
                reset();
            }


        }
        public void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = comboBox1.Text;

            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                bool check = UserDL.updateDetails(username, password, role);
                if (check)
                {
                    MessageBox.Show("Updated Successfully");
                    reset();
                }
                else
                {

                    MessageBox.Show("User not found");
                    reset();

                }
            }
            else
            {
                MessageBox.Show("please Enter All The data \n Unsuccessfull");
                reset();
            }

           


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = comboBox1.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                User user = new User(username, password, role);
                UserDL.AddUserIntoList(user);
                MessageBox.Show("Data Entered Successfully:");
                reset();

            }
            else
            {
                MessageBox.Show("please Enter All The data \n Unsuccessfull");
                reset();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignInsignUpApplication signInsignUpApplication = new SignInsignUpApplication();
            signInsignUpApplication.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
