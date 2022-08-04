using Obs_AdoNet.Ogrenci;
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            OgrNo=Convert.ToInt32(txtStudentNo.Text);
            Ogrenci_Ekrani ogrenci_Ekrani = new Ogrenci_Ekrani();
            ogrenci_Ekrani.Show();
            this.Hide();

        }
    }
}
