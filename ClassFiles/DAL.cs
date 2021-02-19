using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicTrainingProject
{
    static class DAL
    {


        private static string connectionString = "Server=localhost;Database=MagicTraining;User Id=MagicAdmin; Password= admin";
        public static DataTable GetDataTable(string sqlQuery)
        {
            try
            {// retrieves
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(dataReader);
                            return dataTable;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0 || ex.Number == 17142)
                {
                    MessageBox.Show("Connection error, please dial 00-000000 for further assistens");
                    return null;
                }
                else if(ex.Number == 207 || ex.Number == 208)
                {
                     MessageBox.Show("Database error, please contact dial 00-000000 for further assistans");
                     return null;
                }
  
                else
                {
                    throw ex;                   
                }
             

            }
            
        }
        public static void SendData(string sqlQuery) //send sql queries for insert,update, delete
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))

                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0)
                {
                    MessageBox.Show("Connection error, please dial 00-000000 for further assistens");
                }
                else if (ex.Number == 207 || ex.Number == 208)
                {
                    MessageBox.Show("Database error, please contact dial 00-000000 for further assistans");
                }
                else
                {
                    throw ex;
                }
            }
        }



    }
}
