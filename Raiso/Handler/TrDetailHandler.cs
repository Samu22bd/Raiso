using Raiso.Factory;
using Raiso.Model;
using Raiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Handler
{
    public class TrDetailHandler
    {
        public static string HanCreateNewTrDet(int trID, int statID, int quantity)
        {
            TransactionDetail trDet = TrDetailFactory.FacCreateNewTrDetail(trID, statID, quantity);
            return TrDetailRepository.RepCreateNewTrDet(trDet);
        }

        public static List<TransactionDetail> HanGetAllTrDetByID(int trID)
        {
            return TrDetailRepository.RepGetAllTrDetByID(trID);
        }
        public static List<TransactionDetail> getAll() 
        { 
            return TrDetailRepository.getall(); 
        }
    }
}