using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemic_Zombie_Manager
{
    public partial class TicketView : Form
    {
        public TicketView(string id, string username, string status, string title, string message, string admin)
        {
            InitializeComponent(); //Soy gilipollas
            tb_id.Text = id;
            tb_username.Text = username;
            tb_title.Text = title;
            tb_admin.Text = admin;
            tb_message.Text = message;
            cb_status.Items.Add("Abierta");
            cb_status.Items.Add("En proceso");
            cb_status.Items.Add("Cerrada");
            int index = Convert.ToInt32(status);
            cb_status.SelectedIndex = index; //Me cago en to
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_id.Text);
            int status = cb_status.SelectedIndex;
            DataClass.con.UpdateTicket(id, status);
            this.Close();

        }
    }
}
