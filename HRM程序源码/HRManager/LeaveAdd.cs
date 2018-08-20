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
    public partial class LeaveAdd : Form
    {
        Entity.Users users = null;
        public LeaveAdd(Entity.Users u)
        {
            this.users = u;
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            Entity.Leave le = new Entity.Leave();
            //员工编号
            le.pID = int.Parse(this.textBox4.Text);
            //开始时间
            string Ls = this.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff");
            le.lStart = DateTime.Parse(Ls);
            //结束时间
            string lsp = this.dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff");
            le.lStop = DateTime.Parse(lsp);
            //请假原因
            le.lWhy =this.textBox2.Text;
            le.lBoss = users.uName;
            //审核状态
            le.lState = "通过";

            if (BLL.LeaveBLL.Leaves1(le) == true)
            {
                Msg.Box.Show("恭喜您，添加成功！");
                clear();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void clear()
        {
            this.textBox4.Clear();
            this.textBox2.Clear();
            this.textBox1.Clear();
        }

    }
}
