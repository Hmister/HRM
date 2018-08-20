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
    public partial class FinderPlanAdmin : Form
    {
        public FinderPlanAdmin()
        {
            InitializeComponent();
        }

        private void FinderPlanAdmin_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.AddFinder.CJobPla();

            //绑定部门
            this.comboBox1.DataSource = BLL.AddFinder.aaa();
            //绑定显示值
            this.comboBox1.DisplayMember = "DepName";
            //绑定实际值
            this.comboBox1.ValueMember = "DepID";
            //绑定联系人
            this.comboBox3.DataSource = BLL.AddFinder.ccc();
            //绑定显示值
            this.comboBox3.DisplayMember = "UName";


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //this.textBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            this.comboBox3.Text = (this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString());
            this.textBox5.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
            this.textBox6.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            this.comboBox1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.comboBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            this.dateTimePicker1.Value = DateTime.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //绑定岗位
            this.comboBox2.DataSource = BLL.AddFinder.bbb(this.comboBox1.Text);
            //绑定显示值
            this.comboBox2.DisplayMember = "JName";
            //绑定实际值
            this.comboBox2.ValueMember = "JID";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entity.JobPlan jp = new Entity.JobPlan();
            //接受编号
            jp.jpID = int.Parse(this.textBox1.Text);
            //接受岗位
            jp.jID = int.Parse(this.comboBox2.SelectedValue.ToString());
            //接受人数
            jp.jpCount = int.Parse(this.textBox3.Text);
            //接受内容
            jp.jpNeed = this.textBox6.Text;
            //接受联系人
            jp.jpCall = this.comboBox3.Text;
            //接受电话
            jp.jpPhone = this.textBox5.Text;
            //接受最后时间
            jp.jpStop = this.dateTimePicker1.Value;
            bool jop = BLL.AddFinder.JPL(jp);
            if (jop == true)
            {
                Msg.Box.Show("修改成功！", "成功提示", Msg.Box.Ico.Info);


            }
            this.dataGridView1.DataSource = BLL.AddFinder.CJobPla();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Entity.JobPlan jp = new Entity.JobPlan();
            //接受编号
            jp.jpID = int.Parse(this.textBox1.Text);
            bool Djp = BLL.AddFinder.DJP(jp);
            if (Djp == true)
            {
                Msg.Box.Show("删除成功！", "成功提示", Msg.Box.Ico.Info);

            }
            this.dataGridView1.DataSource = BLL.AddFinder.CJobPla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Entity.JobPlan jp = new Entity.JobPlan();
            //接受岗位
            jp.jID = int.Parse(this.comboBox2.SelectedValue.ToString());
            //接受人数
            jp.jpCount = int.Parse(this.textBox3.Text);
            //接受内容
            jp.jpNeed = this.textBox6.Text;
            //接受联系人
            jp.jpCall = this.comboBox3.Text;
            //接受电话
            jp.jpPhone = this.textBox5.Text;
            //接受最后时间

            jp.jpStop = this.dateTimePicker1.Value;
            bool jop = BLL.AddFinder.AJP(jp);
            if (jop == true)
            {
                Msg.Box.Show("添加成功！", "成功提示", Msg.Box.Ico.Info);


            }
            this.dataGridView1.DataSource = BLL.AddFinder.CJobPla();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string a = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //this.textBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string b = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string c = (this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString());
            string d = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
            string l = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string f = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string g = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            DateTime h = DateTime.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString());

            MessageBox.Show("编号：" + a + "\r\n" + "需求部门：" + f + "\r\n" + "需求岗位：" + g + "\r\n" + "需求人数：" + b + "人" + "\r\n" + "岗位要求：" + l + "\r\n" + "截至日期：" + h + "\r\n" + "招聘联系人：" + c + "\r\n" + "联系人电话：" + d, "招聘详细信息");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Entity.JobPlan jp = new Entity.JobPlan();
            string a = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            jp.jpID = int.Parse(a);
            bool isExit = Msg.Box.RShow("请确认是否删除此项？", "删除提示", Msg.Box.Ico.Question);
            if (isExit == true)
            {
                BLL.AddFinder.DJP(jp);
                this.dataGridView1.DataSource = BLL.AddFinder.CJobPla();
            }
        }
    }
}
