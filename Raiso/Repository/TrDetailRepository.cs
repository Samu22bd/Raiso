using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Repository
{
    public class TrDetailRepository
    {
        public static string RepCreateNewTrDet(TransactionDetail trDet)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.TransactionDetails.Add(trDet);
            db.SaveChanges();
            return "Success";
        }

        public static List<TransactionDetail> RepGetAllTrDetByID(int trID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<TransactionDetail> trDetList = db.TransactionDetails.Where(x => x.TransactionID == trID).ToList();
            return trDetList;
        }
        public static List<TransactionDetail> getall()
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<TransactionDetail> TdAll = db.TransactionDetails.ToList();
            return TdAll;
        }
    }
}