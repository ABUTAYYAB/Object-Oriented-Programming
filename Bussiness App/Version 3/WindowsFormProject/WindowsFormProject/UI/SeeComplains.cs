using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormProject.UI
{
    public partial class SeeComplains : UserControl
    {
        IWorker worker = Program.GetWorkerInstance();
        IUser user = Program.GetUserInstance();

        public SeeComplains()
        {
            InitializeComponent();
            LoadGridBox();
        }
        private void ClearData()
        {
            guna2TextBox1.Text = "";
        }
        private void LoadGridBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("Complains", typeof(string));

            List<Worker> workers = worker.GetWorkerList();

            foreach (Worker worker in workers)
            {
                List<string> list = worker.GetComplainsList();
                foreach (string complaint in list)
                {
                    dt.Rows.Add(worker.GetUserName(), complaint);
                }
            }

            dataGridView1.DataSource = dt;
        }
        private void ViewComplainsOfScpecificUser(string username)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("Complains", typeof(string));
            dataGridView1.DataSource = dt;
            List<Worker> workers = worker.GetWorkerList();

            foreach (Worker worker in workers)
            {
                List<string> list = worker.GetComplainsList();
                for (int i = 0; i < list.Count; i++)
                {
                    if (worker.GetUserName() == username)
                    {
                        dt.Rows.Add(worker.GetUserName(), list[i]);
                    }
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                string username = guna2TextBox1.Text;
                if(username =="")
                {
                    LoadGridBox();
                }
                else if(user.CheckIfUserNameAlreadyExist(username)) 
                {
                    ViewComplainsOfScpecificUser(username);
                }
                else
                {
                    MessageBox.Show("Incorrect Username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
