using Obs_AdoNet.Ogrenci;
using Obs_AdoNet.Personel;
using Obs_AdoNet.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        public static int OgrNo;
        public static int TeacherNo;
        public static int PersonelNo;


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            OgrNo = Convert.ToInt32(txtStudentNo.Text);
            Student_Screen ogrenci_Ekrani = new Student_Screen();
            ogrenci_Ekrani.Show();
            this.Hide();

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherNo = Convert.ToInt32(txtTeacherNo.Text);
            Teacher_Screen teacher_Screen = new Teacher_Screen();
            teacher_Screen.Show();
            this.Hide();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            PersonelNo = Convert.ToInt32(txtPersonelNo.Text);
            Personel_Screen personel_Screen = new Personel_Screen();
            personel_Screen.Show();
            this.Hide();
        }
    }
}
