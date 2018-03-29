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
    public partial class Vouchers : Form
    {
        int id = 0;
        public Vouchers()
        {
            InitializeComponent();
            UpdateData();

        }

        public void UpdateData()
        {
            DataTable dt = DataClass.con.SelectVouchers();
            dgv_datavouchers.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            string Code = dgv_datavouchers.Rows[id].Cells[0].Value.ToString();
            DataClass.con.DeleteVoucher(Code);
            UpdateData();
        }

        private void dgv_datavouchers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            bt_Edit.Enabled = true;
            bt_Eliminar.Enabled = true;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            EAVouchers add = new EAVouchers(0,"","","");
            add.ShowDialog();
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            string code = dgv_datavouchers.Rows[id].Cells[0].Value.ToString();
            string money = dgv_datavouchers.Rows[id].Cells[1].Value.ToString();
            string experience = dgv_datavouchers.Rows[id].Cells[2].Value.ToString();
            EAVouchers add = new EAVouchers(1,code,money,experience);
            add.ShowDialog();
        }
    }
}
