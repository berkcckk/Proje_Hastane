﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.tc = MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC yada Şifre.");
            }
            bgl.baglanti().Close();
        }
    }
}