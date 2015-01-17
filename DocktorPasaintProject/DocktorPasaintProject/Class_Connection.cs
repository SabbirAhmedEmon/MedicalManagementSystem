using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DocktorPasaintProject
{
    public class Class_Connection
    {
        public SqlConnection Conn;

        public SqlConnection GetConnection()
        {
            string connnection = ConfigurationManager.ConnectionStrings["SQLDB"].ToString();
            Conn = new SqlConnection(connnection);
            //Conn.ConnectionTimeout;
            Conn.Open();
            return Conn;
        }

        public void Close()
        {
            if (Conn != null)
            {
                Conn.Close();
            }
        }

    }
}