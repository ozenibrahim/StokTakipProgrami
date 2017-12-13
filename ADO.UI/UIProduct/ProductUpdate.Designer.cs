namespace ADO.UI.UIProduct
{
    partial class ProductUpdate
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.cbGuncelKategoriAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunGuncelStokAdeti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunGuncelFiyati = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunGuncelAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunGuncelID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(280, 227);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 28);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGuncelle.Location = new System.Drawing.Point(179, 227);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(95, 28);
            this.btnUrunGuncelle.TabIndex = 5;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // cbGuncelKategoriAdi
            // 
            this.cbGuncelKategoriAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuncelKategoriAdi.FormattingEnabled = true;
            this.cbGuncelKategoriAdi.Location = new System.Drawing.Point(139, 104);
            this.cbGuncelKategoriAdi.Name = "cbGuncelKategoriAdi";
            this.cbGuncelKategoriAdi.Size = new System.Drawing.Size(236, 21);
            this.cbGuncelKategoriAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kategori Adı:";
            // 
            // txtUrunGuncelStokAdeti
            // 
            this.txtUrunGuncelStokAdeti.Location = new System.Drawing.Point(139, 188);
            this.txtUrunGuncelStokAdeti.Name = "txtUrunGuncelStokAdeti";
            this.txtUrunGuncelStokAdeti.Size = new System.Drawing.Size(236, 20);
            this.txtUrunGuncelStokAdeti.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün Adet:";
            // 
            // txtUrunGuncelFiyati
            // 
            this.txtUrunGuncelFiyati.Location = new System.Drawing.Point(139, 149);
            this.txtUrunGuncelFiyati.Name = "txtUrunGuncelFiyati";
            this.txtUrunGuncelFiyati.Size = new System.Drawing.Size(236, 20);
            this.txtUrunGuncelFiyati.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Fiyatı:";
            // 
            // txtUrunGuncelAdi
            // 
            this.txtUrunGuncelAdi.Location = new System.Drawing.Point(139, 64);
            this.txtUrunGuncelAdi.Name = "txtUrunGuncelAdi";
            this.txtUrunGuncelAdi.Size = new System.Drawing.Size(236, 20);
            this.txtUrunGuncelAdi.TabIndex = 1;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(26, 65);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(67, 17);
            this.lblUrunAdi.TabIndex = 10;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün ID:";
            // 
            // txtUrunGuncelID
            // 
            this.txtUrunGuncelID.Enabled = false;
            this.txtUrunGuncelID.Location = new System.Drawing.Point(139, 25);
            this.txtUrunGuncelID.Name = "txtUrunGuncelID";
            this.txtUrunGuncelID.Size = new System.Drawing.Size(236, 20);
            this.txtUrunGuncelID.TabIndex = 0;
            // 
            // ProductUpdate
            // 
            this.AcceptButton = this.btnUrunGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 271);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.cbGuncelKategoriAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunGuncelStokAdeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunGuncelFiyati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunGuncelID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrunGuncelAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProductUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Güncelle";
            this.Load += new System.EventHandler(this.ProductUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGuncelKategoriAdi;
        private System.Windows.Forms.TextBox txtUrunGuncelStokAdeti;
        private System.Windows.Forms.TextBox txtUrunGuncelFiyati;
        private System.Windows.Forms.TextBox txtUrunGuncelAdi;
        private System.Windows.Forms.TextBox txtUrunGuncelID;
    }
}