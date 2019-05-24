using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.FEMIJET;
using System.Resources;
using System.Reflection;
using System.Globalization;


namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        public Form1()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
        }
        string Tipi;
        string EmriMbiemri;
        public Form1(string emriMbiemri,string tipi)
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
            EmriMbiemri = emriMbiemri;
            Tipi = tipi;
        }

        LidhjaDB ldb = new LidhjaDB();

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            
            Kyqu n = new Kyqu();
            n.Show();
            Visible = false;
            //Application.Exit();
           
        }

        private void btnShtoFemije_Click(object sender, EventArgs e)
        {
            ShtoFemijet n = new ShtoFemijet();
            n.ShowDialog();
        }

        private void btnEditoFemije_Click(object sender, EventArgs e)
        {
            EditoFemijet n = new EditoFemijet();
            n.ShowDialog();
            
        }

        private void btnShtoKlase_Click(object sender, EventArgs e)
        {
            KLASAT.ShtoKlase n = new KLASAT.ShtoKlase();
            n.ShowDialog();
        }

        private void btnEditoKlase_Click(object sender, EventArgs e)
        {
            KLASAT.EditoKlase n = new KLASAT.EditoKlase();
            n.ShowDialog();
        }

        private void btnShtoPagesë_Click(object sender, EventArgs e)
        {
            PAGESAT.ShtoPagesë n = new PAGESAT.ShtoPagesë();
            n.ShowDialog();
        }

        private void btnLexoPagesë_Click(object sender, EventArgs e)
        {
            PAGESAT.LexoPagesë n = new PAGESAT.LexoPagesë();
            n.ShowDialog();
        }

        private void btnShtoMesues_Click(object sender, EventArgs e)
        {
            MESUESIT.ShtoMësues n = new MESUESIT.ShtoMësues();
            n.ShowDialog();
        }

        private void btnEditoMesues_Click(object sender, EventArgs e)
        {
            MESUESIT.EditoMesues n = new MESUESIT.EditoMesues();
            n.ShowDialog();
        }

        private void btnLexoFemije_Click(object sender, EventArgs e)
        {
            LexoFemijet LF = new LexoFemijet();
            LF.ShowDialog();
        }

        private void btnShtoLlogari_Click(object sender, EventArgs e)
        {
            PARAMETRAT.ShtoLlogari n = new PARAMETRAT.ShtoLlogari();
            n.ShowDialog();
        }

        private void btnEditoLlogari_Click(object sender, EventArgs e)
        {
            PARAMETRAT.EditoLlogari n = new PARAMETRAT.EditoLlogari();
            n.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (Tipi=="Mesues")
            {
                //btnParametrat.Enabled = false;
                btnParametrat.Visibility = ElementVisibility.Hidden;
             
                
            }


            lblEmriMbiemri.Text = "Miresevini : " + EmriMbiemri;
            //listKlasat.DataSource = ldb.LexoKlase();
            //tabelNxansat.DataSource = ldb.Lexo_Femijet_Me_DataSet().Tables[0].DefaultView;
            //tabelNxansat.BestFitColumns();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics objGrafika = e.Graphics;
            SolidBrush brushaB =
                new SolidBrush(Color.Blue);
            SolidBrush brushaR = new SolidBrush(Color.Red);
            SolidBrush brushaG =
                new SolidBrush(Color.Green);
            SolidBrush brushaP = new SolidBrush(Color.Purple);
            Pen lapsiR = new Pen(Color.Red);
            Pen lapsiB = new Pen(Color.Blue);
            Rectangle katrori =
                new Rectangle(10, 10, 350, 350);
            Font font = new Font("Times New Roman", 12.0f);

          //  objGrafika.DrawString("Suksesi i përgjithshëm i Klasëve Janar-Mars", font, Brushes.Black, 70, 14);

            katrori.Location = new Point(40, 40);
            objGrafika.DrawRectangle(lapsiR, katrori);
            objGrafika.FillPie(brushaB, katrori, 0, 50);
            objGrafika.FillPie(brushaR, katrori, 50, 80);
            objGrafika.FillPie(brushaG, katrori, 130, 100);
            objGrafika.FillPie(brushaP, katrori, 230, 130);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Graphics objGrafika = e.Graphics;
            SolidBrush brushaB =
                new SolidBrush(Color.Blue);
            SolidBrush brushaR = new SolidBrush(Color.Red);
            SolidBrush brushaG =
                new SolidBrush(Color.Green);
            SolidBrush brushaP = new SolidBrush(Color.Purple);
            Pen lapsiR = new Pen(Color.Red);
            Pen lapsiB = new Pen(Color.Blue);
            Rectangle katrori =
                new Rectangle(10, 10, 350, 350);
            Font font = new Font("Times New Roman", 12.0f);

           // objGrafika.DrawString("Raporti i mungesave javore", font, Brushes.Black, 150, 14);

            katrori.Location = new Point(40, 40);
            objGrafika.DrawRectangle(lapsiR, katrori);
            objGrafika.FillPie(brushaB, katrori, 0, 20);
            objGrafika.FillPie(brushaR, katrori, 20, 70);
            objGrafika.FillPie(brushaG, katrori, 90, 110);
            objGrafika.FillPie(brushaP, katrori, 180, 190);
        }



        private void MerrGjuhenEng(CultureInfo ci)
        {
            Assembly a = Assembly.Load("Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve");
            ResourceManager rm = new ResourceManager("Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.gjuhaEng", a);
            btnFemijet.Text = rm.GetString("bFemijet", ci);
            btnKlasa.Text = rm.GetString("bKlase", ci);
            btnPagesat.Text = rm.GetString("bPagesat", ci);
            btnMesuesit.Text = rm.GetString("bMesuesit", ci);
            btnParametrat.Text = rm.GetString("bParametrat", ci);
            lblEmriMbiemri.Text = rm.GetString("lEmriMbiemri", ci);

            btnShtoFemije.Text = rm.GetString("bShto", ci);
            btnLexoFemije.Text = rm.GetString("bLexo", ci);
            btnEditoFemije.Text = rm.GetString("bEdito", ci);

            btnShtoKlase.Text = rm.GetString("bShto", ci);
            btnEditoKlase.Text = rm.GetString("bEdito", ci);

            btnShtoKlase.Text = rm.GetString("bShto", ci);
            btnEditoKlase.Text = rm.GetString("bEdito", ci);

            btnShtoPagesë.Text = rm.GetString("bShto", ci);
            btnLexoPagesë.Text = rm.GetString("bEdito", ci);

            btnShtoMesues.Text = rm.GetString("bShto", ci);
            btnEditoMesues.Text = rm.GetString("bEdito", ci);

            btnShtoLlogari.Text = rm.GetString("bShto", ci);
            btnEditoLlogari.Text = rm.GetString("bEdito", ci);

            lblGjuha.Text = rm.GetString("lZgjedhGjuhen", ci);

            lblPaneli1.Text = rm.GetString("lPaneli1", ci);
            lblPaneli2.Text = rm.GetString("lPaneli2", ci);

            label1.Text = rm.GetString("blabeli1", ci);
            label2.Text = rm.GetString("blabeli2", ci);
            label3.Text = rm.GetString("blabeli3", ci);
            label4.Text = rm.GetString("blabeli4", ci);
            label5.Text = rm.GetString("blabeli5", ci);
            label6.Text = rm.GetString("blabeli6", ci);
            label7.Text = rm.GetString("blabeli7", ci);
            label8.Text = rm.GetString("blabeli8", ci);

            btnFile.Text = rm.GetString("brregullimi",ci);
            btnEXIT.Text = rm.GetString("bexit", ci);


        }

        private void MerrGjuhenAl(CultureInfo ci)
        {
            Assembly a = Assembly.Load("Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve");
            ResourceManager rm = new ResourceManager("Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.gjuhaAl", a);
            btnFemijet.Text = rm.GetString("bFemijet", ci);
            btnKlasa.Text = rm.GetString("bKlase", ci);
            btnPagesat.Text = rm.GetString("bPagesat", ci);
            btnMesuesit.Text = rm.GetString("bMesuesit", ci);
            btnParametrat.Text = rm.GetString("bParametrat", ci);
            lblEmriMbiemri.Text = rm.GetString("lEmriMbiemri", ci);

            btnShtoFemije.Text = rm.GetString("bShto", ci);
            btnLexoFemije.Text = rm.GetString("bLexo", ci);
            btnEditoFemije.Text = rm.GetString("bEdito", ci);

            btnShtoKlase.Text = rm.GetString("bShto", ci);
            btnEditoKlase.Text = rm.GetString("bEdito", ci);

            btnShtoKlase.Text = rm.GetString("bShto", ci);
            btnEditoKlase.Text = rm.GetString("bEdito", ci);

            btnShtoPagesë.Text = rm.GetString("bShto", ci);
            btnLexoPagesë.Text = rm.GetString("bEdito", ci);

            btnShtoMesues.Text = rm.GetString("bShto", ci);
            btnEditoMesues.Text = rm.GetString("bEdito", ci);

            btnShtoLlogari.Text = rm.GetString("bShto", ci);
            btnEditoLlogari.Text = rm.GetString("bEdito", ci);

            lblGjuha.Text = rm.GetString("lZgjedhGjuhen", ci);

            lblPaneli1.Text = rm.GetString("lPaneli1", ci);
            lblPaneli2.Text = rm.GetString("lPaneli2", ci);

            label1.Text = rm.GetString("blabeli1",ci);
            label2.Text = rm.GetString("blabeli2", ci);
            label3.Text = rm.GetString("blabeli3", ci);
            label4.Text = rm.GetString("blabeli4", ci);
            label5.Text = rm.GetString("blabeli5", ci);
            label6.Text = rm.GetString("blabeli6", ci);
            label7.Text = rm.GetString("blabeli7", ci);
            label8.Text = rm.GetString("blabeli8", ci);

            btnFile.Text = rm.GetString("brregullimi", ci);
            btnEXIT.Text = rm.GetString("bexit", ci);


        }

        private void pnlGjuhaEng_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            MerrGjuhenEng(ci);
        }


        private void pnlGjuhaAlb_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("shq-AL");
            MerrGjuhenAl(ci);
        }

        private void radMenu1_Click(object sender, EventArgs e)
        {

        }
    }
}
