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
    public partial class PageCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser User = (MsUser)Session["User"];
            if (User is null || User.UserRole != "Customer")
            {
                Response.Redirect("~/Views/Home.aspx");
            }

            List<Cart> cartList = CartHandler.HanGetAllCartByUserID(User.UserID);
            List<MsStationery> statList = StationeryHandler.HanGetStationeryByCart(cartList);

            var mergeList = from c in cartList join s in statList on c.StationeryID equals s.StationeryID select new 
            { 
                s.StationeryID,
                s.StationeryName,
                s.StationeryPrice,
                c.Quantity
            };

            GV_CartList.DataSource = mergeList;
            GV_CartList.DataBind();

            if(cartList.Count == 0)
            {
                Btn_CheckOut.Visible = false;
            }
        }
        protected void GV_CartList_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            MsUser User = (MsUser)Session["User"];
            int userid = User.UserID;

            GridViewRow row = GV_CartList.Rows[e.RowIndex];
            int statid = Convert.ToInt32(row.Cells[0].Text);
            string name = row.Cells[1].Text;
            int price = Convert.ToInt32(row.Cells[2].Text);
            int quantity = Convert.ToInt32(row.Cells[3].Text);
            Response.Redirect("~/Views/CartPages/UpdateCart.aspx?userid=" + userid + "&statid=" + statid + "&name=" + name
                + "&price=" + price + "&quantity=" + quantity);
        }

        protected void GV_CartList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MsUser User = (MsUser)Session["User"];
            int userID = User.UserID;

            GridViewRow row = GV_CartList.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Lbl_Status.Text = "Deletion of id " + id.ToString() + CartHandler.HanDelCart(userID, id);
        }

        //protected void GV_CartList_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    //string tes = GV_CartList.SelectedRow.Cells[0].Text;
        //    GridViewRow row = GV_CartList.Rows[e.NewEditIndex];
        //    int id = Convert.ToInt32(row.Cells[0].Text);

        //}

        protected void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            MsUser User = (MsUser)Session["User"];
            int userID = User.UserID;

            GridView gv = GV_CartList;
            int trID = TrHeaderController.ConCreateNewTrHead(userID);

            foreach (GridViewRow row in gv.Rows)
            {
                int statID = Convert.ToInt32(row.Cells[0].Text);
                //insert into transaction history
                int quantity = Convert.ToInt32(row.Cells[3].Text);
                string statusTrDetail = TrDetailController.ConCreateNewTrDetail(trID, statID, quantity);
                Lbl_Status.Text = CartHandler.HanDelCart(userID, statID);
            }

            Response.Redirect("~/Views/Home.aspx");
        }
    }
}