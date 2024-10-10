using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Repository
{
    
    public class TransactionRepo
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static List<TransactionHeader> GetAllTransaction()
        {
            var AllTransaction = db.TransactionHeaders.ToList();
            return AllTransaction;
        }
    }
}