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

namespace Obs_AdoNet.Personel.Personel
{
    public partial class Personel_Personel_Process_Add : Form
    {
        public Personel_Personel_Process_Add()
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


        private void DtgPersonnelList()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Personnels", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgPersonellList.DataSource = dataTable;

            connection.Close();
        }


        private void Personel_Personel_Process_Add_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgPersonnelList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Personel_Personel_Process personel_Personel_Process = new Personel_Personel_Process();
            personel_Personel_Process.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            SqlCommand command = new SqlCommand("insert into Personnels ( PersonnelNo, PersonnelName, PersonnelSurname, PersonnelEmail, PersonnelAdress, PersonnelPhone, CreatedDate, ModifiedDate, StatusDate, CreatedUserId, ModifiedUserId, StatusUserId , Status1,PersonnelPassword)  Values(@PersonnelNo,@PersonnelName,@PersonnelSurname,@PersonnelEmail,@PersonnelAdress,@PersonnelPhone,@CreatedDate, @ModifiedDate, @StatusDate, @CreatedUserId, @ModifiedUserId, @StatusUserId , @Status1,@PersonnelPassword)", connection);

            command.Parameters.AddWithValue("@PersonnelNo", txtPersonelNo.Text);
            command.Parameters.AddWithValue("@PersonnelPassword", txtPassword.Text);
            command.Parameters.AddWithValue("@PersonnelName", txtPersonelName.Text);
            command.Parameters.AddWithValue("@PersonnelSurname", txtPersonelSurname.Text);
            command.Parameters.AddWithValue("@PersonnelEmail", txtPersonelEmail.Text);
            command.Parameters.AddWithValue("@PersonnelPhone", txtPersonelPhone.Text);
            command.Parameters.AddWithValue("@PersonnelAdress", rtxtAdress.Text);
            command.Parameters.AddWithValue("@CreatedDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@ModifiedDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@StatusDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@CreatedUserId", PersonnelIdGet());
            command.Parameters.AddWithValue("@ModifiedUserId", PersonnelIdGet());
            command.Parameters.AddWithValue("@StatusUserId", PersonnelIdGet());


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
            MessageBox.Show("Personel başarılı bir şekilde sisteme kaydedildi");
            connection.Close();
            DtgPersonnelList();
        }
    }
}
