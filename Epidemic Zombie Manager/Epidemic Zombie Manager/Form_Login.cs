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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjustesDDBB ajustesDDBB = new AjustesDDBB();
            ajustesDDBB.ShowDialog();
        }
    }
}
