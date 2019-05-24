using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.PAGESAT
{
    public partial class ShtoPagesë : Telerik.WinControls.UI.RadForm
    {
        public ShtoPagesë()
        {
            InitializeComponent();
            objLidhja.HAPE_LIDHJEN();
        }

        LidhjaDB objLidhja = new LidhjaDB();

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (objLidhja.Shto_Pagese(txtEmriMbiemri.Text, DateTime.Now, DateTime.Now.TimeOfDay, Convert.ToDouble(txtCmimi.Text), txtEmriBabait.Text, cmbPersoniA.Text, txtKlasa.Text, txtKomenti.Text) == true)
            {
                MessageBox.Show("Pagesa u shtua me Sukses !");
                txtCmimi.Clear();
                txtEmriBabait.Clear();
                txtEmriMbiemri.SelectedIndex = -1;
                txtKlasa.SelectedIndex = -1;
                txtKomenti.Clear();
                cmbPersoniA.SelectedIndex = -1;
            }
        }

        private void ShtoPagesë_Load(object sender, EventArgs e)
        {
            txtKlasa.DataSource = objLidhja.LexoKlase();
        }

        private void txtKlasa_DropDownClosed(object sender, EventArgs e)
        {
            txtEmriMbiemri.DataSource = objLidhja.Lexo_Femije(txtKlasa.Text);
            cmbPersoniA.DataSource = objLidhja.Lexo_Mesues(txtKlasa.Text,1);
        }
    }
}
