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
    class ClassOtchet
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=root;database=kinoteatr");
        public ArrayList Otchet()
        {
            ArrayList list = new ArrayList();
             MySqlCommand cmd = new MySqlCommand($"SELECT u.imya, s.title, s.genre, s.hall, o.data FROM seans s  JOIN orders o ON s.id=o.id_seans JOIN users u ON u.id=o.id_users ", connection);
            //MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users ", connection);
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