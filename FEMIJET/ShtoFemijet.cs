using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.FEMIJET
{
    public partial class ShtoFemijet : Telerik.WinControls.UI.RadForm
    {
        public ShtoFemijet()
        {
            InitializeComponent();
            lidhja.HAPE_LIDHJEN();
            txtKlasa.DataSource = lidhja.LexoKlase();
        }
        LidhjaDB lidhja = new LidhjaDB();
        private void btnShtoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog GjejeFOTON = new OpenFileDialog();

            GjejeFOTON.Filter = "All files (*.*)|*.*";
            GjejeFOTON.RestoreDirectory = true;

            if (GjejeFOTON.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(GjejeFOTON.FileName);
            }

        }

        private void btnShto_Click(object sender, EventArgs e)
        {


            if (pictureBox1.Image != null && txtEmriMbiemri.Text != "" && txtAdresa.Text != "" && txtDatelindja.Text != "" && txtEmriBabai.Text != "" && txtEmriNena.Text != "" && txtKlasa.Text != "" && txtMosha.Text != "")
            {


                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] photo = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo, 0, photo.Length);



                    if (lidhja.Shto_Femije(photo, txtEmriMbiemri.Text, txtEmriBabai.Text, txtEmriNena.Text, Convert.ToInt32(txtMosha.Text), txtKlasa.Text, Convert.ToDateTime(txtDatelindja.Text), txtAdresa.Text) == true)
                    {
                        MessageBox.Show("Femiju eshte shtuar me sukses!", "SUKSESE");
                        txtEmriMbiemri.Clear();
                        txtEmriBabai.Clear();
                        txtEmriNena.Clear();                   
                        txtAdresa.Clear();
                        txtMosha.Clear();
                        pictureBox1.Image = null;
                        txtKlasa.SelectedIndex = -1;
                    }
                }
                catch (Exception)
                {

                    //
                }


            }
            else
            {
                MessageBox.Show("Ju lutem mbushini Fushat");
            }


        }

        private void ShtoFemijet_Load(object sender, EventArgs e)
        {

        }

        private void txtEmriNena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
