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
    public partial class FinderAllPlan : Form
    {
        public FinderAllPlan()
        {
            InitializeComponent();
        }

        private void FinderAllPlan_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.Recruitment.CJobPlan();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Entity.Job job = new Entity.Job();
            if (this.textBox7.Text == "请输入岗位" || this.textBox7.Text == "")
            {
                this.dataGridView1.DataSource = BLL.Recruitment.CJobPlan();
                return;
            }

            try
            {
                job.jName = this.textBox7.Text;
            }
            catch(Entity.HrmException  he)
            {
                Msg.Box.Show(he.Message);
                return;
            }
            this.dataGridView1.DataSource = BLL.Recruitment.CJobPlan1(job);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            this.textBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.textBox3.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.textBox4.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            this.textBox1.Text = (this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString());
            this.textBox5.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
            this.textBox6.Text = (this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString());
        }
    }
}
