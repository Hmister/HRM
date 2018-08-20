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
    public partial class TPNotes : Form
    {
        public TPNotes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entity.Train a = new Entity.Train();
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.comboBox3.Text == "")
            {
                Msg.Box.Show("请输入完整信息!");
                return;
            }
            try
            {
                a.pID = int.Parse(this.textBox2.Text);
                a.tpID = int.Parse(this.textBox3.Text);
            }
            catch (Exception)
            {
                Msg.Box.Show("输入的代号格式有误！");
                return;
            }
            try
            {
                a.nResult = this.comboBox3.Text;
                a.nTexts = this.textBox1.Text;
            }
            catch(Entity.HrmException he)
            {
                Msg.Box.Show(he.Message);
                return;
             }
            try
            {
                if (BLL.TrainPlanBLL.IsHave(a) == 0)
                {
                    Msg.Box.Show("您输入的工号不存在！");
                    return;
                }
                if (BLL.TrainPlanBLL.adjId(a) == true)
                {
                    Msg.Box.Show("恭喜您，成功添加评价！");
                    this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = "";
                }
                else
                {
                    Msg.Box.Show("抱歉，添加失败！");
                    return;
                }
            }
            catch(Exception)
            {
                Msg.Box.Show("您输入的计划代号有误！");
                return;
            }
            this.dataGridView1.DataSource = BLL.TrainPlanBLL.TPNotes(a);
        }
    }
}
