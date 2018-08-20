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
    public partial class MoneyDel : Form
    {
        Entity.Users users = null;
        public MoneyDel(Entity.Users u)
        {
            this.users = u;
            InitializeComponent();
            this.textBox4.Text = users.uName;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Entity.Express a = new Entity.Express();
            try
            {
                a.pID = int.Parse(this.textBox1.Text);
                a.eType = "处罚";
                a.eMoney = double.Parse(this.textBox2.Text);
                a.eWhy = this.textBox3.Text;
                a.eTime = this.dateTimePicker1.Value;
                a.eBoss = this.textBox4.Text;
            }
            catch 
            {
                Msg.Box.Show("请填写正确的信息！");
                return;
            }

            if (BLL.MoneyBLL.FindP(a) == false)
            {
                Msg.Box.Show("抱歉，该人员编号不存在！");
                return;
            }
            if (BLL.MoneyBLL.ADd(a) == true)
            {
                //更新本月工资
                BLL.MoneyBLL.MoneyDel(a);
                Msg.Box.Show("恭喜您，操作成功");
                clear();
            }
        }

        /// <summary>
        /// 清空输入
        /// </summary>
        private void clear()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
