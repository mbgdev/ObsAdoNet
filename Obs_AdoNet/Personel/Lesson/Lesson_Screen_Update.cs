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
    public partial class Lesson_Screen_Update : Form
    {
        public Lesson_Screen_Update()
        {
            InitializeComponent();
        }

        private string PersonelID;
        private int LessonID;

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

            SqlCommand command = new SqlCommand("select Lesson_Id, LessonName, LessonDate, LessonTime,Status1  from Lessons order by Lesson_Id desc", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataTable.Columns["LessonDate"].ColumnName = "Ders_Günü";
            dataTable.Columns["Lesson_Id"].ColumnName = "Ders_Id";

            dataTable.Columns["LessonTime"].ColumnName = "Ders_Saati";
            dataTable.Columns["LessonName"].ColumnName = "Ders_Adı";
            dataTable.Columns["Status1"].ColumnName = "Durum";
        
            dataTable.AcceptChanges();
            dtgLessonList.DataSource = dataTable;

            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Lesson_Screen lesson_Screen = new Lesson_Screen();
            lesson_Screen.Show();
            this.Close();
        }

        private void Lesson_Screen_Update_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgLessonList();
        }

        private void dtgLessonList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectRowColoum=dtgLessonList.SelectedCells[0].RowIndex;

            LessonID = Convert.ToInt32(dtgLessonList.Rows[selectRowColoum].Cells[0].Value);
            txtLessonName.Text = dtgLessonList.Rows[selectRowColoum].Cells[1].Value.ToString();
            txtLessonDay.Text = dtgLessonList.Rows[selectRowColoum].Cells[2].Value.ToString();
            txtLessonTime.Text = dtgLessonList.Rows[selectRowColoum].Cells[3].Value.ToString();
            

        }

        private void txtLessonSearch_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select distinct LessonName, LessonDate, LessonTime, TeacherName, TeacherSurname  from Teachers inner join TransitionLesson on TransitionLesson.TeacherId = Teachers.TeacherId inner join  Lessons on Lessons.Lesson_Id = TransitionLesson.LessonId where LessonName like'" + txtLessonSearch.Text + "%'", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dtgLessonList.DataSource = dataTable;
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //sqlcommand var
            #region
            SqlCommand sqlCommand = new SqlCommand("update Lessons set " +
                "LessonName       = @LessonName, " +
                "   LessonDate    =  @LessonDate, " +
                "   LessonTime    =  @LessonTime,  " +
                "  CreaateDate    =  @CreaateDate, " +
                "  ModifiedDate   =  @ModifiedDate, " +
                "   DeletedDate   = @DeletedDate,  " +
                " CreatedUserId   =  @CreatedUserId, " +
                "  ModifeidUserId =  @ModifeidUserId, " +
                "   StatusUserId  =  @StatusUserId, " +
                "   Status1       =  @Status1    where Lesson_Id=@LessonId", connection);
       
            #endregion
            sqlCommand.Parameters.AddWithValue("@LessonName", txtLessonName.Text);
            sqlCommand.Parameters.AddWithValue("@LessonId", LessonID);
            sqlCommand.Parameters.AddWithValue("@LessonDate", txtLessonDay.Text);
            sqlCommand.Parameters.AddWithValue("@LessonTime", txtLessonTime.Text);
            sqlCommand.Parameters.AddWithValue("@CreaateDate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@ModifiedDate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@DeletedDate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@CreatedUserId", PersonnelIdGet());
            sqlCommand.Parameters.AddWithValue("@ModifeidUserId", PersonnelIdGet());
            sqlCommand.Parameters.AddWithValue("@StatusUserId", PersonnelIdGet());

            if (rbActive.Checked == true)
            {
                sqlCommand.Parameters.AddWithValue("@Status1", "True");
            }
            else if (rbPasive.Checked == true)
            {
                sqlCommand.Parameters.AddWithValue("@Status1", "False");
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Status1", "False");

            }
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Ders başarılı bir şekilde sisteme güncellendi.");
            connection.Close();
            DtgLessonList();


        }
    }
}
