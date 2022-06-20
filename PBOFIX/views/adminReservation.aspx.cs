using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PBOFIX.myclass;

namespace PBOFIX.views.admin
{
    public partial class adminReservation : System.Web.UI.Page
    {
        // PROPERTIES
        string query;
        bool verify;

        // OBJECT
        reservation_class reservationAdmin = new reservation_class();
        room_class room = new room_class();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                READ();
            }
        }

        protected void ButtonUserUpadateReservation_Click(object sender, EventArgs e)
        {
            try
            {
                // UPDATE
                room.room_number = Convert.ToInt32(txtroomnumber.Text);
                query = "SELECT * FROM room WHERE room_number =@room_number AND room_status =false";
                verify = room.Validation_data(query);
                if (verify)
                {
                    UPDATE();
                    Response.Write("<script>alert('Data telah diupdate!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Data tidak ada!');</script>");
                }
                READ();

            }
            catch (Exception)
            {
                Response.Write("<script>alert('Masukkan data dengan benar!');</script>");
            }
            CLEAR();
        }

        // READ
        void READ()
        {
            reservationAdmin.Read_Admin();
            gridviewreservation.DataSource = reservationAdmin.dt;
            gridviewreservation.DataBind();
        }

        // UPDATE
        void UPDATE()
        {
            query = "UPDATE room SET room_status =true WHERE room_number = @room_number;";
            room.room_number = Convert.ToInt32(txtroomnumber.Text);
            room.Update(query);

            reservationAdmin.id_customer = Convert.ToInt32(txtiduser.Text);
            reservationAdmin.Update_data();
        }

        // CLEAR
        void CLEAR()
        {
            txtroomnumber.Text = "";
            txtiduser.Text = "";
        }
    }
}