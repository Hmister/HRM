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
    public partial class LeaveYN : Form
    {
        Entity.Users users = null;
        public LeaveYN(Entity.Users u)
        {
            this.users = u;
            InitializeComponent();
            this.dataGridView1.DataSource = BLL.LeaveBLL.LeaveYN();
        }
        Entity.Leave le = new Entity.Leave();
        Entity.Pay p = new Entity.Pay();
        private static bool isClick = false;
        private void btn_yes_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (isClick == false)
            {
                Msg.Box.Show("请先选择需要操作人员！");
                return;
            }
            le.lBoss = users.uName;
            le.lWhy = "待销假";
            le.pID=int.Parse(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
            Entity.MoneyModel mm = BLL.SalaryBLL.OpenSet();
            DateTime stop = DateTime.Parse(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Column5"].Value.ToString());
            DateTime start = DateTime.Parse(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Column4"].Value.ToString());
            TimeSpan ts = stop.Subtract(start);
            p.payDel = (BLL.SalaryBLL.PBase(le.pID) / mm.shouldDay) * ts.Days;
            if (BLL.LeaveBLL.UpLeave(le) == true)
            {
                BLL.LeaveBLL.UpState(p);
                Msg.Box.Show("恭喜您，操作成功!");
                dataGridView1.DataSource = BLL.LeaveBLL.LeaveYN();
            }
            else
            {
                Msg.Box.Show("抱歉，操作失败!");
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (isClick == false)
            {
                Msg.Box.Show("请先选择需要操作人员！");
                return;
            }
            le.lBoss = users.uName;
            le.lWhy = "驳回";
            le.pID = int.Parse(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
            if (BLL.LeaveBLL.UpLeave(le) == true)
            {
                Msg.Box.Show("恭喜您，成功驳回申请!");
                dataGridView1.DataSource = BLL.LeaveBLL.LeaveYN();
            }
            else
            {
                Msg.Box.Show("抱歉，驳回申请失败!");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isClick = true;
        }
    }
}
