﻿using System;
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
    public partial class Personel_Personel_Process : Form
    {
        public Personel_Personel_Process()
        {
            InitializeComponent();
        }


        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=ObsDB;Integrated Security=True;");

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


        private void DtgPersonelList()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Personnels", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgPersonelList.DataSource = dataTable;

            connection.Close();
        }

        private void Personel_Personel_Process_Load(object sender, EventArgs e)
        {
            LabelValues();
            DtgPersonelList();
        }

        private void btnSearchPersonelNo_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Personnels where PersonnelNo=@PersonnelNo", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.SelectCommand.Parameters.AddWithValue("@PersonnelNo", txtSearchPersonelNo.Text);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dtgPersonelList.DataSource = dataTable;

            connection.Close();
        }

        private void btnPersonelList_Click(object sender, EventArgs e)
        {
            DtgPersonelList();
        }

        private void btnPersonelAdd_Click(object sender, EventArgs e)
        {
            Personel_Personel_Process_Add personel_Personel_Process_Add =new Personel_Personel_Process_Add();
            personel_Personel_Process_Add.Show();
            this.Hide();
        }

        private void BtnPersonelUpdate_Click(object sender, EventArgs e)
        {
            Personel_Personel_Process_Update personel_Personel_Process_Update = new Personel_Personel_Process_Update();
            personel_Personel_Process_Update.Show();
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
