using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ipv4
{
    public partial class Form1 : Form
    {
        IP ip1 = new IP();
        IP ip2 = new IP();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = "";
            ip1.Set(Convert.ToByte(tb_1_1.Text), Convert.ToByte(tb_1_2.Text), Convert.ToByte(tb_1_3.Text), Convert.ToByte(tb_1_4.Text));
            ip2.Set(Convert.ToByte(tb_2_1.Text), Convert.ToByte(tb_2_2.Text), Convert.ToByte(tb_2_3.Text), Convert.ToByte(tb_2_4.Text));
            while (ip1.IsLess(ip2))
            {
                rtb_Result.Text += Convert.ToString(ip1.Get_1()) + "." + Convert.ToString(ip1.Get_2()) + "." + Convert.ToString(ip1.Get_3()) + "." + Convert.ToString(ip1.Get_4()) + "\n";
                ip1.Next();
            }
            rtb_Result.Text += Convert.ToString(ip1.Get_1()) + "." + Convert.ToString(ip1.Get_2()) + "." + Convert.ToString(ip1.Get_3()) + "." + Convert.ToString(ip1.Get_4()) + "\n";
        }
    }
}
