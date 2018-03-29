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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjustesDDBB ajustesDDBB = new AjustesDDBB();
            ajustesDDBB.ShowDialog();
        }
        private void OnEnter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "Username")
            {
                tb_Username.Text = "";
                tb_Username.ForeColor = Color.Black;
            }
            if (((TextBox)sender).Text == "Password")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
                tb_password.PasswordChar = '*';
            }
        }
        private void OnLeave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Username";
                tb_Username.ForeColor = Color.Silver;
            }
            if (tb_password.Text == "")
            {
                tb_password.Text = "Password";
                tb_password.ForeColor = Color.Silver;
                tb_password.PasswordChar = '\0';
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string user = tb_Username.Text;
            string pass = tb_password.Text;
            
            bool login = DataClass.con.Login(user, pass);
            if (login)
            {
                DataClass.AdminName = user;
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Login!", "Epidemic Zombie Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
    }
}
