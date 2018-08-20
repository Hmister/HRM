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
    public partial class MailSet : Form
    {
        public MailSet()
        {
            InitializeComponent();
            LoadSet();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Msg.Box.Show("同步配置前，需选择中需同步的BackMail.XML文件！");
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            if (BLL.SalaryBLL.UpSaveMail(ofd.FileName) == true)
            {
                Msg.Box.Show("恭喜您，同步成功！");
            }
            else
            {
                Msg.Box.Show("抱歉，同步失败！");
            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                //主设置
                Entity.Mail mail1 = new Entity.Mail();
                mail1.url = this.txt_smtp1.Text;
                mail1.port = int.Parse(this.txt_smtpk1.Text);
                mail1.account = this.txt_id1.Text;
                mail1.pass = this.txt_pass1.Text;
                BLL.FileUse.SaveMailSet(mail1, "MailSet");
                //备用设置
                Entity.Mail mail2 = new Entity.Mail();
                mail2.url = this.txt_smtp2.Text;
                mail2.port = int.Parse(this.txt_smtpk2.Text);
                mail2.account = this.txt_id2.Text;
                mail2.pass = this.txt_pass2.Text;
                BLL.FileUse.SaveMailSet(mail2, "BackMail");
            }
            catch (Entity.HrmException he)
            {
                Msg.Box.Show(he.Message);
                return;
            }

            Msg.Box.Show("恭喜您，配置保存成功！");
            LoadSet();
        }

        /// <summary>
        /// 加载配置
        /// </summary>
        private void LoadSet()
        {
            //主设置
            Entity.Mail mail1 = BLL.FileUse.OpenMailSet("MailSet");
            this.txt_smtp1.Text=mail1.url ;
            this.txt_smtpk1.Text=mail1.port.ToString();
            this.txt_id1.Text=mail1.account ;
            this.txt_pass1.Text=mail1.pass ;
            //备用设置
            Entity.Mail mail2 = BLL.FileUse.OpenMailSet("BackMail");
            this.txt_smtp2.Text = mail2.url;
            this.txt_smtpk2.Text = mail2.port.ToString();
            this.txt_id2.Text = mail2.account;
            this.txt_pass2.Text = mail2.pass;
        }

    }
}
