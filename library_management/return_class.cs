using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace library_management
{
    public class return_class
    {
        public SqlCommand sqlconnection(string sql)
        {
            string conn_str = ConfigurationManager.ConnectionStrings["Library_management"].ConnectionString;
            SqlConnection connection = new SqlConnection(conn_str);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();

            return cmd;
        }

        public SqlDataReader search_id_info(string key)
        {
            string sql = "select * from [dbo].[User] where UID='"+key+"'";
            SqlCommand cmd = sqlconnection(sql);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader search_borrow_tab(string key)
        {
            //string sql1 = "UPDATE [dbo].[Borrow] SET Fine += '""'";

            

            string sql = "select Borrow.BrID AS BrID, Borrow.BID AS BID, Borrow.Issued AS Issued, Borrow.Returned AS Returned, Borrow.Fine AS FINE, Books.BName AS BName from [dbo].[Borrow] JOIN [dbo].[Books] ON Borrow.BID = Books.BID where Borrow.UID = '" + key + "' ";
            
            
            //string sql = "SELECT ";
            //string sql = "select * from [dbo].[Borrow] where UID='" + key + "'";
            string conn_str = ConfigurationManager.ConnectionStrings["Library_management"].ConnectionString;
            SqlConnection connection = new SqlConnection(conn_str);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader search_data_for_user(Borrow_Model obj)
        {
            string sql = "SELECT  Borrow.BrID AS BrID, Borrow.BID AS BID, Borrow.Issued AS Issued, Books.BName AS BName FROM [dbo].[Borrow] JOIN [dbo].[Books] ON Borrow.BID = Books.BID WHERE UID = '" + obj.user_id + "'";
            
            string conn_str = ConfigurationManager.ConnectionStrings["Library_management"].ConnectionString;
            SqlConnection connection = new SqlConnection(conn_str);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public bool return_book(Borrow_Model obj)
        {
            string y = "Yes";
            string sql = " update [dbo].[Borrow] set Returned = '"+DateTime.Now+"' , IsReturned = '"+y+"' where BrID = "+ obj.BrID +" ";

            SqlCommand cmd = sqlconnection(sql);

            cmd.ExecuteNonQuery();
            return true;
            
        }

        
    }
}