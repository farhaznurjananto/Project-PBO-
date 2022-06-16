using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PBOFIX.myclass;
using PBOFIX.views;

namespace PBOFIX
{
    public partial class login : System.Web.UI.Page
    {

        // TRANSFER TO ANOTHER FORM
        //public static int T_id;
        //public static string T_username;
        //public static string T_role;

        // PROPERTIES
        string query;
        
        // OBJECT
        admin_class admin = new admin_class();
        customer_class customer = new customer_class();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonUserLogin_Click(object sender, EventArgs e)
        {
            customer.customer_username = txtUsername.Text;
            customer.customer_password = txtPassword.Text;
            query = "SELECT * FROM customer WHERE customer_username =@customer_username AND customer_password =@customer_password;";
            bool verify = customer.Validation_data(query);
            if (verify)
            {
                Response.Write("<script>alert('Berhasil login!');</script>");

                //T_id = customer.customer_id;
                //T_username = customer.customer_username;
                //T_role = "user";

                Session["id"] = customer.customer_id;
                Session["username"] = customer.customer_username;
                Session["role"] = "user";

                Response.Redirect("landingPage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Periksa kembali Username dan Password!');</script>");
            }

            CLEAR();
        }

        protected void ButtonAdminLogin_Click(object sender, EventArgs e)
        {
            admin.admin_username = txtUsername.Text;
            admin.admin_password = txtPassword.Text;
            query = "SELECT * FROM admin WHERE admin_username =@admin_username AND admin_password =@admin_password;";
            bool verify = admin.Validation_data(query);
            if (verify)
            {
                Response.Write("<script>alert('Berhasil login!');</script>");

                //T_id = admin.admin_id;
                //T_username = admin.admin_username;
                //T_role = "admin";

                Session["id"] = customer.customer_id;
                Session["username"] = customer.customer_username;
                Session["role"] = "admin";

                Response.Redirect("landingPage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Periksa kembali Username dan Password!');</script>");
            }

            CLEAR();
        }

        // CLEAR FORM
        void CLEAR()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}