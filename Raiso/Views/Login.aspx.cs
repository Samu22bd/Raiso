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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }

        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string password = TBox_Password.Text;
            bool rememberMe = Check_RememberMe.Checked;

            string result = UserController.ConLoginUser(name, password, rememberMe);
            if (result == "Success")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            else
            {
                Lbl_Status.Text = result;
            }

            //MsUser loginUser = UserController.ConLoginUser(name, password, rememberMe);
            //if (loginUser != null)
            //{
            //    Session["user"] = loginUser;
            //    if(rememberMe)
            //    {
            //        Http
            //        cookie = new HttpCookie("user_cookie");
            //        cookie.Value = loginUser.UserID.ToString();
            //        cookie.Expires.AddHours(8);
            //        Response.Cookies.Add(cookie);
            //    }
            //    Response.Redirect("~/Views/Home.aspx");
            //}
            //else
            //{
            //    Lbl_Status.Text =
            //    not found";
            //}
        }

        protected void LinkBtn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }
    }
}