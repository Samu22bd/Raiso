using Raiso.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Controller
{
    public class CartController
    {
        public static string ConCreateNewCart(int userID, int statID, string quantity)
        {
            if(quantity == "" || !isNumeric(quantity))
            {
                return "Quantity must be filled and must be numeric";
            }

            int quantitynum = Convert.ToInt32(quantity);
            if(quantitynum < 1)
            {
                return "Quantity must more than 0";
            }

            return CartHandler.HanCreateNewCart(userID, statID, quantitynum);
        }
        public static Boolean isNumeric(string price)
        {
            //return true if all integer
            return int.TryParse(price, out _);
        }

        public static string ConUpdateCart(int userID, int statID, string quantity)
        {
            if(quantity == "" || !isNumeric(quantity)) 
            {
                return "Quantity must be filled and/or numeric";
            }

            int quantitynum = Convert.ToInt32(quantity);
            if(quantitynum < 1)
            {
                return "Quanity must be more than 0";
            }

            return CartHandler.HanUpdateCart(userID, statID, quantitynum);
        }
    }
}