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
    public partial class AddSysUser : Form
    {
        public AddSysUser()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Entity.Users users = new Entity.Users();
            try
            {
                users.uName = this.textBox2.Text;
                users.uPwd = this.textBox3.Text;
                char sex;
                if (this.radioButton1.Checked)
                {
                    sex = char.Parse(this.radioButton1.Text);
                }
                else
                {
                    sex = char.Parse(this.radioButton2.Text);
                }
                users.sex = sex;
                users.age = int.Parse(this.textBox4.Text);
                users.state = this.comboBox1.Text;
                users.uMail = "请及时修改为您的邮箱账号！";
            }
            catch (Entity.HrmException he)
            {
                Msg.Box.Show(he.Message);
                return;
            }
            if (BLL.quanli.CheckName(users) == false)
            {
                Msg.Box.Show("此账户名已存在，请勿重复添加！");
                return;
            }

            bool IsAdd = BLL.quanli.TeAdd(users);
            if (IsAdd == true)
            {
                Msg.Box.Show("新增管理员" + users.uName + "成功！", "成功提示", Msg.Box.Ico.Info);
            }
            this.dataGridView1.DataSource = BLL.quanli.ADm();
        }

        private void AddSysUser_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.quanli.ADm();
        }
    }
}
