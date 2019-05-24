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
    public partial class EditoLlogari : Telerik.WinControls.UI.RadForm
    {
        public EditoLlogari()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
        }
        LidhjaDB ldb = new LidhjaDB();
        List<Llogaria> ListaAktuale = new List<Llogaria>();
        private void EditoLlogari_Load(object sender, EventArgs e)
        {
            ListaAktuale = ldb.Lexo_Llogari();
            foreach (Llogaria item in ListaAktuale)
            {
                listLlogarit.Items.Add(item.EMRIMBIEMRI);
            }
        }
        string llogariaEVjeter;
        private void listLlogarit_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtEmriMbiemri.Text = ListaAktuale[Convert.ToInt32(listLlogarit.SelectedIndex)].EMRIMBIEMRI;
                txtFjalekalimi.Text = ListaAktuale[Convert.ToInt32(listLlogarit.SelectedIndex)].FJALKALIMI;
                txtLlogaria.Text = ListaAktuale[Convert.ToInt32(listLlogarit.SelectedIndex)].LLOGARIA;
                cmbTipi.Text = ListaAktuale[Convert.ToInt32(listLlogarit.SelectedIndex)].TIPI;
                rbAktiv.IsChecked = ListaAktuale[Convert.ToInt32(listLlogarit.SelectedIndex)].STATUSI;
                llogariaEVjeter = ListaAktuale[Convert.ToInt32(listLlogarit.SelectedIndex)].LLOGARIA;
            }
            catch (Exception)
            {
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ldb.Edito_Llogari(txtEmriMbiemri.Text, txtLlogaria.Text, txtFjalekalimi.Text, cmbTipi.Text, rbAktiv.IsChecked, llogariaEVjeter) == true)
            {
                MessageBox.Show("Llogaria eshte ndryshuar.", "Suksese");
                ListaAktuale.Clear();
                listLlogarit.Items.Clear();
                EditoLlogari_Load(sender, e);


            }
            else
            {
                MessageBox.Show("Llogaria nuk eshte ndryshuar.", "Gabim");
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            if (txtLlogaria.Text != "")
            {
                if (ListaAktuale[Convert.ToInt32(listLlogarit.SelectedIndex)].STATUSI != true)
            {
                if (ldb.Fshi_Llogari(ListaAktuale[Convert.ToInt32(listLlogarit.SelectedIndex)].LLOGARIA) == true)
                {
                    
                        MessageBox.Show("Llogaria eshte fshire.", "Suksese");
                        txtEmriMbiemri.Clear();
                        txtFjalekalimi.Clear();
                        txtLlogaria.Clear();
                        cmbTipi.SelectedIndex = -1;
                        rbAktiv.Checked = false;
                    
                }
                else
                {
                    MessageBox.Show("Llogaria nuk eshte fshire.", "Gabim");
                }
            }
            else
            {
                MessageBox.Show("LLOGARIA DUHET TE JETE JO AKTIVE");
            }
            }
            else { MessageBox.Show("Nuk keni zgjedhur ndonje Llogari !"); }

        }
    }
}
