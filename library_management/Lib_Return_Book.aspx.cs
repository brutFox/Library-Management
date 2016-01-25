using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace library_management
{
    

    public partial class Lib_Return_Book : System.Web.UI.Page
    {
        return_class rt = new return_class();
        BorrowData bd = new BorrowData();
        Borrow_Model bm = new Borrow_Model();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                profile_lbl.Text = Session["user_name"].ToString();
            }
        }

        protected void result_grid_OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void result_grid_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void result_grid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void result_grid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void result_grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BID_field.Value = result_grid.SelectedRow.Cells[0].Text;

            bm.BrID = int.Parse(this.BID_field.Value);

            if (rt.return_book(bm) && bd.BorrowCount_decrement(bm) && bd.Available_copies_increment(bm))
            {
                this.msg_lbl.Text = "Returned";
                databinding(uid_field.Value.ToString());
            }

        }

        protected void srch_btn_Click(object sender, EventArgs e)
        {
            string key = this.search_box.Text.ToString();
            
            databinding(key);
        }

        protected void databinding(string key)
        {
            return_class rt = new return_class();
            SqlDataReader rdr = rt.search_id_info(key);

            SqlDataReader reader = rt.search_borrow_tab(key);


            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    this.name_lbl.Text = rdr.GetString(2).ToString();
                    this.ID_lbl.Text = rdr.GetString(1).ToString();
                    this.acc_lbl.Text = rdr.GetString(5).ToString();
                }
            }

            result_grid.DataSource = reader;
            result_grid.DataBind();
        }

        protected void logout_btn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("HomePage.aspx");
        }

        protected void search_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("LibrarianProfile.aspx");
        }

        protected void add_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Librarian_Add_Books.aspx");
        }
    }
}