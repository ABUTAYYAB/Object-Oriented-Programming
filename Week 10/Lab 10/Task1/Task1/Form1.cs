using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.DL;
using MyLibrary.BL;
using System.Data.SqlClient;
using MyLibrary.Utils;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("FSc", typeof(string));
            dt.Columns.Add("Ecat", typeof(string));
            dt.Columns.Add("Matric", typeof(string));



            dataGridView1.DataSource = dt;

            List<Student> Students = StudentDL.GetAllStudents();
            foreach(Student student in Students)
            {
                dt.Rows.Add(student.Roll,student.Name, student.FSc,student.Ecat,student.Matric);
            }
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roll = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            float ecat = float.Parse(textBox3.Text);
            float fsc = float.Parse(textBox4.Text);
            float matric = float.Parse(textBox5.Text);
            Student student = new Student(roll,name,ecat,fsc,matric);
            bool result = StudentDL.SaveStudent(student);
            FillGVD();

            if (result) 
            {
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("UnSuccessfull");

            }



        }
        private void FillGVD()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("FSc", typeof(string));
            dt.Columns.Add("Ecat", typeof(string));
            dt.Columns.Add("Matric", typeof(string));



            dataGridView1.DataSource = dt;

            List<Student> Students = StudentDL.GetAllStudents();
            foreach (Student student in Students)
            {
                dt.Rows.Add(student.Roll, student.Name, student.FSc, student.Ecat, student.Matric);
            }
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string roll = textBox1.Text;
            StudentDL.DeleteStudentByRoll(roll);
            FillGVD();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int roll = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            float ecat = float.Parse(textBox3.Text);
            float fsc = float.Parse(textBox4.Text);
            float matric = float.Parse(textBox5.Text);
            Student student = new Student(roll, name, ecat, fsc, matric);
            bool result = StudentDL.UpateStudent(student);
                FillGVD();

            if (result)
            {
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("UnSuccessfull");

            }


        }
    }
}
