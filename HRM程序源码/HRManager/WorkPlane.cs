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
    public partial class WorkPlane : Form
    {
        Entity.Users users = null;
        public WorkPlane(Entity.Users u)
        {
            this.users = u;
            InitializeComponent();


        }

        private void btn_ChangeInfo_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            LeaveYN p = new LeaveYN(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            LeaveAdd p = new LeaveAdd(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_work_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            WorkInfo p = new WorkInfo();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            LeaveList p = new LeaveList();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_allGoods_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            GoodInfo p = new GoodInfo();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_addGoods_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            GoodsAdd p = new GoodsAdd();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }
    }
}
