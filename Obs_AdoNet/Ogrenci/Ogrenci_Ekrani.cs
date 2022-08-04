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
    public partial class Ogrenci_Ekrani : Form
    {
        public Ogrenci_Ekrani()
        {
            InitializeComponent();
        }

        private SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");

        private void labelValues()
        {
            lblStudentScreenDateTime.Text = DateTime.Now.ToLongDateString();

            SqlCommand labelCommand = new SqlCommand("select StudentNo,StudentName,StudentSurname from Students where StudentNo=@OgrNo", baglanti);

            labelCommand.Parameters.AddWithValue("@OgrNo", Form1.OgrNo);

            baglanti.Open();

            labelCommand.ExecuteNonQuery();

            SqlDataReader reader = labelCommand.ExecuteReader();

            while (reader.Read())
            {
                lblStudentNo.Text = reader["StudentNo"].ToString();
                lblStudentName.Text = reader["StudentName"].ToString();
                lblStudentSurname.Text = reader["StudentSurname"].ToString();
            }

            reader.Close();

            baglanti.Close();
        }

        private void dataGridLessonValues()
        {

            baglanti.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select StudentName,StudentSurname,LessonName,TeacherName,TeacherSurname from Students inner join TransitionLesson on TransitionLesson.StudentId = Students.Id inner join Lessons on TransitionLesson.LessonId = Lessons.Id inner join Teachers on Teachers.Id = TransitionLesson.TeacherId where StudentNo = @ogrNo", baglanti);

            SqlDataAdapter dtgLessonAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgLessonAdapter.SelectCommand.Parameters.AddWithValue("@OgrNo", Form1.OgrNo);

            DataTable dataTable = new DataTable();

            dtgLessonAdapter.Fill(dataTable);

            dtgStudentLessonProgram.DataSource = dataTable;

            baglanti.Close();
        }

        private void dataGridExamValues() 
        {
            baglanti.Open();

            SqlCommand dtgLessonCommand = new SqlCommand("select StudentName,StudentSurname,LessonName,Midterm,Final,ExamAvg from Students inner join Exam_Results on Students.Id =  Exam_Results.StudentId inner join Lessons  on Lessons.Id =  Exam_Results.LessonId where StudentNo = @ogrno", baglanti);

            SqlDataAdapter dtgExamAdapter = new SqlDataAdapter(dtgLessonCommand);

            dtgExamAdapter.SelectCommand.Parameters.AddWithValue("@OgrNo", Form1.OgrNo);

            DataTable dataTable = new DataTable();

            dtgExamAdapter.Fill(dataTable);

            dtgExamResult.DataSource = dataTable;

            baglanti.Close();
        }

        private void Ogrenci_Ekrani_Load(object sender, EventArgs e)
        {

            labelValues();

            dataGridLessonValues();

            dataGridExamValues();


        }
    }
}
