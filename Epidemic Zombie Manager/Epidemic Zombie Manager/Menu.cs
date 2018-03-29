using System;
using System.Windows.Forms;

namespace Epidemic_Zombie_Manager
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vouchers vouchers = new Vouchers();
            vouchers.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.ShowDialog();
        }
    }
}
