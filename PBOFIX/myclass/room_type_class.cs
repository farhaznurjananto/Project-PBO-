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
    public class room_type_class : connection_class
    {
        // PROPERTIES
        public int room_type_id { get; set; }
        public string room_type_name { get; set; }
        public int room_type_price { get; set; }
        public string room_type_description { get; set; }
        public string room_type_img { get; set; }

        public DataTable dt = new DataTable();
        public List<string> datafill = new List<string>();

        // CREATE FUNCTION
        public void Create_data()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "INSERT INTO room_type(room_type_name, room_type_price, room_type_description, room_type_img) VALUES(@room_type_name, @room_type_price, @room_type_description, @room_type_img);";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_type_price", NpgsqlDbType.Integer).Value = room_type_price;
                cmd.Parameters.Add("@room_type_description", NpgsqlDbType.Varchar).Value = room_type_description;
                cmd.Parameters.Add("@room_type_img", NpgsqlDbType.Varchar).Value = room_type_img;

                cmd.Parameters.Add("@room_type_name", NpgsqlDbType.Varchar).Value = room_type_name;

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        // READ FUNCTION
        public void Read_data()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT room_type_name, room_type_price, room_type_description, room_type_img FROM room_type;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                NpgsqlDataAdapter NDA = new NpgsqlDataAdapter(cmd);
                NDA.Fill(dt);
                cmd.Dispose();
                connectdb.Close();
            }
        }

        // UPDATE FUNCTION
        public void Update_data()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "UPDATE room_type SET room_type_price =@room_type_price, room_type_description =@room_type_description, room_type_img =@room_type_img WHERE room_type_name =@room_type_name;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_type_price", NpgsqlDbType.Integer).Value = room_type_price;
                cmd.Parameters.Add("@room_type_description", NpgsqlDbType.Varchar).Value = room_type_description;
                cmd.Parameters.Add("@room_type_img", NpgsqlDbType.Varchar).Value = room_type_img;

                cmd.Parameters.Add("@room_type_name", NpgsqlDbType.Varchar).Value = room_type_name;

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
                cmd.CommandText = "DELETE FROM room_type WHERE room_type_name =@room_type_name;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_type_name", NpgsqlDbType.Varchar).Value = room_type_name;

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        // ROOM TYPE VALIDATION
        public bool Validation_data(string query)
        {
            connectdb.Open();
            NpgsqlDataReader rd;
            bool check = false;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_type_name", NpgsqlDbType.Varchar).Value = room_type_name;
                cmd.Parameters.Add("@room_type_id", NpgsqlDbType.Integer).Value = room_type_id;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    check = true;
                    room_type_id = rd.GetInt32(0);
                    room_type_name = rd.GetString(1);
                    room_type_price = rd.GetInt32(2);
                    room_type_description = rd.GetString(3);
                    room_type_img = rd.GetString(4);
                }
                connectdb.Close();
            }
            return check;
        }

        // GET ROOM TYPE NAME
        public string get_roomtypename(int roomID)
        {
            connectdb.Open();
            NpgsqlDataReader rd;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT room_type_name FROM room_type WHERE room_type_id =@room_type_id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_type_id", NpgsqlDbType.Integer).Value = roomID;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    room_type_name = rd.GetString(0);
                }
                connectdb.Close();
            }
            return room_type_name;
        }

        // GET ROOM TYPE ID
        public int get_roomtypeid(string roomName)
        {
            connectdb.Open();
            NpgsqlDataReader rd;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT room_type_id FROM room_type WHERE room_type_name =@room_type_name";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_type_name", NpgsqlDbType.Varchar).Value = roomName;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    room_type_id = rd.GetInt32(0);
                }
                connectdb.Close();
            }
            return room_type_id;
        }

        // COMBOBOX
        public void Combobox()
        {
            datafill.Clear();
            NpgsqlDataReader rd;

            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = "SELECT room_type_name FROM room_type;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    datafill.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }

        public int get_roomtypeprice(int roomid)
        {
            connectdb.Open();
            NpgsqlDataReader rd;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT room_type_price FROM room_type WHERE room_type_id =@room_type_id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_type_id", NpgsqlDbType.Integer).Value = roomid;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    room_type_price = rd.GetInt32(0);
                }
                connectdb.Close();
            }
            return room_type_price;
        }
    }
}