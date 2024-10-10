using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Controller
{
    public class TransactionConrtoller
    {
        public static List<TransactionHeader> GetAllTransaction()
        {
            return TransactionHandler.GetAllTransactions();
        }
    }
}