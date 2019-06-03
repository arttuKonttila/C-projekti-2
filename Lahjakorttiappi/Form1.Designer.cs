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
            this.btnTulosta = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnLaheta = new System.Windows.Forms.Button();
            this.cmBoxJarjestys = new System.Windows.Forms.ComboBox();
            this.gBoxHallinta = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääUusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBoxHallinta.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
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
            // 
            // btnTulosta
            // 
            this.btnTulosta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTulosta.Location = new System.Drawing.Point(6, 160);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(124, 41);
            this.btnTulosta.TabIndex = 3;
            this.btnTulosta.Text = "Tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
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
            // 
            // btnLaheta
            // 
            this.btnLaheta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaheta.Location = new System.Drawing.Point(6, 207);
            this.btnLaheta.Name = "btnLaheta";
            this.btnLaheta.Size = new System.Drawing.Size(124, 41);
            this.btnLaheta.TabIndex = 4;
            this.btnLaheta.Text = "Lahetä";
            this.btnLaheta.UseVisualStyleBackColor = true;
            // 
            // cmBoxJarjestys
            // 
            this.cmBoxJarjestys.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxJarjestys.FormattingEnabled = true;
            this.cmBoxJarjestys.Location = new System.Drawing.Point(13, 50);
            this.cmBoxJarjestys.Name = "cmBoxJarjestys";
            this.cmBoxJarjestys.Size = new System.Drawing.Size(278, 26);
            this.cmBoxJarjestys.TabIndex = 6;
            // 
            // gBoxHallinta
            // 
            this.gBoxHallinta.Controls.Add(this.btnLaheta);
            this.gBoxHallinta.Controls.Add(this.btnLisaa);
            this.gBoxHallinta.Controls.Add(this.btnTulosta);
            this.gBoxHallinta.Controls.Add(this.btnPoista);
            this.gBoxHallinta.Controls.Add(this.btnMuokkaa);
            this.gBoxHallinta.Location = new System.Drawing.Point(970, 26);
            this.gBoxHallinta.Name = "gBoxHallinta";
            this.gBoxHallinta.Size = new System.Drawing.Size(162, 438);
            this.gBoxHallinta.TabIndex = 7;
            this.gBoxHallinta.TabStop = false;
            this.gBoxHallinta.Text = "Hallinta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.haeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisääUusiToolStripMenuItem,
            this.poistaToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // lisääUusiToolStripMenuItem
            // 
            this.lisääUusiToolStripMenuItem.Name = "lisääUusiToolStripMenuItem";
            this.lisääUusiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lisääUusiToolStripMenuItem.Text = "Lisää uusi";
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poistaToolStripMenuItem.Text = "Poista";
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 514);
            this.dataGridView1.TabIndex = 9;
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 789);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gBoxHallinta);
            this.Controls.Add(this.cmBoxJarjestys);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Paaikkuna";
            this.Text = "Pääikkuna";
            this.gBoxHallinta.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnTulosta;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnLaheta;
        private System.Windows.Forms.ComboBox cmBoxJarjestys;
        private System.Windows.Forms.GroupBox gBoxHallinta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisääUusiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

