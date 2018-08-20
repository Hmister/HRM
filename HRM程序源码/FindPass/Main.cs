using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace FindPass
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (ToInternet() == false)
            {
                MessageBox.Show("请先将此电脑连接至互联网！");
                return;
            }
            if (this.txt_id.Text == "" || this.txt_mail.Text == "")
            {
                MessageBox.Show("请输入完整信息！");
                return;
            }
            try
            {
                if (this.rad_admin.Checked)
                {
                    //管理员账户
                    if (Pass.CheckID1(this.txt_id.Text) == false)
                    {
                        MessageBox.Show("此账号不存在！");
                        return;
                    }
                    if (Pass.CheckMail1(this.txt_id.Text, this.txt_mail.Text) == false)
                    {
                        MessageBox.Show("输入的邮箱与账号不相符！");
                        return;
                    }
                    string pass = Pass.UpPass1(this.txt_id.Text);
                    //发邮件
                    try
                    {
                        SendM.SendMail(this.txt_mail.Text.Trim(), pass.Trim());
                        MessageBox.Show("恭喜您，重置成功,请注意查收！\n接收邮箱：" + this.txt_mail.Text);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
                else if (this.rad_per.Checked)
                {
                    //员工账户
                    if (Pass.CheckID2(this.txt_id.Text) == false)
                    {
                        MessageBox.Show("此工号不存在！");
                        return;
                    }
                    if (Pass.CheckMail2(this.txt_id.Text, this.txt_mail.Text) == false)
                    {
                        MessageBox.Show("输入的邮箱与工号不相符！");
                        return;
                    }
                    string pass = Pass.UpPass2(this.txt_id.Text);
                    //发邮件
                    try
                    {
                        SendM.SendMail(this.txt_mail.Text.Trim(), pass.Trim());
                        MessageBox.Show("恭喜您，重置成功,请注意查收！\n接收邮箱：" + this.txt_mail.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("请先选择账户类型！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        /// <summary>
        /// 测试网络连接的方法
        /// </summary>
        /// <returns></returns>
        public static bool ToInternet()
        {
            Ping p = new Ping();
            //淘宝网IP
            PingReply pip = p.Send("140.205.172.5");
            if (pip.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
