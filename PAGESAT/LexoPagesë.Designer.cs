namespace Aplikacioni_per_menaxhimin_e_çerdhes_se_femijeve.PAGESAT
{
    partial class LexoPagesë
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridTabela = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTabela
            // 
            this.gridTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTabela.Location = new System.Drawing.Point(12, 69);
            // 
            // 
            // 
            this.gridTabela.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridTabela.Name = "gridTabela";
            this.gridTabela.ReadOnly = true;
            this.gridTabela.Size = new System.Drawing.Size(851, 441);
            this.gridTabela.TabIndex = 2;
            this.gridTabela.Text = "radGridView1";
            this.gridTabela.ThemeName = "TelerikMetroTouch";
            // 
            // LexoPagesë
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.gridTabela);
            this.Name = "LexoPagesë";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "LexoPagesë";
            this.ThemeName = "TelerikMetroTouch";
            this.Load += new System.EventHandler(this.LexoPagesë_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView gridTabela;
    }
}
