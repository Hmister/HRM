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
    public partial class FinderIf : Form
    {
        public FinderIf()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.textBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            this.textBox4.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
            this.textBox5.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
            this.textBox6.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[15].Value.ToString();

        }

        private void FinderIf_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.FindBLL.CPL();
        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请先选中需要操作的人员！");
                return;
            }

            Entity.Person cc = new Entity.Person();
            cc.pID = int.Parse(this.textBox1.Text);
            cc.pState = "试用";
            bool XGP = BLL.FindBLL.xgPP(cc);
            if (XGP == true)
            {
                Msg.Box.Show("【 " + this.textBox2.Text + "】 已经成为实习员工", "成功提示", Msg.Box.Ico.Info);
                this.dataGridView1.DataSource = BLL.FindBLL.CPL();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";

            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请先选中需要操作的人员！");
                return;
            }

            Entity.Person dd = new Entity.Person();
            bool isDel = Msg.Box.RShow("是否确认删除 【"+this.textBox2.Text+"】 的信息？",Msg.Box.Ico.Question);
            if (isDel == false)
            {
                return;
            }
            dd.pID = int.Parse(this.textBox1.Text);
            bool DGP = BLL.FindBLL.DDPR(dd);
            if (DGP == true)
            {
                Msg.Box.Show("【 "+this.textBox2.Text + " 】已经从应聘人员中移除！", "成功提示", Msg.Box.Ico.Info);
                this.dataGridView1.DataSource = BLL.FindBLL.CPL();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
                return;
            }
        }
    
    }
}
