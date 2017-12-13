namespace ADO.UI.UICategory
{
    partial class CategoryUpdate
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
            this.lblKategoriID = new System.Windows.Forms.Label();
            this.txtGuncelKategoriID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuncelKategoriAciklama = new System.Windows.Forms.TextBox();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnIptalUpdate = new System.Windows.Forms.Button();
            this.cbKategoriGuncelle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblKategoriID
            // 
            this.lblKategoriID.AutoSize = true;
            this.lblKategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriID.Location = new System.Drawing.Point(17, 27);
            this.lblKategoriID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategoriID.Name = "lblKategoriID";
            this.lblKategoriID.Size = new System.Drawing.Size(82, 17);
            this.lblKategoriID.TabIndex = 0;
            this.lblKategoriID.Text = "Kategori ID:";
            // 
            // txtGuncelKategoriID
            // 
            this.txtGuncelKategoriID.Enabled = false;
            this.txtGuncelKategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelKategoriID.Location = new System.Drawing.Point(146, 24);
            this.txtGuncelKategoriID.Margin = new System.Windows.Forms.Padding(2);
            this.txtGuncelKategoriID.Name = "txtGuncelKategoriID";
            this.txtGuncelKategoriID.Size = new System.Drawing.Size(187, 23);
            this.txtGuncelKategoriID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Açıklama:";
            // 
            // txtGuncelKategoriAciklama
            // 
            this.txtGuncelKategoriAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelKategoriAciklama.Location = new System.Drawing.Point(146, 80);
            this.txtGuncelKategoriAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txtGuncelKategoriAciklama.Multiline = true;
            this.txtGuncelKategoriAciklama.Name = "txtGuncelKategoriAciklama";
            this.txtGuncelKategoriAciklama.Size = new System.Drawing.Size(187, 99);
            this.txtGuncelKategoriAciklama.TabIndex = 2;
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(189, 195);
            this.btnKategoriGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(74, 24);
            this.btnKategoriGuncelle.TabIndex = 3;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnIptalUpdate
            // 
            this.btnIptalUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalUpdate.Location = new System.Drawing.Point(266, 195);
            this.btnIptalUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptalUpdate.Name = "btnIptalUpdate";
            this.btnIptalUpdate.Size = new System.Drawing.Size(65, 24);
            this.btnIptalUpdate.TabIndex = 4;
            this.btnIptalUpdate.Text = "İptal";
            this.btnIptalUpdate.UseVisualStyleBackColor = true;
            this.btnIptalUpdate.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // cbKategoriGuncelle
            // 
            this.cbKategoriGuncelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriGuncelle.FormattingEnabled = true;
            this.cbKategoriGuncelle.Location = new System.Drawing.Point(146, 53);
            this.cbKategoriGuncelle.Name = "cbKategoriGuncelle";
            this.cbKategoriGuncelle.Size = new System.Drawing.Size(187, 21);
            this.cbKategoriGuncelle.TabIndex = 5;
            // 
            // CategoryUpdate
            // 
            this.AcceptButton = this.btnKategoriGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 235);
            this.Controls.Add(this.cbKategoriGuncelle);
            this.Controls.Add(this.btnIptalUpdate);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuncelKategoriAciklama);
            this.Controls.Add(this.txtGuncelKategoriID);
            this.Controls.Add(this.lblKategoriID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CategoryUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Güncelle";
            this.Load += new System.EventHandler(this.CategoryUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategoriID;
        private System.Windows.Forms.TextBox txtGuncelKategoriID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuncelKategoriAciklama;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnIptalUpdate;
        private System.Windows.Forms.ComboBox cbKategoriGuncelle;
    }
}