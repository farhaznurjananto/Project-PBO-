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
    public partial class adminRoomType : System.Web.UI.Page
    {
        // PROPERTIES
        string query;
        bool verify;

        // OBJECT
        room_type_class roomType = new room_type_class();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                READ();
            }
        }

        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            try
            {
                // SEARCH
                roomType.room_type_name = txttyperoom.Text;
                query = "SELECT * FROM room_type WHERE room_type_name =@room_type_name";
                verify = roomType.Validation_data(query);
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
            catch (Exception)
            {
                Response.Write("<script>alert('Masukkan data dengan benar!');</script>");
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // ADD
                roomType.room_type_name = txttyperoom.Text;
                query = "SELECT * FROM room_type WHERE room_type_name =@room_type_name";
                verify = roomType.Validation_data(query);
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
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Masukkan data dengan benar!');</script>");
            }
            CLEAR();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // UPDATE
                roomType.room_type_name = txttyperoom.Text;
                query = "SELECT * FROM room_type WHERE room_type_name =@room_type_name";
                verify = roomType.Validation_data(query);
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

            }
            CLEAR();
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // DELETE
                roomType.room_type_name = txttyperoom.Text;
                query = "SELECT * FROM room_type WHERE room_type_name =@room_type_name";
                verify = roomType.Validation_data(query);
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

            }
            catch (Exception)
            {

            }
            CLEAR();
        }

        // CREATE
        public void CREATE()
        {
            // ~/imgRoomTypeDB/
            string filename = Path.GetFileName(fileuploadimg.PostedFile.FileName);
            fileuploadimg.SaveAs(Server.MapPath("~/imgRoomTypeDB/" + filename));
            string filepath = "~/imgRoomTypeDB/" + filename;

            roomType.room_type_name = txttyperoom.Text;
            roomType.room_type_price = Convert.ToInt32(txtpricetype.Text);
            roomType.room_type_description = txttypedescription.Text;
            roomType.room_type_img = filepath;

            roomType.Create_data();
        }

        // READ
        void READ()
        {
            roomType.Read_data();
            Gridviewroomtype.DataSource = roomType.dt;
            Gridviewroomtype.DataBind();
        }

        // UPDATE
        void UPDATE()
        {
            string filename = Path.GetFileName(fileuploadimg.PostedFile.FileName);
            string filepath;

            if (filename == "" || filename == null)
            {
                filepath = roomType.room_type_img.ToString();

            }
            else
            {
                fileuploadimg.SaveAs(Server.MapPath("~/imgRoomTypeDB/" + filename));
                filepath = "~/imgRoomTypeDB/" + filename;
            }

            roomType.room_type_name = txttyperoom.Text;
            roomType.room_type_price = Convert.ToInt32(txtpricetype.Text);
            roomType.room_type_description = txttypedescription.Text;
            roomType.room_type_img = filepath;

            roomType.Update_data();
        }

        // DELETE
        void DELETE()
        {
            roomType.room_type_name = txttyperoom.Text;
            roomType.Delete_data();
        }


        // FILL FORM
        void FILL()
        {
            txtpricetype.Text = roomType.room_type_price.ToString();
            txttypedescription.Text = roomType.room_type_description.ToString();
            pathImg.Text = roomType.room_type_img.ToString();
        }

        // CLEAR FORM
        void CLEAR()
        {
            txttyperoom.Text = "";
            txtpricetype.Text = "";
            txttypedescription.Text = "";
            pathImg.Text = "";
        }
    }
}