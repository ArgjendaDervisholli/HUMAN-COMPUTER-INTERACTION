namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.FEMIJET
{
    partial class LexoFemijet
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridFemije = new Telerik.WinControls.UI.RadGridView();
            this.cmbKlasa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParaqit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridFemije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFemije.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParaqit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFemije
            // 
            this.gridFemije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFemije.Location = new System.Drawing.Point(12, 62);
            // 
            // 
            // 
            this.gridFemije.MasterTemplate.AllowAddNewRow = false;
            this.gridFemije.MasterTemplate.AllowColumnReorder = false;
            this.gridFemije.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.gridFemije.Name = "gridFemije";
            this.gridFemije.ReadOnly = true;
            this.gridFemije.Size = new System.Drawing.Size(702, 434);
            this.gridFemije.TabIndex = 0;
            this.gridFemije.Text = "radGridView1";
            this.gridFemije.ThemeName = "TelerikMetroTouch";
            // 
            // cmbKlasa
            // 
            this.cmbKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasa.Font = new System.Drawing.Font("Calibri", 14F);
            this.cmbKlasa.FormattingEnabled = true;
            this.cmbKlasa.Location = new System.Drawing.Point(54, 12);
            this.cmbKlasa.Name = "cmbKlasa";
            this.cmbKlasa.Size = new System.Drawing.Size(202, 31);
            this.cmbKlasa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klasa :";
            // 
            // btnParaqit
            // 
            this.btnParaqit.Location = new System.Drawing.Point(262, 12);
            this.btnParaqit.Name = "btnParaqit";
            this.btnParaqit.Size = new System.Drawing.Size(87, 32);
            this.btnParaqit.TabIndex = 3;
            this.btnParaqit.Text = "Paraqit";
            this.btnParaqit.ThemeName = "TelerikMetroTouch";
            this.btnParaqit.Click += new System.EventHandler(this.btnParaqit_Click);
            // 
            // LexoFemijet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 508);
            this.Controls.Add(this.btnParaqit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKlasa);
            this.Controls.Add(this.gridFemije);
            this.Name = "LexoFemijet";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LexoFemijet";
            this.ThemeName = "TelerikMetroTouch";
            this.Load += new System.EventHandler(this.LexoFemijet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFemije.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFemije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParaqit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridFemije;
        private System.Windows.Forms.ComboBox cmbKlasa;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnParaqit;
    }
}
