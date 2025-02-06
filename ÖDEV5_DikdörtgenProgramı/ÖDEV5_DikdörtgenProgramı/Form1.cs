using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖDEV5_DikdörtgenProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kk, uk, alan, cevre;
            kk = 10;
            uk = 15;
            alan = kk * uk;
            cevre = kk * 2 + uk * 2;
            label3.Text = "alan: " + alan + " çEVRE: " + cevre;
        }
    }
}
