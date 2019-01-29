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
    using Dal;
    using Entity;
    public partial class CategoryUpdate : Form
    {
        public CategoryUpdate()
        {
            InitializeComponent();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            CategoryDAL cDal = new CategoryDAL();
            Category category = new Category();
            try
            {
                category.CategoryID = Convert.ToInt32(txtGuncelKategoriID.Text);
                category.CategoryName = cbKategoriGuncelle.SelectedItem.ToString();
                category.Description =txtGuncelKategoriAciklama.Text;     

                cDal.Update(category);

                DialogResult sonuc = MessageBox.Show("Kategori Güncelleme İşleminiz Başarıyla Gerçekleşmiştir...", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public Category category = new Category();
        private void CategoryUpdate_Load(object sender, EventArgs e)
        {
            CategoryDAL cDal = new CategoryDAL();

            txtGuncelKategoriID.Text = category.CategoryID.ToString();

            cbKategoriGuncelle.DataSource = cDal.List();
            cbKategoriGuncelle.DisplayMember = "CategoryName";
            cbKategoriGuncelle.ValueMember = "CategoryID";

            txtGuncelKategoriAciklama.Text = category.Description;
        }
    }
}
