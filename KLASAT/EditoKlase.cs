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
    public partial class EditoKlase : Telerik.WinControls.UI.RadForm
    {
        public EditoKlase()
        {
            InitializeComponent();
            objLidhja.HAPE_LIDHJEN();
        }

        LidhjaDB objLidhja = new LidhjaDB();
        List<string> ListaAktuale = new List<string>();
        private void EditoKlase_Load(object sender, EventArgs e)
        {
            ListaAktuale = objLidhja.LexoKlase();
            foreach (string item in ListaAktuale)
            {
                listKlasa.Items.Add(item.ToString());
            }
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {


            objLidhja.Edito_Klase(txtEmriKlases.Text, ListaAktuale[listKlasa.SelectedIndex].ToString());
            MessageBox.Show("Klasa është edituar me sukses!");
            ListaAktuale.Clear();
            ListaAktuale = objLidhja.LexoKlase();
            listKlasa.DataSource = ListaAktuale;


        }

        private void listKlasa_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtEmriKlases.Text = ListaAktuale[listKlasa.SelectedIndex].ToString();
            }
            catch (Exception)
            {
                //
            }




        }

        private void btnFshi_Click(object sender, EventArgs e)
        {

            if (txtEmriKlases.Text != "")
            {
                objLidhja.FshiKlase(txtEmriKlases.Text);
                MessageBox.Show("Klasa është fshirë me sukses!");
                ListaAktuale.Clear();
                ListaAktuale = objLidhja.LexoKlase();
                listKlasa.DataSource = ListaAktuale;
                txtEmriKlases.Clear();
            }
            else { MessageBox.Show("Nuk keni zgjedhur ndonje klase !"); }


        }
    }
}
