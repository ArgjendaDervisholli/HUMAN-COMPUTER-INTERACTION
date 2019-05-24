using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.KLASAT
{
    public partial class ShtoKlase : Telerik.WinControls.UI.RadForm
    {
        public ShtoKlase()
        {
            InitializeComponent();
            objLidhja.HAPE_LIDHJEN();
        }
        LidhjaDB objLidhja = new LidhjaDB();
        private void btnShtoKlase_Click(object sender, EventArgs e)
        {
           
              
                    objLidhja.Shto_Klase(txtEmriKlasa.Text);
                    MessageBox.Show("Klasa u shtua me sukses!");
            txtEmriKlasa.Clear();
           
           
        }

        private void ShtoKlase_Load(object sender, EventArgs e)
        {
            btnShtoKlase.Enabled = false;

        }

        private void txtEmriKlasa_TextChanged(object sender, EventArgs e)
        {
            if (txtEmriKlasa.Text!="")
            {
                btnShtoKlase.Enabled=true;
            }
            else
            {
                btnShtoKlase.Enabled = false;
            }
           
        }
    }
}
