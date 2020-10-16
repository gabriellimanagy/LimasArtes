using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimasArtes.Base
{
    class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;port=3306;database=limasartes;uid=root;password=1234;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }

    }
}
