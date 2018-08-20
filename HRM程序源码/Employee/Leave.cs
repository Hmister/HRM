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
    public partial class Leave : Form
    {
        //对象
        Main m = null;
        Entity.Person p = null;
        public Leave(Main ma, Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
            this.txt_uid.Text = p.pID.ToString();
            this.dgv_main.DataSource = EBLL.WorkBLL.LoadLeave(p);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            m.LoadMenu();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Entity.Leave l = new Entity.Leave();
            try
            {
                l.pID = p.pID;
                l.lWhy = this.txt_reason.Text;
                l.lStart = this.dtp_start.Value;
                l.lStop = this.dtp_stop.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string msg = "";
            if (EBLL.WorkBLL.SubLeave(l, out msg) == true)
            {
                MessageBox.Show(msg);
                this.dtp_start.Value = System.DateTime.Now;
                this.dtp_stop.Value = System.DateTime.Now;
                this.txt_reason.Clear();
                this.dgv_main.DataSource = EBLL.WorkBLL.LoadLeave(p);
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void dgv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_main.Rows.Count == 0) return;
            this.dtp_start.Value=DateTime.Parse(this.dgv_main.Rows[dgv_main.CurrentCell.RowIndex].Cells[2].Value.ToString());
            this.dtp_stop.Value = DateTime.Parse(this.dgv_main.Rows[dgv_main.CurrentCell.RowIndex].Cells[3].Value.ToString());
            this.txt_reason.Text = this.dgv_main.Rows[dgv_main.CurrentCell.RowIndex].Cells[1].Value.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Entity.Leave l = new Entity.Leave();
            try
            {
                l.lID = int.Parse(this.dgv_main.Rows[dgv_main.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("请先选择记录行！");
                return;
            }
            if (EBLL.WorkBLL.UpLState(l) == true)
            {
                MessageBox.Show("恭喜您，销假成功！");
                EBLL.WorkBLL.UpLState(l);
                this.dgv_main.DataSource = EBLL.WorkBLL.LoadLeave(p);
            }
        }
    }
}
