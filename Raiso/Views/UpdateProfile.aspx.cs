using Raiso.Controller;
using Raiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raiso.Views
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MsUser updateUser = (MsUser)Session["user"];
                if (updateUser == null)
                {
                    Response.Redirect("~/Views/Home.aspx");
                }

                TBox_Name.Text = updateUser.UserName;
                Tbox_dob.Text = updateUser.UserDOB.Date.ToString();
                GenderRadioButton.SelectedValue = updateUser.UserGender;
                TBox_Address.Text = updateUser.UserAddress;
                TBox_Password.Text = updateUser.UserPassword;
                TBox_Phone.Text = updateUser.UserPhone;

                Lbl_Status.Text = Request.QueryString["status"];
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            MsUser updateUser = (MsUser)Session["user"];
            int id = Convert.ToInt32(updateUser.UserID);
            string name = TBox_Name.Text;
            string DOB = Tbox_dob.Text;
            //DateTime DOB = Convert.ToDateTime(Tbox_dob.Text.ToString());
            string gender = GenderRadioButton.SelectedValue;
            string address = TBox_Address.Text;
            string password = TBox_Password.Text;
            string phone = TBox_Phone.Text;

            string status = UserController.ConUpdateUser(id, name, DOB, gender, address, password, phone);
            Response.Redirect("~/Views/UpdateProfile.aspx?status=" + status);
        }
    }
}