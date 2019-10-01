namespace Lahjakorttiappi
{
    partial class HallitseAikoja
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
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.lblAddTime = new System.Windows.Forms.Label();
            this.dgwTimes = new System.Windows.Forms.DataGridView();
            this.txtBoxNameStaff = new System.Windows.Forms.TextBox();
            this.btnRemoveTime = new System.Windows.Forms.Button();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.AccessibleName = "Sulje ikkuna";
            this.btnCloseWindow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWindow.Location = new System.Drawing.Point(11, 287);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(131, 60);
            this.btnCloseWindow.TabIndex = 5;
            this.btnCloseWindow.Text = "Sulje ikkuna";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindow_Click);
            // 
            // lblAddTime
            // 
            this.lblAddTime.AutoSize = true;
            this.lblAddTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTime.Location = new System.Drawing.Point(12, 18);
            this.lblAddTime.Name = "lblAddTime";
            this.lblAddTime.Size = new System.Drawing.Size(107, 24);
            this.lblAddTime.TabIndex = 0;
            this.lblAddTime.Text = "Lisää aika";
            // 
            // dgwTimes
            // 
            this.dgwTimes.AccessibleName = "Henkilökunta";
            this.dgwTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTimes.Location = new System.Drawing.Point(148, 18);
            this.dgwTimes.Name = "dgwTimes";
            this.dgwTimes.Size = new System.Drawing.Size(161, 329);
            this.dgwTimes.TabIndex = 5;
            // 
            // txtBoxNameStaff
            // 
            this.txtBoxNameStaff.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameStaff.Location = new System.Drawing.Point(11, 51);
            this.txtBoxNameStaff.Name = "txtBoxNameStaff";
            this.txtBoxNameStaff.Size = new System.Drawing.Size(221, 32);
            this.txtBoxNameStaff.TabIndex = 6;
            // 
            // btnRemoveTime
            // 
            this.btnRemoveTime.AccessibleName = "Poista aika";
            this.btnRemoveTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTime.Location = new System.Drawing.Point(11, 170);
            this.btnRemoveTime.Name = "btnRemoveTime";
            this.btnRemoveTime.Size = new System.Drawing.Size(131, 60);
            this.btnRemoveTime.TabIndex = 4;
            this.btnRemoveTime.Text = "Poista henkilö";
            this.btnRemoveTime.UseVisualStyleBackColor = true;
            // 
            // btnAddTime
            // 
            this.btnAddTime.AccessibleName = "Lisää Aika";
            this.btnAddTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime.Location = new System.Drawing.Point(11, 104);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(131, 60);
            this.btnAddTime.TabIndex = 3;
            this.btnAddTime.Text = "Lisää aika";
            this.btnAddTime.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "Kirjoita aika";
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 32);
            this.textBox1.TabIndex = 1;
            // 
            // HallitseAikoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 363);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.lblAddTime);
            this.Controls.Add(this.dgwTimes);
            this.Controls.Add(this.txtBoxNameStaff);
            this.Controls.Add(this.btnRemoveTime);
            this.Controls.Add(this.btnAddTime);
            this.Name = "HallitseAikoja";
            this.Text = "Hallitse Aikoja";
            this.Load += new System.EventHandler(this.HallitseAikoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Label lblAddTime;
        private System.Windows.Forms.DataGridView dgwTimes;
        private System.Windows.Forms.TextBox txtBoxNameStaff;
        private System.Windows.Forms.Button btnRemoveTime;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.TextBox textBox1;
    }
}