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
    public partial class Teacher_Screen : Form
    {
        public Teacher_Screen()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");

        private  void LabelValues ()
            {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHours.Text = DateTime.Now.ToLongTimeString();

            SqlCommand labelCommand = new SqlCommand("select TeacherNo,TeacherName,TeacherSurname from Teachers where TeacherNo=@teacherNo", connection);

            labelCommand.Parameters.AddWithValue("@teacherNo", Form1.TeacherNo);

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

        private void DtgLessonProgram()
        {
            connection.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select distinct LessonName, LessonDate, LessonTime, TeacherName, TeacherSurname  from Teachers inner join TransitionLesson  on TransitionLesson.TeacherId = Teachers.Id  inner join  Lessons  on Lessons.Lesson_Id = TransitionLesson.LessonId where TeacherNo = @teacherNo", connection);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@teacherNo", Form1.TeacherNo);

            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);

            dtgTeacherLessonProgram.DataSource = dataTable;

            connection.Close();
        }

        private void DtgStudentList()
        {
            connection.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select LessonName, StudentNo,StudentName,StudentSurname from Students inner join Exam_Results on Students.Id = Exam_Results.StudentId inner join Lessons on Lessons.Lesson_Id = Exam_Results.LessonId inner join Teachers on Teachers.Id = Exam_Results.TeacherId where TeacherNo = @teacherNo", connection);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@teacherNo", Form1.TeacherNo);

            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }

        private void Teacher_Screen_Load(object sender, EventArgs e)
        {
            LabelValues ();
            DtgLessonProgram();
            DtgStudentList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnExamInput_Click(object sender, EventArgs e)
        {
            Teacher_Exam_Input input = new Teacher_Exam_Input();
            input.Show();
            this.Hide();

        }

      
    }
}
