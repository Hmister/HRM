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
    public partial class MoneyPanle : Form
    {
        Entity.Users users = null;
        public MoneyPanle(Entity.Users u)
        {
            this.users = u;
            InitializeComponent();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            MoneyExpress p = new MoneyExpress();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_bad_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            MoneyDel p = new MoneyDel(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_good_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            MoneyAdd p = new MoneyAdd(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_money_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            MoneyInfo p = new MoneyInfo();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_model_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            MoneyModel p = new MoneyModel();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }
    }
}
