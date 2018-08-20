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
    public partial class TrainLesson : Form
    {
        public TrainLesson()
        {
            InitializeComponent();
        }
        Entity.Train a = new Entity.Train();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                a.leName = this.textBox1.Text;
                a.leType = this.comboBox1.Text;
                a.leText = this.textBox2.Text;
            }
            catch (Exception ex)
            {
                Msg.Box.Show(ex.Message);
                return;
            }

            if (BLL.CourseBLL.adt(a) == true)
            {
                Msg.Box.Show("增加成功");
                this.textBox1.Clear();
                this.textBox2.Clear();

            }
            else
            {
                Msg.Box.Show("失败");
            }

            this.dataGridView1.DataSource = BLL.CourseBLL.dt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.leName = this.textBox1.Text;
            a.leType = this.comboBox1.Text;
            a.leText = this.textBox2.Text;
            a.leID = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            if (BLL.CourseBLL.mod(a) == true)
            {
                Msg.Box.Show("修改成功");
                this.dataGridView1.DataSource = BLL.CourseBLL.dt();
                this.textBox1.Clear();
                this.textBox2.Clear();
            }
            else
            {
                Msg.Box.Show("失败");
            }
        }

        private void TrainLesson_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.CourseBLL.dt();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            this.textBox1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.comboBox1.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            this.textBox2.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }
    }
}
