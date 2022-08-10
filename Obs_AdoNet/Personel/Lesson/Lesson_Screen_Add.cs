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
    public partial class Lesson_Screen_Add : Form
    {
        public Lesson_Screen_Add()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");


        private string PersonelID;
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

            SqlCommand command = new SqlCommand("select  LessonName, LessonDate, LessonTime,Status1  from Lessons order by Lesson_Id desc", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataTable.Columns["LessonDate"].ColumnName = "Ders_Günü";
            dataTable.Columns["LessonTime"].ColumnName = "Ders_Saati";
            dataTable.Columns["LessonName"].ColumnName = "Ders_Adı";
            dataTable.Columns["Status1"].ColumnName = "Durum";
            dataTable.AcceptChanges();
            dtgLessonList.DataSource = dataTable;

            connection.Close();
        }

        private void Lesson_Screen_Add_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgLessonList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //sqlcommand var
            #region
            SqlCommand sqlCommand = new SqlCommand("insert into Lessons (" +
                "LessonName," +
                "   LessonDate," +
                "   LessonTime, " +
                "  CreaateDate, " +
                "  ModifiedDate," +
                "   DeletedDate,  " +
                " CreatedUserId, " +
                "  ModifeidUserId," +
                "   StatusUserId," +
                "   Status1) " +
                "values(@LessonName," +
                " @LessonDate," +
                " @LessonTime," +
                " @CreaateDate," +
                " @ModifiedDate, " +
                "@DeletedDate," +
                " @CreatedUserId," +
                " @ModifeidUserId," +
                " @StatusUserId," +
                " @Status1)", connection);
            #endregion
            sqlCommand.Parameters.AddWithValue("@LessonName", txtLessonName.Text);
            sqlCommand.Parameters.AddWithValue("@LessonDate", txtLessonDay.Text);
            sqlCommand.Parameters.AddWithValue("@LessonTime", txtLEssonTime.Text);
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
            MessageBox.Show("Ders başarılı bir şekilde sisteme kaydedildi");
            connection.Close();
            DtgLessonList();



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Lesson_Screen lesson_Screen = new Lesson_Screen();
            lesson_Screen.Show();
            this.Close();
        }
    }
}
