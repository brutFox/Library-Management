using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;

namespace library_management
{
    public partial class LibrarianProfile : System.Web.UI.Page
    {
        SignIn user = new SignIn();
        Borrow_Model bm = new Borrow_Model();
        BorrowData bd = new BorrowData();

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                profile_lbl.Text = Session["user_name"].ToString();
            }
            
        }

        protected void logout_btn_Click1(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("HomePage.aspx");

        }

        protected void srch_btn_Click(object sender, EventArgs e)
        {
           string key = this.search_box.Text.ToString();
           databinding(key);
            
        }

        public void databinding(string key)
        {
            searching s = new searching();
            SqlDataAdapter adapter = s.search(key);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Books");
            ds.Tables["Books"].PrimaryKey = new DataColumn[] { ds.Tables["Books"].Columns["BID"] };
            result_grid.DataSource = ds.Tables["Books"];
            result_grid.DataBind(); 
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
                //Response.Write(result_grid.SelectedRow.Cells[0].Text);
            //this.bid = int.Parse(result_grid.SelectedRow.Cells[0].Text);
            this.bid_field.Value = result_grid.SelectedRow.Cells[0].Text;
            this.Bname_field.Value = result_grid.SelectedRow.Cells[1].Text;

            this.Label1.Visible = true;
            this.ID_box.Visible = true;
            this.issue_book_btn.Visible = true;


        }

        

        protected void search_btn_Click(object sender, EventArgs e)
        {
            
        }

        protected void add_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Librarian_Add_Books.aspx");
        }

        protected void issue_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lib_Return_Book.aspx");        
        }

        protected void issue_book_btn_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                if (string.IsNullOrEmpty(this.ID_box.Text))
                    this.id_msg.Text = "Valid ID is required";

                else
                {
                    //Response.Write(bm.ToString());
                    bm.UID = this.ID_box.Text;
                    bm.BID = int.Parse(this.bid_field.Value);
                    bm.Issued = DateTime.Now;

                    string msg = bd.validID(bm);

                    //Response.Write(msg);

                    if (msg == "ok")
                    {
                        
                        if (bd.check_available_books(bm))
                        {
                            
                            
                            if (bd.BorrowCount_increment(bm) && bd.Available_copies_decrement(bm))
                            {
                                
                                if (bd.IssueBook(bm))
                                {
                                    this.msg_lbl.Text = "Issued";
                                    databinding(this.Bname_field.Value.ToString());
                                }
                                else
                                {
                                    this.msg_lbl.Text = "Something wrong";
                                }
                            }
                            else
                            {
                                this.msg_lbl.Text = "Something went wrong"; 
                            }
                            
                        }
                        else
                        {
                            this.msg_lbl.Text = "At least 1 book should remain in library";
                        }
                    }
                    else
                    {
                        this.msg_lbl.Text = msg;
                    }

                    
                }

            }
        }

        
        

       
    }
}