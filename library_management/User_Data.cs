using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace library_management
{
    public class User_Data
    {
        public SqlCommand sqlconnection(string sql)
        {
            string conn_str = ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString; ;
            SqlConnection connection = new SqlConnection(conn_str);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();

            return cmd;
        }

        public string save_user_info(User_Info u_obj)
        {
            try
            {
                string sql = "INSERT INTO [dbo].[User](UID,UName,UEmail,Password,UType) VALUES('" + u_obj.UID + "', '" + u_obj.UName + "', '" + u_obj.UEmail + "', '" + u_obj.Password + "', '" + u_obj.Account_Type + "')";

                SqlCommand cmd = sqlconnection(sql);

                
                cmd.ExecuteNonQuery();
                //connection.Close();
                return null;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            
        }

        public SqlDataReader check_user(User_Info obj)
        {
            string sql = "SELECT * FROM [dbo].[User] WHERE UID='" + obj.UID + "' AND Password='" + obj.Password + "'";
            SqlCommand cmd = sqlconnection(sql);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        
        }

        public SqlDataReader check_duplicate(User_Info obj)
        {
            string sql = "SELECT * FROM [dbo].[User] WHERE UID='" + obj.UID + "' OR UEmail='" + obj.UEmail + "'";
            SqlCommand cmd = sqlconnection(sql);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        
    }
}