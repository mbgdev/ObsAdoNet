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

namespace Obs_AdoNet.Personel.Lesson
{
    public partial class Lesson_Screen : Form
    {
        public Lesson_Screen()
        {
            InitializeComponent();
        }
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");
        private void LabelValues()
        {
            lblDate.Text = DateTime.Now.ToLongDateString();

            lblHours.Text = DateTime.Now.ToLongTimeString();
            connection.Open();

            SqlCommand labelCommand = new SqlCommand("select PersonnelNo,PersonnelName,PersonnelSurname from Personnels where PersonnelNo=@PersonelNo", connection);

            labelCommand.Parameters.AddWithValue("@PersonelNo", Form1.PersonelNo);

            labelCommand.ExecuteNonQuery();

            SqlDataReader reader = labelCommand.ExecuteReader();

            while (reader.Read())
            {
                lblPersonelNo.Text = reader["PersonnelNo"].ToString();
                lblPersonelName.Text = reader["PersonnelName"].ToString();
                lblPersonelSurname.Text = reader["PersonnelSurname"].ToString();
            }

            reader.Close();

            connection.Close();


        }

        private void DtgLessonList()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select distinct LessonName, LessonDate, LessonTime, TeacherName, TeacherSurname  from Teachers inner join TransitionLesson on TransitionLesson.TeacherId = Teachers.TeacherId inner join  Lessons  on Lessons.Lesson_Id = TransitionLesson.LessonId", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgLessonList.DataSource = dataTable;

            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Personel_Screen personelProcess = new Personel_Screen();
            personelProcess.Show();
            this.Close();
        }

        private void Lesson_Screen_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgLessonList();
        }

        private void txtSearchPersonelNo_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select distinct LessonName, LessonDate, LessonTime, TeacherName, TeacherSurname  from Teachers inner join TransitionLesson on TransitionLesson.TeacherId = Teachers.TeacherId inner join  Lessons on Lessons.Lesson_Id = TransitionLesson.LessonId where LessonName like'" + txtSearchLessonName.Text + "%'", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dtgLessonList.DataSource = dataTable;
            connection.Close();
        }

        private void btnLessonAdd_Click(object sender, EventArgs e)
        {
            Lesson_Screen_Add lesson_Screen_Add = new Lesson_Screen_Add();
            lesson_Screen_Add.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lesson_Screen_Update lesson_Screen_Update = new Lesson_Screen_Update();
            lesson_Screen_Update.Show();
            this.Hide();
        }



        private void btnAssigment_Click(object sender, EventArgs e)
        {
            Lesson_Screen_Assigment_Student lesson_Screen_Assigment_Student = new Lesson_Screen_Assigment_Student();
            lesson_Screen_Assigment_Student.Show();
            this.Hide();
        }
    }
}
