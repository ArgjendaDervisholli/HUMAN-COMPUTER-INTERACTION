namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.KLASAT
{
    partial class ShtoKlase
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtEmriKlasa = new Telerik.WinControls.UI.RadTextBox();
            this.btnShtoKlase = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmriKlasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShtoKlase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 59);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(73, 18);
            this.radLabel1.TabIndex = 20;
            this.radLabel1.Text = "Emri i Klases :";
            // 
            // txtEmriKlasa
            // 
            this.txtEmriKlasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmriKlasa.Location = new System.Drawing.Point(119, 53);
            this.txtEmriKlasa.Name = "txtEmriKlasa";
            this.txtEmriKlasa.NullText = "Emri i Klases";
            this.txtEmriKlasa.Size = new System.Drawing.Size(473, 20);
            this.txtEmriKlasa.TabIndex = 19;
            this.txtEmriKlasa.ThemeName = "TelerikMetroTouch";
            this.txtEmriKlasa.TextChanged += new System.EventHandler(this.txtEmriKlasa_TextChanged);
            // 
            // btnShtoKlase
            // 
            this.btnShtoKlase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShtoKlase.Location = new System.Drawing.Point(432, 119);
            this.btnShtoKlase.Name = "btnShtoKlase";
            this.btnShtoKlase.Size = new System.Drawing.Size(160, 41);
            this.btnShtoKlase.TabIndex = 21;
            this.btnShtoKlase.Text = "Shto";
            this.btnShtoKlase.ThemeName = "TelerikMetroTouch";
            this.btnShtoKlase.Click += new System.EventHandler(this.btnShtoKlase_Click);
            // 
            // ShtoKlase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 172);
            this.Controls.Add(this.btnShtoKlase);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtEmriKlasa);
            this.Name = "ShtoKlase";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ShtoKlase";
            this.ThemeName = "TelerikMetroTouch";
            this.Load += new System.EventHandler(this.ShtoKlase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmriKlasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShtoKlase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtEmriKlasa;
        private Telerik.WinControls.UI.RadButton btnShtoKlase;
    }
}
