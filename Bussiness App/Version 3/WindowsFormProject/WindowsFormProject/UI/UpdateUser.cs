using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormProject.UI
{
    public partial class UpdateUser : UserControl
    {
        IUser user = Program.GetUserInstance();
        IWorker worker = Program.GetWorkerInstance();

        public UpdateUser()
        {
            InitializeComponent();
            LoadGridBox();
        }
        private void LoadGridBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("salary", typeof(string));
            dt.Columns.Add("Bonus", typeof(string));

            dataGridView1.DataSource = dt;
            List<Worker> List = worker.GetWorkerList();
            foreach (Worker worker in List)
            {

                dt.Rows.Add(worker.GetUserName(), worker.GetPassword(), worker.GetSalary(), worker.GetBonus());


            }
            dataGridView1.DataSource = dt;
        }
        private void ClearData()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            try
            {

                string username = guna2TextBox1.Text;
                string password = guna2TextBox2.Text;
                string Salary = guna2TextBox3.Text;
                string Bonus = guna2TextBox4.Text;

                if (username != "")
                {
                    bool check = user.CheckIfUserNameAlreadyExist(username);
                    if (check)
                    {
                        if(password != "")
                        {
                            bool Ispasschanged = user.ChangePasswordByUserName(username, password);
                        }
                        if (Salary != "")
                        {
                            bool IsSalaryCHanged = worker.ChangeSalaryByUserName(username, Salary);
                        }
                        if (Bonus != "")
                        {
                            bool IsBonusChanged = worker.ChangeBonusByUserName(username, Bonus);
                        }
                        ClearData();
                        LoadGridBox();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Enter Username of Worker.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
