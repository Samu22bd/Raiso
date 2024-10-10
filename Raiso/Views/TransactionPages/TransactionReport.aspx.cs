using Raiso.Controller;
using Raiso.Dataset;
using Raiso.Handler;
using Raiso.Model;
using Raiso.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views.TransactionPages
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser User = (MsUser)Session["User"];
            if (User == null || User.UserRole != "Admin")
            {
                Response.Redirect("~/Views/Home.aspx");
            }


            var report = new CrystalReport1();
            var datasets = new DataSet1();
            var header = datasets.TransactionHeader;
            var detail = datasets.TransactionDetail;

            var transactions = TransactionConrtoller.GetAllTransaction();

            foreach (var transaction in transactions)
            {
                var newHeader = header.NewRow();
                newHeader["TransactionID"] = transaction.TransactionID;
                newHeader["TransactionDate"] = transaction.TransactionDate;
                newHeader["userID"] = transaction.UserID;

                int GrandTotal = 0; //add this

                List<TransactionDetail> trDetList = TrDetailController.ConGetAllTrDetByID(transaction.TransactionID);
                foreach (var transactionDetail in trDetList)
                {
                    MsStationery ms = StationeryController.ConGetID(transactionDetail.StationeryID);
                    int ItemPrice = transactionDetail.Quantity * ms.StationeryPrice;
                    GrandTotal += ItemPrice;

                    var newDetail = detail.NewRow();

                    newDetail["TransactionID"] = transactionDetail.TransactionID;
                    newDetail["StationeryName"] = ms.StationeryName;
                    newDetail["StationeryPrice"] = ms.StationeryPrice;
                    newDetail["Quantity"] = transactionDetail.Quantity;
                    newDetail["SubTotalValue"] = ItemPrice;
                    detail.Rows.Add(newDetail);
                }
                newHeader["GrandTotalValue"] = GrandTotal;
                // Grand Total value
                header.Rows.Add(newHeader);
            }
            CrystalReportViewer1.ReportSource = report;
            report.SetDataSource(datasets);
        }
    }
}