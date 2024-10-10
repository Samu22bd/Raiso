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
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MsUser User = (MsUser)Session["User"];
            if (User == null || User.UserRole != "Customer")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            int id = Convert.ToInt32(Request.QueryString["id"]);
            List<TransactionDetail> trDetList = TrDetailController.ConGetAllTrDetByID(id);
            List<MsStationery> statList = StationeryController.ConGetStationeryByTrDet(trDetList);
            var mergeList = from t in trDetList join s in statList on t.StationeryID equals s.StationeryID select new 
            { 
                s.StationeryName,
                s.StationeryPrice,
                t.Quantity
            };


            GV_TransactionDetail.DataSource = mergeList;
            GV_TransactionDetail.DataBind();
        }
    }
}