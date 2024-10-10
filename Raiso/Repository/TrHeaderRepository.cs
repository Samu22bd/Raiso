using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Repository
{
    public class TrHeaderRepository
    {
        public static int RepCreateNewTrHead(TransactionHeader trHead)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.TransactionHeaders.Add(trHead);
            db.SaveChanges();
            return trHead.TransactionID;
        }
        
        public static List<TransactionHeader> RepGetAllTrHeadByUserID(int UserID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<TransactionHeader> trHeadList = db.TransactionHeaders.Where(x => x.UserID == UserID).ToList();
            return trHeadList;
        }
    }
}