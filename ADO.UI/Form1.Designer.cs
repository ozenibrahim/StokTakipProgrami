namespace ADO.UI
{
    partial class Form1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.UrunlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TumUrunlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TumKategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KategoriGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KategoriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CikisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTumUrunler = new System.Windows.Forms.GroupBox();
            this.dGvUrunler = new System.Windows.Forms.DataGridView();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.gbTumKategoriler = new System.Windows.Forms.GroupBox();
            this.dGvKategoriler = new System.Windows.Forms.DataGridView();
            this.txtKategoriAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.gbTumUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvUrunler)).BeginInit();
            this.gbTumKategoriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrunlerToolStripMenuItem,
            this.kategorilerToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(975, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // UrunlerToolStripMenuItem
            // 
            this.UrunlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TumUrunlerToolStripMenuItem,
            this.UrunEkleToolStripMenuItem,
            this.UrunGuncelleToolStripMenuItem,
            this.UrunSilToolStripMenuItem,
            this.toolStripSeparator1,
            this.CikisToolStripMenuItem});
            this.UrunlerToolStripMenuItem.Name = "UrunlerToolStripMenuItem";
            this.UrunlerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.UrunlerToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.UrunlerToolStripMenuItem.Text = "Ürünler";
            // 
            // TumUrunlerToolStripMenuItem
            // 
            this.TumUrunlerToolStripMenuItem.Name = "TumUrunlerToolStripMenuItem";
            this.TumUrunlerToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.TumUrunlerToolStripMenuItem.Text = "Tüm Ürünler";
            this.TumUrunlerToolStripMenuItem.Click += new System.EventHandler(this.TumUrunlerToolStripMenuItem_Click);
            // 
            // UrunEkleToolStripMenuItem
            // 
            this.UrunEkleToolStripMenuItem.Name = "UrunEkleToolStripMenuItem";
            this.UrunEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.UrunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.UrunEkleToolStripMenuItem.Click += new System.EventHandler(this.UrunEkleToolStripMenuItem_Click);
            // 
            // UrunGuncelleToolStripMenuItem
            // 
            this.UrunGuncelleToolStripMenuItem.Name = "UrunGuncelleToolStripMenuItem";
            this.UrunGuncelleToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.UrunGuncelleToolStripMenuItem.Text = "Ürün Güncelle";
            this.UrunGuncelleToolStripMenuItem.Click += new System.EventHandler(this.UrunGuncelleToolStripMenuItem_Click);
            // 
            // UrunSilToolStripMenuItem
            // 
            this.UrunSilToolStripMenuItem.Name = "UrunSilToolStripMenuItem";
            this.UrunSilToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.UrunSilToolStripMenuItem.Text = "Ürün Sil";
            this.UrunSilToolStripMenuItem.Click += new System.EventHandler(this.UrunSilToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // CikisToolStripMenuItem
            // 
            this.CikisToolStripMenuItem.Name = "CikisToolStripMenuItem";
            this.CikisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CikisToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.CikisToolStripMenuItem.Text = "Çıkış";
            this.CikisToolStripMenuItem.Click += new System.EventHandler(this.CikisToolStripMenuItem_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TumKategorilerToolStripMenuItem,
            this.KategoriEkleToolStripMenuItem,
            this.KategoriGuncelleToolStripMenuItem,
            this.KategoriSilToolStripMenuItem,
            this.toolStripSeparator2,
            this.CikisToolStripMenuItem1});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // TumKategorilerToolStripMenuItem
            // 
            this.TumKategorilerToolStripMenuItem.Name = "TumKategorilerToolStripMenuItem";
            this.TumKategorilerToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.TumKategorilerToolStripMenuItem.Text = "Tüm Kategoriler";
            this.TumKategorilerToolStripMenuItem.Click += new System.EventHandler(this.TumKategorilerToolStripMenuItem_Click);
            // 
            // KategoriEkleToolStripMenuItem
            // 
            this.KategoriEkleToolStripMenuItem.Name = "KategoriEkleToolStripMenuItem";
            this.KategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.KategoriEkleToolStripMenuItem.Text = "Kategori Ekle";
            this.KategoriEkleToolStripMenuItem.Click += new System.EventHandler(this.KategoriEkleToolStripMenuItem_Click);
            // 
            // KategoriGuncelleToolStripMenuItem
            // 
            this.KategoriGuncelleToolStripMenuItem.Name = "KategoriGuncelleToolStripMenuItem";
            this.KategoriGuncelleToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.KategoriGuncelleToolStripMenuItem.Text = "Kategori Güncelle";
            this.KategoriGuncelleToolStripMenuItem.Click += new System.EventHandler(this.KategoriGuncelleToolStripMenuItem_Click);
            // 
            // KategoriSilToolStripMenuItem
            // 
            this.KategoriSilToolStripMenuItem.Name = "KategoriSilToolStripMenuItem";
            this.KategoriSilToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.KategoriSilToolStripMenuItem.Text = "Kategori Sil";
            this.KategoriSilToolStripMenuItem.Click += new System.EventHandler(this.KategoriSilToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // CikisToolStripMenuItem1
            // 
            this.CikisToolStripMenuItem1.Name = "CikisToolStripMenuItem1";
            this.CikisToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CikisToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.CikisToolStripMenuItem1.Text = "Çıkış";
            this.CikisToolStripMenuItem1.Click += new System.EventHandler(this.CikisToolStripMenuItem1_Click);
            // 
            // gbTumUrunler
            // 
            this.gbTumUrunler.Controls.Add(this.dGvUrunler);
            this.gbTumUrunler.Controls.Add(this.txtUrunAra);
            this.gbTumUrunler.Controls.Add(this.lblUrunAra);
            this.gbTumUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTumUrunler.Location = new System.Drawing.Point(12, 32);
            this.gbTumUrunler.Name = "gbTumUrunler";
            this.gbTumUrunler.Size = new System.Drawing.Size(471, 422);
            this.gbTumUrunler.TabIndex = 1;
            this.gbTumUrunler.TabStop = false;
            this.gbTumUrunler.Text = "Tüm Ürünler";
            this.gbTumUrunler.Visible = false;
            // 
            // dGvUrunler
            // 
            this.dGvUrunler.AllowUserToOrderColumns = true;
            this.dGvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGvUrunler.Location = new System.Drawing.Point(3, 64);
            this.dGvUrunler.Name = "dGvUrunler";
            this.dGvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvUrunler.Size = new System.Drawing.Size(465, 355);
            this.dGvUrunler.TabIndex = 1;
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAra.Location = new System.Drawing.Point(112, 28);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(180, 21);
            this.txtUrunAra.TabIndex = 0;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.AutoSize = true;
            this.lblUrunAra.Location = new System.Drawing.Point(32, 29);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(73, 17);
            this.lblUrunAra.TabIndex = 0;
            this.lblUrunAra.Text = "Ürün Ara :";
            // 
            // gbTumKategoriler
            // 
            this.gbTumKategoriler.Controls.Add(this.dGvKategoriler);
            this.gbTumKategoriler.Controls.Add(this.txtKategoriAra);
            this.gbTumKategoriler.Controls.Add(this.label1);
            this.gbTumKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTumKategoriler.Location = new System.Drawing.Point(486, 32);
            this.gbTumKategoriler.Name = "gbTumKategoriler";
            this.gbTumKategoriler.Size = new System.Drawing.Size(484, 422);
            this.gbTumKategoriler.TabIndex = 5;
            this.gbTumKategoriler.TabStop = false;
            this.gbTumKategoriler.Text = "Tüm Kategoriler";
            this.gbTumKategoriler.Visible = false;
            // 
            // dGvKategoriler
            // 
            this.dGvKategoriler.AllowUserToOrderColumns = true;
            this.dGvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvKategoriler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGvKategoriler.Location = new System.Drawing.Point(3, 63);
            this.dGvKategoriler.Name = "dGvKategoriler";
            this.dGvKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvKategoriler.Size = new System.Drawing.Size(478, 356);
            this.dGvKategoriler.TabIndex = 1;
            // 
            // txtKategoriAra
            // 
            this.txtKategoriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAra.Location = new System.Drawing.Point(106, 27);
            this.txtKategoriAra.Name = "txtKategoriAra";
            this.txtKategoriAra.Size = new System.Drawing.Size(180, 21);
            this.txtKategoriAra.TabIndex = 0;
            this.txtKategoriAra.TextChanged += new System.EventHandler(this.txtKategoriAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Ara :";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(197, 462);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(89, 26);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Visible = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(292, 462);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(95, 26);
            this.btnUrunGuncelle.TabIndex = 3;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Visible = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(393, 462);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(90, 26);
            this.btnUrunSil.TabIndex = 4;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Visible = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(668, 462);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(89, 26);
            this.btnKategoriEkle.TabIndex = 6;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Visible = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(762, 462);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(107, 26);
            this.btnKategoriGuncelle.TabIndex = 7;
            this.btnKategoriGuncelle.Text = "Kategori Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Visible = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(875, 462);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(90, 26);
            this.btnKategoriSil.TabIndex = 8;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Visible = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 508);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.gbTumKategoriler);
            this.Controls.Add(this.gbTumUrunler);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Programı";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbTumUrunler.ResumeLayout(false);
            this.gbTumUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvUrunler)).EndInit();
            this.gbTumKategoriler.ResumeLayout(false);
            this.gbTumKategoriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem UrunlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TumUrunlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TumKategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KategoriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KategoriGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KategoriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem1;
        private System.Windows.Forms.GroupBox gbTumUrunler;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.GroupBox gbTumKategoriler;
        private System.Windows.Forms.TextBox txtKategoriAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        public System.Windows.Forms.DataGridView dGvUrunler;
        public System.Windows.Forms.DataGridView dGvKategoriler;
    }
}

