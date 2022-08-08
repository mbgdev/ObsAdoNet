using Obs_AdoNet.Ogrenci;
using Obs_AdoNet.Personel;
using Obs_AdoNet.Teacher;
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

namespace Obs_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FromClosing;
        }

        private void Form1_FromClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static int OgrNo;
        public static int TeacherNo;
        public static int PersonelNo;
         private int a ;

        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");


        private void btnLogIn_Click(object sender, EventArgs e)
        {
        
            if (!(string.IsNullOrEmpty(txtNo.Text)))
                a = Convert.ToInt32(txtNo.Text);

            connection.Open();

            if (a / 1000 == 20221)
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Students where StudentNo=@StudentNo and StudentPassword=@StudentPassword", connection);
                sqlCommand.Parameters.AddWithValue("@StudentNo", txtNo.Text);
                sqlCommand.Parameters.AddWithValue("@StudentPassword", txtPassword.Text);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    OgrNo = a;
                    Student_Screen ogrenci_Ekrani = new Student_Screen();
                    ogrenci_Ekrani.Show();
                    this.Hide();
                    dataReader.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı numarası veya şifre yanlış.");
                }


            }
            else if (a / 1000 == 20222)
            {

                SqlCommand sqlCommand = new SqlCommand("select * from Teachers where TeacherNo=@TeacherNo and TeacherPassword=@TeacherPassword", connection);
                sqlCommand.Parameters.AddWithValue("@TeacherNo", txtNo.Text);
                sqlCommand.Parameters.AddWithValue("@TeacherPassword", txtPassword.Text);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    TeacherNo = a;
                    Teacher_Screen teacher_Screen = new Teacher_Screen();
                    teacher_Screen.Show();
                    this.Hide();
                    dataReader.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı numarası veya şifre yanlış.");
                }
            }
            else if (a / 1000 == 20223)
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Personnels where PersonnelNo=@PersonnelNo and PersonnelPassword=@PersonnelPassword", connection);
                sqlCommand.Parameters.AddWithValue("@PersonnelNo", txtNo.Text);
                sqlCommand.Parameters.AddWithValue("@PersonnelPassword", txtPassword.Text);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {

                    PersonelNo = a;
                    Personel_Screen personel_Screen = new Personel_Screen();
                    personel_Screen.Show();
                    this.Hide();
                    dataReader.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı numarası veya şifre yanlış.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı numarası veya şifre yanlış.");
            }


            connection.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPassword.Checked==true)
            txtPassword.UseSystemPasswordChar = false;
            else
            txtPassword.UseSystemPasswordChar = true;

        }
    }
}
