using Raiso.Handler;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace Raiso.Controller
{
    public class UserController
    {
        public static string ConRegisterUser(string name, string DOB, string gender, string address, string password, string phone)
        {
            Regex rg = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z0-9]+$");
            //Regex rg = new Regex(@"^[a-zA-Z0-9]+$");

            if (name == "" || gender == "" || address == "" || password == "" || phone == "" || gender == "" || DOB == string.Empty)
            {
                return "Gaboleh ada yang kosong";
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                return "Nama harus 5<= x <= 50";
            }
            else if (!rg.IsMatch(password))
            {
                return "Password harus alphanumeric";
            }

            if (UserHandler.HanIsNameUnique(name) == false)
            {
                return "Nama harus unique";
            }

            DateTime DateOfBirth = Convert.ToDateTime(DOB);
            var age = DateTime.Now.Year - DateOfBirth.Year;
            if (age < 1)
            {
                return "Umur gaboleh kurang dari 1 tahun";
            }

            string role = "Customer";
            return UserHandler.HanRegisterUser(name, DateOfBirth, gender, address, password, phone, role);
        }

        public static String ConLoginUser(string name, string password, bool rememberme)
        {

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
                return "Name or Password must be filled!";

            var user = UserHandler.HanLoginUser(name, password);
            if (user == null)
                return "Name or Password is wrong!";
            HttpContext.Current.Session["User"] = user;

            if (rememberme)
            {
                HttpCookie cookie = new HttpCookie("UserCookie");
                cookie.Values["UserID"] = Convert.ToString(user.UserID);
                cookie.Expires = DateTime.Now.AddHours(2);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }

            return "Success";
        }

        public static string ConUpdateUser(int id, string name, string DOB, string gender, string address, string password, string phone)
        {
            Regex rg = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z0-9]+$");
            //Regex rg = new Regex(@"^[a-zA-Z0-9]+$");

            if (name == "" || gender == "" || address == "" || password == "" || phone == "" || gender == "" || DOB == string.Empty)
            {
                return "Gaboleh ada yang kosong";
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                return "Nama harus 5<= x <= 50";
            }
            else if (!rg.IsMatch(password))
            {
                return "Password harus alphanumeric";
            }

            DateTime DateOfBirth = Convert.ToDateTime(DOB);
            var age = DateTime.Now.Year - DateOfBirth.Year;
            if (age < 1)
            {
                return "Umur gaboleh kurang dari 1 tahun";
            }


            int checkID = UserHandler.HanIsNameUniqueOnUpdate(name);

            if (UserHandler.HanIsNameUnique(name) == false)
            {
                if(id == checkID || id == 0)
                {

                }
                else
                {
                    return "Nama harus unique";
                }      
            }

            //var dob = UserHandler.HanGetUserByID(id);
            //if(dob == null) return "User not found.";
            //else if (dob.UserDOB != DOB) return "We cannot change our birth date.";

            return UserHandler.HanUpdateUser(id, name, DateOfBirth, gender, address, password, phone);
        }

        public static void Logout()
        {
            HttpContext.Current.Session.Remove("User");
            HttpCookie cookie = HttpContext.Current.Request.Cookies["UserCookie"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddHours(-2);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
        }

        public static MsUser GetLoggedInUser()
        {
            if (HttpContext.Current.Session["User"] != null)
            {
                return (MsUser)HttpContext.Current.Session["User"];
            }

            if (HttpContext.Current.Request.Cookies["UserCookie"] != null)
            {
                if (int.TryParse(HttpContext.Current.Request.Cookies["UserCookie"]["UserID"], out int userId))
                {
                    return UserHandler.HanGetUserByID(userId);
                }
            }

            return null;
        }

        public static string GetUserRole()
        {
            MsUser user = GetLoggedInUser();
            if (user != null)
            {
                return user.UserRole;
            }
            else
            {
                return "Guest";
            }
        }

        public static MsStationery ConGetByID(string id)
        {
            int integerID = Convert.ToInt32(id);
            return StationeryHandler.HanGetByID(integerID);
        }
    }
}