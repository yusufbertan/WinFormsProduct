﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProduct
{
    public partial class urunForm : Form
    {
        public urunForm()
        {
            InitializeComponent();
        }
        public void urunForm_Load(object sender, EventArgs e)
        {
            Form kategori = new kategoriForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtUrunAd.Text} Başarıyla Eklendi!","Ürünler!",MessageBoxButtons.OK);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
