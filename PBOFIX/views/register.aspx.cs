using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PBOFIX.myclass;

namespace PBOFIX
{
    public partial class register : System.Web.UI.Page
    {
        // PROPERTIES
        string query;

        // OBJECT
        customer_class customer = new customer_class();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSignUp_Click(object sender, EventArgs e)
        {
            // CREATE
            try
            {
                customer.customer_username = txtusername.Text;
                customer.customer_password = txtpassword.Text;
                query = "SELECT * FROM customer WHERE customer_username =@customer_username;";
                bool verify = customer.Validation_data(query);
                if (verify != true)
                {
                    CREATE();
                    Response.Write("<script>alert('Akun berhasil dibuat!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Username telah digunakan!');</script>");
                }
                CLEAR();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Isikan data dengan benar!);</script>");
            }
        }

        // CREATE
        public void CREATE()
        {
            customer.customer_fullname = txtfullname.Text;
            customer.customer_birthdate = Convert.ToDateTime(txtbirthdate.Text);
            customer.customer_phone = txtphone.Text;
            customer.customer_state = txtstate.Text;
            customer.customer_city = txtcity.Text;
            customer.customer_address = txtaddress.Text;
            customer.customer_email = txtemail.Text;
            customer.customer_username = txtusername.Text;
            customer.customer_password = txtpassword.Text;

            customer.Create_data();
        }

        // CLEAR FORM
        void CLEAR()
        {
            txtfullname.Text = "";
            txtbirthdate.Text = "";
            txtphone.Text = "";
            txtstate.Text = "";
            txtcity.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
        }
    }
}