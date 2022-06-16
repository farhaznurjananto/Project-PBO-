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
    public partial class adminRoom : System.Web.UI.Page
    {
        // PROPERTIES
        string query;
        bool verify;

        // OBJECT
        room_class room = new room_class();
        room_type_class roomType = new room_type_class();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FCOMBO();
                READ();
            }
        }

        protected void LinkButtonGo_Click(object sender, EventArgs e)
        {
            room.room_number = Convert.ToInt32(txtnoroom.Text);
            query = "SELECT * FROM room WHERE room_number =@room_number";
            verify = room.Validation_data(query);
            if (verify)
            {
                FILL();
            }
            else
            {
                Response.Write("<script>alert('Data tidak ada!');</script>");
                CLEAR();
            }
        }

        protected void LinkButtonAdd_Click(object sender, EventArgs e)
        {
            room.room_number = Convert.ToInt32(txtnoroom.Text);
            query = "SELECT * FROM room WHERE room_number =@room_number";
            verify = room.Validation_data(query);
            if (verify != true)
            {
                CREATE();
                Response.Write("<script>alert('Data berhasil ditambahkan!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Data sudah ada!');</script>");
            }
            READ();
            CLEAR();
        }

        protected void LinkButtonUpdate_Click(object sender, EventArgs e)
        {
            // UPDATE
            room.room_number = Convert.ToInt32(txtnoroom.Text);
            query = "SELECT * FROM room WHERE room_number =@room_number";
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
            CLEAR();
        }

        protected void LinkButtonDelete_Click(object sender, EventArgs e)
        {
            // DELETE
            room.room_number = Convert.ToInt32(txtnoroom.Text);
            query = "SELECT * FROM room WHERE room_number =@room_number";
            verify = room.Validation_data(query);
            if (verify)
            {
                DELETE();
                Response.Write("<script>alert('Data telah dihapus!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Data tidak ada!');</script>");
            }
            READ();
            CLEAR();
        }


        // CREATE
        public void CREATE()
        {
            room.room_number = Convert.ToInt32(txtnoroom.Text);
            room.id_room_type = roomType.get_roomtypeid(dropdowntype.SelectedItem.Value);

            room.Create_data();
        }

        // READ
        void READ()
        {
            room.Read_data();
            GridViewroom.DataSource = room.dt;
            GridViewroom.DataBind();
        }

        // UPDATE
        void UPDATE()
        {
            txtnoroom.Text = Convert.ToString(txtnoroom.Text);
            room.id_room_type = roomType.get_roomtypeid(dropdowntype.SelectedItem.Value);

            room.Update_data();
        }

        // DELETE
        void DELETE()
        {
            room.room_number = Convert.ToInt32(txtnoroom.Text);
            room.Delete_data();
        }

        // FILL
        void FILL()
        {
            labeltype.Text = roomType.get_roomtypename(room.id_room_type);
        }

        // FILL COMBOBOX
        void FCOMBO()
        {
            roomType.Combobox();
            dropdowntype.DataSource = roomType.datafill;
            dropdowntype.DataBind();
        }

        // CLEAR FORM
        void CLEAR()
        {
            txtnoroom.Text = "";
            labeltype.Text = "";
        }
    }
}