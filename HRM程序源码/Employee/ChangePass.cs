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
    public partial class ChangePass : Form
    {
        Entity.Person p = null;
        public ChangePass(Entity.Person per)
        {
            this.p = per;
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (this.txt_old.Text == "" || this.txt_new.Text == "" || this.txt_new1.Text == "")
            {
                MessageBox.Show("请输入完整信息！");
                return;
            }
            string pwd=p.pPwd;

            //需要传入动态值
            System.Data.DataTable dt = EBLL.MyInfoBLL.MInfo(p);
            pwd = dt.Rows[0][1].ToString();
            if (this.txt_old.Text != pwd)
            {

               MessageBox.Show("您输入的原始密码错误！");
                return;
            }
            if (this.txt_new.Text != this.txt_new1.Text)
            {

                MessageBox.Show("您输入的两次密码不一致！");
                this.txt_new.Text = "";
                this.txt_new1.Text = "";
                return;
            }
            p.pPwd = this.txt_new1.Text;
            bool xMy = EBLL.MyInfoBLL.XMy(p);
            if (xMy == true)
            {
               MessageBox.Show("恭喜您，密码修改成功！");
                Application.Restart();
            }

        }
    }
}
