using Raiso.Factory;
using Raiso.Model;
using Raiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Handler
{
    public class TrHeaderHandler
    {
        public static int HanCreateNewTrHead(int userID, DateTime dt)
        {
            TransactionHeader trHead = TrHeaderFactory.FacCreateNewTrHeader(userID, dt);
            return TrHeaderRepository.RepCreateNewTrHead(trHead);
        }

        public static List<TransactionHeader> HanGetAllTrHeadByUserID(int userID)
        {
            return TrHeaderRepository.RepGetAllTrHeadByUserID(userID);
        }
    }
}