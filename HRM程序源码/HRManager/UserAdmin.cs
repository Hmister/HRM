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
    public partial class UserAdmin : Form
    {
       
        public UserAdmin()
        {
            InitializeComponent();
        }

        private void UserAdmin_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.quanli.ADm();
            this.button5.Enabled = false;
            this.button6.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.textBox1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.textBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            char sex = char.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString());
            if (sex == '男')
            {
                this.radioButton1.Checked = true;


            }
            else if (sex == '女')
            {
                this.radioButton2.Checked = true;

            }
            this.textBox4.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
            this.comboBox1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Entity.Users users = new Entity.Users();
            int i = -1;
            int a = -1;
            try
            {
                i = int.Parse(this.textBox1.Text);
                a = int.Parse(this.textBox4.Text);
            }
            catch
            {
                Msg.Box.Show("请输入正确的格式！");
                return;
            }
            try
            {
               
                users.uID = i;
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
                
                users.age = a;
                users.state = this.comboBox1.Text;
                bool IsTrue = BLL.quanli.Testusers(users);
                if (IsTrue == true)
                {
                    Msg.Box.Show("修改成功！", "成功提示", Msg.Box.Ico.Info);
                }

            }
            catch (Entity.HrmException he)
            {
                Msg.Box.Show(he.Message);
            }
            this.dataGridView1.DataSource = BLL.quanli.ADm();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Entity.Users users = new Entity.Users();
            try
            {
                users.uID = int.Parse(this.textBox1.Text);
                if (users.uID == 10000)
                {
                    Msg.Box.Show("最高权限账户，禁止删除！","系统警告",Msg.Box.Ico.Warining);
                    return;
                }
                bool isDel = Msg.Box.RShow("是否确认删除改账户？","删除提示",Msg.Box.Ico.Question);
                if (isDel == true)
                {
                    if (BLL.quanli.TeDelete(users) == true)
                    {
                        Msg.Box.Show("恭喜您，删除成功！", "成功提示", Msg.Box.Ico.Info);
                    }
                }
            }
            catch (Entity.HrmException he)
            {
                Msg.Box.Show(he.Message);
            }
            this.dataGridView1.DataSource = BLL.quanli.ADm();
        }
    }
}
