using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee
{
    public partial class MsgRead : Form
    {
        Main m = null;
        Entity.Person p = null;
        Entity.Message msg = new Entity.Message();
        bool isSee = false;
        public MsgRead(Main ma, Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
            msg.pID = p.pID;
            this.dgv_msg.DataSource=EBLL.MsgBLL.LoadMsg(msg);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            m.LoadMenu();
        }

        private void dgv_msg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_msg.Rows.Count == 0) return;
            //判断当前
            if (isSee == false)
            {
                
                //加载未读
                this.dgv_msg.DataSource = EBLL.MsgBLL.LoadMsg(msg);
                //加载信息
                if (this.dgv_msg.Rows.Count == 0) return;
                msg.mID = int.Parse(this.dgv_msg.Rows[dgv_msg.CurrentCell.RowIndex].Cells[0].Value.ToString());
                this.txt_id.Text = EBLL.MsgBLL.SendID(msg).ToString();
                this.txt_text.Text = this.dgv_msg.Rows[dgv_msg.CurrentCell.RowIndex].Cells[1].Value.ToString();
                this.txt_time.Text = this.dgv_msg.Rows[dgv_msg.CurrentCell.RowIndex].Cells[2].Value.ToString();
                //更新状态
                EBLL.MsgBLL.UpState(msg);
            }
            else
            {
                //加载信息
                msg.mID = int.Parse(this.dgv_msg.Rows[dgv_msg.CurrentCell.RowIndex].Cells[0].Value.ToString());
                this.txt_id.Text = EBLL.MsgBLL.SendID(msg).ToString();
                this.txt_text.Text = this.dgv_msg.Rows[dgv_msg.CurrentCell.RowIndex].Cells[1].Value.ToString();
                this.txt_time.Text = this.dgv_msg.Rows[dgv_msg.CurrentCell.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            isSee = false;
            this.dgv_msg.DataSource = EBLL.MsgBLL.LoadMsg(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isSee = true;
            this.dgv_msg.DataSource = EBLL.MsgBLL.LoadMsgYse(msg);
        }
    }
}
