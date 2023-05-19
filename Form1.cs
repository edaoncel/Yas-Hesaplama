using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yas_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDogumtarihi_Click(object sender, EventArgs e)
        {

        }

        private void btnYashesaplayıcı_Click(object sender, EventArgs e)
        {
            DateTime Dogumtarih;
            Dogumtarih = Convert.ToDateTime(txtDogumtarihi.Text);
            int yas;
            yas = DateTime.Now.Year - Dogumtarih.Year;
            MessageBox.Show(yas.ToString());
        }
    }
}
