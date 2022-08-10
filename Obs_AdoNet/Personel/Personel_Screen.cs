using Obs_AdoNet.Personel.Lesson;
using Obs_AdoNet.Personel.Personel;
using Obs_AdoNet.Personel.Teachers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obs_AdoNet.Personel
{
    public partial class Personel_Screen : Form
    {
        public Personel_Screen()
        {
            InitializeComponent();
        }
        private void btnStudentProcess_Click(object sender, EventArgs e)
        {
            Personel_Process personel_Student_Process = new Personel_Process();
            personel_Student_Process.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnTeacherProcess_Click(object sender, EventArgs e)
        {
            Personel_Teacher_Process personel_Teacher_Process = new Personel_Teacher_Process();
            personel_Teacher_Process.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel_Personel_Process personel_Personel_Process = new Personel_Personel_Process();
            personel_Personel_Process.Show();
            this.Hide();
        }

        private void btnLessonAdd_Click(object sender, EventArgs e)
        {
            Lesson_Screen lesson_Screen = new Lesson_Screen();
            lesson_Screen.Show();
            this.Hide();
        }
    }
}
