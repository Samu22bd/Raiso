using Raiso.Controller;
using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views.Header
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Button btn_home = (Button)this.Page.Master.FindControl("Btn_Home");
            //btn_home.Visible = false;
            //if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            //{

            //    if (Session["user"] == null)
            //    {
            //        int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            //        MsUser userFromCookie = UserHandler.HanGetUserByID(id);
            //        Session["user"] = userFromCookie;
            //    }
            //    MsUser loginUser = (MsUser)Session["user"];

            //    if (loginUser.UserRole == "Admin")
            //    {
            //        Btn_Login.Visible = false;
            //        Btn_Register.Visible = false;
            //        Btn_Cart.Visible = false;
            //    }
            //    else if (loginUser.UserRole == "Customer")
            //    {
            //        Btn_Login.Visible = false;
            //        Btn_Register.Visible = false;
            //    }
            //}
            //else
            //{
            //    Btn_Cart.Visible = false;
            //    Btn_Transaction.Visible = false;
            //    Btn_Update.Visible = false;
            //    Btn_Logout.Visible = false;
            //}

            if (!IsPostBack)
            {
                String role = UserController.GetUserRole();
                switch (role)
                {
                    case "Admin":
                        Btn_Login.Visible = false;
                        Btn_Register.Visible = false;
                        Btn_Cart.Visible = false;
                        break;
                    case "Customer":
                        Btn_Login.Visible = false;
                        Btn_Register.Visible = false;
                        break;
                    case "Guest":
                        Btn_Cart.Visible = false;
                        Btn_Transaction.Visible = false;
                        Btn_Update.Visible = false;
                        Btn_Logout.Visible = false;
                        break;
                }
            }
        }

        protected void Btn_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Home.aspx");
        }

        protected void Btn_Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/CartPages/PageCart.aspx");
        }

        protected void Btn_Transaction_Click(object sender, EventArgs e)
        {
            String role = UserController.GetUserRole();
            if (role == "Customer")
            {
                Response.Redirect("~/Views/TransactionPages/TransactionHistory.aspx");
            }
            else if(role == "Admin")
            {
                Response.Redirect("~/Views/TransactionPages/TransactionReport.aspx");
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/UpdateProfile.aspx");
        }
        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            //if (Session["user"] != null)
            //{
            //    Session.Remove("user");
            //    HttpCookie cookie = Request.Cookies["user_cookie"];
            //    if (cookie != null)
            //    {
            //        cookie.Expires = DateTime.Now.AddDays(-1);
            //        Response.Cookies.Add(cookie);
            //    }
            //}

            //Response.Redirect("~/Views/Login.aspx");
            UserController.Logout();
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }
    }
}