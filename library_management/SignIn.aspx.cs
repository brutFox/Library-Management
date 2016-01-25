using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace library_management
{
    public partial class SignIn : System.Web.UI.Page
    {
        public string userName = "";
        User_Data signin_data =  new User_Data();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn_btn_Click(object sender, EventArgs e)
        {
            User_Info obj = new User_Info();

            obj.UID = this.id_box.Text;
            obj.Password = this.pwd_box.Text;

            if (string.IsNullOrEmpty(this.id_box.Text))
                this.msg_lbl.Text = "Please enter ID";
            else if (string.IsNullOrEmpty(this.pwd_box.Text))
                this.msg_lbl.Text = "please enter password";

            else
            {
                

                SqlDataReader signin = signin_data.check_user(obj);
                if (signin.HasRows)
                {
                    while (signin.Read())
                    {
                        Session["user"] = signin.GetString(5);
                        Session["user_name"] = signin.GetString(2);
                        Session["user_id"] = signin.GetString(1);
                        Response.Write(userName);
                        switch (signin.GetString(5))
                        {
                            case "Librarian":
                                Response.Redirect("LibrarianProfile.aspx");
                                break;
                            case "Faculty":
                                Response.Redirect("User_Profile.aspx");
                                break;
                            case "Student":
                                Response.Redirect("User_Profile.aspx");
                                break;
                        }
                    }
                    
                }

                else
                {
                    this.msg_lbl.Text = "Invalid ID";
                }
            }

        }
    }
}