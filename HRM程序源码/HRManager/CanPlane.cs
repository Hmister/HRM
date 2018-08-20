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
    public partial class CanPlane : Form
    {
        
        public CanPlane()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            UserAdmin p = new UserAdmin();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            AddSysUser p = new AddSysUser();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_dep_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            DepAdmin p = new DepAdmin();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }
    }
}
