using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRManager
{
    public partial class DepAdmin : Form
    {
        public DepAdmin()
        {
            InitializeComponent();
        }
        public void gx()
        {

            this.listBox1.DataSource = BLL.DepBLL.CDp();
            this.listBox1.DisplayMember = "DepName";
            this.listBox1.ValueMember = "DepID";

        }


        private void DepAdmin_Load(object sender, EventArgs e)
        {
            gx();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请输入完整信息", "错误提示", Msg.Box.Ico.Warining);
                return;


            }
            Entity.Department Dp = new Entity.Department();
            Dp.depName = this.textBox1.Text;
            bool IsTrue = BLL.DepBLL.ADL(Dp);
            if (IsTrue == true)
            {
                Msg.Box.Show("修改成功！", "成功提示", Msg.Box.Ico.Info);
                gx();
            }

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请输入完整信息", "错误提示", Msg.Box.Ico.Warining);
                return;


            }
            Entity.Department Dp = new Entity.Department();
            Dp.depID = int.Parse(this.listBox1.SelectedValue.ToString());
            Dp.depName = this.textBox1.Text;

            bool IsTrue = BLL.DepBLL.CDL(Dp);
            if (IsTrue == true)
            {
                Msg.Box.Show("修改成功！", "成功提示", Msg.Box.Ico.Info);
                gx();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请输入完整信息", "错误提示", Msg.Box.Ico.Warining);
                return;

            }


            Entity.Department Dp = new Entity.Department();
            try
            {
                Dp.depID = int.Parse(this.listBox1.SelectedValue.ToString());
                bool IsTrue = BLL.DepBLL.DDL(Dp);
                if (IsTrue == true)
                {
                    Msg.Box.Show("恭喜您,修改成功！", "成功提示", Msg.Box.Ico.Info);
                    gx();
                }
            }
            catch
            {
             Msg.Box.Show("该部门下存在岗位，请先清空岗位信息！", "系统警告", Msg.Box.Ico.Warining);
                return;
                
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = this.listBox1.Text;
        }
    }
}
