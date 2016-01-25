using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace library_management
{
    public class searching
    {
        public SqlDataAdapter search(string key)
        {
            //string sql = "select Books.BName as BName, Author.AName as AName , Books.Total_Copies as Total_Copies, Books.Available_copies as Available_copies from Books as Books, Books_Authors_rel, Books_Category,Author,Category where (Books.BName like '%" + key + "%' or Author.AName like '%" + key + "%' or Category.CName like '%" + key + "%') and (Books.BID = Books_Authors_rel.BID and Books.BID = Books_Category.BID and Author.AID = Books_Authors_rel.AID and Category.CID = Books_Category.CID)";

            //string sql = "select Books.BName , Author.AName , Books.Total_Copies , Books.Available_copies from Books as Books, Books_Authors_rel, Books_Category,Author,Category where (Books.BName like '%" + key + "%' or Author.AName like '%" + key + "%' or Category.CName like '%" + key + "%') and (Books.BID = Books_Authors_rel.BID and Books.BID = Books_Category.BID and Author.AID = Books_Authors_rel.AID and Category.CID = Books_Category.CID)";

            //string sql = "select BName , Authors, Total_Copies, Available_copies from [dbo].[Books]";

            string sql = "select * from [dbo].[Books] where (BName like '%" + key + "%' or Authors like '%" + key + "%' )";
            string conn_str = ConfigurationManager.ConnectionStrings["Library_management"].ConnectionString;
            SqlConnection connection = new SqlConnection(conn_str);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            return adapter;
        }
    }
}