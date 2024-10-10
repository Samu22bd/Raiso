using Raiso.Controller;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] != null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            //MsUser user = (MsUser)Session["user"];
            //if(user != null)
            //{
            //    Response.Redirect("~/Views/Home.aspx");
            //}
        }
        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string DOB = Tbox_dob.Text;
            string gender = GenderRadioButton.SelectedValue;
            string address = TBox_Address.Text;
            string password = TBox_Password.Text;
            string phone = TBox_Phone.Text;

            Lbl_Status.Text = UserController.ConRegisterUser(name, DOB, gender, address, password, phone);
        }

        protected void LinkBtn_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}