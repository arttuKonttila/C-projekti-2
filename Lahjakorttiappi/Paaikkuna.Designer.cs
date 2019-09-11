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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmBoxSum = new System.Windows.Forms.ComboBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblByer = new System.Windows.Forms.Label();
            this.cmBoxByer = new System.Windows.Forms.ComboBox();
            this.lblDTPOrderDate = new System.Windows.Forms.Label();
            this.dTPOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblSeller = new System.Windows.Forms.Label();
            this.cmBoxSeller = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cmBoxService = new System.Windows.Forms.ComboBox();
            this.gBoxControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSearch.SuspendLayout();
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
            this.btnMuokkaa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuokkaa.Location = new System.Drawing.Point(6, 113);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(124, 41);
            this.btnMuokkaa.TabIndex = 2;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.Color.Red;
            this.btnPoista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(6, 66);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(124, 41);
            this.btnPoista.TabIndex = 1;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(6, 19);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(124, 41);
            this.btnLisaa.TabIndex = 0;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnLaheta
            // 
            this.btnLaheta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaheta.Location = new System.Drawing.Point(6, 160);
            this.btnLaheta.Name = "btnLaheta";
            this.btnLaheta.Size = new System.Drawing.Size(124, 41);
            this.btnLaheta.TabIndex = 4;
            this.btnLaheta.Text = "Lahetä";
            this.btnLaheta.UseVisualStyleBackColor = true;
            // 
            // cmBoxOrder
            // 
            this.cmBoxOrder.AccessibleName = "Järjestys";
            this.cmBoxOrder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxOrder.FormattingEnabled = true;
            this.cmBoxOrder.Location = new System.Drawing.Point(1238, 480);
            this.cmBoxOrder.Name = "cmBoxOrder";
            this.cmBoxOrder.Size = new System.Drawing.Size(163, 32);
            this.cmBoxOrder.TabIndex = 6;
            // 
            // gBoxControl
            // 
            this.gBoxControl.AccessibleName = "Hallinta paneeli";
            this.gBoxControl.Controls.Add(this.btnLaheta);
            this.gBoxControl.Controls.Add(this.btnLisaa);
            this.gBoxControl.Controls.Add(this.btnPoista);
            this.gBoxControl.Controls.Add(this.btnMuokkaa);
            this.gBoxControl.Location = new System.Drawing.Point(1239, 36);
            this.gBoxControl.Name = "gBoxControl";
            this.gBoxControl.Size = new System.Drawing.Size(162, 438);
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
            this.menuStrip1.Size = new System.Drawing.Size(1413, 24);
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
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // lisääUusiToolStripMenuItem
            // 
            this.lisääUusiToolStripMenuItem.Name = "lisääUusiToolStripMenuItem";
            this.lisääUusiToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.lisääUusiToolStripMenuItem.Text = "Lisää uusi";
            this.lisääUusiToolStripMenuItem.Click += new System.EventHandler(this.lisääUusiToolStripMenuItem_Click);
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.poistaToolStripMenuItem.Text = "Poista";
            // 
            // asetuksetToolStripMenuItem
            // 
            this.asetuksetToolStripMenuItem.Name = "asetuksetToolStripMenuItem";
            this.asetuksetToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.asetuksetToolStripMenuItem.Text = "Asetukset";
            this.asetuksetToolStripMenuItem.Click += new System.EventHandler(this.asetuksetToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // haeToolStripMenuItem
            // 
            this.haeToolStripMenuItem.Name = "haeToolStripMenuItem";
            this.haeToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.haeToolStripMenuItem.Text = "Hae";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1220, 514);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.AccessibleName = "Hae lahjakortteja";
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.cmBoxSum);
            this.pnlSearch.Controls.Add(this.lblSum);
            this.pnlSearch.Controls.Add(this.lblByer);
            this.pnlSearch.Controls.Add(this.cmBoxByer);
            this.pnlSearch.Controls.Add(this.lblDTPOrderDate);
            this.pnlSearch.Controls.Add(this.dTPOrderDate);
            this.pnlSearch.Controls.Add(this.lblSeller);
            this.pnlSearch.Controls.Add(this.cmBoxSeller);
            this.pnlSearch.Controls.Add(this.lblService);
            this.pnlSearch.Controls.Add(this.cmBoxService);
            this.pnlSearch.Location = new System.Drawing.Point(13, 585);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1107, 175);
            this.pnlSearch.TabIndex = 10;
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleName = "Etsi";
            this.btnSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(844, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 77);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Hae";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmBoxSum
            // 
            this.cmBoxSum.AccessibleName = "Määrä";
            this.cmBoxSum.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxSum.FormattingEnabled = true;
            this.cmBoxSum.Location = new System.Drawing.Point(211, 117);
            this.cmBoxSum.Name = "cmBoxSum";
            this.cmBoxSum.Size = new System.Drawing.Size(170, 32);
            this.cmBoxSum.TabIndex = 9;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(207, 90);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(70, 24);
            this.lblSum.TabIndex = 8;
            this.lblSum.Text = "Määrä";
            // 
            // lblByer
            // 
            this.lblByer.AutoSize = true;
            this.lblByer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByer.Location = new System.Drawing.Point(9, 90);
            this.lblByer.Name = "lblByer";
            this.lblByer.Size = new System.Drawing.Size(71, 24);
            this.lblByer.TabIndex = 7;
            this.lblByer.Text = "Ostaja";
            // 
            // cmBoxByer
            // 
            this.cmBoxByer.AccessibleName = "Ostaja";
            this.cmBoxByer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxByer.FormattingEnabled = true;
            this.cmBoxByer.Location = new System.Drawing.Point(13, 117);
            this.cmBoxByer.Name = "cmBoxByer";
            this.cmBoxByer.Size = new System.Drawing.Size(170, 32);
            this.cmBoxByer.TabIndex = 6;
            // 
            // lblDTPOrderDate
            // 
            this.lblDTPOrderDate.AutoSize = true;
            this.lblDTPOrderDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTPOrderDate.Location = new System.Drawing.Point(422, 10);
            this.lblDTPOrderDate.Name = "lblDTPOrderDate";
            this.lblDTPOrderDate.Size = new System.Drawing.Size(180, 24);
            this.lblDTPOrderDate.TabIndex = 5;
            this.lblDTPOrderDate.Text = "Tilaus päivämäärä";
            // 
            // dTPOrderDate
            // 
            this.dTPOrderDate.AccessibleName = "Tilaus päivämäärä";
            this.dTPOrderDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPOrderDate.Location = new System.Drawing.Point(426, 37);
            this.dTPOrderDate.Name = "dTPOrderDate";
            this.dTPOrderDate.Size = new System.Drawing.Size(350, 32);
            this.dTPOrderDate.TabIndex = 4;
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeller.Location = new System.Drawing.Point(204, 10);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(65, 24);
            this.lblSeller.TabIndex = 3;
            this.lblSeller.Text = "Myyjä";
            // 
            // cmBoxSeller
            // 
            this.cmBoxSeller.AccessibleName = "Myyjä";
            this.cmBoxSeller.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxSeller.FormattingEnabled = true;
            this.cmBoxSeller.Location = new System.Drawing.Point(208, 37);
            this.cmBoxSeller.Name = "cmBoxSeller";
            this.cmBoxSeller.Size = new System.Drawing.Size(170, 32);
            this.cmBoxSeller.TabIndex = 2;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(9, 10);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(62, 24);
            this.lblService.TabIndex = 1;
            this.lblService.Text = "Tuote";
            // 
            // cmBoxService
            // 
            this.cmBoxService.AccessibleName = "Palvelu";
            this.cmBoxService.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxService.FormattingEnabled = true;
            this.cmBoxService.Location = new System.Drawing.Point(13, 37);
            this.cmBoxService.Name = "cmBoxService";
            this.cmBoxService.Size = new System.Drawing.Size(170, 32);
            this.cmBoxService.TabIndex = 0;
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1413, 789);
            this.Controls.Add(this.cmBoxOrder);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gBoxControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Paaikkuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pääikkuna";
            this.gBoxControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
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
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.ComboBox cmBoxService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmBoxSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblByer;
        private System.Windows.Forms.ComboBox cmBoxByer;
        private System.Windows.Forms.Label lblDTPOrderDate;
        private System.Windows.Forms.DateTimePicker dTPOrderDate;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.ComboBox cmBoxSeller;
        private System.Windows.Forms.ToolStripMenuItem asetuksetToolStripMenuItem;
    }
}

