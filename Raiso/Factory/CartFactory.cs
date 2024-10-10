using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Factory
{
    public class CartFactory
    {
        public static Cart FacCreateNewCart(int userID, int statID, int quantity)
        {
            Cart newCart = new Cart();
            newCart.UserID = userID;
            newCart.StationeryID = statID;
            newCart.Quantity = quantity;
            return newCart;
        }
    }
}