using Raiso.Model;
using Raiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Handler
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> GetAllTransactions()
        {
            return TransactionRepo.GetAllTransaction();
        }
    }
}