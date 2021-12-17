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
    class ClassSeans
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=root;database=kinoteatr");
        public ArrayList Seans()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM seans", connection);
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

        public bool Add_to_Seans(string Title, string Genre, string Data, string Hall, string Time)
        {

            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO Seans(title, genre, data, hall, time ) VALUES (@title, @genre, @data, @hall, @time)", connection);
            command.Parameters.AddWithValue("@title", Title);
            command.Parameters.AddWithValue("@genre", Genre);
            command.Parameters.AddWithValue("@data", Data);
            command.Parameters.AddWithValue("@hall", Hall);
            command.Parameters.AddWithValue("@time", Time);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            connection.Close();
            return flag;
        }
    }
}
