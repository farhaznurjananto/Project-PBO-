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
    public class customer_class : connection_class
    {
        // PROPERTIES
        public int customer_id { get; set; }
        public string customer_fullname { get; set; }
        public DateTime customer_birthdate { get; set; }
        public string customer_phone { get; set; }
        public string customer_state { get; set; }
        public string customer_city { get; set; }
        public string customer_address { get; set; }
        public string customer_email { get; set; }
        public string customer_username { get; set; }
        public string customer_password { get; set; }

        // CREATE FUNCTION
        public void Create_data()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "INSERT INTO customer(customer_fullname, customer_birthdate, customer_phone, customer_state, customer_city, customer_address, customer_email, customer_username, customer_password) VALUES(@customer_fullname, @customer_birthdate, @customer_phone, @customer_state, @customer_city, @customer_address, @customer_email, @customer_username, @customer_password);";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@customer_fullname", NpgsqlDbType.Varchar).Value = customer_fullname;
                cmd.Parameters.Add("@customer_birthdate", NpgsqlDbType.Date).Value = customer_birthdate;
                cmd.Parameters.Add("@customer_phone", NpgsqlDbType.Varchar).Value = customer_phone;
                cmd.Parameters.Add("@customer_state", NpgsqlDbType.Varchar).Value = customer_state;
                cmd.Parameters.Add("@customer_city", NpgsqlDbType.Varchar).Value = customer_city;
                cmd.Parameters.Add("@customer_address", NpgsqlDbType.Varchar).Value = customer_address;
                cmd.Parameters.Add("@customer_email", NpgsqlDbType.Varchar).Value = customer_email;
                cmd.Parameters.Add("@customer_username", NpgsqlDbType.Varchar).Value = customer_username;
                cmd.Parameters.Add("@customer_password", NpgsqlDbType.Varchar).Value = customer_password;

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        // UPDATE FUNCTION
        public void Update_data()
        {
            connectdb.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = "UPDATE customer SET customer_fullname =@customer_fullname, customer_birthdate =@customer_birthdate, customer_phone =@customer_phone, customer_state =@customer_state, customer_city =@customer_city, customer_address =@customer_address, customer_email =@customer_email, customer_password =@customer_password WHERE customer_username =@customer_username;";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@customer_fullname", NpgsqlDbType.Varchar).Value = customer_fullname;
                cmd.Parameters.Add("@customer_birthdate", NpgsqlDbType.Date).Value = customer_birthdate;
                cmd.Parameters.Add("@customer_phone", NpgsqlDbType.Varchar).Value = customer_phone;
                cmd.Parameters.Add("@customer_state", NpgsqlDbType.Varchar).Value = customer_state;
                cmd.Parameters.Add("@customer_city", NpgsqlDbType.Varchar).Value = customer_city;
                cmd.Parameters.Add("@customer_address", NpgsqlDbType.Varchar).Value = customer_address;
                cmd.Parameters.Add("@customer_email", NpgsqlDbType.Varchar).Value = customer_email;
                cmd.Parameters.Add("@customer_password", NpgsqlDbType.Varchar).Value = customer_password;

                cmd.Parameters.Add("@customer_username", NpgsqlDbType.Varchar).Value = customer_username;

                cmd.ExecuteNonQuery();
                connectdb.Close();
            }

        }

        // GET USER DATA
        public bool Get_datauser(string query)
        {
            connectdb.Open();
            NpgsqlDataReader rd;
            bool check = false;
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@customer_username", NpgsqlDbType.Varchar).Value = customer_username;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    check = true;
                    customer_fullname = rd.GetString(1);
                    customer_birthdate = rd.GetDateTime(2);
                    customer_phone = rd.GetString(3);
                    customer_state = rd.GetString(4);
                    customer_city = rd.GetString(5);
                    customer_address = rd.GetString(6);
                    customer_email = rd.GetString(7);
                    customer_username = rd.GetString(8);
                    customer_password = rd.GetString(9);
                    
                }

                connectdb.Close();
            }
            return check;
        }

        // VALIDATION USER
        public bool Validation_data(string query)
        {
            connectdb.Open();
            NpgsqlDataReader rd;
            bool check = false;
            using(NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@customer_username", NpgsqlDbType.Varchar).Value = customer_username;
                cmd.Parameters.Add("@customer_password", NpgsqlDbType.Varchar).Value = customer_password;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    check= true;
                    customer_id = rd.GetInt32(0);
                    customer_username = rd.GetString(8);
                }

                connectdb.Close();
            }
            return check;
        }
    }
}