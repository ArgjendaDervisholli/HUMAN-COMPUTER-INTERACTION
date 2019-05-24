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
    public partial class EditoMesues : Telerik.WinControls.UI.RadForm
    {
        public EditoMesues()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
        }
        List<string> ListaAktuale = new List<string>();
        LidhjaDB ldb = new LidhjaDB();
        private void EditoMesues_Load(object sender, EventArgs e)
        {
            ListaAktuale = ldb.Lexo_Mesues();
            listMesues.DataSource = ListaAktuale;
            txtKlasa.DataSource = ldb.LexoKlase();
        }
        string klasaEVjeter;
        private void listMesues_ItemMouseClick(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            List<string> Shenimet_E_Mesuesit = new List<string>();
            Shenimet_E_Mesuesit = ldb.Lexo_Mesues(ListaAktuale[Convert.ToInt32(listMesues.SelectedIndex)]);
            txtEmriMbiemri.Text = Shenimet_E_Mesuesit[0];
            txtKlasa.Text = Shenimet_E_Mesuesit[1];
            klasaEVjeter = Shenimet_E_Mesuesit[1];
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            if (ldb.Edito_Mesues(txtKlasa.Text, klasaEVjeter) == true)
            {
                MessageBox.Show("Mesuesi eshte ndryshar", "SUKSESE");
            }
            else
            {
                MessageBox.Show("Mesuesi nuk eshte ndryshar", "GABIM");
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            if (ldb.Fshi_Mesues(ListaAktuale[Convert.ToInt32(listMesues.SelectedIndex)]) == true)
            {
                if(txtEmriMbiemri.Text!="")
                { 
                MessageBox.Show("Mesuesi eshte fshire", "SUKSESE");
                txtEmriMbiemri.Clear();
                txtKlasa.SelectedIndex = -1;
                }
                else { MessageBox.Show("Nuk keni zgjedhur ndonje mesues !"); }
            }
            else
            {
                MessageBox.Show("Mesuesi nuk eshte fshire", "GABIM");
            }
        }
    }
}
