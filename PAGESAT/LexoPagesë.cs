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
    public partial class LexoPagesë : Telerik.WinControls.UI.RadForm
    {
        public LexoPagesë()
        {
            InitializeComponent();
            ldb.HAPE_LIDHJEN();
        }

        LidhjaDB ldb = new LidhjaDB();
        private void LexoPagesë_Load(object sender, EventArgs e)
        {
            gridTabela.DataSource = ldb.Lexo_Pagesa_Me_DataSet().Tables[0].DefaultView;
            
        }
    }
}
