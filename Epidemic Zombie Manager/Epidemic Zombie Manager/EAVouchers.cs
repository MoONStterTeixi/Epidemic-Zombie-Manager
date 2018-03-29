using System;
using System.Windows.Forms;

namespace Epidemic_Zombie_Manager
{
    public partial class EAVouchers : Form
    {
        int act;
        public EAVouchers(int action,string voucher, string money, string experience)
        {
            InitializeComponent();
            tb_Experience.Text = experience;
            tb_Money.Text = money;
            tb_VoucherCode.Text = voucher;
            act = action;
            if(act == 1)
            {
                tb_VoucherCode.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            string code = tb_VoucherCode.Text;
            int money = Convert.ToInt32(tb_Money.Text);
            int exp = Convert.ToInt32(tb_Experience.Text);
            if(act == 0) //Crear
            {
                DataClass.con.AddVoucher(code,money+"",exp+"");
            }
            else //Editar
            {
                    DataClass.con.EditVouchers(code, money + "", exp + "");
                }
            }catch(Exception ex) {
                MessageBox.Show("Revisa los campos hay valores no validos.", "Epidemic Zombie Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            this.Close();
        }
    }
}
