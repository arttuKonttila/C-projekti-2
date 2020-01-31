namespace Lahjakorttiappi
{
    partial class Paaikkuna
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnLaheta = new System.Windows.Forms.Button();
            this.cmBoxOrder = new System.Windows.Forms.ComboBox();
            this.gBoxControl = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääUusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asetuksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBoxControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuokkaa.Location = new System.Drawing.Point(8, 139);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(165, 50);
            this.btnMuokkaa.TabIndex = 2;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.Color.Red;
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(8, 81);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(165, 50);
            this.btnPoista.TabIndex = 1;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(8, 23);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(165, 50);
            this.btnLisaa.TabIndex = 0;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnLaheta
            // 
            this.btnLaheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaheta.Location = new System.Drawing.Point(8, 197);
            this.btnLaheta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaheta.Name = "btnLaheta";
            this.btnLaheta.Size = new System.Drawing.Size(165, 50);
            this.btnLaheta.TabIndex = 4;
            this.btnLaheta.Text = "Lahetä";
            this.btnLaheta.UseVisualStyleBackColor = true;
            // 
            // cmBoxOrder
            // 
            this.cmBoxOrder.AccessibleName = "Järjestys";
            this.cmBoxOrder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxOrder.FormattingEnabled = true;
            this.cmBoxOrder.Location = new System.Drawing.Point(1651, 373);
            this.cmBoxOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmBoxOrder.Name = "cmBoxOrder";
            this.cmBoxOrder.Size = new System.Drawing.Size(216, 39);
            this.cmBoxOrder.TabIndex = 6;
            // 
            // gBoxControl
            // 
            this.gBoxControl.AccessibleName = "Hallinta paneeli";
            this.gBoxControl.Controls.Add(this.btnLaheta);
            this.gBoxControl.Controls.Add(this.btnLisaa);
            this.gBoxControl.Controls.Add(this.btnPoista);
            this.gBoxControl.Controls.Add(this.btnMuokkaa);
            this.gBoxControl.Location = new System.Drawing.Point(1652, 44);
            this.gBoxControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxControl.Name = "gBoxControl";
            this.gBoxControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxControl.Size = new System.Drawing.Size(216, 278);
            this.gBoxControl.TabIndex = 7;
            this.gBoxControl.TabStop = false;
            this.gBoxControl.Text = "Hallinta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.haeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1884, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisääUusiToolStripMenuItem,
            this.poistaToolStripMenuItem,
            this.asetuksetToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // lisääUusiToolStripMenuItem
            // 
            this.lisääUusiToolStripMenuItem.Name = "lisääUusiToolStripMenuItem";
            this.lisääUusiToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.lisääUusiToolStripMenuItem.Text = "Lisää uusi";
            this.lisääUusiToolStripMenuItem.Click += new System.EventHandler(this.lisääUusiToolStripMenuItem_Click);
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.poistaToolStripMenuItem.Text = "Poista";
            // 
            // asetuksetToolStripMenuItem
            // 
            this.asetuksetToolStripMenuItem.Name = "asetuksetToolStripMenuItem";
            this.asetuksetToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.asetuksetToolStripMenuItem.Text = "Asetukset";
            this.asetuksetToolStripMenuItem.Click += new System.EventHandler(this.asetuksetToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // haeToolStripMenuItem
            // 
            this.haeToolStripMenuItem.Name = "haeToolStripMenuItem";
            this.haeToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.haeToolStripMenuItem.Text = "Hae";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1627, 633);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1884, 715);
            this.Controls.Add(this.cmBoxOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gBoxControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Paaikkuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pääikkuna";
            this.Load += new System.EventHandler(this.Paaikkuna_Load);
            this.gBoxControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnLaheta;
        private System.Windows.Forms.ComboBox cmBoxOrder;
        private System.Windows.Forms.GroupBox gBoxControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisääUusiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem asetuksetToolStripMenuItem;
    }
}

