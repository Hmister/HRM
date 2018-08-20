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
    public partial class SetPlane : Form
    {
        Entity.Users users = null;
        Main ma = null;
        public SetPlane(Entity.Users u, Main m)
        {
            this.ma = m;
            this.users = u;
            InitializeComponent();
        }

        private void btn_ChangeInfo_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            ChangeInfo p = new ChangeInfo(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_soft_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            SoftVersion p = new SoftVersion();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            AboutWe p = new AboutWe();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_ChangLogo_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            UserLogo p = new UserLogo(ma,users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_mailSet_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            MailSet p = new MailSet();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }
    }
}
