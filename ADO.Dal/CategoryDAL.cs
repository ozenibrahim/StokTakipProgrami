using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Dal
{
    using DataAccessLayer;
    using Entity;
    using Common;
    using System.Data.SqlClient;
    public class CategoryDAL : DataAccessLayer<Category>
    {
        // Select, Insert, Update, Delete, Search Methods

        public override List<Category> List()
        {
            SqlProvider provider = new SqlProvider("Pr_CategoryList", true);

            SqlDataReader reader = provider.ExecuteReader();

            List<Category> categoryList = new List<Category>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Category category = new Category()
                    {
                        CategoryID = Convert.ToInt32(reader["CategoryID"].ToString()),
                        CategoryName = reader["CategoryName"].ToString(),
                        Description = reader["Description"].ToString()
                    };
                    categoryList.Add(category);
                }
            }
            reader.Close();
            return categoryList;


        }

        public override int Save(Category instance)
        {
            int sonuc = 0;
            SqlProvider provider = new SqlProvider("Pr_CategoryInsert", true);
          
            provider.AddParameter("@CategoryName", instance.CategoryName);
            provider.AddParameter("@Description", instance.Description);

            sonuc = provider.ExecuteNonQuery();
            return sonuc;
        }

        public override int Update(Category instance)
        {
            int sonuc = 0;
            SqlProvider provider = new SqlProvider("Pr_CategoryUpdate", true);
            provider.AddParameter("@CategoryID", instance.CategoryID);

            provider.AddParameter("@CategoryName", instance.CategoryName);
            provider.AddParameter("@Description", instance.Description);

            sonuc = provider.ExecuteNonQuery();
            return sonuc;
        }

        public override int Delete(object instanceId)
        {
            int sonuc = 0;
            SqlProvider provider = new SqlProvider("Pr_CategoryDelete", true);
            provider.AddParameter("@CategoryID", instanceId);
            sonuc = provider.ExecuteNonQuery();
            return sonuc;
        }

        public override List<Category> Search(string search)
        {
            SqlProvider provider = new SqlProvider("Pr_CategorySearch", true);
            provider.AddParameter("@CategoryName", search);
            SqlDataReader reader = provider.ExecuteReader();

            List<Category> categoryList = new List<Category>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Category category = new Category()
                    {
                        CategoryID = Convert.ToInt32(reader["CategoryID"]),
                        CategoryName=reader["CategoryName"].ToString(),
                        Description=reader["Description"].ToString()                         
                    };
                    categoryList.Add(category);
                }
            }
            reader.Close();
            return categoryList;
        }
    }
}
