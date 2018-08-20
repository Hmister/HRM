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
    public partial class PassChange : Form
    {
        //空entity对象
        Entity.Users users=null;
        public PassChange(Entity.Users u)
        {
            this.users = u;
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.txt_old.Text == "" || this.txt_new.Text == "" || this.txt_new1.Text == "")
            {
                Msg.Box.Show("请填写完整信息！");
                return;
            }
            if (this.txt_old.Text != users.uPwd)
            {
                Msg.Box.Show("原密码有误！");
                return;
            }
            if (this.txt_new.Text != this.txt_new1.Text)
            {
                Msg.Box.Show("两次密码输入的不一致！");
                return;
            }
            users.uPwd = this.txt_new1.Text;
            if (BLL.LoginBLL.PassChange(users) == true)
            {
                Msg.Box.Show("恭喜你，密码修改成功！");
                Application.Restart();
            }


        }

        private void Clear()
        {
            this.txt_new.Clear();
            this.txt_new1.Clear();
            this.txt_old.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
