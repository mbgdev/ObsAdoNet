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
    public partial class Personel_Student_Process_Add : Form
    {
        public Personel_Student_Process_Add()
        {
            InitializeComponent();
        }
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");
        private void LabelValues()
        {
            lblDate.Text = DateTime.Now.ToLongDateString();

            lblHours.Text = DateTime.Now.ToLongTimeString();
            connection.Open();

            SqlCommand labelCommand = new SqlCommand("select PersonnelNo,Name,Surname from Personnels where PersonnelNo=20223001", connection);

            labelCommand.ExecuteNonQuery();

            SqlDataReader reader = labelCommand.ExecuteReader();

            while (reader.Read())
            {
                lblPersonelNo.Text = reader["PersonnelNo"].ToString();
                lblPersonelName.Text = reader["Name"].ToString();
                lblPersonelSurname.Text = reader["Surname"].ToString();
            }

            reader.Close();

            connection.Close();


        }
        private void DtgStudentList()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Students order by Id desc", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgStudentList.DataSource = dataTable;

            connection.Close();
        }
        private void Personel_Student_Process_Add_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgStudentList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("insert into Students ( StudentNo, StudentName, StudentSurname, StudentEmail, StudentAdress, StduentPhone, CreatedDate, ModifiedDate, StatusDate, CreatedUserId, ModifiedUserId, StatusUserId , Status1)  Values(@StudentNo,@StudentName,@StudentSurname,@StudentEmail,@StudentAdress,@StduentPhone,@CreatedDate, @ModifiedDate, @StatusDate, @CreatedUserId, @ModifiedUserId, @StatusUserId , @Status1)", connection);

            command.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);
            command.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
            command.Parameters.AddWithValue("@StudentSurname", txtStudentSurname.Text);
            command.Parameters.AddWithValue("@StudentEmail", txtStudentEmail.Text);
            command.Parameters.AddWithValue("@StduentPhone", txtStudentPhone.Text);
            command.Parameters.AddWithValue("@StudentAdress", rtxtAdress.Text);
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
            MessageBox.Show("Ürün başarılı bir şekilde sisteme kaydedildi");
            connection.Close();
            DtgStudentList();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Personel_Student_Process personel_Student_Process = new Personel_Student_Process();

            personel_Student_Process.Show();

            this.Hide();
        }
    }
}
