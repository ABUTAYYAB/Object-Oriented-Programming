using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using UAMS.BL;

namespace UAMS.DL
{
    internal class StudentDL
    {
        public static List<StudentBL> StudentList = new List<StudentBL>();
        public static void getdata()
        {
            StudentList = GetStudentList();

        }
        public static void AddIntoStudentList(StudentBL s)
        {
            if (CreateStudent(s) != null)
            {
                StudentList.Add(s);

            }

        }

        public static List<StudentBL> SortStudentsByMerit()
        {
            List<StudentBL> sortedStudentList = new List<StudentBL>();
            foreach (StudentBL s in StudentDL.StudentList)
            {
                s.CalculateMerit();
            }

            sortedStudentList = StudentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }

        public static List<StudentBL> GetStudentsList()
        {
            return StudentList;
        }
        public static StudentBL AddStudent(StudentBL student)
        {
            StudentList.Add(student);
            return student;
        }

        public static void RemoveStudent(StudentBL student)
        {
            StudentList.Remove(student);
        }

        public static StudentBL RemoveStudentByName(string name)
        {
            foreach (StudentBL student in StudentList)
            {
                if (student.name == name)
                {
                    StudentList.ToList().Remove(student);
                }
            }
            return null;
        }

        public static StudentBL FindStudentByName(string name)
        {
            foreach (StudentBL student in StudentList)
            {
                if (student.name == name)
                {
                    return student;
                }
            }
            return null;
        }

        public static string ConnectionString = "Server=DESKTOP-RN4E49S;Database=UMAS;Trusted_Connection=True;";
        public static StudentBL CreateStudent(StudentBL student)
        {
            string query = string.Format("insert into Student (Name,Age,FSCMArks,Ecat,Merit)" + "values ('{0}','{1}','{2}','{3}','{4}')", student.name, student.age, student.fscMarks, student.ecatMarks, student.merit);
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return student;
                }
            }
            return null;
        }
        //public static void CreatePreference(DegreeProgramBL degree )
        //{
        //    string query = string.Format("insert into Preference (Name,Age,FSCMArks,Ecat,Merit)" + "values ('{0}','{1}','{2}','{3}','{4}')", degree.degreeName,degree., student.fscMarks, student.ecatMarks, student.merit);
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        SqlCommand command = new SqlCommand(query, connection);
        //        connection.Open();
        //        int rowsAffected = command.ExecuteNonQuery();
                
        //    }
            
        //}
        public static List<StudentBL> GetStudentList()
        {
            List<StudentBL> students = new List<StudentBL>();
            string query = "select * from Student";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string a = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);

                    //int age = int.Parse(reader.GetString(1));
                    double fsc = Convert.ToDouble(reader["FSCMarks"]);
                    double ecat = Convert.ToDouble(reader["Ecat"]);
                    double merit = Convert.ToDouble(reader["Merit"]);

                    StudentBL student = new StudentBL(a,age,fsc,ecat,merit);
                    students.Add(student);
                }

                Console.WriteLine("ho gia aiiiiiii");
                Console.ReadLine();
                return students;
            }
        }

        //public static List<StudentBL> GetStudentpreference()
        //{
        //    List<DegreeProgramBL> students = new List<DegreeProgramBL>();
        //    string query = "select * from Student";

        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        SqlCommand command = new SqlCommand(query, connection);
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            DegreeProgramBL degree = new DegreeProgramBL(
        //                Convert.ToString(reader.GetString(1)),
        //                int.Parse(reader.GetString(2)),
        //                double.Parse(reader.GetString(3)),
        //                double.Parse(reader.GetString(4)),
        //                double.Parse(reader.GetString(5))

        //                );
        //        }

        //        return students;
        //    }
    }
}

