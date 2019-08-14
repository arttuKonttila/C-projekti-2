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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGWTuotteet = new System.Windows.Forms.DataGridView();
            this.btnLisaaTuoet = new System.Windows.Forms.Button();
            this.btnPoistaTuote = new System.Windows.Forms.Button();
            this.txtBoxLisaaTuote = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWTuotteet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPoistaTuote);
            this.panel1.Controls.Add(this.txtBoxLisaaTuote);
            this.panel1.Controls.Add(this.btnLisaaTuoet);
            this.panel1.Location = new System.Drawing.Point(13, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dGWTuotteet);
            this.panel3.Location = new System.Drawing.Point(13, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 483);
            this.panel3.TabIndex = 1;
            // 
            // dGWTuotteet
            // 
            this.dGWTuotteet.AccessibleName = "Tuotteet";
            this.dGWTuotteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWTuotteet.Location = new System.Drawing.Point(3, 3);
            this.dGWTuotteet.Name = "dGWTuotteet";
            this.dGWTuotteet.Size = new System.Drawing.Size(713, 580);
            this.dGWTuotteet.TabIndex = 0;
            // 
            // btnLisaaTuoet
            // 
            this.btnLisaaTuoet.Location = new System.Drawing.Point(391, 12);
            this.btnLisaaTuoet.Name = "btnLisaaTuoet";
            this.btnLisaaTuoet.Size = new System.Drawing.Size(148, 73);
            this.btnLisaaTuoet.TabIndex = 0;
            this.btnLisaaTuoet.Text = "Lisää tuote";
            this.btnLisaaTuoet.UseVisualStyleBackColor = true;
            // 
            // btnPoistaTuote
            // 
            this.btnPoistaTuote.Location = new System.Drawing.Point(562, 12);
            this.btnPoistaTuote.Name = "btnPoistaTuote";
            this.btnPoistaTuote.Size = new System.Drawing.Size(148, 73);
            this.btnPoistaTuote.TabIndex = 1;
            this.btnPoistaTuote.Text = "Poista tuote";
            this.btnPoistaTuote.UseVisualStyleBackColor = true;
            // 
            // txtBoxLisaaTuote
            // 
            this.txtBoxLisaaTuote.AccessibleName = "Lisää tuote";
            this.txtBoxLisaaTuote.Location = new System.Drawing.Point(23, 33);
            this.txtBoxLisaaTuote.Name = "txtBoxLisaaTuote";
            this.txtBoxLisaaTuote.Size = new System.Drawing.Size(345, 32);
            this.txtBoxLisaaTuote.TabIndex = 0;
            this.txtBoxLisaaTuote.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tuotteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tuotteet";
            this.Text = "Tuotteet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGWTuotteet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dGWTuotteet;
        private System.Windows.Forms.TextBox txtBoxLisaaTuote;
        private System.Windows.Forms.Button btnPoistaTuote;
        private System.Windows.Forms.Button btnLisaaTuoet;
    }
}