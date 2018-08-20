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
    public partial class PchangeWork : Form
    {
        public PchangeWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PchangeWork_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = BLL.PersonBLL.PersonDT();
            this.comboBox1.DisplayMember = "DepName";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text == "")
            {
                Msg.Box.Show("请先查询出人员信息！");
            }
            pr.jID =int.Parse(this.comboBox2.SelectedValue.ToString().Trim());
            if (BLL.JobChangeBLL.JobUPDATE(pr) == true)
            {
                Msg.Box.Show("恭喜您,成功变动人员岗位！");
                this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.textBox4.Text = this.comboBox2.Text = "";

            }
        }


        Entity.Person pr = new Entity.Person();
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                pr.pID = int.Parse(this.textBox2.Text);
            }
            catch (FormatException)
            {
                Msg.Box.Show("请输入正确的工号格式！");
                return;
            }
            try
            {
                this.textBox4.Text = BLL.JobChangeBLL.JobPName(pr);
                this.textBox1.Text = BLL.JobChangeBLL.JobDepName(pr);
                this.textBox3.Text = BLL.JobChangeBLL.JobJName(pr);
            }
            catch(Exception)
            {
                Msg.Box.Show("您输入的员工编号不存在!");
                return;

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //岗位
            comboBox2.DataSource = BLL.PersonBLL.PersonDT1(this.comboBox1.Text);
            comboBox2.DisplayMember = "JName";
            comboBox2.ValueMember = "JID";
        }




    }
}