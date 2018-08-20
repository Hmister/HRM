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
    public partial class PersonLeave : Form
    {
        public PersonLeave()
        {
            InitializeComponent();
        }

        private void PersonLeave_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.ResignationBLL.cr();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            this.textBox1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.textBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            this.textBox4.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            this.textBox5.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();

        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请选择信息");
                return;

            }
            Entity.Resignation RE = new Entity.Resignation();
            RE.rID = int.Parse(this.textBox1.Text);
            RE.rState = "驳回";
            bool XG = BLL.ResignationBLL.XG(RE);
            if (XG == true)
            {
                Msg.Box.Show("驳回成功！", "成功提示", Msg.Box.Ico.Info);
                this.dataGridView1.DataSource = BLL.ResignationBLL.cr();
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (this.textBox1.Text == "")
            {
                Msg.Box.Show("请选择信息");
                return;

            }


            bool isGo = Msg.Box.RShow("是否同意该员工的辞职申请？", Msg.Box.Ico.Question);
            if (isGo == true)
            {
                Entity.Person per = new Entity.Person();
                per.pID = int.Parse(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());

                Entity.Resignation RE = new Entity.Resignation();
                RE.rID = int.Parse(this.textBox1.Text);
                bool XG = BLL.ResignationBLL.SR(RE);
                if (XG == true)
                {

                    Msg.Box.Show("辞退成功！", "成功提示", Msg.Box.Ico.Info);
                    BLL.PersonBLL.Person1(per);
                    this.dataGridView1.DataSource = BLL.ResignationBLL.cr();
                }
                else
                {

                    Msg.Box.Show("辞退失败！", "失败示", Msg.Box.Ico.Info);
                    return;
                }
            }
            else
            {

                Msg.Box.Show("辞退失败！", "失败示", Msg.Box.Ico.Info);
                return;
            }



        }
    }
}
