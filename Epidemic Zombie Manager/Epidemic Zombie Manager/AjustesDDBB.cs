using System;
using System.Collections;
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
    public partial class AjustesDDBB : Form
    {
        public AjustesDDBB()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList DataConection = new ArrayList();
            DataConection.Add(tb_Server.Text);
            DataConection.Add(tb_Port.Text);
            DataConection.Add(tb_DataBase.Text);
            DataConection.Add(tb_User.Text);
            DataConection.Add(tb_Password.Text);

            Conection con = new Conection(DataConection);
            bool test = con.Test();
            tb_result.Visible = true;
            if (test)
            {
                tb_result.Text = "Ok!";
                tb_result.ForeColor = Color.Green;
            }
            else
            {
                tb_result.ForeColor = Color.Red;
                tb_result.Text = "Error!";
            }

        }
    }
}
