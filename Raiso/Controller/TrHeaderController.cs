using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Controller
{
    public class TrHeaderController
    {
        public static int ConCreateNewTrHead(int userID)
        {
            DateTime dt = DateTime.Now;
            return TrHeaderHandler.HanCreateNewTrHead(userID, dt);
        }

        public static List<TransactionHeader> ConGetTrHeadByUserID(int userID)
        {
            return TrHeaderHandler.HanGetAllTrHeadByUserID(userID);
        }
    }
}