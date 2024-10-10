using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace Raiso.Repository
{
    public class StationeryRepository
    {
        public static string RepCreateNewStationery(MsStationery stationery)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.MsStationeries.Add(stationery);
            db.SaveChanges();
            return "Success";
        }

        public static List<MsStationery> RepGetAllStationery() 
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<MsStationery> stationeryList = db.MsStationeries.ToList();
            return stationeryList;
        }
        
        public static MsStationery RepGetByID(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            return db.MsStationeries.Find(id);
        }
        public static string RepUpdateByID(int id, string name, int price)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsStationery upStat = db.MsStationeries.Find(id);
            upStat.StationeryName = name;
            upStat.StationeryPrice = price;
            db.SaveChanges();
            return "Success";
        }

        public static string RepDeleteByID(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();           
            MsStationery delStat = db.MsStationeries.Find(id);
            if(delStat != null)
            {
                db.MsStationeries.Remove(delStat);
                db.SaveChanges();
                return "Success";
            }

            return "Failed";
        }
      
    }
}