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
    public partial class kategoriForm : Form
    {
        public kategoriForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!((string.IsNullOrEmpty(txtKategoriAdd.Text)) && string.IsNullOrWhiteSpace(txtKategoriAdd.Text)))
            {
                comboKategoriBox.Items.Add(txtKategoriAdd.Text);
            }
            else { MessageBox.Show("Boş Bırakmayınız", "Ekleme Hatası!", MessageBoxButtons.OK); }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void kategoriForm_Load(object sender, EventArgs e)
        {

        }
    }
}
