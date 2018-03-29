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
    public partial class Tickets : Form
    {
        int id;
        public Tickets()
        {
            InitializeComponent();
            UpdateData();
        }
        public void UpdateData()
        {
            DataTable dt = DataClass.con.SelectTickets();
            dgv_tickets.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dgv_tickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            bt_delete.Enabled = true;
            bt_view.Enabled = true;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string Code = dgv_tickets.Rows[id].Cells[0].Value.ToString();
            DataClass.con.DeletTicket(Code);
            UpdateData();
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            string idcode = dgv_tickets.Rows[id].Cells[0].Value.ToString();
            string user = dgv_tickets.Rows[id].Cells[1].Value.ToString();
            string title = dgv_tickets.Rows[id].Cells[2].Value.ToString();
            string message = dgv_tickets.Rows[id].Cells[3].Value.ToString();
            string status = dgv_tickets.Rows[id].Cells[4].Value.ToString();
            string admin = dgv_tickets.Rows[id].Cells[5].Value.ToString();
            TicketView ticketView = new TicketView(idcode,user,status,title, message,admin);
            ticketView.ShowDialog(); //por aqui tmb soy tonto

        }
    }
}
