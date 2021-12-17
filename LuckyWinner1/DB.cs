using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamma
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=root;database=kinoteatr");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnetionState.Closed);
            connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnetionState.Open);
            connection.Close();
        }
        
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
