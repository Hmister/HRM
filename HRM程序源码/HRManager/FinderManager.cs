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
    public partial class FinderManager : Form
    {
        public FinderManager()
        {
            InitializeComponent();
        }

        private void btn_allPlan_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            FinderAllPlan p = new FinderAllPlan();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            FinderPlanAdmin p = new FinderPlanAdmin();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_if_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            FinderIf p = new FinderIf();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_tryUse_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            TryUse p = new TryUse();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_changeJob_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            JobAdmin p = new JobAdmin();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            PersonLeave p = new PersonLeave();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }
    }
}
