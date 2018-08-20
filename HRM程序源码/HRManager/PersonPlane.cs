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
    public partial class PersonPlane : Form
    {
        Main ma = null;
        Entity.Users users = null;
        public PersonPlane(Main m,Entity.Users u)
        {
            this.users = u;
            InitializeComponent();
            this.ma = m;
        }


        private void btn_PInfo_Click(object sender, EventArgs e)
        {
            LoadPInfo();
        }

        //人员信息列表
        public void LoadPInfo()
        {
            this.panel.Controls.Clear();
            PInfo p = new PInfo(this);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        //人员详情显示
        public void LoadMyInfo(PersonPlane pp,Entity.Person per)
        {
            this.panel.Controls.Clear();
            MyInfo p = new MyInfo(pp,per);
            p.LoadInfo();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        /// <summary>
        /// 添加人员信息
        /// </summary>
        public void LoadNewInfo()
        {
            this.panel.Controls.Clear();
            MyInfo p = new MyInfo(ma);
            p.AddPerson();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadNewInfo();
           
        }

        private void btn_changeWork_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            PchangeWork p = new PchangeWork();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();

        }

        private void btn_InsertPAG_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            PinsertAgree p = new PinsertAgree();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_updateAG_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            PAgreeMentChange p = new PAgreeMentChange();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            AppraiseForm p = new AppraiseForm(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }

        private void btn_appraise_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            PAppraise p = new PAppraise();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();

        }

        private void btn_see_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            AppraiseBySelf p = new AppraiseBySelf(users);
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel.Controls.Add(p);
            p.Show();
        }
    }
}
