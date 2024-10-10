using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Factory
{
    public class TrDetailFactory
    {
        public static TransactionDetail FacCreateNewTrDetail(int trID, int statID, int quantity)
        {
            TransactionDetail trDet = new TransactionDetail();
            trDet.TransactionID = trID;
            trDet.StationeryID = statID;
            trDet.Quantity = quantity;
            return trDet;
        }
    }
}