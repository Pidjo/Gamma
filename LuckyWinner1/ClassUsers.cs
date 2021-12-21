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
    class ClassUsers
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;username=root;password=root;database=kinoteatr");
        public ArrayList Users()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users", connection);
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

        public bool Add_to_Users(string Login, string Password, string Imya, string Surname)
        {

            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO users(login, password, imya, surname ) VALUES (@login, @password, @imya, @surname)", connection);
            command.Parameters.AddWithValue("@login", Login);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@imya", Imya);
            command.Parameters.AddWithValue("@surname", Surname);
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
