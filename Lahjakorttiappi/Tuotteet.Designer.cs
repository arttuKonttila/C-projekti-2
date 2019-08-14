namespace Lahjakorttiappi
{
    partial class Tuotteet
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
            this.pnAddProduct = new System.Windows.Forms.Panel();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.txtBoxLisaaTuote = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGWProducts = new System.Windows.Forms.DataGridView();
            this.pnAddProduct.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAddProduct
            // 
            this.pnAddProduct.AccessibleName = "Lisää tuote  paneeli";
            this.pnAddProduct.Controls.Add(this.btnDelProduct);
            this.pnAddProduct.Controls.Add(this.txtBoxLisaaTuote);
            this.pnAddProduct.Controls.Add(this.btnAddProduct);
            this.pnAddProduct.Location = new System.Drawing.Point(13, 24);
            this.pnAddProduct.Name = "pnAddProduct";
            this.pnAddProduct.Size = new System.Drawing.Size(723, 100);
            this.pnAddProduct.TabIndex = 0;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.AccessibleName = "Poista tuote";
            this.btnDelProduct.Location = new System.Drawing.Point(562, 12);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(148, 73);
            this.btnDelProduct.TabIndex = 1;
            this.btnDelProduct.Text = "Poista tuote";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // txtBoxLisaaTuote
            // 
            this.txtBoxLisaaTuote.AccessibleName = "Lisää tuote";
            this.txtBoxLisaaTuote.Location = new System.Drawing.Point(23, 33);
            this.txtBoxLisaaTuote.Name = "txtBoxLisaaTuote";
            this.txtBoxLisaaTuote.Size = new System.Drawing.Size(345, 38);
            this.txtBoxLisaaTuote.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AccessibleName = "Lisää tuote";
            this.btnAddProduct.Location = new System.Drawing.Point(391, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(148, 73);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Lisää tuote";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnLisaaTuoet_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dGWProducts);
            this.panel3.Location = new System.Drawing.Point(13, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 483);
            this.panel3.TabIndex = 1;
            // 
            // dGWProducts
            // 
            this.dGWProducts.AccessibleName = "Tuotteet";
            this.dGWProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWProducts.Location = new System.Drawing.Point(3, 3);
            this.dGWProducts.Name = "dGWProducts";
            this.dGWProducts.Size = new System.Drawing.Size(713, 580);
            this.dGWProducts.TabIndex = 0;
            // 
            // Tuotteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnAddProduct);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tuotteet";
            this.Text = "Tuotteet";
            this.pnAddProduct.ResumeLayout(false);
            this.pnAddProduct.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGWProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAddProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dGWProducts;
        private System.Windows.Forms.TextBox txtBoxLisaaTuote;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnAddProduct;
    }
}