using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace library_management
{
    public partial class Lib_Issue_Books : System.Web.UI.Page
    {
        Borrow_Model bm=new Borrow_Model();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                if (string.IsNullOrEmpty(this.id_box.Text))
                    this.id_msg.Text = "Valid ID is required";
                else if (string.IsNullOrEmpty(this.book_box.Text))
                    this.bk_msg.Text = "Book name is required";

                else
                {
                    bm.UID = this.id_box.Text;
                    //bm.BID = 
                }
            }
        }
    }
}