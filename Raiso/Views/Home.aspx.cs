using Raiso.Controller;
using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            //MsUser user = (MsUser)Session["user"];
            //if (user != null)
            //{
            //    if (user.UserRole == "Admin")
            //    {
            //        GV_StationeryList.Columns[3].Visible = false;
            //    }
            //    else if(user.UserRole == "Customer")
            //    {
            //        Btn_Insert.Visible = false;
            //        GV_StationeryList.Columns[4].Visible = false;
            //        GV_StationeryList.Columns[5].Visible = false;
            //    }
            //    else
            //    {
            //        GV_StationeryList.Columns[3].Visible = false;
            //        Btn_Insert.Visible = false;
            //        GV_StationeryList.Columns[4].Visible = false;
            //        GV_StationeryList.Columns[5].Visible = false;
            //    }
            //    Response.Redirect("~/Views/Home.aspx");
            //}

            //if (Session[
            //"] == null)
            //{
            //    Response.Redirect("~/Views/Login.aspx");
            //}
            if (!IsPostBack)
            {
                ManageVisibility();
            }

        }

        protected void RefreshGrid()
        {
            List<MsStationery> StationeryList = StationeryHandler.HanGetAllStationery();
            GV_StationeryList.DataSource = StationeryList;
            GV_StationeryList.DataBind();
        }

        private void ManageVisibility()
        {
            String role = UserController.GetUserRole();
            switch (role)
            {
                case "Admin":
                    GV_StationeryList.Columns[3].Visible = false;
                    break;
                case "Customer":
                    Btn_Insert.Visible = false;
                    GV_StationeryList.Columns[4].Visible = false;
                    GV_StationeryList.Columns[5].Visible = false;
                    break;

                case "Guest":
                    GV_StationeryList.Columns[3].Visible = false;
                    Btn_Insert.Visible = false;
                    GV_StationeryList.Columns[4].Visible = false;
                    GV_StationeryList.Columns[5].Visible = false;
                    break;
            }
        }

        protected void Selecting_Click(object sender, EventArgs e)
        {
            string id = GV_StationeryList.SelectedRow.Cells[0].Text;
            Response.Redirect("~/Views/Stationery/DetailStationery.aspx?id=" + id);
        }

        protected void Deleting_Click(object sender, GridViewDeleteEventArgs e)
        {

            GridViewRow row = GV_StationeryList.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Lbl_Status.Text = id + " deletion " + StationeryHandler.HanDeleteByID(id);
            RefreshGrid();
        }

        protected void Updating_Click(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GV_StationeryList.Rows[e.RowIndex];
            string id = row.Cells[0].Text;
            // query string url?key=value
            Response.Redirect("~/Views/Stationery/UpdateStationery.aspx?id=" + id);

        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Stationery/InsertStationery.aspx");
        }
    }
}