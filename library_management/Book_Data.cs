using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace library_management
{
    public class Book_Data
    {
        public SqlCommand sqlconnection(string sql)
        {
            string conn_str = ConfigurationManager.ConnectionStrings["Library_management"].ConnectionString;
            SqlConnection connection = new SqlConnection(conn_str);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();

            return cmd;
        }



        public SqlDataReader Get_Book_Category()
        {
            string sql = "SELECT * FROM [dbo].Category";
            SqlCommand cmd = sqlconnection(sql);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public bool Save_category(string Cat)
        {
            string sql = "INSERT INTO [dbo].Category VALUES ('" + Cat + "')";

            SqlCommand cmd = sqlconnection(sql);
            cmd.ExecuteNonQuery();

            return true;
        }

        public SqlDataReader Get_Book_Publisher()
        {
            string sql = "SELECT * FROM [dbo].Publication";
            SqlCommand cmd = sqlconnection(sql);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public bool Save_Publisher(string pub)
        {
            string sql = "INSERT INTO [dbo].Publication VALUES ('" + pub + "')";

            SqlCommand cmd = sqlconnection(sql);
            cmd.ExecuteNonQuery();

            return true;
        }

        public bool Save_New_Book(Book_Tab_Model obj)
        {
            string sql = "INSERT INTO [dbo].Books VALUES ('"+obj.BName+"', '"+obj.Authors+"', '"+obj.CID+"', '"+obj.Info+"', '"+obj.PID+"', '"+obj.Total_Copies+"', '"+obj.Total_Copies+"')";

            SqlCommand cmd = sqlconnection(sql);
            cmd.ExecuteNonQuery();

            return true;
        }


    }
}