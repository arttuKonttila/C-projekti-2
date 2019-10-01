namespace Lahjakorttiappi
{
    partial class HallitseHenkilokuntaa
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
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.txtBoxNameStaff = new System.Windows.Forms.TextBox();
            this.dgwStaffMembers = new System.Windows.Forms.DataGridView();
            this.lblAddName = new System.Windows.Forms.Label();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStaffMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.AccessibleName = "Lisää henkilö";
            this.btnAddStaff.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(12, 113);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(131, 60);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Lisää henkilö";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.AccessibleName = "Poista henkilö";
            this.btnRemoveStaff.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStaff.Location = new System.Drawing.Point(12, 179);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(131, 60);
            this.btnRemoveStaff.TabIndex = 2;
            this.btnRemoveStaff.Text = "Poista henkilö";
            this.btnRemoveStaff.UseVisualStyleBackColor = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.BtnRemoveStaff_Click);
            // 
            // txtBoxNameStaff
            // 
            this.txtBoxNameStaff.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameStaff.Location = new System.Drawing.Point(12, 60);
            this.txtBoxNameStaff.Name = "txtBoxNameStaff";
            this.txtBoxNameStaff.Size = new System.Drawing.Size(221, 32);
            this.txtBoxNameStaff.TabIndex = 0;
            // 
            // dgwStaffMembers
            // 
            this.dgwStaffMembers.AccessibleName = "Henkilökunta";
            this.dgwStaffMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStaffMembers.Location = new System.Drawing.Point(239, 27);
            this.dgwStaffMembers.Name = "dgwStaffMembers";
            this.dgwStaffMembers.Size = new System.Drawing.Size(212, 329);
            this.dgwStaffMembers.TabIndex = 3;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(13, 27);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(105, 24);
            this.lblAddName.TabIndex = 0;
            this.lblAddName.Text = "Lisää nimi";
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.AccessibleName = "Sulje ikkuna";
            this.btnCloseWindow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWindow.Location = new System.Drawing.Point(12, 296);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(131, 60);
            this.btnCloseWindow.TabIndex = 4;
            this.btnCloseWindow.Text = "Sulje ikkuna";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindow_Click);
            // 
            // HallitseHenkilokuntaa
            // 
            this.AccessibleName = "Hallitse henkilökuntaa ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 376);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.dgwStaffMembers);
            this.Controls.Add(this.txtBoxNameStaff);
            this.Controls.Add(this.btnRemoveStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Name = "HallitseHenkilokuntaa";
            this.Text = "Hallitse Henkilokuntaa";
            ((System.ComponentModel.ISupportInitialize)(this.dgwStaffMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.TextBox txtBoxNameStaff;
        private System.Windows.Forms.DataGridView dgwStaffMembers;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Button btnCloseWindow;
    }
}