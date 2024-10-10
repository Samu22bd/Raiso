using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Controller
{
    public class StationeryController
    {
        public static string ConCreateNewStationery(string name, string price)
        {
            if (name.Length < 3 || name.Length > 50 || name == "")
            {
                return "Name must be filled and between 3 – 50 characters";
            }
            else if (price == "" || !isNumeric(price))
            {
                return "Price must be filled and need to be numeric";
            }
            
            int pricenum = Convert.ToInt32(price);
            if (pricenum < 2000)
            {
                return "Price must be greater or equal to 2000";
            }
            return StationeryHandler.HanCreateNewStationery(name,pricenum);
        }

        public static string ConUpdateStationery(int id, string name, string price)
        {
            if(name.Length < 3 || name.Length > 50 || name=="")
            {
                return "Name must be filled and between 3 – 50 characters";
            }
            else if (price == "" || !isNumeric(price)) 
            {
                return "Price must be filled and need to be numeric";
            }

            int pricenum = Convert.ToInt32(price);
            if (pricenum < 2000)
            {
                return "Price must be greater or equal to 2000";
            }

            return StationeryHandler.HanUpdateByID(id, name, pricenum);
        }

        public static Boolean isNumeric(string price)
        {
            //return true if all integer
            return int.TryParse(price, out _);
        }

        public static List<MsStationery> ConGetStationeryByTrDet(List<TransactionDetail> trDetList)
        {
            return StationeryHandler.HanGetStationeryByTrDet(trDetList);
        }

        public static MsStationery ConGetByID(string id)
        {
            int integerID = Convert.ToInt32(id);
            return StationeryHandler.HanGetByID(integerID);
        }
        public static MsStationery ConGetID(int id)
        {
            int integerID = Convert.ToInt32(id);
            return StationeryHandler.HanGetByID(integerID);
        }
    }
}