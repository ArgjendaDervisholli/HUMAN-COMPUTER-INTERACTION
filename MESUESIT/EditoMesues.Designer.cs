namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.MESUESIT
{
    partial class EditoMesues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radTextBox7 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.listMesues = new Telerik.WinControls.UI.RadListView();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtEmriMbiemri = new Telerik.WinControls.UI.RadTextBox();
            this.btnFshi = new Telerik.WinControls.UI.RadButton();
            this.btnEdito = new Telerik.WinControls.UI.RadButton();
            this.txtKlasa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMesues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmriMbiemri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFshi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox7
            // 
            this.radTextBox7.Location = new System.Drawing.Point(2, 53);
            this.radTextBox7.Name = "radTextBox7";
            this.radTextBox7.NullText = "Kërko";
            this.radTextBox7.Size = new System.Drawing.Size(139, 32);
            this.radTextBox7.TabIndex = 38;
            this.radTextBox7.ThemeName = "TelerikMetroTouch";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(147, 53);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(71, 32);
            this.radButton1.TabIndex = 37;
            this.radButton1.Text = "Kërko";
            this.radButton1.ThemeName = "TelerikMetroTouch";
            // 
            // listMesues
            // 
            this.listMesues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listMesues.GroupItemSize = new System.Drawing.Size(200, 40);
            this.listMesues.ItemSize = new System.Drawing.Size(200, 40);
            this.listMesues.Location = new System.Drawing.Point(2, 91);
            this.listMesues.Name = "listMesues";
            this.listMesues.Size = new System.Drawing.Size(216, 292);
            this.listMesues.TabIndex = 36;
            this.listMesues.Text = "radListView1";
            this.listMesues.ThemeName = "TelerikMetroTouch";
            this.listMesues.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.listMesues_ItemMouseClick);
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(224, 129);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(37, 18);
            this.radLabel6.TabIndex = 30;
            this.radLabel6.Text = "Klasa :";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(224, 91);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(101, 18);
            this.radLabel1.TabIndex = 35;
            this.radLabel1.Text = "Emri dhe Mbiemri :";
            // 
            // txtEmriMbiemri
            // 
            this.txtEmriMbiemri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmriMbiemri.Location = new System.Drawing.Point(331, 85);
            this.txtEmriMbiemri.Name = "txtEmriMbiemri";
            this.txtEmriMbiemri.NullText = "Emri dhe Mbiemri";
            this.txtEmriMbiemri.Size = new System.Drawing.Size(427, 32);
            this.txtEmriMbiemri.TabIndex = 0;
            this.txtEmriMbiemri.ThemeName = "TelerikMetroTouch";
            // 
            // btnFshi
            // 
            this.btnFshi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFshi.Location = new System.Drawing.Point(598, 342);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(160, 41);
            this.btnFshi.TabIndex = 3;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.ThemeName = "TelerikMetroTouch";
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnEdito
            // 
            this.btnEdito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdito.Location = new System.Drawing.Point(432, 342);
            this.btnEdito.Name = "btnEdito";
            this.btnEdito.Size = new System.Drawing.Size(160, 41);
            this.btnEdito.TabIndex = 2;
            this.btnEdito.Text = "Edito";
            this.btnEdito.ThemeName = "TelerikMetroTouch";
            this.btnEdito.Click += new System.EventHandler(this.btnEdito_Click);
            // 
            // txtKlasa
            // 
            this.txtKlasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKlasa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKlasa.FormattingEnabled = true;
            this.txtKlasa.Location = new System.Drawing.Point(331, 120);
            this.txtKlasa.Name = "txtKlasa";
            this.txtKlasa.Size = new System.Drawing.Size(427, 31);
            this.txtKlasa.TabIndex = 1;
            // 
            // EditoMesues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 395);
            this.Controls.Add(this.txtKlasa);
            this.Controls.Add(this.radTextBox7);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.listMesues);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtEmriMbiemri);
            this.Controls.Add(this.btnFshi);
            this.Controls.Add(this.btnEdito);
            this.Name = "EditoMesues";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EditoMesues";
            this.ThemeName = "TelerikMetroTouch";
            this.Load += new System.EventHandler(this.EditoMesues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMesues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmriMbiemri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFshi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox7;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadListView listMesues;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtEmriMbiemri;
        private Telerik.WinControls.UI.RadButton btnFshi;
        private Telerik.WinControls.UI.RadButton btnEdito;
        private System.Windows.Forms.ComboBox txtKlasa;
    }
}
