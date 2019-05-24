namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.KLASAT
{
    partial class EditoKlase
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
            this.listKlasa = new Telerik.WinControls.UI.RadListView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtEmriKlases = new Telerik.WinControls.UI.RadTextBox();
            this.btnFshi = new Telerik.WinControls.UI.RadButton();
            this.btnEdito = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listKlasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmriKlases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFshi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox7
            // 
            this.radTextBox7.Location = new System.Drawing.Point(12, 63);
            this.radTextBox7.Name = "radTextBox7";
            this.radTextBox7.NullText = "Kërko";
            this.radTextBox7.Size = new System.Drawing.Size(139, 32);
            this.radTextBox7.TabIndex = 38;
            this.radTextBox7.ThemeName = "TelerikMetroTouch";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(157, 63);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(71, 32);
            this.radButton1.TabIndex = 37;
            this.radButton1.Text = "Kërko";
            this.radButton1.ThemeName = "TelerikMetroTouch";
            // 
            // listKlasa
            // 
            this.listKlasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listKlasa.GroupItemSize = new System.Drawing.Size(200, 40);
            this.listKlasa.ItemSize = new System.Drawing.Size(200, 40);
            this.listKlasa.Location = new System.Drawing.Point(12, 101);
            this.listKlasa.Name = "listKlasa";
            this.listKlasa.Size = new System.Drawing.Size(216, 301);
            this.listKlasa.TabIndex = 36;
            this.listKlasa.Text = "radListView1";
            this.listKlasa.ThemeName = "TelerikMetroTouch";
            this.listKlasa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listKlasa_MouseClick);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(252, 107);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(73, 18);
            this.radLabel1.TabIndex = 35;
            this.radLabel1.Text = "Emri i Klases :";
            // 
            // txtEmriKlases
            // 
            this.txtEmriKlases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmriKlases.Location = new System.Drawing.Point(359, 101);
            this.txtEmriKlases.Name = "txtEmriKlases";
            this.txtEmriKlases.NullText = "Emri i Klases";
            this.txtEmriKlases.Size = new System.Drawing.Size(416, 32);
            this.txtEmriKlases.TabIndex = 0;
            this.txtEmriKlases.ThemeName = "TelerikMetroTouch";
            // 
            // btnFshi
            // 
            this.btnFshi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFshi.Location = new System.Drawing.Point(615, 361);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(160, 41);
            this.btnFshi.TabIndex = 2;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.ThemeName = "TelerikMetroTouch";
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnEdito
            // 
            this.btnEdito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdito.Location = new System.Drawing.Point(449, 361);
            this.btnEdito.Name = "btnEdito";
            this.btnEdito.Size = new System.Drawing.Size(160, 41);
            this.btnEdito.TabIndex = 1;
            this.btnEdito.Text = "Edito";
            this.btnEdito.ThemeName = "TelerikMetroTouch";
            this.btnEdito.Click += new System.EventHandler(this.btnEdito_Click);
            // 
            // EditoKlase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 414);
            this.Controls.Add(this.radTextBox7);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.listKlasa);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtEmriKlases);
            this.Controls.Add(this.btnFshi);
            this.Controls.Add(this.btnEdito);
            this.Name = "EditoKlase";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EditoKlase";
            this.ThemeName = "TelerikMetroTouch";
            this.Load += new System.EventHandler(this.EditoKlase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listKlasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmriKlases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFshi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox7;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadListView listKlasa;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtEmriKlases;
        private Telerik.WinControls.UI.RadButton btnFshi;
        private Telerik.WinControls.UI.RadButton btnEdito;
    }
}
