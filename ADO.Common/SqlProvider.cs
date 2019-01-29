using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Common
{
    using System.Data;
    using System.Data.SqlClient;

    public class SqlProvider
    {
        // Bütün SQL sağlayıcılarım burada olacak.
        // SqlConnection, SqlCommand, Parameters, Connection, Execute işlemlerim burada 

        #region cnnAndcmd
        SqlConnection cnn;
        SqlCommand cmd;

        public SqlProvider(string commandText, bool isProcedure)
        {
            cnn = new SqlConnection(Tools.ConnectionString); //Tools ile bağlantımızı yaptık   
            cmd = new SqlCommand(commandText, cnn);

            // Burada cmd'mizin procedure mü yoksa Text(sorgu) mu olduğunu kontrol ettik.
            cmd.CommandType = isProcedure ? CommandType.StoredProcedure : CommandType.Text;
        }
        #endregion

        #region Parameters
        public void AddParameter(string parameterName, object value)
        {
            // Parametremizi verdik.
            cmd.Parameters.AddWithValue(parameterName, value);
        }
        #endregion

        #region ConnectionMethods
        public void OpenConnection()
        {
            // bağlantımız kapalıysa bağlantımızı açtık.
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }               
        }
        public void CloseConnection()
        {
            // bağlantımız açıksa bağlantımızı kapattık.
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }         
        }

        #endregion

        #region ExecuteMethods

        public SqlDataReader ExecuteReader()
        {
            OpenConnection();
            return cmd.ExecuteReader(); 
        }
        public int ExecuteNonQuery()
        {
            int result = -1;
            try
            {
                OpenConnection();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {              
                result = -1;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
        public object ExecuteScalar()
        {
            object result = null;
            try
            {
                OpenConnection();
                result = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                result = null;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
        #endregion

    }
}
