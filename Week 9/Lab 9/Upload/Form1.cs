using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string conURL = "Data Source=DESKTOP-RN4E49S;Initial Catalog=ProjectB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(conURL);

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGVD();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void FillGVD()
        {
            con.Open();
            string query = "Select * From Student ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
