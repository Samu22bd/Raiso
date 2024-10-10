using Raiso.Controller;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views.Stationery
{
    public partial class UpdateStationery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["User"];
            if (user == null || user.UserRole != "Admin")
            {
                Response.Redirect("~/Views/Home.aspx");
            }

            string id = Request.QueryString["id"].ToString();

            MsStationery upStationery = StationeryController.ConGetByID(id);
            TBox_OldName.Text = upStationery.StationeryName.ToString();
            TBox_OldPrice.Text = upStationery.StationeryPrice.ToString();
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string name = TBox_Name.Text;
            string price = TBox_Price.Text;
            Lbl_Status.Text = StationeryController.ConUpdateStationery(id, name, price);

        }
    }
}