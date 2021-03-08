using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleDataReader
{


    public class CRUD
    {
        private static int CONTADOR = 0;

        private static string connectionString { get { return Configuration.ConnectionStringsSql; } }


        public static DbDataReader ExecuteReader(string strSQL)
        {


            DbDataReader dr = null;

            using (DbCommand cmd = new SqlConnection(connectionString).CreateCommand())
            {
                cmd.Connection.Open();
                cmd.CommandText = strSQL;

                dr = cmd.ExecuteReader();

                // conectado = true, o banco de dados fica CONECTADO durante a leitura do DataReader
                // conetado = false, o banco de dados fica DESCONECTADO durante a leitura do DataReader
                bool conectado = true;

                if (!conectado)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dr.Close();
                    dr = null;

                    dr = dt.CreateDataReader();
                    dt = null;
                    cmd.Connection.Close();
                    cmd.Connection = null;
                }

            }

            return dr;
        }


        public static int ExecuteNonQuery(string strSQL)
        {
            int _return = 0;

            using (DbCommand cmd = new SqlConnection(connectionString).CreateCommand())
            {
                cmd.Connection.Open();
                cmd.CommandText = strSQL;

                _return = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return _return;
        }

    }
}
