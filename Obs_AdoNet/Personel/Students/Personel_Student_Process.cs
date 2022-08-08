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

namespace Obs_AdoNet.Personel
{
    public partial class Personel_Process : Form
    {
        public Personel_Process()
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


        private void DtgStudentList()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Students", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }

        private void Personel_Student_Process_Load(object sender, EventArgs e)
        {

            LabelValues();
            DtgStudentList();


        }

        private void btnSearchStudentNo_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Students where StudentNo=@StudentNo",connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.SelectCommand.Parameters.AddWithValue("@StudentNo",txtSearchStudentNo.Text);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            DtgStudentList();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            Personel_Student_Process_Add personel_Student_Process_Add = new Personel_Student_Process_Add();
            personel_Student_Process_Add.Show();
            this.Hide();
        }

        private void BtnStudentUpdate_Click(object sender, EventArgs e)
        {
            Personel_Student_Process_Update personel_Student_Process_Update = new Personel_Student_Process_Update();
            personel_Student_Process_Update.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Personel_Screen personelProcess = new Personel_Screen();
            personelProcess.Show();
            this.Close();
        }
    }
}
