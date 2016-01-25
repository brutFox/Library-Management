using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace library_management
{
    public partial class User_Profile : System.Web.UI.Page
    {
        BorrowData bd = new BorrowData();
        Borrow_Model bm = new Borrow_Model();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    profile_lbl.Text = Session["user_name"].ToString();
                }

                bm.user_id = Session["user_id"].ToString();

                
                return_class rt = new return_class();
                
                SqlDataReader reader = rt.search_data_for_user(bm);

                if (reader.HasRows)
                {
                    History_Grid.DataSource = reader;
                    History_Grid.DataBind();
                }
                else
                {
                    this.msg_lbl.Text = "No history found";
                }


            }
        }

        protected void logout_btn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("HomePage.aspx");
        }
    }
}