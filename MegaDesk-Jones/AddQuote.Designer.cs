
namespace MegaDesk_Jones
{
    partial class AddQuote
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
            this.txtbxCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewQuote = new System.Windows.Forms.Label();
            this.grpbxSize = new System.Windows.Forms.GroupBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.nudNumDrawers = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblNumDrawers = new System.Windows.Forms.Label();
            this.cmbxSurfMaterial = new System.Windows.Forms.ComboBox();
            this.cmbxDelivery = new System.Windows.Forms.ComboBox();
            this.lblSurfMaterial = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxCustomerName
            // 
            this.txtbxCustomerName.Location = new System.Drawing.Point(290, 74);
            this.txtbxCustomerName.Name = "txtbxCustomerName";
            this.txtbxCustomerName.Size = new System.Drawing.Size(319, 29);
            this.txtbxCustomerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // lblNewQuote
            // 
            this.lblNewQuote.AutoSize = true;
            this.lblNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewQuote.Location = new System.Drawing.Point(319, 9);
            this.lblNewQuote.Name = "lblNewQuote";
            this.lblNewQuote.Size = new System.Drawing.Size(168, 35);
            this.lblNewQuote.TabIndex = 2;
            this.lblNewQuote.Text = "New Quote";
            // 
            // grpbxSize
            // 
            this.grpbxSize.Controls.Add(this.lblDepth);
            this.grpbxSize.Controls.Add(this.lblWidth);
            this.grpbxSize.Controls.Add(this.nudDepth);
            this.grpbxSize.Controls.Add(this.nudWidth);
            this.grpbxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxSize.Location = new System.Drawing.Point(120, 142);
            this.grpbxSize.Name = "grpbxSize";
            this.grpbxSize.Size = new System.Drawing.Size(224, 157);
            this.grpbxSize.TabIndex = 3;
            this.grpbxSize.TabStop = false;
            this.grpbxSize.Text = "Desk Size";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(85, 34);
            this.nudWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 26);
            this.nudWidth.TabIndex = 0;
            this.nudWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(85, 91);
            this.nudDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nudDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(120, 26);
            this.nudDepth.TabIndex = 1;
            this.nudDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // nudNumDrawers
            // 
            this.nudNumDrawers.Location = new System.Drawing.Point(551, 142);
            this.nudNumDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudNumDrawers.Name = "nudNumDrawers";
            this.nudNumDrawers.Size = new System.Drawing.Size(68, 29);
            this.nudNumDrawers.TabIndex = 4;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 36);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(57, 20);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(10, 93);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(59, 20);
            this.lblDepth.TabIndex = 3;
            this.lblDepth.Text = "Depth:";
            // 
            // lblNumDrawers
            // 
            this.lblNumDrawers.AutoSize = true;
            this.lblNumDrawers.Location = new System.Drawing.Point(361, 144);
            this.lblNumDrawers.Name = "lblNumDrawers";
            this.lblNumDrawers.Size = new System.Drawing.Size(190, 25);
            this.lblNumDrawers.TabIndex = 5;
            this.lblNumDrawers.Text = "Number Of Drawers:";
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
            this.cmbxSurfMaterial.Location = new System.Drawing.Point(551, 210);
            this.cmbxSurfMaterial.Name = "cmbxSurfMaterial";
            this.cmbxSurfMaterial.Size = new System.Drawing.Size(121, 32);
            this.cmbxSurfMaterial.TabIndex = 6;
            // 
            // cmbxDelivery
            // 
            this.cmbxDelivery.FormattingEnabled = true;
            this.cmbxDelivery.Items.AddRange(new object[] {
            "None",
            "3 Day",
            "5 Day",
            "7 Day"});
            this.cmbxDelivery.Location = new System.Drawing.Point(551, 265);
            this.cmbxDelivery.Name = "cmbxDelivery";
            this.cmbxDelivery.Size = new System.Drawing.Size(121, 32);
            this.cmbxDelivery.TabIndex = 7;
            // 
            // lblSurfMaterial
            // 
            this.lblSurfMaterial.AutoSize = true;
            this.lblSurfMaterial.Location = new System.Drawing.Point(391, 213);
            this.lblSurfMaterial.Name = "lblSurfMaterial";
            this.lblSurfMaterial.Size = new System.Drawing.Size(160, 25);
            this.lblSurfMaterial.TabIndex = 8;
            this.lblSurfMaterial.Text = "Surface Material:";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(463, 268);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(88, 25);
            this.lblDelivery.TabIndex = 9;
            this.lblDelivery.Text = "Delivery:";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(186, 322);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(158, 46);
            this.btnGetQuote.TabIndex = 10;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(459, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 448);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblSurfMaterial);
            this.Controls.Add(this.cmbxDelivery);
            this.Controls.Add(this.cmbxSurfMaterial);
            this.Controls.Add(this.lblNumDrawers);
            this.Controls.Add(this.nudNumDrawers);
            this.Controls.Add(this.grpbxSize);
            this.Controls.Add(this.lblNewQuote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxCustomerName);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.grpbxSize.ResumeLayout(false);
            this.grpbxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewQuote;
        private System.Windows.Forms.GroupBox grpbxSize;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudNumDrawers;
        private System.Windows.Forms.Label lblNumDrawers;
        private System.Windows.Forms.ComboBox cmbxSurfMaterial;
        private System.Windows.Forms.ComboBox cmbxDelivery;
        private System.Windows.Forms.Label lblSurfMaterial;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Button btnCancel;
    }
}