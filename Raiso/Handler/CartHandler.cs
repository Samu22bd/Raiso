using Raiso.Factory;
using Raiso.Model;
using Raiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Handler
{
    public class CartHandler
    {
        public static string HanCreateNewCart(int userID, int statID, int quantity)
        {
            Cart newCart = CartFactory.FacCreateNewCart(userID, statID, quantity);
            string rep = CartRepository.RepCreateNewCart(newCart);
            return rep;
        }

        public static List<Cart> HanGetAllCartByUserID(int id)
        {
            List<Cart> cartList = CartRepository.RepGetAllCartByUserID(id);

            return cartList;
        }

        public static string HanDelCart(int userID, int id)
        {
            return CartRepository.RepDelCart(userID, id);
        }

        public static string HanUpdateCart(int userID, int statID, int quantity)
        {
            return CartRepository.RepUpdateCart(userID, statID, quantity);
        }
    }
}