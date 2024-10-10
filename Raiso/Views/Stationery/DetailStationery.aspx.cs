using Raiso.Controller;
using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views.Stationery
{
    public partial class DetailStationery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            MsStationery stat = StationeryHandler.HanGetByID(id);
            StatName.Text = stat.StationeryName.ToString();
            StatPrice.Text = stat.StationeryPrice.ToString();

            MsUser User = (MsUser)Session["User"];
            if (User.UserRole == "Customer")
            {
                Btn_AddToCart.Visible = true;
            }
            else
            {
                Btn_AddToCart.Visible = false;
            }
        }

        protected void Btn_AddToCart_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["User"];
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string quantity = TBox_Quantity.Text;
            Lbl_Status.Text = CartController.ConCreateNewCart(user.UserID, id, quantity);
        }
    }
}