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

namespace Obs_AdoNet.Teacher
{
    public partial class Teacher_Exam_Input : Form
    {
        public Teacher_Exam_Input()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");

        private void LabelValues()
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHours.Text = DateTime.Now.ToLongTimeString();

            SqlCommand labelCommand = new SqlCommand("select TeacherNo,TeacherName,TeacherSurname from Teachers where TeacherNo=20222001", connection);

            connection.Open();

            labelCommand.ExecuteNonQuery();

            SqlDataReader reader = labelCommand.ExecuteReader();

            while (reader.Read())
            {
                lblTeacherNo.Text = reader["TeacherNo"].ToString();
                lblTeacherName.Text = reader["TeacherName"].ToString();
                lblTeacherSurname.Text = reader["TeacherSurname"].ToString();
            }

            reader.Close();

            connection.Close();


        }


        private void DtgStudentList()
        {
            connection.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select LessonName, StudentNo,StudentName,StudentSurname,Midterm,Final,ExamAvg,ExamStatus from Students inner join Exam_Results on Students.Id = Exam_Results.StudentId inner join Lessons on Lessons.Id = Exam_Results.LessonId inner join Teachers on Teachers.Id = Exam_Results.TeacherId where TeacherNo = 20222001", connection);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);

            //dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@OgrNo", Form1.OgrNo);

            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }
        private void Teacher_Exam_Input_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgStudentList();
        }





        private void btnBack_Click(object sender, EventArgs e)
        {
            Teacher_Screen teacher_Screen = new Teacher_Screen();
            teacher_Screen.Show();
            this.Hide();
        }

    }
}
