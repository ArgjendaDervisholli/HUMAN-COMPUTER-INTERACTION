using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.FEMIJET
{
    public partial class LexoFemijet : Telerik.WinControls.UI.RadForm
    {
        public LexoFemijet()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
        }

        LidhjaDB ldb = new LidhjaDB();
        private void LexoFemijet_Load(object sender, EventArgs e)
        {
            cmbKlasa.DataSource = ldb.LexoKlase();
            gridFemije.DataSource = ldb.Lexo_Femijet_Me_DataSet().Tables[0].DefaultView;
        }

        private void btnParaqit_Click(object sender, EventArgs e)
        {
            if (cmbKlasa.Text != "")
            {
                gridFemije.DataSource = ldb.Lexo_Femijet_Me_DataSet(cmbKlasa.Text).Tables[0].DefaultView;
            }

        }
    }
}
