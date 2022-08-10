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

        private string midtrem;

        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");

        private void LabelValues()
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

        private void DtgStudentList()
        {
            connection.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select LessonName, StudentNo,StudentName,StudentSurname,Midterm,Final,ExamAvg,ExamStatus from Students inner join Exam_Results " +
                        "on Students.StudentId = Exam_Results.StudentIdd" +
                        " inner join Lessons " +
                        "on Lessons.Lesson_Id = Exam_Results.LessonId " +
                        "inner join Teachers " +
                        "on Teachers.TeacherId = Exam_Results.TeacherId " +
                        "where TeacherNo=@TeacherNo", connection);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);


            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@TeacherNo", Form1.TeacherNo);


            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);
            dataTable.Columns["StudentName"].ColumnName = "Öğrenci_Adı";
            dataTable.Columns["StudentNo"].ColumnName = "Öğrenci_No";
            dataTable.Columns["StudentSurname"].ColumnName = "Öğrenci_Soyadı";
            dataTable.Columns["LessonName"].ColumnName = "Ders_Adı";
            dataTable.Columns["Midterm"].ColumnName = "Ara_Sınav";
            dataTable.Columns["Final"].ColumnName = "Final";
            dataTable.Columns["ExamAvg"].ColumnName = "Ortalama";
            dataTable.Columns["ExamStatus"].ColumnName = "Ders Durum";
            dataTable.AcceptChanges();

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }

        private int ExamAvg(int Midterm, int Final)
        {
            return (Midterm + Final) / 2;

        }

        private void ComboBoxLesson()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select distinct LessonId,LessonName, LessonDate, LessonTime, TeacherName, TeacherSurname  from Teachers inner join TransitionLesson on TransitionLesson.TeacherId = Teachers.TeacherId  inner join  Lessons on Lessons.Lesson_Id = TransitionLesson.LessonId where TeacherNo = @teacherNo", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@TeacherNo", Form1.TeacherNo);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cbLesson.DisplayMember = "LessonName";
            cbLesson.ValueMember = "LessonId";
            cbLesson.DataSource = dataTable;
            connection.Close();
        }

        private void Teacher_Exam_Input_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgStudentList();
            ComboBoxLesson();
            btnExamUpdateFinal.Enabled = false;
            btnExamUpdateMidterm.Enabled = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Teacher_Screen teacher_Screen = new Teacher_Screen();
            teacher_Screen.Show();
            this.Hide();
        }

        private void btnStudentGet_Click(object sender, EventArgs e)
        {

            btnExamUpdateFinal.Enabled = true;
            btnExamUpdateMidterm.Enabled = true;

            connection.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select LessonName, StudentNo,StudentName,StudentSurname,Midterm,Final,ExamAvg,ExamStatus from Students inner join Exam_Results " +
                "on Students.StudentId = Exam_Results.StudentIdd " +
                "inner join Lessons " +
                "on Lessons.Lesson_Id = Exam_Results.LessonId " +
                "inner join Teachers " +
                "on Teachers.TeacherId = Exam_Results.TeacherId" +
                " where StudentNo = @StudentNo and TeacherNo=@TeacherNo", connection);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);
            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@TeacherNo", Form1.TeacherNo);



            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }

        private void btnExamUpdateMidterm_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand ExamCommand = new SqlCommand("update  Exam_Results set Midterm = @Midterm where LessonId=@LessonId and  StudentIdd = (select   distinct StudentId from Students inner join Exam_Results " +
                "on Students.StudentId = Exam_Results.StudentIdd " +
                "inner join Lessons " +
                "on Lessons.Lesson_Id = Exam_Results.LessonId  " +
                "inner join Teachers " +
                "on Teachers.TeacherId = Exam_Results.TeacherId " +
                "where StudentNo = @StudentNo and TeacherNo = @TeacherNo)", connection);



            ExamCommand.Parameters.AddWithValue("@LessonId", cbLesson.SelectedValue);
            ExamCommand.Parameters.AddWithValue("@Midterm", txtMidterm.Text);
            ExamCommand.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);
            ExamCommand.Parameters.AddWithValue("@TeacherNo", Form1.TeacherNo);


            ExamCommand.ExecuteNonQuery();



            SqlCommand dtgLessonCommand = new SqlCommand("select LessonName, StudentNo,StudentName,StudentSurname,Midterm,Final,ExamAvg,ExamStatus from Students inner join Exam_Results " +
                "on Students.StudentId = Exam_Results.StudentIdd " +
                "inner join Lessons " +
                "on Lessons.Lesson_Id = Exam_Results.LessonId " +
                "inner join Teachers " +
                "on Teachers.TeacherId = Exam_Results.TeacherId " +
                "where StudentNo = @StudentNo and TeacherNo=@TeacherNo", connection);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);
            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@TeacherNo", Form1.TeacherNo);



            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }

        private void btnExamUpdateFinal_Click(object sender, EventArgs e)
        {


            connection.Open();

            SqlCommand midtermCommand = new SqlCommand("select Midterm from Students " +
                "inner join Exam_Results " +
                "on Students.StudentId = Exam_Results.StudentIdd " +
                "inner join Lessons " +
                "on Lessons.Lesson_Id = Exam_Results.LessonId " +
                "inner join Teachers " +
                "on Teachers.TeacherId = Exam_Results.TeacherId " +
                "where StudentNo = @StudentNo and TeacherNo=@TeacherNo and Lesson_Id=@Lesson_Id", connection);

            midtermCommand.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);
            midtermCommand.Parameters.AddWithValue("@TeacherNo", Form1.TeacherNo);
            midtermCommand.Parameters.AddWithValue("@Lesson_Id", cbLesson.SelectedValue);


            SqlDataReader reader = midtermCommand.ExecuteReader();
            while (reader.Read())
            {
                midtrem = reader["Midterm"].ToString();


            }
            reader.Close();

            SqlCommand ExamCommand = new SqlCommand("update  Exam_Results set Final = @Final ,ExamAvg=@ExamAvg where LessonId=@LessonId and StudentIdd = (select  distinct StudentId from Students " +
                "inner join Exam_Results " +
                "on Students.StudentId = Exam_Results.StudentIdd " +
                "inner join Lessons " +
                "on Lessons.Lesson_Id = Exam_Results.LessonId " +
                " inner join Teachers " +
                "on Teachers.TeacherId = Exam_Results.TeacherId " +
                "where StudentNo = @StudentNo and TeacherNo = @TeacherNo)", connection);



            ExamCommand.Parameters.AddWithValue("@LessonId", cbLesson.SelectedValue);
            ExamCommand.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);
            ExamCommand.Parameters.AddWithValue("@TeacherNo", Form1.TeacherNo);
            ExamCommand.Parameters.AddWithValue("@Final", txtFinal.Text);
            ExamCommand.Parameters.AddWithValue("@ExamAvg", ExamAvg(Convert.ToInt32(midtrem), Convert.ToInt32(txtFinal.Text)));

            ExamCommand.ExecuteNonQuery();



            SqlCommand dtgLessonCommand = new SqlCommand("select LessonName, StudentNo,StudentName,StudentSurname,Midterm,Final,ExamAvg,ExamStatus from Students inner join Exam_Results " +
                "on Students.StudentId = Exam_Results.StudentIdd" +
                " inner join Lessons " +
                "on Lessons.Lesson_Id = Exam_Results.LessonId " +
                "inner join Teachers " +
                "on Teachers.TeacherId = Exam_Results.TeacherId " +
                "where StudentNo = @StudentNo and TeacherNo=@TeacherNo", connection);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);
            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@TeacherNo", Form1.TeacherNo);



            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Teacher_Screen teacher_Screen = new Teacher_Screen();
            teacher_Screen.Show();
            this.Hide();
        }
    }
}
