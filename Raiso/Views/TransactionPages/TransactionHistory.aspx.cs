using Raiso.Controller;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views.TransactionPages
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser loginUser = (MsUser)Session["User"];
            if (loginUser is null || loginUser.UserRole != "Customer")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            List<TransactionHeader> trHeadList = TrHeaderController.ConGetTrHeadByUserID(loginUser.UserID);

            var newList = from t in trHeadList
                            select new
                            {
                                t.TransactionID,
                                t.TransactionDate,
                                UserName = loginUser.UserName,
                            };
            GV_trHistory.DataSource = newList;
            GV_trHistory.DataBind();
        }

        protected void GV_trHistory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GV_trHistory.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text;
            Response.Redirect("~/Views/TransactionPages/TransactionDetailPage.aspx?id=" + id);
        }
    }
}