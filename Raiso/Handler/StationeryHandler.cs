using Raiso.Factory;
using Raiso.Model;
using Raiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace Raiso.Handler
{
    public class StationeryHandler
    {
        public static string HanCreateNewStationery(string name, int price)
        {
            MsStationery stationery = StationeryFactory.FacCreateNewStationery(name, price);
            string rep = StationeryRepository.RepCreateNewStationery(stationery);
            return rep;
        }

        public static MsStationery HanGetByID(int id)
        {
            return StationeryRepository.RepGetByID(id);
        }
        public static List<MsStationery> HanGetAllStationery()
        {
            return StationeryRepository.RepGetAllStationery();
        }

        public static string HanUpdateByID(int id, string name, int price)
        {
            return StationeryRepository.RepUpdateByID(id, name, price);
        }

        public static string HanDeleteByID(int id)
        {
            return StationeryRepository.RepDeleteByID(id);
        }

        public static List<MsStationery> HanGetStationeryByCart(List<Cart> cartList)
        {
            List<MsStationery> stationeryList = new List<MsStationery>();
            foreach (Cart cart in cartList)
            {
                int statid = cart.StationeryID;
                MsStationery ms = HanGetByID(statid);
                stationeryList.Add(ms);
            }
            return stationeryList;
        }

        public static List<MsStationery> HanGetStationeryByTrDet(List<TransactionDetail> trDetList)
        {
            List<MsStationery> stationeryList = new List<MsStationery>();
            foreach (TransactionDetail td in trDetList)
            {
                int statid = td.StationeryID;
                MsStationery ms = HanGetByID(statid);
                stationeryList.Add(ms);
            }
            return stationeryList;
        }
    }
}