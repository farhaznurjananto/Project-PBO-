using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PBOFIX.myclass;

namespace PBOFIX.views.user
{
    public partial class userReservation : System.Web.UI.Page
    {
        // PROPERTIES
        string query;

        // OBJECT
        reservation_class userReservationOrder = new reservation_class();
        room_type_class roomType = new room_type_class();
        room_class room = new room_class();
        customer_class customer = new customer_class();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FCOMBO();
            }
        }

        protected void ButtonUserOrderReservation_Click(object sender, EventArgs e)
        {
            try
            {
                customer.customer_username = Session["username"].ToString();
                customer.customer_password = txtpassword.Text;
                query = "SELECT * FROM customer WHERE customer_username =@customer_username AND customer_password =@customer_password;";
                bool verify = customer.Validation_data(query);
                if (verify == true)
                {
                    ORDER();
                    roomType.get_roomtypeprice(room.GetRoomTypeId(Convert.ToInt32(txtroomnumber.Text)));
                    if (Convert.ToInt32(txtroomprice.Text) >= roomType.room_type_price)
                    {
                        userReservationOrder.Create_data();
                        UPDATE();
                        Response.Write("<script>alert('Reservation berhasil!');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Uang anda kurang!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Password anda salah!');</script>");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Isikan data dengan benar!');</script>");
            }
            CLEAR();
        }

        protected void ButtonUserSearchTypeRoom_Click(object sender, EventArgs e)
        {
            SEARCH();
        }

        // RESERVATION ORDER
        void ORDER()
        {
            userReservationOrder.reservation_checkin = Convert.ToDateTime(txtcheckin.Text);
            userReservationOrder.reservation_checkout = Convert.ToDateTime(txtcheckout.Text);
            userReservationOrder.id_room = room.GetRoomId(Convert.ToInt32(txtroomnumber.Text));
            userReservationOrder.id_customer = Convert.ToInt32(Session["id"].ToString());
        }

        void UPDATE()
        {
            query = "UPDATE room SET room_status =false WHERE room_number = @room_number;";
            room.room_number = Convert.ToInt32(txtroomnumber.Text);
            room.Update(query);
        }

        // SEARCH
        void SEARCH()
        {
            room.id_room_type = roomType.get_roomtypeid(dropdowntype.SelectedItem.Value);
            room.Seacrh();
            gridviewreservation.DataSource = room.dt;
            gridviewreservation.DataBind();
        }

        // FILL COMBOBOX
        void FCOMBO()
        {
            roomType.Combobox();
            dropdowntype.DataSource = roomType.datafill;
            dropdowntype.DataBind();
        }

        // CLEAR
        void CLEAR()
        {
            txtcheckin.Text = "";
            txtcheckout.Text = "";
            txtroomnumber.Text = "";
            txtroomprice.Text = "";
            txtpassword.Text = "";
        }
    }
}