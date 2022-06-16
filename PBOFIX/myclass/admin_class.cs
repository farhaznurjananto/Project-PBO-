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
    public class admin_class : connection_class
    {
        // PROPERTIES
        public int admin_id { get; set; }
        public string admin_username { get; set; }
        public string admin_password { get; set; }

        // VALIDATION ADMIN
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

                cmd.Parameters.Add("@admin_username", NpgsqlDbType.Varchar).Value = admin_username;
                cmd.Parameters.Add("@admin_password", NpgsqlDbType.Varchar).Value = admin_password;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    check = true;
                    admin_id = rd.GetInt32(0);
                    admin_username = rd.GetString(1);
                }

                connectdb.Close();
            }
            return check;
        }
    }
}