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
    public class room_class : connection_class
    {
        // PROPERTIES
        public int room_id { get; set; }
        public int room_number { get; set; }
        public bool room_status { get; set; }
        public int id_room_type { get; set; }

        // READ PROPERTIES
        public DataTable dt = new DataTable();

        // CREATE FUNCTION
        public void Create_data()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "INSERT INTO room(room_number, id_room_type) VALUES(@room_number, @id_room_type);";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;


                cmd.Parameters.AddWithValue("@room_number", NpgsqlDbType.Integer).Value = room_number;
                cmd.Parameters.AddWithValue("@id_room_type", NpgsqlDbType.Integer).Value = id_room_type;


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
                cmd.CommandText = "SELECT r.room_number, r.room_status, rt.room_type_name FROM room r JOIN room_type rt ON(r.id_room_type = rt.room_type_id);";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                NpgsqlDataAdapter NDA = new NpgsqlDataAdapter(cmd);
                NDA.Fill(dt);
                cmd.Dispose();
                connectdb.Close();
            }
        }

        // SEACRH USER
        public void Seacrh()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT r.room_number, r.room_status, rt.room_type_name, rt.room_type_price FROM room r JOIN room_type rt ON(r.id_room_type = rt.room_type_id) WHERE id_room_type = @id_room_type AND r.room_status =true;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.AddWithValue("@id_room_type", NpgsqlDbType.Integer).Value = id_room_type;

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
                cmd.CommandText = "UPDATE room SET id_room_type =@id_room_type WHERE room_number =@room_number;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@id_room_type", NpgsqlDbType.Integer).Value = id_room_type;

                cmd.Parameters.Add("@room_number", NpgsqlDbType.Integer).Value = room_number;

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
                cmd.CommandText = "DELETE FROM room WHERE room_number =@room_number;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_number", NpgsqlDbType.Integer).Value = room_number;

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        // ROOM VALIDATION
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

                cmd.Parameters.Add("@room_number", NpgsqlDbType.Integer).Value = room_number;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    check = true;
                    room_id = rd.GetInt32(0);
                    room_number = rd.GetInt32(1);
                    room_status = rd.GetBoolean(2);
                    id_room_type = rd.GetInt32(3);
                }
                connectdb.Close();
            }
            return check;
        }

        // UPDATE FOR ADMIN
        public void Update(string query)
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_number", NpgsqlDbType.Integer).Value = room_number;

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        public int GetRoomId(int roomNumber)
        {
            connectdb.Open();
            NpgsqlDataReader rd;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT room_id FROM room WHERE room_number =@room_number";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_number", NpgsqlDbType.Integer).Value = roomNumber;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    room_id = rd.GetInt32(0);
                }
                connectdb.Close();
            }
            return room_id;
        }

        public int GetRoomTypeId(int roomNumber)
        {
            connectdb.Open();
            NpgsqlDataReader rd;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "SELECT id_room_type FROM room WHERE room_number =@room_number";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@room_number", NpgsqlDbType.Integer).Value = roomNumber;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    id_room_type = rd.GetInt32(0);
                }
                connectdb.Close();
            }
            return id_room_type;
        }
    }
}