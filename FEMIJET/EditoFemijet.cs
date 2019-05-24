using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.FEMIJET
{
    public partial class EditoFemijet : Telerik.WinControls.UI.RadForm
    {
        public EditoFemijet()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
        }
        LidhjaDB ldb = new LidhjaDB();

        List<Femija> ListaAkuale = new List<Femija>();

        private void EditoFemijet_Load(object sender, EventArgs e)
        {
           

            ListaAkuale = ldb.Lexo_Femije();
            foreach (Femija item in ListaAkuale)
            {
                listFemijet.Items.Add(item.EMRIMBIEMRI);
            }
        }

        private void listFemijet_MouseClick(object sender, MouseEventArgs e)
        {
            if (A_Eshte_Kerku==false)
            {
                try
                {
                    txtEmriMbeimri.Text = ListaAkuale[listFemijet.SelectedIndex].EMRIMBIEMRI;
                    txtBaba.Text = ListaAkuale[listFemijet.SelectedIndex].EMRIBABA;
                    txtDateLindja.Text = ListaAkuale[listFemijet.SelectedIndex].DATELINDJA.ToShortDateString();
                    txtMosha.Text = ListaAkuale[listFemijet.SelectedIndex].MOSHA.ToString();
                    txtNena.Text = ListaAkuale[listFemijet.SelectedIndex].EMRINENA;
                    //cmbKlasa.Text = ListaAkuale[listFemijet.SelectedIndex].KLASA;
                    txtAdresa.Text = ListaAkuale[listFemijet.SelectedIndex].ADRESA;
                    pictureBox1.Image = ListaAkuale[listFemijet.SelectedIndex].FOTO.Image;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                try
                {
                    
                    txtEmriMbeimri.Text = Lista_per_Kerkim[listFemijet.SelectedIndex].EMRIMBIEMRI;
                    txtBaba.Text = Lista_per_Kerkim[listFemijet.SelectedIndex].EMRIBABA;
                    txtDateLindja.Text = Lista_per_Kerkim[listFemijet.SelectedIndex].DATELINDJA.ToShortDateString();
                    txtMosha.Text = Lista_per_Kerkim[listFemijet.SelectedIndex].MOSHA.ToString();
                    txtNena.Text = Lista_per_Kerkim[listFemijet.SelectedIndex].EMRINENA;
                   // cmbKlasa.Text = Lista_per_Kerkim[listFemijet.SelectedIndex].KLASA;
                    pictureBox1.Image = Lista_per_Kerkim[listFemijet.SelectedIndex].FOTO.Image;
                }
                catch (Exception)
                {

                }
            }
          

        }

        private void btnFshi_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null && txtEmriMbeimri.Text != "" && txtAdresa.Text != "" && txtBaba.Text != "" && txtNena.Text != "" && txtMosha.Text != "")

            {
                if (ldb.Fshi_Femije(ListaAkuale[listFemijet.SelectedIndex].ID) == true)
                {
                    ListaAkuale.Clear();
                    listFemijet.Items.Clear();
                    MessageBox.Show("FEMIJA ESHTE FSHIRE ME SUKSES!", "SUKSESE");
                    EditoFemijet_Load(sender, e);
                    txtEmriMbeimri.Clear();
                    txtBaba.Clear();
                    txtNena.Clear();
                    txtDateLindja.Clear();
                    txtAdresa.Clear();
                    txtMosha.Clear();
                    pictureBox1.Image = null;
                }
            }
            else { MessageBox.Show("Nuk keni zgjedhur ndonje femije"); }
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            if (A_Eshte_Kerku == false)
            {
                try
                {
                    
                    if (ldb.Edito_Femije(txtEmriMbeimri.Text, txtBaba.Text, txtNena.Text, Convert.ToInt32(txtMosha.Text), txtKerko.Text, Convert.ToDateTime(txtDateLindja.Text), txtAdresa.Text, ListaAkuale[listFemijet.SelectedIndex].ID)==true)
                    {
                        MessageBox.Show("Femija u editua me sukses!");
                        ListaAkuale.Clear();
                        listFemijet.Items.Clear();
                        EditoFemijet_Load(sender, e);
                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                   
                        if (ldb.Edito_Femije(txtEmriMbeimri.Text, txtBaba.Text, txtNena.Text, Convert.ToInt32(txtMosha.Text), txtKerko.Text, Convert.ToDateTime(txtDateLindja.Text), txtAdresa.Text, Lista_per_Kerkim[listFemijet.SelectedIndex].ID) == true)
                        {
                            MessageBox.Show("Femija u editua me sukses!");
                            ListaAkuale.Clear();
                            listFemijet.Items.Clear();
                            EditoFemijet_Load(sender, e);

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        bool A_Eshte_Kerku = false;
        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            Kerko_Dhe_Filtro();
        }



        List<Femija> Lista_per_Kerkim;
        private void Kerko_Dhe_Filtro()
        {
            Lista_per_Kerkim = new List<Femija>();

            foreach (Femija a in ListaAkuale)
            {
                if (a.EMRIMBIEMRI.StartsWith(txtKerko.Text, true, null) || a.EMRIBABA.StartsWith(txtKerko.Text, true, null) || a.ADRESA.StartsWith(txtKerko.Text, true, null) || a.EMRINENA.StartsWith(txtKerko.Text, true, null) || a.DATELINDJA.ToShortDateString().StartsWith(txtKerko.Text, true, null) || a.KLASA.StartsWith(txtKerko.Text, true, null))
                {
                    Lista_per_Kerkim.Add(new Femija() { EMRIMBIEMRI = a.EMRIMBIEMRI, KLASA = a.KLASA, ADRESA = a.ADRESA, DATELINDJA = a.DATELINDJA, EMRIBABA = a.EMRIBABA, EMRINENA = a.EMRINENA, FOTO = a.FOTO, ID = a.ID, MOSHA = a.MOSHA });
                }
            }
            List<string> EmriMbiemriListaAktuale = new List<string>();
            foreach (Femija item in Lista_per_Kerkim)
            {
                EmriMbiemriListaAktuale.Add(item.EMRIMBIEMRI);
            }
            listFemijet.DataSource = EmriMbiemriListaAktuale;
            A_Eshte_Kerku = true;


        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Kerko_Dhe_Filtro();
        }
    }
}
