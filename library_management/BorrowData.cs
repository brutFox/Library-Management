using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace library_management
{
    public class BorrowData
    {
        public SqlCommand sqlconnection(string sql)
        {
            string conn_str = ConfigurationManager.ConnectionStrings["Library_management"].ConnectionString;
            SqlConnection connection = new SqlConnection(conn_str);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();

            return cmd;
        }

        public string validID(Borrow_Model obj)
        {
            string sql = "Select * from [dbo].[User] WHERE UID='" + obj.UID + "'";
            SqlCommand cmd = sqlconnection(sql);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (int.Parse(reader.GetValue(6).ToString()) >= 3)
                    {
                        return "The ID has already 3 books pending to return";
                    }
                    else
                    {
                        return "ok";
                    }
                }

            }
            else
            {
                return "Invalid ID";
            }
            return "corrupted";
        }

        public bool check_available_books(Borrow_Model obj)
        {
            string sql = " SELECT * FROM [dbo].[Books] WHERE BID = " + obj.BID + "";
            SqlCommand cmd = sqlconnection(sql);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (int.Parse(reader.GetValue(7).ToString()) <= 1)
                        return false;
                    else
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool IssueBook(Borrow_Model obj)
        {
            string sql = "INSERT INTO [dbo].[Borrow] (UID, BID, Issued) VALUES ('" + obj.UID + "', " + obj.BID + ",'" + obj.Issued + "')";
            SqlCommand cmd = sqlconnection(sql);

            cmd.ExecuteNonQuery();

            return true;
        }

        public bool BorrowCount_increment(Borrow_Model obj)
        {
            string sql = " UPDATE [dbo].[User] SET BorrowCount += '" + 1 + "' WHERE UID ='"+obj.UID+"' ";
            SqlCommand cmd = sqlconnection(sql);

            cmd.ExecuteNonQuery();
            return true;
        }

        public bool BorrowCount_decrement(Borrow_Model obj)
        {
            string sql = " UPDATE [dbo].[User] SET BorrowCount -= '" + 1 + "' WHERE UID ='" + obj.UID + "' ";
            SqlCommand cmd = sqlconnection(sql);

            cmd.ExecuteNonQuery();
            return true;
        }

        public bool Available_copies_increment(Borrow_Model obj)
        {
            string sql = " UPDATE [dbo].[Books] SET Available_copies += '" + 1 + "' WHERE BID =" + obj.BID + "  ";
            SqlCommand cmd = sqlconnection(sql);

            cmd.ExecuteNonQuery();
            return true;
        }

        public bool Available_copies_decrement(Borrow_Model obj)
        {
            string sql = " UPDATE [dbo].[Books] SET Available_copies -= '" + 1 + "' WHERE BID="+ obj.BID +"  ";
            SqlCommand cmd = sqlconnection(sql);

            cmd.ExecuteNonQuery();
            return true;
        }
    }


}