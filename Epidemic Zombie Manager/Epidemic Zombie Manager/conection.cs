using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epidemic_Zombie_Manager
{

    class Conection
    {
        private string Server;
        private string Port;
        private string DataBase;
        private string User;
        private string Password;
        MySqlConnection conn;

        public Conection(ArrayList DataConection)
        {
            Server = DataConection[0].ToString();
            Port = DataConection[1].ToString();
            DataBase = DataConection[2].ToString();
            User = DataConection[3].ToString();
            Password = DataConection[4].ToString();
        }
        public void open()
        {
            string ConnString = "Server=" + Server + ";Database=" + DataBase + ";Uid=" + User + ";Pwd=" + Password;
            conn = new MySqlConnection(ConnString);
            conn.Open();
        }

        public bool Test()
        {
            try
            {
                open();
                return true;
            }catch(MySqlException e)
            {

                return false;

            }
        }
    }
}
