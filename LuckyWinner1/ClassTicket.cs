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
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM clients", connection);
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

        public bool Add_to_Ticket(string Buyer, string Ticket, string Title, string Hall, string Data, string Time, string Pay)
        {

            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO clients(buyer, ticket, title, hall, data, time, pay ) VALUES (@buyer, @ticket, @title, @hall, @data, @time, @pay)", connection);
            command.Parameters.AddWithValue("@buyer", Buyer);
            command.Parameters.AddWithValue("@ticket", Ticket);
            command.Parameters.AddWithValue("@title", Title);
            command.Parameters.AddWithValue("@hall", Hall);
            command.Parameters.AddWithValue("@data", Data);
            command.Parameters.AddWithValue("@time", Time);
            command.Parameters.AddWithValue("@pay", Pay);
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
