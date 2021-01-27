
namespace MegaDesk_Jones
{
    partial class SearchQuotes
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
            this.cmbxSurfMaterial = new System.Windows.Forms.ComboBox();
            this.lblSurfMaterial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbxSurfMaterial
            // 
            this.cmbxSurfMaterial.FormattingEnabled = true;
            this.cmbxSurfMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.cmbxSurfMaterial.Location = new System.Drawing.Point(331, 51);
            this.cmbxSurfMaterial.Name = "cmbxSurfMaterial";
            this.cmbxSurfMaterial.Size = new System.Drawing.Size(332, 32);
            this.cmbxSurfMaterial.TabIndex = 0;
            // 
            // lblSurfMaterial
            // 
            this.lblSurfMaterial.AutoSize = true;
            this.lblSurfMaterial.Location = new System.Drawing.Point(146, 57);
            this.lblSurfMaterial.Name = "lblSurfMaterial";
            this.lblSurfMaterial.Size = new System.Drawing.Size(154, 25);
            this.lblSurfMaterial.TabIndex = 1;
            this.lblSurfMaterial.Text = "Surface Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 724);
            this.Controls.Add(this.lblSurfMaterial);
            this.Controls.Add(this.cmbxSurfMaterial);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxSurfMaterial;
        private System.Windows.Forms.Label lblSurfMaterial;
    }
}