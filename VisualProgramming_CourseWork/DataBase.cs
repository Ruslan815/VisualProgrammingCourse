using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming_CourseWork
{
    /*
     * В данном проекте работа с базой данных происходит через СУБД MySQL.
     * База данных хранится на локальном сервере, работающем с помощью XAMPP.
     * 
     * Данный класс служит для открытия/закрытия соединения с базой данных, 
     * проверки состояния текущего соединения с базой данных.
     */
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;password=;username=root;database=driving_school");

        public bool openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
