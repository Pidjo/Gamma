using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gamma
{
    class ClassTicket
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=root;database=kinoteatr");
        public ArrayList Ticket()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM orders", connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    list.Add(result);
                }
            }
            connection.Close();
            return list;
        }
    }
}
