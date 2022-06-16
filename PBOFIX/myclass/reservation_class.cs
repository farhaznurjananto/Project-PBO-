using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using PBOFIX.myclass;

namespace PBOFIX.myclass
{
    public class reservation_class : connection_class
    {
        // PROPERTIES
        public int reservation_id { get; set; }
        public DateTime reservation_date { get; set; }
        public DateTime reservation_checkin { get; set; }
        public DateTime reservation_checkout { get; set; }
        public int id_admin { get; set; }
        public int id_room { get; set; }
        public int id_customer { get; set; }

        // READ PROPERTIES
        public DataTable dt = new DataTable();

        // CREATE FUNCTION
        public void Create_data()
        {
            connectdb.Open();
            using(NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "INSERT INTO reservation(reservation_checkin, reservation_checkout, id_room, id_customer) VALUES(@reservation_checkin, @reservation_checkout, @id_room, @id_customer);";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@reservation_checkin", NpgsqlDbType.Date).Value = reservation_checkin;
                cmd.Parameters.Add("@reservation_checkout", NpgsqlDbType.Date).Value = reservation_checkout;
                cmd.Parameters.Add("@id_room", NpgsqlDbType.Integer).Value = id_room; // no room convert id room
                cmd.Parameters.Add("@id_customer", NpgsqlDbType.Integer).Value = id_customer; // langsung pakai session

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        // READ FOR USER
        public void Read_User(int idCustomer)
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT r.reservation_date, r.reservation_checkin, r.reservation_checkout, rm.room_number, rt.room_type_name, rt.room_type_price, c.customer_fullname FROM reservation r JOIN room rm ON(r.id_room = rm.room_id) JOIN customer c ON(r.id_customer = c.customer_id) JOIN room_type rt ON(rm.id_room_type = rt.room_type_id) WHERE id_customer =@id_customer;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@id_customer", NpgsqlDbType.Integer).Value = idCustomer;

                NpgsqlDataAdapter NDA = new NpgsqlDataAdapter(cmd);
                NDA.Fill(dt);
                cmd.Dispose();
                connectdb.Close();
            }
        }

        // UPDATE FOR USER
        public void Update_data()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "UPDATE reservation SET reservation_date =@reservation_date, reservation_checkin =@reservation_checkin, reservation_checkout =@reservation_checkout, id_admin =@id_admin, id_room =@id_room, id_customer =@id_customer WHERE reservation_id =@reservation_id;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@reservation_date", NpgsqlDbType.Date).Value = reservation_date;
                cmd.Parameters.Add("@reservation_checkin", NpgsqlDbType.Date).Value = reservation_checkin;
                cmd.Parameters.Add("@reservation_checkout", NpgsqlDbType.Date).Value = reservation_checkout;
                cmd.Parameters.Add("@id_admin", NpgsqlDbType.Integer).Value = id_admin;
                cmd.Parameters.Add("@id_room", NpgsqlDbType.Integer).Value = id_room;
                cmd.Parameters.Add("@customer", NpgsqlDbType.Integer).Value = id_customer;

                cmd.Parameters.Add("@reservation_id", NpgsqlDbType.Integer).Value = reservation_id;

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        // DELETE FUNCTION
        public void Delete_data()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "DELETE FROM reservation WHERE reservation_id =@reservation_id;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@reservation_id", NpgsqlDbType.Integer).Value = reservation_id;

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        // READ FOR ADMIN
        public void Read_Admin()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT r.reservation_id, r.reservation_date, r.reservation_checkin, r.reservation_checkout, rm.room_number, rt.room_type_name, rt.room_type_price, c.customer_fullname, rm.room_status FROM reservation r JOIN room rm ON(r.id_room = rm.room_id) JOIN customer c ON(r.id_customer = c.customer_id) JOIN room_type rt ON(rm.id_room_type = rt.room_type_id) WHERE rm.room_status =false;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                NpgsqlDataAdapter NDA = new NpgsqlDataAdapter(cmd);
                NDA.Fill(dt);
                cmd.Dispose();
                connectdb.Close();
            }
        }
    }
}