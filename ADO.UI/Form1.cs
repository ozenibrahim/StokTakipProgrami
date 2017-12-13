using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.UI
{
    using Dal;
    using Entity;
    using Common;
    using UIProduct;
    using UICategory;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region AllCategoriesAndAllProductList
        //Kategorileri veritabanından datagrid'e çektik
        private void TumKategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbTumKategoriler.Visible = true;
            btnKategoriEkle.Visible = true;
            btnKategoriGuncelle.Visible = true;
            btnKategoriSil.Visible = true;

            CategoryDAL cDal = new CategoryDAL();
            if (cDal != null)
            {
                dGvKategoriler.DataSource = cDal.List();
            }
        }
        //Ürüleri veritabanından datagrid'e çektik
        private void TumUrunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbTumUrunler.Visible = true;
            btnUrunEkle.Visible = true;
            btnUrunGuncelle.Visible = true;
            btnUrunSil.Visible = true;

            ProductDAL pDal = new ProductDAL();

            if (pDal != null)
            {
                dGvUrunler.DataSource = pDal.List();
            }
        }

        #endregion     

        #region YavruFormlar.show()
        private void UrunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInsert uEkle = new ProductInsert();
            uEkle.Show();
        }

        private void KategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryInsert cInsert = new CategoryInsert();
            cInsert.Show();
        }

        private void CikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            ProductInsert uEkle = new ProductInsert();
            uEkle.Show();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            CategoryInsert cInsert = new CategoryInsert();
            cInsert.Show();
        }
        #endregion

        #region ProductAndCategoriesUpdate

        //DataGrid'den seçili ürüne ait bilgileri ProductUpdate formuna yönlendirdik.
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            ProductUpdate uGuncelle = new ProductUpdate();
            try
            {
                Product product = new Product
                {
                    ProductID = Convert.ToInt32(dGvUrunler.SelectedRows[0].Cells[0].Value),
                    ProductName = dGvUrunler.SelectedRows[0].Cells[1].Value.ToString(),
                    CategoryID = Convert.ToInt32(dGvUrunler.SelectedRows[0].Cells[2].Value),
                    UnitPrice = Convert.ToDecimal(dGvUrunler.SelectedRows[0].Cells[3].Value.ToString()),
                    UnitsInStock = Convert.ToInt32(dGvUrunler.SelectedRows[0].Cells[4].Value)
                };
                uGuncelle.product = product;
                uGuncelle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Ürün Listesini 'Ürünler' Sekmesinden Listeleyiniz...\n\n" + ex.Message);
            }
        }

        private void UrunGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductUpdate uGuncelle = new ProductUpdate();
            try
            {
                Product product = new Product
                {
                    ProductID = Convert.ToInt32(dGvUrunler.SelectedRows[0].Cells[0].Value),
                    ProductName = dGvUrunler.SelectedRows[0].Cells[1].Value.ToString(),
                    CategoryID = Convert.ToInt32(dGvUrunler.SelectedRows[0].Cells[2].Value),
                    UnitPrice = Convert.ToDecimal(dGvUrunler.SelectedRows[0].Cells[3].Value.ToString()),
                    UnitsInStock = Convert.ToInt32(dGvUrunler.SelectedRows[0].Cells[4].Value)
                };
                uGuncelle.product = product;
                uGuncelle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Ürün Listesini 'Ürünler' Sekmesinden Listeleyiniz...\n\n" + ex.Message);
            }
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            CategoryUpdate cGuncelle = new CategoryUpdate();
            try
            {
                Category category = new Category()
                {
                    CategoryID = Convert.ToInt32(dGvKategoriler.SelectedRows[0].Cells[0].Value),
                    CategoryName = dGvKategoriler.SelectedRows[0].Cells[1].Value.ToString(),
                    Description = dGvKategoriler.SelectedRows[0].Cells[2].Value.ToString()
                };
                cGuncelle.category = category;
                cGuncelle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Kategori Listesini 'Kategoriler' Sekmesinden Listeleyiniz...\n\n" + ex.Message);
            }

        }

        private void KategoriGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryUpdate cGuncelle = new CategoryUpdate();
            try
            {
                Category category = new Category
                {
                    CategoryID = Convert.ToInt32(dGvKategoriler.SelectedRows[0].Cells[0].Value),
                    CategoryName = dGvKategoriler.SelectedRows[0].Cells[1].Value.ToString(),
                    Description = dGvKategoriler.SelectedRows[0].Cells[2].Value.ToString()
                };
                cGuncelle.category = category;
                cGuncelle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Ürün Listesini 'Ürünler' Sekmesinden Listeleyiniz...\n\n" + ex.Message);
            }
            cGuncelle.Show();
        }
        #endregion       

        #region ProductAndCategoriesDelete
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGvUrunler.SelectedRows.Count > 0)
                {
                    DialogResult sonuc = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.OK)
                    {
                        ProductDAL pDal = new ProductDAL();
                        foreach (DataGridViewRow row in dGvUrunler.SelectedRows)
                        {
                            pDal.Delete(dGvUrunler.SelectedRows[0].Cells[0].Value);

                            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Silinmiştir.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Ürün Seçiniz!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Ürünü 'Ürünler' Sekmesinden Listeleyip Ürün Seçiniz...\n\n" + ex.Message);
            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGvKategoriler.SelectedRows.Count > 0)
                {
                    DialogResult sonuc = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.OK)
                    {
                        CategoryDAL cDal = new CategoryDAL();
                        foreach (DataGridViewRow row in dGvKategoriler.SelectedRows)
                        {
                            cDal.Delete(dGvKategoriler.SelectedRows[0].Cells[0].Value);

                            MessageBox.Show("Kategoriniz Başarılı Bir Şekilde Silinmiştir.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Kategori Seçiniz!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Kategoriyi 'Kategoriler' Sekmesinden Listeleyip Kategori Seçiniz...\n\n" + ex.Message);
            }
        }

        private void UrunSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGvUrunler.SelectedRows.Count > 0)
                {
                    DialogResult sonuc = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.OK)
                    {
                        ProductDAL pDal = new ProductDAL();
                        foreach (DataGridViewRow row in dGvUrunler.SelectedRows)
                        {
                            pDal.Delete(dGvUrunler.SelectedRows[0].Cells[0].Value);

                            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Silinmiştir.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Ürün Seçiniz!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Ürünü 'Ürünler' Sekmesinden Listeleyip Ürün Seçiniz...\n\n" + ex.Message);
            }
        }

        private void KategoriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGvKategoriler.SelectedRows.Count > 0)
                {
                    DialogResult sonuc = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.OK)
                    {
                        CategoryDAL cDal = new CategoryDAL();
                        foreach (DataGridViewRow row in dGvKategoriler.SelectedRows)
                        {
                            cDal.Delete(dGvKategoriler.SelectedRows[0].Cells[0].Value);

                            MessageBox.Show("Kategoriniz Başarılı Bir Şekilde Silinmiştir.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Kategori Seçiniz!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Kategoriyi 'Kategoriler' Sekmesinden Listeleyip Kategori Seçiniz...\n\n" + ex.Message);
            }
        }
        #endregion

        #region ProductAndCategoriesSearch
        // Product Search
        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            ProductDAL pDal = new ProductDAL();
            dGvUrunler.DataSource = pDal.Search(txtUrunAra.Text);
        }
        // Category Search
        private void txtKategoriAra_TextChanged(object sender, EventArgs e)
        {
            CategoryDAL cDal = new CategoryDAL();
            dGvKategoriler.DataSource = cDal.Search(txtKategoriAra.Text);
        }
        #endregion

      
    }
}
