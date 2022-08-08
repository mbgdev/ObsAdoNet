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
    public partial class Personel_Personel_Process_Update : Form
    {
        public Personel_Personel_Process_Update()
        {
            InitializeComponent();
        }



        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");

        private void LabelValues()
        {
            lblDate.Text = DateTime.Now.ToLongDateString();

            lblHours.Text = DateTime.Now.ToLongTimeString();
            connection.Open();

            SqlCommand labelCommand = new SqlCommand("select PersonnelNo,PersonnelName,PersonnelSurname from Personnels where PersonnelNo=20223001", connection);

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

            SqlCommand command = new SqlCommand("select * from Personnels order by Id desc", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgPersonelList.DataSource = dataTable;

            connection.Close();
        }

        private void Personel_Personel_Process_Update_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgPersonnelList();
        }

       

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Personel_Personel_Process personel_Personel_Process = new Personel_Personel_Process();
            personel_Personel_Process.Show();
            this.Hide();
        }

        private void BtnStudentGet_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("Select * from Personnels where PersonnelNo='" + txtPersonelNo.Text + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtPersonelName.Text = reader["PersonnelName"].ToString();
                txtPersonelSurname.Text = reader["PersonnelSurname"].ToString();
                txtPersonelEmail.Text = reader["PersonnelEmail"].ToString();
                txtPersonelPhone.Text = reader["PersonnelPhone"].ToString();
                rtxtAdress.Text = reader["PersonnelAdress"].ToString();
                string st = reader["Status1"].ToString();


            }

            reader.Close();
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("update Personnels set  " +
                "PersonnelName=@PersonnelName, " +
                "PersonnelSurname=@PersonnelSurname," +
                "PersonnelEmail=@PersonnelEmail," +
                "PersonnelAdress=@PersonnelAdress," +
                "PersonnelPhone=@PersonnelPhone," +
                "CreatedDate=@CreatedDate," +
                "ModifiedDate=@ModifiedDate," +
                "StatusDate=@StatusDate," +
                "CreatedUserId=@CreatedUserId," +
                "ModifiedUserId=@ModifiedUserId," +
                "StatusUserId=@StatusUserId," +
                "Status1=@Status1" +
                "  where PersonnelNo=@PersonnelNo", connection);

            command.Parameters.AddWithValue("@PersonnelNo", txtPersonelNo.Text);
            command.Parameters.AddWithValue("@PersonnelName", txtPersonelName.Text);
            command.Parameters.AddWithValue("@PersonnelSurname", txtPersonelSurname.Text);
            command.Parameters.AddWithValue("@PersonnelEmail", txtPersonelEmail.Text);
            command.Parameters.AddWithValue("@PersonnelPhone", txtPersonelPhone.Text);
            command.Parameters.AddWithValue("@PersonnelAdress", rtxtAdress.Text);
            command.Parameters.AddWithValue("@CreatedDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@ModifiedDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@StatusDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@CreatedUserId", 1);
            command.Parameters.AddWithValue("@ModifiedUserId", 1);
            command.Parameters.AddWithValue("@StatusUserId", 1);


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
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün başarılı bir şekilde sisteme güncellendi.");
            connection.Close();
            DtgPersonnelList();
        }
    }
}
