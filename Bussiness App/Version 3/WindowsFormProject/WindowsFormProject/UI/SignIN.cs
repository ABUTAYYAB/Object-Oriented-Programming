using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.DL.DataBase;
using DairyDelightsLibrary.Interface;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace WindowsFormProject.UI
{
    public partial class SignIN : Form
    {
        IUser user = Program.GetUserInstance();

        public SignIN()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUP signUP = new SignUP();
            this.Hide();
            signUP.Show();
        }
        private void ClearData()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = guna2TextBox1.Text;
                string Password = guna2TextBox2.Text;

                if (UserName != "" && Password != "")
                {
                    string Role = user.SignIN(UserName, Password);
                    if (Role == "UserNotFound")
                    {
                        MessageBox.Show("Username or Password is Incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearData();
                    }
                    else if (Role == "Customer")
                    {
                        //Call The user Form of Customer
                    }
                    else if (Role == "Worker")
                    {
                        //Call The user Form of Worker 
                    }
                    else if (Role == "DeliveryBoy")
                    {
                        //Call The user Form of Delivery Boy
                    }
                    else if (Role == "Admin")
                    {
                        //Call The user Form of  Admin
                        AdminMainForm form = new AdminMainForm();
                        this.Hide();
                        form.Show();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Please enter complete data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearData();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearData();
            }
        }
    }
}
