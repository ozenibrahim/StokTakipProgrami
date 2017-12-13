using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.Dal;
using ADO.Entity;

namespace ADO.UI.UIProduct
{
    public partial class ProductInsert : Form
    {

        public ProductInsert()
        {
            InitializeComponent();
        }
        // ürün Ekleme işlemlerimizi gerçekleştirdik.
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {           
            Category category = cbKategoriAdi.SelectedItem as Category;
            ProductDAL pDal = new ProductDAL();
            try
            {
                Product product = new Product()
                {
                    ProductName = txtUrunAdi.Text,
                    CategoryID = category.CategoryID,
                    UnitPrice = Convert.ToDecimal(txtUrunFiyati.Text),
                    UnitsInStock = int.Parse(txtUrunStokAdeti.Text)
                };
                pDal.Save(product);
                Clear();
                DialogResult sonuc = MessageBox.Show("Ürün Ekleme İşleminiz Başarılı Bir Şekilde Gerçekleşmiştir...","Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtUrunAdi.Clear();
            txtUrunFiyati.Clear();
            txtUrunStokAdeti.Clear();
            cbKategoriAdi.SelectedIndex = 0;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Ürün Ekleme'de hangi kategoriye ait ürün ekleyecekse onları Db'den ComboBox'a cekiyoruz.
        private void ProductInsert_Load(object sender, EventArgs e)
        {
            CategoryDAL cDal = new CategoryDAL();           
            cbKategoriAdi.DataSource = cDal.List();
            cbKategoriAdi.DisplayMember = "CategoryName";
            cbKategoriAdi.ValueMember = "CategoryID";
        }
    }
}
