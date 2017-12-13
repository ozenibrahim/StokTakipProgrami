using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Dal
{
    using DataAccessLayer; // Klasörüm.
    using Entity;
    using Common;
    using System.Data.SqlClient;

    public class ProductDAL : DataAccessLayer<Product>
    {
        // Select, Insert, Update, Delete, Search Methods

        public override List<Product> List()
        {
            SqlProvider provider = new SqlProvider("Pr_ProductList", true);

            SqlDataReader reader = provider.ExecuteReader();

            List<Product> productList = new List<Product>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"].ToString()),
                        ProductName = reader["ProductName"].ToString(),
                        CategoryID = Convert.ToInt32(reader["CategoryID"].ToString()),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"].ToString()),
                        UnitsInStock = Convert.ToInt32(reader["UnitsInStock"].ToString())
                    };
                    productList.Add(product);
                }
            }
            reader.Close();
            return productList;
        }

        public override int Save(Product instance)
        {
             int sonuc = 0;
                SqlProvider provider = new SqlProvider("Pr_ProductInsert", true);
                provider.AddParameter("@ProductName", instance.ProductName);
                provider.AddParameter("@CategoryID", instance.CategoryID);
                provider.AddParameter("@UnitPrice", instance.UnitPrice);
                provider.AddParameter("@UnitsInStock", instance.UnitsInStock);

                sonuc = provider.ExecuteNonQuery();
                return sonuc;         
        }

        public override int Update(Product instance)
        {
            int sonuc = 0;
            SqlProvider provider = new SqlProvider("Pr_ProductUpdate", true);
            provider.AddParameter("@ProductID", instance.ProductID);

            provider.AddParameter("@ProductName", instance.ProductName);
            provider.AddParameter("@CategoryID", instance.CategoryID);
            provider.AddParameter("@UnitPrice", instance.UnitPrice);
            provider.AddParameter("@UnitsInStock", instance.UnitsInStock);

            sonuc = provider.ExecuteNonQuery();
            return sonuc;
        }

        public override int Delete(object instanceId)
        {
            int sonuc = 0;
            SqlProvider provider = new SqlProvider("Pr_ProductDelete", true);
            provider.AddParameter("@ProductID", instanceId);           
            sonuc = provider.ExecuteNonQuery();
            return sonuc;
        }       

        public override List<Product> Search(string search)
        {
            SqlProvider provider = new SqlProvider("Pr_ProductSearch", true);
            provider.AddParameter("@ProductName", search);
            SqlDataReader reader = provider.ExecuteReader();

            List<Product> productList = new List<Product>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {           
                        ProductID= Convert.ToInt32(reader["ProductID"].ToString()),
                        ProductName = reader["ProductName"].ToString(),
                        CategoryID = Convert.ToInt32(reader["CategoryID"].ToString()),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"].ToString()),
                        UnitsInStock = Convert.ToInt32(reader["UnitsInStock"].ToString())
                    };
                    productList.Add(product);
                }
            }
            reader.Close();
            return productList;
        }
    }
}
