using AdapterPattern.Configarations;
using Configarations.Configarations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdapterPattern.DBOperations
{
    public class Adaptee<T> where T : class
    {
        private readonly IMSSQLConn mssqlConn = null;
        private SqlConnection sqlConnection = null;
        public Adaptee()
        {
            mssqlConn = new MSSQLConn();
            sqlConnection = mssqlConn.connMSSQLDB;
        }

        public List<T> GetDBData(string tableName)
        {
            SqlDataReader myReader = null;
            List<T> list = new List<T>();

            try
            {
                sqlConnection.Open();
                using (SqlCommand myCommand = new SqlCommand("select * from " + tableName + "", sqlConnection))
                {
                    myReader = myCommand.ExecuteReader();
                }

                list = myReader.DataReaderToList<T>();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            sqlConnection.Close();

            return list;
        }

        public SqlDataReader GetDBReaderData(string tableName)
        {
            SqlDataReader myReader = null;
            try
            {
                sqlConnection.Open();
                using (SqlCommand myCommand = new SqlCommand("select * from " + tableName + "", sqlConnection))
                {
                    myReader = myCommand.ExecuteReader();
                }                
            }
            catch (Exception ex)
            {               
                Console.WriteLine(ex.Message);
            }
            sqlConnection.Close();

            return myReader;
        }

    }
}
