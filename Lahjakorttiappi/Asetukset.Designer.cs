namespace Lahjakorttiappi
{
    partial class Asetukset
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
            this.PnSettings = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFirm = new System.Windows.Forms.Label();
            this.txtBoxFirmName = new System.Windows.Forms.TextBox();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.txtBoxIdentifier = new System.Windows.Forms.TextBox();
            this.lblFirmAdress = new System.Windows.Forms.Label();
            this.txtBoxAdress = new System.Windows.Forms.TextBox();
            this.lblPostNumber = new System.Windows.Forms.Label();
            this.txtBoxPostNumber = new System.Windows.Forms.TextBox();
            this.lblPostState = new System.Windows.Forms.Label();
            this.textBoxPostState = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblWeb = new System.Windows.Forms.Label();
            this.txtBoxWeb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddLogo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemoveLogo = new System.Windows.Forms.Button();
            this.lblOpenTiime = new System.Windows.Forms.Label();
            this.txtBoxOpenTimes = new System.Windows.Forms.TextBox();
            this.PnSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnSettings
            // 
            this.PnSettings.Controls.Add(this.txtBoxWeb);
            this.PnSettings.Controls.Add(this.lblWeb);
            this.PnSettings.Controls.Add(this.txtBoxEmail);
            this.PnSettings.Controls.Add(this.lblEmail);
            this.PnSettings.Controls.Add(this.txtBoxPhone);
            this.PnSettings.Controls.Add(this.lblPhone);
            this.PnSettings.Controls.Add(this.textBoxPostState);
            this.PnSettings.Controls.Add(this.lblPostState);
            this.PnSettings.Controls.Add(this.txtBoxPostNumber);
            this.PnSettings.Controls.Add(this.lblPostNumber);
            this.PnSettings.Controls.Add(this.txtBoxAdress);
            this.PnSettings.Controls.Add(this.lblFirmAdress);
            this.PnSettings.Controls.Add(this.txtBoxIdentifier);
            this.PnSettings.Controls.Add(this.lblIdentifier);
            this.PnSettings.Controls.Add(this.txtBoxFirmName);
            this.PnSettings.Controls.Add(this.lblFirm);
            this.PnSettings.Location = new System.Drawing.Point(13, 13);
            this.PnSettings.Name = "PnSettings";
            this.PnSettings.Size = new System.Drawing.Size(502, 560);
            this.PnSettings.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(521, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 560);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "Tallenna";
            this.btnSave.Location = new System.Drawing.Point(14, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 73);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.AccessibleName = "Tyhjennä";
            this.btnClear.Location = new System.Drawing.Point(14, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 73);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Tyhjennä";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Location = new System.Drawing.Point(16, 16);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(140, 24);
            this.lblFirm.TabIndex = 0;
            this.lblFirm.Text = "Yrityksen nimi";
            // 
            // txtBoxFirmName
            // 
            this.txtBoxFirmName.AccessibleName = "Yrityksen nimi";
            this.txtBoxFirmName.Location = new System.Drawing.Point(20, 44);
            this.txtBoxFirmName.Name = "txtBoxFirmName";
            this.txtBoxFirmName.Size = new System.Drawing.Size(459, 32);
            this.txtBoxFirmName.TabIndex = 1;
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Location = new System.Drawing.Point(16, 95);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(95, 24);
            this.lblIdentifier.TabIndex = 2;
            this.lblIdentifier.Text = "Y-Tunnus";
            // 
            // txtBoxIdentifier
            // 
            this.txtBoxIdentifier.AccessibleName = "Y-tunnus";
            this.txtBoxIdentifier.Location = new System.Drawing.Point(20, 122);
            this.txtBoxIdentifier.Name = "txtBoxIdentifier";
            this.txtBoxIdentifier.Size = new System.Drawing.Size(459, 32);
            this.txtBoxIdentifier.TabIndex = 3;
            this.txtBoxIdentifier.TextChanged += new System.EventHandler(this.txtBoxIdentifier_TextChanged);
            // 
            // lblFirmAdress
            // 
            this.lblFirmAdress.AutoSize = true;
            this.lblFirmAdress.Location = new System.Drawing.Point(16, 172);
            this.lblFirmAdress.Name = "lblFirmAdress";
            this.lblFirmAdress.Size = new System.Drawing.Size(72, 24);
            this.lblFirmAdress.TabIndex = 4;
            this.lblFirmAdress.Text = "Osoite";
            // 
            // txtBoxAdress
            // 
            this.txtBoxAdress.AccessibleName = "Osoite";
            this.txtBoxAdress.Location = new System.Drawing.Point(20, 199);
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.Size = new System.Drawing.Size(459, 32);
            this.txtBoxAdress.TabIndex = 5;
            // 
            // lblPostNumber
            // 
            this.lblPostNumber.AutoSize = true;
            this.lblPostNumber.Location = new System.Drawing.Point(16, 247);
            this.lblPostNumber.Name = "lblPostNumber";
            this.lblPostNumber.Size = new System.Drawing.Size(127, 24);
            this.lblPostNumber.TabIndex = 6;
            this.lblPostNumber.Text = "Postinumero";
            // 
            // txtBoxPostNumber
            // 
            this.txtBoxPostNumber.AccessibleName = "Postinumero";
            this.txtBoxPostNumber.Location = new System.Drawing.Point(20, 274);
            this.txtBoxPostNumber.Name = "txtBoxPostNumber";
            this.txtBoxPostNumber.Size = new System.Drawing.Size(194, 32);
            this.txtBoxPostNumber.TabIndex = 7;
            // 
            // lblPostState
            // 
            this.lblPostState.AutoSize = true;
            this.lblPostState.Location = new System.Drawing.Point(237, 247);
            this.lblPostState.Name = "lblPostState";
            this.lblPostState.Size = new System.Drawing.Size(162, 24);
            this.lblPostState.TabIndex = 8;
            this.lblPostState.Text = "Postitoimipaikka";
            this.lblPostState.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxPostState
            // 
            this.textBoxPostState.AccessibleName = "Postitoimipaikka";
            this.textBoxPostState.Location = new System.Drawing.Point(241, 274);
            this.textBoxPostState.Name = "textBoxPostState";
            this.textBoxPostState.Size = new System.Drawing.Size(194, 32);
            this.textBoxPostState.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 323);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(147, 24);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Puhelinnumero";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.AccessibleName = "Puhelinnumero";
            this.txtBoxPhone.Location = new System.Drawing.Point(20, 350);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(459, 32);
            this.txtBoxPhone.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 400);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(114, 24);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Sähköposti";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.AccessibleName = "Sähköposti";
            this.txtBoxEmail.Location = new System.Drawing.Point(20, 427);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(459, 32);
            this.txtBoxEmail.TabIndex = 13;
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(16, 478);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(117, 24);
            this.lblWeb.TabIndex = 14;
            this.lblWeb.Text = "Verkkosivut";
            // 
            // txtBoxWeb
            // 
            this.txtBoxWeb.AccessibleName = "Verkkosivut";
            this.txtBoxWeb.Location = new System.Drawing.Point(20, 505);
            this.txtBoxWeb.Name = "txtBoxWeb";
            this.txtBoxWeb.Size = new System.Drawing.Size(459, 32);
            this.txtBoxWeb.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBoxOpenTimes);
            this.panel2.Controls.Add(this.lblOpenTiime);
            this.panel2.Controls.Add(this.btnRemoveLogo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnAddLogo);
            this.panel2.Location = new System.Drawing.Point(12, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 196);
            this.panel2.TabIndex = 2;
            // 
            // btnAddLogo
            // 
            this.btnAddLogo.AccessibleName = "Lisää logo";
            this.btnAddLogo.Location = new System.Drawing.Point(21, 17);
            this.btnAddLogo.Name = "btnAddLogo";
            this.btnAddLogo.Size = new System.Drawing.Size(136, 45);
            this.btnAddLogo.TabIndex = 1;
            this.btnAddLogo.Text = "Lisää logo";
            this.btnAddLogo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(163, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 159);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemoveLogo
            // 
            this.btnRemoveLogo.AccessibleName = "Lisää logo";
            this.btnRemoveLogo.Location = new System.Drawing.Point(21, 68);
            this.btnRemoveLogo.Name = "btnRemoveLogo";
            this.btnRemoveLogo.Size = new System.Drawing.Size(136, 45);
            this.btnRemoveLogo.TabIndex = 3;
            this.btnRemoveLogo.Text = "Poista logo";
            this.btnRemoveLogo.UseVisualStyleBackColor = true;
            // 
            // lblOpenTiime
            // 
            this.lblOpenTiime.AutoSize = true;
            this.lblOpenTiime.Location = new System.Drawing.Point(370, 17);
            this.lblOpenTiime.Name = "lblOpenTiime";
            this.lblOpenTiime.Size = new System.Drawing.Size(123, 24);
            this.lblOpenTiime.TabIndex = 4;
            this.lblOpenTiime.Text = "Auki olo ajat";
            // 
            // txtBoxOpenTimes
            // 
            this.txtBoxOpenTimes.AccessibleName = "Auki oloajat";
            this.txtBoxOpenTimes.Location = new System.Drawing.Point(374, 41);
            this.txtBoxOpenTimes.Multiline = true;
            this.txtBoxOpenTimes.Name = "txtBoxOpenTimes";
            this.txtBoxOpenTimes.Size = new System.Drawing.Size(283, 135);
            this.txtBoxOpenTimes.TabIndex = 5;
            // 
            // Asetukset
            // 
            this.AccessibleName = "Asetukset";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(698, 807);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnSettings);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Asetukset";
            this.ShowInTaskbar = false;
            this.Text = "Asetukset";
            this.PnSettings.ResumeLayout(false);
            this.PnSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnSettings;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFirmAdress;
        private System.Windows.Forms.TextBox txtBoxIdentifier;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.TextBox txtBoxFirmName;
        private System.Windows.Forms.Label lblFirm;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPostState;
        private System.Windows.Forms.TextBox txtBoxPostNumber;
        private System.Windows.Forms.Label lblPostNumber;
        private System.Windows.Forms.TextBox txtBoxAdress;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBoxPostState;
        private System.Windows.Forms.TextBox txtBoxWeb;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxOpenTimes;
        private System.Windows.Forms.Label lblOpenTiime;
        private System.Windows.Forms.Button btnRemoveLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddLogo;
    }
}