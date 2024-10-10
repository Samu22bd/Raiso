using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Repository
{
    public class CartRepository
    {
        public static string RepCreateNewCart(Cart newCart)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.Carts.Add(newCart);
            db.SaveChanges();
            return "Success";
        }

        public static List<Cart> RepGetAllCartByUserID(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<Cart> cartList = db.Carts.Where(x => x.UserID == id).ToList();
            return cartList;
        }

        public static string RepDelCart(int userID, int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            Cart delCart = db.Carts.Where(x => x.UserID == userID && x.StationeryID==id).FirstOrDefault();
            db.Carts.Remove(delCart);
            db.SaveChanges();
            return "Success";
        }

        public static string RepUpdateCart(int userID, int statID, int quantity)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            Cart updateCart = db.Carts.Where(x => x.UserID == userID && x.StationeryID == statID).FirstOrDefault();
            updateCart.Quantity = quantity;
            db.SaveChanges();
            return "Success";
        }
    }
}