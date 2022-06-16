using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBOFIX.myclass
{
    public class connection_class
    {
        // field
        public NpgsqlConnection connectdb;

        // constructor
        public connection_class()
        {
            string server = "localhost";
            string port = "5432";
            string database = "hotelPBO";
            string user_id = "postgres";
            string password = "nurjanantofarhaz";

            //< add name = "con" connectionString = "Server=localhost; Port=5432; Database=cloverhotel; User Id=postgres; Password=nurjanantofarhaz" providerName = "Npgsql" />

            string connection_string = "Server=" + server + "; Port=" + port + "; Database=" + database + "; User Id=" + user_id + "; Password=" + password + ";";

            connectdb = new NpgsqlConnection(connection_string);
        }
    }
}