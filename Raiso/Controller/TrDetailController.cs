using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Controller
{
    public class TrDetailController
    {
        public static string ConCreateNewTrDetail(int trID, int statID, int quantity)
        {
            return TrDetailHandler.HanCreateNewTrDet(trID, statID, quantity);
        }

        public static List<TransactionDetail> ConGetAllTrDetByID(int trID)
        {
            return TrDetailHandler.HanGetAllTrDetByID(trID);
        }
    }
}