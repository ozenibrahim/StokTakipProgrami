namespace ADO.UI.UICategory
{
    partial class CategoryInsert
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
            this.btnIptalInsert = new System.Windows.Forms.Button();
            this.btnKategoriInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertKategoriAciklama = new System.Windows.Forms.TextBox();
            this.txtInsertKategoriAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIptalInsert
            // 
            this.btnIptalInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalInsert.Location = new System.Drawing.Point(344, 201);
            this.btnIptalInsert.Name = "btnIptalInsert";
            this.btnIptalInsert.Size = new System.Drawing.Size(96, 31);
            this.btnIptalInsert.TabIndex = 3;
            this.btnIptalInsert.Text = "İptal";
            this.btnIptalInsert.UseVisualStyleBackColor = true;
            this.btnIptalInsert.Click += new System.EventHandler(this.btnIptalInsert_Click);
            // 
            // btnKategoriInsert
            // 
            this.btnKategoriInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriInsert.Location = new System.Drawing.Point(243, 201);
            this.btnKategoriInsert.Name = "btnKategoriInsert";
            this.btnKategoriInsert.Size = new System.Drawing.Size(95, 31);
            this.btnKategoriInsert.TabIndex = 2;
            this.btnKategoriInsert.Text = "Ekle";
            this.btnKategoriInsert.UseVisualStyleBackColor = true;
            this.btnKategoriInsert.Click += new System.EventHandler(this.btnKategoriInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategori Açıklama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategori Adı:";
            // 
            // txtInsertKategoriAciklama
            // 
            this.txtInsertKategoriAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInsertKategoriAciklama.Location = new System.Drawing.Point(196, 66);
            this.txtInsertKategoriAciklama.Multiline = true;
            this.txtInsertKategoriAciklama.Name = "txtInsertKategoriAciklama";
            this.txtInsertKategoriAciklama.Size = new System.Drawing.Size(244, 114);
            this.txtInsertKategoriAciklama.TabIndex = 1;
            // 
            // txtInsertKategoriAdi
            // 
            this.txtInsertKategoriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInsertKategoriAdi.Location = new System.Drawing.Point(196, 20);
            this.txtInsertKategoriAdi.Name = "txtInsertKategoriAdi";
            this.txtInsertKategoriAdi.Size = new System.Drawing.Size(244, 26);
            this.txtInsertKategoriAdi.TabIndex = 0;
            // 
            // CategoryInsert
            // 
            this.AcceptButton = this.btnKategoriInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 244);
            this.Controls.Add(this.btnIptalInsert);
            this.Controls.Add(this.btnKategoriInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsertKategoriAciklama);
            this.Controls.Add(this.txtInsertKategoriAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CategoryInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptalInsert;
        private System.Windows.Forms.Button btnKategoriInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsertKategoriAciklama;
        private System.Windows.Forms.TextBox txtInsertKategoriAdi;
    }
}