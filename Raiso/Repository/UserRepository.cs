using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Repository
{
    public class UserRepository
    {
        public static String RepCreateNewUser(MsUser user)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.MsUsers.Add(user);
            db.SaveChanges();
            return "Success";
        }

        public static Boolean RepIsNameUnique(string name)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser tempUser = db.MsUsers.Where(x => x.UserName == name).FirstOrDefault();
            return (tempUser == null) ? true : false;
        }

        public static int RepIsNameUniqueOnUpdate(string name)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser tempUser = db.MsUsers.Where(x => x.UserName == name).FirstOrDefault();
            if(tempUser == null)
            {
                return 0;
            }
            else
            {
                return tempUser.UserID;
            }
        }

        public static MsUser RepLoginUser(string name, string password)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser tempUser = db.MsUsers.Where(x => x.UserName == name && x.UserPassword == password).FirstOrDefault();
            if(tempUser == null)
            {
                return null;
            }
            else
            {
                return tempUser;
            }
        }

        public static MsUser RepGetUserByID(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser tempUser = db.MsUsers.Where(x => x.UserID == id).FirstOrDefault();
            return tempUser;
        }

        public static String RepUpdateUser(int id, string name, DateTime DOB, string gender, string address, string password, string phone)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser user = db.MsUsers.Find(id);
            user.UserName = name;
            user.UserDOB = DOB;
            user.UserGender = gender;
            user.UserAddress = address;
            user.UserPassword = password;
            user.UserPhone = phone;
            db.SaveChanges();
            return "Success";
        }
    }
}