﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiVeriTasima_Ödev16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string ad;
        public string soyad;
        public string meslek;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(ad);
            comboBox1.Items.Add(soyad);
            comboBox1.Items.Add(meslek);
        }
    }
}
