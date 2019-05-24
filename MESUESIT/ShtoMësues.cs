using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.MESUESIT
{
    public partial class ShtoMësues : Telerik.WinControls.UI.RadForm
    {
        public ShtoMësues()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN(); 
        }
        LidhjaDB ldb = new LidhjaDB();
        private void ShtoMësues_Load(object sender, EventArgs e)
        {
            txtKlasa.DataSource = ldb.LexoKlase();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (ldb.ShtoMesues(txtEmriMbiemri.Text,txtKlasa.Text)==true)
            {
                MessageBox.Show("Mesuesi eshte shtuar me sukses!", "SUKSESE");
                txtEmriMbiemri.Clear();
                txtKlasa.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Mesuesi nuk eshte shtuar.", "GABIM");
            }
        }
    }
}
