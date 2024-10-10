using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Factory
{
    public class UserFactory
    {
        public static MsUser FacCreateNewUser(string name, DateTime DOB, string gender, string address, string password, string phone, string role)
        {
            MsUser user = new MsUser();
            user.UserName = name;
            user.UserDOB = DOB;
            user.UserGender = gender;
            user.UserAddress = address;
            user.UserPassword = password;
            user.UserPhone = phone;
            user.UserRole = role;
            return user;
        }
    }
}