using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Factory
{
    public class StationeryFactory
    {
        public static MsStationery FacCreateNewStationery(string name, int price)
        {
            MsStationery stationery = new MsStationery();
            stationery.StationeryName = name;
            stationery.StationeryPrice = price;
            return stationery;
        }
    }
}