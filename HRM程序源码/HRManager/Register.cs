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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        //退出按钮样式
        private void lbl_Close_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }

        private void lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));

        }


        //最小化按钮样式
        private void lbl_Min_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }

        private void lbl_Min_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));

        }


        //最小化窗体
        private void lbl_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }


        //关闭窗体
        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //提交按钮样式
        private void btn_submit_MouseEnter(object sender, EventArgs e)
        {
            this.btn_submit.BackgroundImage = Image.FromFile(@"Source\Login\btn_m_e.png");
        }

        private void btn_submit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_submit.BackgroundImage = Image.FromFile(@"Source\Login\btn_m_u.png");
        }


        //重填按钮样式
        private void btn_reset_MouseEnter(object sender, EventArgs e)
        {
            this.btn_reset.BackgroundImage = Image.FromFile(@"Source\Login\btn_m_e.png");

        }

        private void btn_reset_MouseLeave(object sender, EventArgs e)
        {
            this.btn_reset.BackgroundImage = Image.FromFile(@"Source\Login\btn_m_u.png");

        }


        //重置按钮
        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txt_id.Text = string.Empty;
            this.txt_pass.Text = string.Empty;
            this.txt_pass1.Text = string.Empty;
            this.txt_age.Text = string.Empty;
      
        }


        //提交
        private void btn_submit_Click(object sender, EventArgs e)
        {

             //信息验证方法
            if (this.txt_id.Text == String.Empty)
            {
                Msg.Box.Show("请输入您要注册的帐号！");
                return;
            }

            foreach (char c in this.txt_id.Text)
            {
                if ((int)c > 127)
                {
                    Msg.Box.Show("您的账户名不能为中文字符！");
                    return;
                }
            }

            if (this.txt_pass.Text == String.Empty)
            {
                Msg.Box.Show("请设置您的账户密码！");
                return;
            }

            foreach (char c in this.txt_pass.Text)
            {
                if ((int)c > 127)
                {
                    Msg.Box.Show("您设置的密码不能为中文字符！");
                    return;
                }
            }

            if (this.txt_pass1.Text == String.Empty)
            {
                Msg.Box.Show("请再次输入您的账户密码！");
                return;
            }

            if (this.txt_pass1.Text!= this.txt_pass.Text)
            {
                Msg.Box.Show("您两次输入的账户密码不一致,请检查！");
                return;
            }

            if (this.txt_age.Text == String.Empty)
            {
                Msg.Box.Show("请填写您的年龄！");
                return;
            }
            int age = -1;
            try
            {
                age = int.Parse(this.txt_age.Text);
            }
            catch
            {
                Msg.Box.Show("请输入正确的年龄！");
                return;
            }

            Entity.Users users = new Entity.Users();
            try
            {
                users.uName = this.txt_id.Text;
                users.uPwd = this.txt_pass1.Text;
                users.age = age;
                users.lastTime = DateTime.Parse(System.DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss"));
                users.uMail = this.textBox1.Text;
                if (this.rad_man.Checked)
                {
                    users.sex = '男';
                }
                else
                {
                    users.sex = '女';
                }
            }
            catch (Entity.HrmException he)
            {
                Msg.Box.Show(he.Message);
                return;
            }

            if (BLL.LoginBLL.IsHave(users) == true)
            {
                Msg.Box.Show("该账号名称已存在！");
                return;
            }

            if (BLL.LoginBLL.RegUsers(users) == true)
            {
                Msg.Box.Show("注册成功，等待管理员审核！");
                this.Close();
            }

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            
        }
    }
}
