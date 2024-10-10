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
    public partial class InsertStationery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["User"];
            if(user == null || user.UserRole != "Admin")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string price = TBox_Price.Text;
            Lbl_Status.Text = StationeryController.ConCreateNewStationery(name, price);
        }
    }
}