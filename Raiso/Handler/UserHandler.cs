using Raiso.Factory;
using Raiso.Model;
using Raiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raiso.Handler
{
    public class UserHandler
    {
        public static string HanRegisterUser(string name, DateTime DOB, string gender, string address, string password, string phone, string role)
        {

            MsUser user = UserFactory.FacCreateNewUser(name, DOB, gender, address, password, phone, role);
            string rep = UserRepository.RepCreateNewUser(user);
            return rep;
        }

        public static Boolean HanIsNameUnique(string name)
        {
            Boolean result = UserRepository.RepIsNameUnique(name);
            return result;
        }

        public static int HanIsNameUniqueOnUpdate(string name)
        {
            return UserRepository.RepIsNameUniqueOnUpdate(name);
        }

        public static MsUser HanLoginUser(string name, string password)
        {
            MsUser loginUser = UserRepository.RepLoginUser(name, password);
            if (loginUser != null)
            {
                return loginUser;
            }
            else
            {
                return null;
            }
        }

        public static MsUser HanGetUserByID(int id)
        {
            MsUser getUser = UserRepository.RepGetUserByID(id);
            return getUser;
        }

        public static string HanUpdateUser(int id, string name, DateTime DOB, string gender, string address, string password, string phone)
        {
            return UserRepository.RepUpdateUser(id, name, DOB, gender, address, password, phone);
        }
    }
}