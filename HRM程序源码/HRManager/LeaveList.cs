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
    public partial class LeaveList : Form
    {
        public LeaveList()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Entity.Leave le = new Entity.Leave();
            Entity.Department dp = new Entity.Department();
            try
            {
                if (this.radioButton1.Checked)
                {
                    le.pID = int.Parse(this.textBox1.Text);
                    dataGridView1.DataSource = BLL.LeaveBLL.LeavePID(le);
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("未查找到您所要的信息!");
                    }
                }
                else if (this.radioButton2.Checked)
                {
                    dp.depID = int.Parse(this.comboBox1.SelectedValue.ToString());
                    dataGridView1.DataSource = BLL.LeaveBLL.LeaveDep(dp);
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("未查找到您所要的信息!");
                    }
                }
                else if (this.radioButton3.Checked)
                {
                   string name= this.textBox2.Text;
                    dataGridView1.DataSource = BLL.LeaveBLL.LeavePName(le,name);
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("未查找到您所要的信息!");
                    }
                }
                else if (this.radioButton4.Checked)
                {
                    le.lStart = this.dateTimePicker1.Value;
                    dataGridView1.DataSource = BLL.LeaveBLL.LeaveLstart(le);
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("未查找到您所要的信息!");
                    }
                }
                else
                {

                    Msg.Box.Show("您还未勾选查询方式");
                    return;

                }
            }
            catch(Exception ex)
            {

                Msg.Box.Show(ex.Message);
                return;

            }


        }

        private void LeaveList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.LeaveBLL.LeavesAll();


            this.comboBox1.DataSource = BLL.LeaveBLL.LeaveComBox();
            this.comboBox1.DisplayMember = "DepName";
            this.comboBox1.ValueMember = "DepID";
        }
    }
}
