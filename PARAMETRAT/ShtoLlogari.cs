using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.PARAMETRAT
{
    public partial class ShtoLlogari : Telerik.WinControls.UI.RadForm
    {
        public ShtoLlogari()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
        }
        LidhjaDB ldb = new LidhjaDB();
        private void ShtoLlogari_Load(object sender, EventArgs e)
        {

        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (ldb.Shto_Llogari(txtEmriMbiemri.Text, txtLlogaria.Text, txtFjalekalimi.Text, cmbTipi.Text, rbAktiv.IsChecked) == true)
            {
                MessageBox.Show("Llogaria eshte shtuar", "SUKSESE");
                txtEmriMbiemri.Clear();
                txtFjalekalimi.Clear();
                txtLlogaria.Clear();
                cmbTipi.SelectedIndex = -1;
                rbAktiv.IsChecked = false;
            }
            else
            {
                MessageBox.Show("Llogaria nuk eshte shtuar", "GABIM");
            }
        }
    }
}
