using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Factory
{
    public class TrHeaderFactory
    {
        public static TransactionHeader FacCreateNewTrHeader(int userID, DateTime dt)
        {
            TransactionHeader trHead = new TransactionHeader();
            trHead.UserID = userID;
            trHead.TransactionDate = dt;
            return trHead;
        }
    }
}