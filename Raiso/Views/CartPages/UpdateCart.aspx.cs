using Raiso.Controller;
using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views.CartPages
{
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MsUser User = (MsUser)Session["User"];
                if (User is null || User.UserRole != "Customer")
                {
                    Response.Redirect("~/Views/Home.aspx");
                }

                Lbl_StatName.Text = Request.QueryString["name"];
                Lbl_StatPrice.Text = Request.QueryString["price"];
                TBox_Quantity.Text = Request.QueryString["quantity"];
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Request.QueryString["userid"]);
            int statid = Convert.ToInt32(Request.QueryString["statid"]);

            string quantity = TBox_Quantity.Text;
            Lbl_Status.Text = CartController.ConUpdateCart(userid, statid, quantity);
        }
    }
}