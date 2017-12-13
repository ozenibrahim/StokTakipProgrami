using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.UI.UIProduct
{
    using Entity;
    using Dal;
    public partial class ProductUpdate : Form
    {
        public ProductUpdate()
        {
            InitializeComponent();
        }
        //Ürün Güncelleme işlemlerini yaptık.
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            ProductDAL pDal = new ProductDAL();
            Product product = new Product();
            try
            {
                product.ProductID = Convert.ToInt32(txtUrunGuncelID.Text);
                product.ProductName = txtUrunGuncelAdi.Text;
                product.CategoryID = Convert.ToInt32(cbGuncelKategoriAdi.SelectedValue.ToString());
                product.UnitPrice = Convert.ToDecimal(txtUrunGuncelFiyati.Text);
                product.UnitsInStock = Convert.ToInt32(txtUrunGuncelStokAdeti.Text);

                pDal.Update(product);

                DialogResult sonuc = MessageBox.Show("Ürün Güncelleme İşleminiz Başarıyla Gerçekleşmiştir...", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Load'da Formumuza ürün listemizden seçilen ürün bilgilerini çektik.
        public Product product = new Product();
        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            cbGuncelKategoriAdi.Items.Clear();           
            CategoryDAL cDal = new CategoryDAL();

            txtUrunGuncelID.Text = product.ProductID.ToString();
            txtUrunGuncelAdi.Text = product.ProductName;
                        
            cbGuncelKategoriAdi.DataSource = cDal.List();
            cbGuncelKategoriAdi.DisplayMember = "CategoryName";
            cbGuncelKategoriAdi.ValueMember = "CategoryID";
            
            txtUrunGuncelFiyati.Text = product.UnitPrice.ToString();
            txtUrunGuncelStokAdeti.Text = product.UnitsInStock.ToString();
        } 
    }
}
