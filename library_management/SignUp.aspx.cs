using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace library_management
{
    public partial class SignUp : System.Web.UI.Page
    {
        User_Data data = new User_Data();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_btn_Click(object sender, EventArgs e)
        {
            User_Info u_obj = new User_Info();

            u_obj.UName = this.Name_box.Text.ToString();
            u_obj.UID = this.ID_box.Text.ToString();
            u_obj.UEmail = this.email_box.Text.ToString();
            u_obj.Account_Type = this.Acc_type_radio.SelectedItem.Text.ToString();
            u_obj.Password = this.pwd_box.Text.ToString();

            SqlDataReader reader = data.check_duplicate(u_obj);

            if (reader.HasRows)
            {
                warning_lbl.Text = "This ID or Email is already registered";
            }
            else
            {
                data.save_user_info(u_obj);
                Response.Redirect("SignIn.aspx");
            }
        }
    }
}