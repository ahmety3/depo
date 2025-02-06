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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ad = textBox1.Text;
            frm.yas = Convert.ToInt32(maskedTextBox1.Text);
            frm.ilce = comboBox1.Text;
            frm.mesaj = listBox1.Text;
            frm.Show();
            this.Hide();
           
        }
    }
}
