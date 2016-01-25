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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        private void LoadDataFromCache()
        {
            DataSet ds = (DataSet)Cache["DATASET"];
            //gridviewStudents.DataSource = ds.Tables["Students"];
            //gridviewStudents.DataBind();
        }

        protected void Search_btn_Click(object sender, EventArgs e)
        {
            string key = this.search_box.Text.ToString();
            searching s = new searching();
            SqlDataAdapter adapter = s.search(key);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            
            
            DataSet ds = new DataSet();
            //adapter.Fill(ds, "Books");
            adapter.Fill(ds, "Books");
            ds.Tables["Books"].PrimaryKey = new DataColumn[] { ds.Tables["Books"].Columns["BID"] };
            result_grid.DataSource = ds.Tables["Books"];
            result_grid.DataBind();
        }

        protected void register_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void SignIn_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }

      
    }
}