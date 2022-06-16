using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBOFIX
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButtonLogin.Visible = true;
                    LinkButtonLogout.Visible = false;

                    LinkButtonUserSignUp.Visible = true;
                    LinkButtonUserProfile.Visible = false;
                    LinkButtonUserProfile.Enabled = true;
                    LinkButtonReservation.Visible = false;

                    LinkButtonAdminRoomManagement.Visible = false;
                    LinkButtonAdminRoomTypeManagement.Visible = false;
                    LinkButtonAdminReservationManagement.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButtonLogin.Visible = false;
                    LinkButtonLogout.Visible = true;

                    LinkButtonUserSignUp.Visible = false;
                    LinkButtonUserProfile.Visible = true;
                    LinkButtonUserProfile.Text = "Hello " + Session["username"].ToString();
                    LinkButtonUserProfile.Enabled = true;
                    LinkButtonReservation.Visible = true;

                    LinkButtonAdminRoomManagement.Visible = false;
                    LinkButtonAdminRoomTypeManagement.Visible = false;
                    LinkButtonAdminReservationManagement.Visible = false;
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButtonLogin.Visible = false;
                    LinkButtonLogout.Visible = true;

                    LinkButtonUserSignUp.Visible = false;
                    LinkButtonUserProfile.Visible = true;
                    LinkButtonUserProfile.Text = "Hello Admin";
                    LinkButtonUserProfile.Visible = false;
                    LinkButtonReservation.Visible = false;

                    LinkButtonAdminRoomManagement.Visible = true;
                    LinkButtonAdminRoomTypeManagement.Visible = true;
                    LinkButtonAdminReservationManagement.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        protected void LinkButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session["id"] = "";
            Session["fullname"] = "";
            Session["role"] = "";

            LinkButtonLogin.Visible = true;
            LinkButtonLogout.Visible = false;

            LinkButtonUserSignUp.Visible = true;
            LinkButtonUserProfile.Visible = false;
            LinkButtonUserProfile.Enabled = true;
            LinkButtonReservation.Visible = false;

            LinkButtonAdminRoomManagement.Visible = false;
            LinkButtonAdminRoomTypeManagement.Visible = false;
            LinkButtonAdminReservationManagement.Visible = false;

            Response.Redirect("landingPage.aspx");
        }

        protected void LinkButtonUserSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void LinkButtonReservation_Click(object sender, EventArgs e)
        {
            Response.Redirect("userReservation.aspx");
        }

        protected void LinkButtonUserProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProfile.aspx");
        }

        protected void LinkButtonAdminRoomManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminRoom.aspx");
        }

        protected void LinkButtonAdminRoomTypeManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminRoomType.aspx");
        }

        protected void LinkButtonAdminReservationManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminReservation.aspx");
        }
    }
}