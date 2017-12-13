using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.UI.UICategory
{
    using Entity;
    using Dal;

    public partial class CategoryInsert : Form
    {
        public CategoryInsert()
        {
            InitializeComponent();
        }

        private void btnIptalInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKategoriInsert_Click(object sender, EventArgs e)
        {           
            CategoryDAL cDal = new CategoryDAL();
            try
            {
                Category category = new Category()
                {
                    CategoryName = txtInsertKategoriAdi.Text,
                    Description = txtInsertKategoriAciklama.Text
                };
                cDal.Save(category);
                Clear();
                DialogResult sonuc = MessageBox.Show("Kategori Ekleme İşleminiz Başarılı Bir Şekilde Gerçekleşmiştir...", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (sonuc == DialogResult.OK)
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            txtInsertKategoriAdi.Clear();
            txtInsertKategoriAciklama.Clear();
        }
    }
}
