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

namespace Obs_AdoNet.Ogrenci
{
    public partial class Student_Screen : Form
    {
        public Student_Screen()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");

        private void labelValues()
        {
            lblStudentScreenDateTime.Text = DateTime.Now.ToLongDateString();
            lblHours.Text=DateTime.Now.ToLongTimeString();

            SqlCommand labelCommand = new SqlCommand("select StudentNo,StudentName,StudentSurname from Students where StudentNo=@OgrNo", connection);

            labelCommand.Parameters.AddWithValue("@OgrNo", Form1.OgrNo);

            connection.Open();

            labelCommand.ExecuteNonQuery();

            SqlDataReader reader = labelCommand.ExecuteReader();

            while (reader.Read())
            {
                lblStudentNo.Text = reader["StudentNo"].ToString();
                lblStudentName.Text = reader["StudentName"].ToString();
                lblStudentSurname.Text = reader["StudentSurname"].ToString();
            }

            reader.Close();

            connection.Close();
        }

        private void dataGridLessonValues()
        {

            connection.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select LessonDate,LessonTime,LessonName,TeacherName,TeacherSurname from Students inner join TransitionLesson on TransitionLesson.StudentId = Students.StudentId inner join Lessons on TransitionLesson.LessonId = Lessons.Lesson_Id inner join Teachers on Teachers.TeacherId = TransitionLesson.TeacherId where StudentNo = @ogrNo", connection);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@OgrNo", Form1.OgrNo);

            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);

            dtgStudentLessonProgram.DataSource = dataTable;

            connection.Close();
        }

        private void dataGridExamValues() 
        {
            connection.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select StudentName,StudentSurname,LessonName,Midterm,Final,ExamAvg,ExamStatus from Students inner join Exam_Results on Students.StudentId =  Exam_Results.StudentIdd inner join Lessons  on Lessons.Lesson_Id =  Exam_Results.LessonId where StudentNo = @ogrno", connection);

            SqlDataAdapter dtgExamAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgExamAdapter.SelectCommand.Parameters.AddWithValue("@OgrNo", Form1.OgrNo);

            DataTable dataTable = new DataTable();

            dtgExamAdapter.Fill(dataTable);

            dtgExamResult.DataSource = dataTable;

            connection.Close();
        }

        private void Ogrenci_Ekrani_Load(object sender, EventArgs e)
        {

            labelValues();

            dataGridLessonValues();

            dataGridExamValues();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
