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

namespace Obs_AdoNet.Personel.Teachers
{
    public partial class Personel_Teacher_Process_Add : Form
    {
        public Personel_Teacher_Process_Add()
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

            SqlCommand labelCommand = new SqlCommand("select PersonnelNo,PersonnelName,PersonnelSurname from Personnels where PersonnelNo=@PersonnelNo", connection);
            labelCommand.Parameters.AddWithValue("@PersonnelNo", Form1.PersonelNo);
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

        private void DtgTeacherList()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Teachers", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgTeacherList.DataSource = dataTable;

            connection.Close();
        }

        private void Personel_Teacher_Process_Add_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgTeacherList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("insert into Teachers ( TeacherNo, TeacherName, TeacherSurname, TeacherEmail, TeacherAdress, TeacherPhone, CreatedDate, ModifiedDate, StatusDate, CreatedUserId, ModifiedUserId, StatusUserId , Status1, TeacherPassword)  Values(@TeacherNo,@TeacherName,@TeacherSurname,@TeacherEmail,@TeacherAdress,@TeacherPhone,@CreatedDate, @ModifiedDate, @StatusDate, @CreatedUserId, @ModifiedUserId, @StatusUserId , @Status1,@TeacherPassword)", connection);

            command.Parameters.AddWithValue("@TeacherNo", txtTeacherNo.Text);
            command.Parameters.AddWithValue("@TeacherName", txtTeacherName.Text);
            command.Parameters.AddWithValue("@TeacherSurname", txtTeacherSurname.Text);
            command.Parameters.AddWithValue("@TeacherEmail", txtTeacherEmail.Text);
            command.Parameters.AddWithValue("@TeacherPhone", txtTeacherPhone.Text);
            command.Parameters.AddWithValue("@TeacherAdress", rtxtAdress.Text);
            command.Parameters.AddWithValue("@CreatedDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@ModifiedDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@StatusDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@CreatedUserId", PersonnelIdGet());
            command.Parameters.AddWithValue("@ModifiedUserId", PersonnelIdGet());
            command.Parameters.AddWithValue("@StatusUserId", PersonnelIdGet());
            command.Parameters.AddWithValue("@TeacherPassword", txtPassword.Text);



            if (rbActive.Checked == true)
            {
                command.Parameters.AddWithValue("@Status1", "True");
            }
            else if (rbPasive.Checked == true)
            {
                command.Parameters.AddWithValue("@Status1", "False");
            }
            else
            {
                command.Parameters.AddWithValue("@Status1", "False");

            }
            connection.Open();

            command.ExecuteNonQuery();
            MessageBox.Show("Öğretmen başarılı bir şekilde sisteme kaydedildi");
            connection.Close();
            DtgTeacherList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Personel_Teacher_Process personel_Teacher_Process = new Personel_Teacher_Process();
            personel_Teacher_Process.Show();
            this.Close();

        }
    }
}
