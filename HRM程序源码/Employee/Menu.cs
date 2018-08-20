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
    public partial class Menu : Form
    {
        //对象
        Main m = null;
        Entity.Person p = null;
        public Menu(Main ma,Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
            MsgCount();
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            m.LoadLeave();
        }

        private void MsgCount()
        {

            int count = EBLL.LoginBLL.MsgCount(p);
            if (count == 0)
            {
                this.btn_red.Visible = false;
            }
            else
            {
                this.btn_red.Visible = true;
                if (count <= 9)
                {
                    this.btn_red.Text = count.ToString();
                }
                else
                {
                    this.btn_red.Text = "*";
                }
            }
        }

        private void btn_message_Click(object sender, EventArgs e)
        {
            m.LoadMsg();
        }

        private void btn_money_Click(object sender, EventArgs e)
        {
            m.LoadExpress();
        }

        private void btn_study_Click(object sender, EventArgs e)
        {
            m.LoadTrain();
        }

        private void btn_appriase_Click(object sender, EventArgs e)
        {
            m.LoadAppraise();
        }

        private void btn_gods_Click(object sender, EventArgs e)
        {
            m.LoadGoods();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            m.LoadMyInfo();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            m.LoadResignation();
        }
    }
}
