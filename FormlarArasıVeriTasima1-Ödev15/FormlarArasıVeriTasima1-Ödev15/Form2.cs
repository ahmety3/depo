using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıVeriTasima1_Ödev15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string ad;
        public int yas;
        public string ilce;
        public string mesaj;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = ad;
            label2.Text = yas.ToString();
            label3.Text = ilce;
            label4.Text = mesaj;
        }
    }
}
