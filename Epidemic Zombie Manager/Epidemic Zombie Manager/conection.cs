using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;
using System.Security.Cryptography;
using System.Text;

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
            open();
        }

        public bool open()
        {
            try
            {
                string ConnString = "Server=" + Server + ";Database=" + DataBase + ";Uid=" + User + ";Pwd=" + Password;
                conn = new MySqlConnection(ConnString);
                conn.Open();
                return true;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }
        public void close()
        {
            conn.Close();
        }

        public bool Test()
        {
                return open();
        }

        public bool Login(string username, string password)
        {
            try
            {
                string sql = "SELECT * FROM ez_admin WHERE Username = '" + username + "';";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;

                MySqlDataReader reader = cmd.ExecuteReader();
                string passw = "";
                while (reader.Read())
                {
                    passw = reader.GetString(2);
                }
                password = MD5(password);
                if (passw.Equals(password))
                {
                    reader.Close();
                    return true;

                }
                else
                {
                    reader.Close();
                    return false;
                }
                
            }catch(MySqlException e)
            {
                return false;
            }

        }

        public string MD5(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }

            return hash.ToString();
        }

        public DataTable SelectVouchers()
        {
            string sql = "SELECT * FROM ez_voucher;";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable t = new DataTable();
            adapter.Fill(t);
            return t;
        }

        public void DeleteVoucher(string id)
        {
            string Quey = "DELETE FROM `ez_voucher` WHERE  `code`='" + id + "';";
            MySqlCommand cmd = new MySqlCommand(Quey, conn);
            cmd.ExecuteNonQuery();
        }

        public void AddVoucher(string code, string money, string experience)
        {
            string Query = "INSERT INTO `ez_voucher` (`code`, `money`, `experience`) VALUES ('" + code + "', '" + money + "', '" + experience + "');";
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
        }

        public void EditVouchers(string code, string money, string experience)
        {
            string Query = "UPDATE `ez_voucher` SET `money`='" + money + "', `experience`='" + experience + "' WHERE  `code`='" + code + "';";
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
        }

        public DataTable SelectTickets()
        {
            string Query = "Select * from ez_tickets";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Query;
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, conn);
            DataTable t = new DataTable();
            adapter.Fill(t);
            return t;
        }

        public void DeletTicket(string id)
        {
            string Quey = "DELETE FROM `ez_tickets` WHERE  `id`='" + id + "';";
            MySqlCommand cmd = new MySqlCommand(Quey, conn);
            cmd.ExecuteNonQuery();
        }

        public void UpdateTicket(int id, int status)
        {
            string Query = "UPDATE `epidemic-zombiedb`.`ez_tickets` SET `status`='" + status +"', `admin`='" + DataClass.AdminName + "' WHERE  `id`=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
