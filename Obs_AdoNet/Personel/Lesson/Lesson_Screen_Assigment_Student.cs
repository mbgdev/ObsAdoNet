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
    public partial class Lesson_Screen_Assigment_Student : Form
    {
        public Lesson_Screen_Assigment_Student()
        {
            InitializeComponent();
        }

        private string PersonelID;

        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");
        private int PersonnelIdGet()
        {


            SqlCommand perId = new SqlCommand("select Id from Personnels where PersonnelNo=@PersonnelNo", connection);
            perId.Parameters.AddWithValue("@PersonnelNo", Form1.PersonelNo);
            connection.Open();
            SqlDataReader reader = perId.ExecuteReader();


            while (reader.Read())
            {
                PersonelID = reader["Id"].ToString();

            }

            reader.Close();
            connection.Close();


            return Convert.ToInt32(PersonelID);


        }
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


            SqlCommand command = new SqlCommand("select  StudentName, StudentSurname, LessonDate,LessonTime,LessonName,TeacherName,TeacherSurname from Students inner join TransitionLesson on TransitionLesson.StudentId = Students.StudentId inner join Lessons on TransitionLesson.LessonId = Lessons.Lesson_Id inner join Teachers on Teachers.TeacherId = TransitionLesson.TeacherId order by Id desc", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataTable.Columns["LessonDate"].ColumnName = "Ders_Günü";
      
            dataTable.Columns["LessonTime"].ColumnName = "Ders_Saati";
            dataTable.Columns["LessonName"].ColumnName = "Ders_Adı";
            dataTable.Columns["StudentName"].ColumnName = "Öğrenci_Adı";
            dataTable.Columns["StudentSurname"].ColumnName = "Öğrenci_Soyadı";
            dataTable.Columns["TeacherName"].ColumnName = "Öğretmen_Adı";
            dataTable.Columns["TeacherSurname"].ColumnName = "Öğretmen_Soyadı";
            dataTable.AcceptChanges();

            dtgLessonList.DataSource = dataTable;

            connection.Close();
        }
        private void TeacherComboBoxGet()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Teachers", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            dataTable.Columns.Add(
               "FullName",
               typeof(string),
               "TeacherName + ' ' +TeacherSurname");

            comboBoxTeacher.DisplayMember = "FullName";
            comboBoxTeacher.ValueMember = "TeacherId";
            comboBoxTeacher.DataSource = dataTable;
            connection.Close();
        }
        private void LessonComboBoxGet()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Lessons", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBoxLesson.DisplayMember = "LessonName";
            comboBoxLesson.ValueMember = "Lesson_Id";
            comboBoxLesson.DataSource = dataTable;
            connection.Close();
        }
        private void StudentComboBoxGet()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Students", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            dataTable.Columns.Add(
               "FullName",
               typeof(string),
               "StudentName + ' ' +StudentSurname");

            comboBoxStudent.DisplayMember = "FullName";
            comboBoxStudent.ValueMember = "StudentId";
            comboBoxStudent.DataSource = dataTable;
            connection.Close();

        }
        private void ExamAssigment()
        {
            
            SqlCommand sqlCommand = new SqlCommand("insert into Exam_Results (" +
                "LessonId, " +
                "StudentIdd,   " +
                "TeacherId,  " +
                "ExamStatus, " +
                "CreatedDate,  " +
                "ModifiedDate,    " +
                "StatusDate, " +
                "CreatedUserId,  " +
                "ModifeidUserId, " +
                "StatusUserId) " +
              "values(" +
              "@LessonId, " +
              "@StudentId,   " +
              "@TeacherId,  " +
              "@ExamStatus, " +
              "@CreatedDate, " +
              "@ModifiedDate,      " +
              "@StatusDate, " +
              "@CreatedUserId,  " +
              "@ModifeidUserId, " +
              "@StatusUserId)", connection);

            sqlCommand.Parameters.AddWithValue("@LessonId", comboBoxLesson.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@StudentId", comboBoxStudent.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@TeacherId", comboBoxTeacher.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@ModifiedDate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@StatusDate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@CreatedUserId", PersonnelIdGet());
            sqlCommand.Parameters.AddWithValue("@ModifeidUserId", PersonnelIdGet());
            sqlCommand.Parameters.AddWithValue("@StatusUserId", PersonnelIdGet());
            sqlCommand.Parameters.AddWithValue("@ExamStatus", 1);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Lesson_Screen lesson_Screen = new Lesson_Screen();
            lesson_Screen.Show();
            this.Close();
        }
        private void Lesson_Screen_Assigment_Student_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgLessonList();
            TeacherComboBoxGet();
            LessonComboBoxGet();
            StudentComboBoxGet();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            
            SqlCommand sqlCommand = new SqlCommand("insert into TransitionLesson (LessonId,TeacherId,StudentId) values(@LessonId,@TeacherId,@StudentId)", connection);
            sqlCommand.Parameters.AddWithValue("@StudentId", comboBoxStudent.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@TeacherId", comboBoxTeacher.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@lessonId", comboBoxLesson.SelectedValue);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ders atama başarılı bir şekilde sisteme kaydedildi");
            DtgLessonList();
            ExamAssigment();
        }
        private void comboBoxLesson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
