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
    public partial class ChangeInfo : Form
    {

        Entity.Users users = null;
        public ChangeInfo(Entity.Users u)
        {
            this.users = u;
            InitializeComponent();

            this.txt_uid.Text = users.uID.ToString();
            this.txt_uname.Text = users.uName;
            this.txt_mail.Text = users.uMail.ToString();
            this.txt_age.Text = users.age.ToString();
            if (users.sex == '男')
            {
                this.rad_man.Checked=true;
            }
            else
            {
                this.rad_wowen.Checked=true;
            }
            this.cmb_state.Text = users.state;

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.rad_man.Checked)
                {
                    users.sex = '男';
                }
                else
                {
                    users.sex = '女';
                }
                users.state = this.cmb_state.Text;
            }
            catch (Entity.HrmException he)
            {
                Msg.Box.Show(he.Message);
                return;
            }
            int age = -1;
            try
            {
                age = int.Parse(this.txt_age.Text);
            }
            catch
            {
                Msg.Box.Show("请输入正确的年龄格式！");
                return;
            }
            users.age = age;
            users.uMail = this.txt_mail.Text;

            if (BLL.quanli.Testusers(users) == true)
            {
                Msg.Box.Show("恭喜您，修改成功！");
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_age.Clear();
        }

        private void ChangeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
