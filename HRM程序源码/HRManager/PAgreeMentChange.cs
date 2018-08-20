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
    public partial class PAgreeMentChange : Form
    {
        public PAgreeMentChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgreeMentListForm_Load(object sender, EventArgs e)
        {

            Entity.AgreeMent ag = new Entity.AgreeMent();
            this.dataGridView1.DataSource = BLL.AgreeMentBLL.AgreeMent2(ag);



        }

        private void button2_Click(object sender, EventArgs e)
        {


            Entity.AgreeMent ag = new Entity.AgreeMent();
            try
            {
                if (this.radioButton1.Checked)
                {
                    ag.amID = int.Parse(this.textBox1.Text);
                    dataGridView1.DataSource = BLL.AgreeMentBLL.AgreeMent3(ag);
                    if (sum() == false) { return; }
                }
                else if (this.radioButton3.Checked)
                {
                    ag.pID = int.Parse(this.textBox2.Text);
                    dataGridView1.DataSource = BLL.AgreeMentBLL.AgreeMent4(ag);
                    if (sum() == false) { return; }
                }
                else if (this.radioButton2.Checked)
                {
                    ag.amState = this.comboBox1.Text;
                    dataGridView1.DataSource = BLL.AgreeMentBLL.AgreeMent5(ag);
                    if (sum() == false) { return; }
                }
                else
                {
                    Msg.Box.Show("您还未勾选查询方式!");
                    return;
                }
            }
            catch
            {
                Msg.Box.Show("您填的信息有误！");
                return;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Entity.AgreeMent ag = new Entity.AgreeMent();
            try
            {
                ag.amID = int.Parse(this.textBox3.Text);
                ag.pID = int.Parse(this.textBox4.Text);
                ag.amStop = this.dateTimePicker1.Value;
                ag.amState = this.comboBox2.Text;
                ag.amBase = double.Parse(this.textBox5.Text);
                if (BLL.AgreeMentBLL.AgreeMent6(ag) == true)
                {

                    Msg.Box.Show("恭喜您,修改成功");
                    this.dataGridView1.DataSource = BLL.AgreeMentBLL.AgreeMent2(ag);
                }
            }
            catch
            {
                Msg.Box.Show("您输入的信息有误！");
                return;
            }
            //清空
            this.textBox3.Text = this.textBox4.Text =this.textBox5.Text= this.comboBox2.Text = "";
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.textBox3.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Column1"].Value.ToString();

            this.textBox4.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Column2"].Value.ToString();

            this.dateTimePicker1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();

            this.comboBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();

            this.textBox5.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["Column7"].Value.ToString();
        }






        //提示未找到相关数据
        public bool sum()
        {

            int i = this.dataGridView1.Rows.Count;
            if (i == 0)
            {

                Msg.Box.Show("未查找到您所要的信息!");
                return false;
            }
            else
            {
                return true;
            }




        }
    }
}
