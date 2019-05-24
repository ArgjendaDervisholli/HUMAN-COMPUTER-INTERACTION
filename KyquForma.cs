using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;


namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve
{
    public partial class Kyqu : Telerik.WinControls.UI.RadForm
    {
        public Kyqu()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
        }
        LidhjaDB ldb = new LidhjaDB();
        private void Kyqu_Load(object sender, EventArgs e)
        {

        }
        string emriMbiemri="";
        string Tipi = "";
        private void btnKyqu_Click(object sender, EventArgs e)
        {
            if (ldb.Kerko_Statusin(txtLlogaria.Text) == true)
            {
                if (ldb.Kyqu(txtLlogaria.Text, txtFjalekalimi.Text) == true)
                {
                    emriMbiemri = ldb.Merr_Emrin(txtLlogaria.Text, txtFjalekalimi.Text);
                    Tipi=ldb.Merr_Tipin(txtLlogaria.Text, txtFjalekalimi.Text);
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Llogaria ose fjalkalimi eshte gabim", "GABIM");
                }
            }
            else
            {
                MessageBox.Show("Llogaria nuk eshte Aktive", "GABIM");
            }

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 100)
            {
                timer1.Stop();
                Form1 f = new Form1(emriMbiemri,Tipi);
                f.Show();
                this.Hide();
                i = 0;
            }
            else
            {
                prbPrit.Value1 = i;
                i = i + 10;
            }

        }

        private void txtFjalekalimi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKyqu_Click(null, null);
            }
        }
    }
}
