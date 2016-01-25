using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace library_management
{
    public partial class Librarian_Add_Books : System.Web.UI.Page
    {
        Book_Data bd = new Book_Data();
        Book_Tab_Model obj = new Book_Tab_Model();
        //BorrowData b_data = new BorrowData();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                this.profile_lbl.Text = Session["user_name"].ToString();
            }

            if (!IsPostBack)
            {
                SqlDataReader cat = bd.Get_Book_Category();
                SqlDataReader pub = bd.Get_Book_Publisher();
                
                if (cat.HasRows)
                {
                    category_list.DataSource = cat;
                    category_list.DataTextField = "CName";
                    category_list.DataValueField = "CID";
                    category_list.DataBind();
                }

                if (pub.HasRows)
                {
                    publisher_list.DataSource = pub;
                    publisher_list.DataTextField = "PName";
                    publisher_list.DataValueField = "PID";
                    publisher_list.DataBind();
                }
            }
        }

        protected void Add_Books_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.BookNm_txt.Text) && string.IsNullOrEmpty(this.auth_txt.Text) &&
                string.IsNullOrEmpty(this.copies_txt.Text) && category_list.SelectedValue=="" && publisher_list.SelectedValue=="")
            {
                this.msg_lbl.Text = "Please insert all the values";
                
            }

            else
            {
                if (string.IsNullOrEmpty(this.BookNm_txt.Text))
                    this.bk_msg.Text = "Book name is required";
                else if (string.IsNullOrEmpty(this.auth_txt.Text))
                    this.auth_msg.Text = "Author(s) is required";
                else if (string.IsNullOrEmpty(this.copies_txt.Text))
                    this.cpy_msg.Text = "Numbers of copies is required";

                else
                {
                    obj.BName = this.BookNm_txt.Text;
                    obj.Authors = this.auth_txt.Text;
                    obj.Total_Copies = int.Parse(this.copies_txt.Text);
                    obj.CID = int.Parse(Request.Form[category_list.UniqueID]);
                    obj.PID = int.Parse(Request.Form[publisher_list.UniqueID]);
                    obj.Info = this.info_txt.Text;

                    if (bd.Save_New_Book(obj))
                    {
                        this.msg_lbl.Text = "Added Successfully";
                    }
                    else
                    {
                        this.msg_lbl.Text = "Something went wrong!";
                    }


                }
            }
        }

        protected void Add_Cat_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cat_txt.Text))
            {
                this.Cat_lbl.Text = "Category Name is required";
            }
            else
            {
                if (bd.Save_category(this.cat_txt.Text) == true)
                {
                    this.Cat_lbl.Text = "Category Added";
                }
                else
                {
                    this.Cat_lbl.Text = "Something went wrong !";
                }
            }
        }

        protected void Add_Pub_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.pub_txt.Text))
            {
                this.Pub_lbl.Text = "Publisher's name is required";

            }
            else
            {
                if (bd.Save_Publisher(this.pub_txt.Text) == true)
                {
                    this.Pub_lbl.Text = "Publisher Added";
                }
                else
                {
                    this.Pub_lbl.Text = "Something went wrong !";
                }
            }
        }

        protected void search_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("LibrarianProfile.aspx");
        }

        protected void logout_btn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("HomePage.aspx");
        }

        protected void return_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lib_Return_Book.aspx");
        }
    }
}