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
    public partial class AllTrainPlan : Form
    {
        public AllTrainPlan()
        {
            InitializeComponent();
        }

        private void AllTrainPlan_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.TrainPlanBLL.dt();
            DataTable dt = BLL.TrainPlanBLL.cous();
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "LeName";
            this.comboBox1.ValueMember = "LeID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entity.Train ap = new Entity.Train();
            try
            {
                if (this.radioButton1.Checked)
                {
                    ap.leID = int.Parse(this.comboBox1.SelectedValue.ToString());
                    dataGridView1.DataSource = BLL.TrainPlanBLL.cou(ap);
                    clear();
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("抱歉,未查找到任何信息!");
                        return;
                    }
                }
                else if (this.radioButton2.Checked)
                {
                    ap.tpTeacher = this.textBox1.Text;
                    dataGridView1.DataSource = BLL.TrainPlanBLL.lect(ap);
                    clear();
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("抱歉,未查找到任何信息!");
                        return;
                    }
                }
                else if (this.radioButton3.Checked)
                {
                    ap.tpAdr = this.textBox2.Text;
                    dataGridView1.DataSource = BLL.TrainPlanBLL.place(ap);
                    clear();
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("抱歉,未查找到任何信息!");
                        return;
                    }
                }
                else
                {
                    Msg.Box.Show("您还未勾选查询方式!");
                    return;

                }
            }
            catch
            {

                Msg.Box.Show("您的填写有误，请重新填写");
             
                return;


            }

        }

        private void clear()
        {
            this.radioButton1.Checked = this.radioButton2.Checked = this.radioButton3.Checked = false;
            this.textBox1.Text = this.textBox2.Text = "";
        }

    }
}
