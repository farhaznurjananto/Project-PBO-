using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PBOFIX.myclass;

namespace PBOFIX.views.user
{
    public partial class userProfile : System.Web.UI.Page
    {
        // PROPERTIES
        string query;
        bool verify;

        // OBJECT
        customer_class customer = new customer_class();
        reservation_class userReservation = new reservation_class();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                customer.customer_username = Session["username"].ToString();
                query = "SELECT * FROM customer WHERE customer_username =@customer_username";
                verify = customer.Get_datauser(query);
                if (verify)
                {
                    FILL();
                    READ();
                }
            }
        }

        protected void ButtonUserUpadateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                UPDATE();
                Response.Write("<script>alert('Data telah diupdate!');</script>");
                FILL();
            }
            catch
            {
                Response.Write("<script>alert('Isikan data dengan benar!');</script>");
            }

        }

        // UPDATE
        void UPDATE()
        {
            customer.customer_fullname = txtFullname.Text;
            customer.customer_birthdate = Convert.ToDateTime(txtBoxDate.Text);
            customer.customer_phone = txtBoxPhone.Text;
            customer.customer_email = txtBoxEmail.Text;
            customer.customer_state = txtBoxState.Text;
            customer.customer_city = txtBoxCity.Text;
            customer.customer_address = txtBoxFulladdress.Text;
            if (txtBoxNewpassword.Text == "")
            {
                customer.customer_password = txtBoxOldpassword.Text;
            }
            else
            {
                customer.customer_password = txtBoxNewpassword.Text;
            }

            customer.customer_username = Session["username"].ToString();

            customer.Update_data();
        }

        // FILL
        void FILL()
        {
            txtFullname.Text = customer.customer_fullname.ToString();
            txtBoxDate.Text = customer.customer_birthdate.ToString("yyyy-MM-dd");
            txtBoxPhone.Text = customer.customer_phone.ToString();
            txtBoxEmail.Text = customer.customer_email.ToString();
            txtBoxState.Text = customer.customer_state.ToString();
            txtBoxCity.Text = customer.customer_city.ToString();
            txtBoxFulladdress.Text = customer.customer_address.ToString();
            txtBoxUsername.Text = customer.customer_username.ToString();
            txtBoxOldpassword.Text = customer.customer_password.ToString();
        }

        // READ RESERVATION
        void READ()
        {
            userReservation.Read_User(Convert.ToInt32(Session["id"].ToString()));
            GridViewReservation.DataSource = userReservation.dt;
            GridViewReservation.DataBind();
        }
    }
}