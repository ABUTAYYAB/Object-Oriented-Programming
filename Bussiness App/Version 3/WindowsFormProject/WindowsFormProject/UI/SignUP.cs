using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.DL.DataBase;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.Validation;
using System;
using System.Windows.Forms;

namespace WindowsFormProject.UI
{
    public partial class SignUP : Form
    {
        IUser user = Program.GetUserInstance();
        public SignUP()
        {
            InitializeComponent();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIN signIN = new SignIN();
            this.Hide();
            signIN.Show();
        }
        private void ClearData()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = guna2TextBox1.Text;
                string Password = guna2TextBox2.Text;
                string ConfirmPassword = guna2TextBox3.Text;
                string Role = "Customer";
                if (UserName != "" && Password != "" && ConfirmPassword != "")
                {
                    if (Password == ConfirmPassword)
                    {
                        if (!(user.CheckIfUserNameAlreadyExist(UserName)))
                        {
                            User user1 = new User(UserName, Password, Role);
                            bool IsSignedUP = user.SignUP(user1);
                            if (IsSignedUP)
                            {
                                this.Hide();    //Take the User to the Customer Menu

                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Try Another Username ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ClearData();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Make Sure Both Passwords Are Same  ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearData();

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

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
