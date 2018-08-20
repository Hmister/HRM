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
    public partial class PAppraise : Form
    {
        public PAppraise()
        {
            InitializeComponent();
        }
        Entity.Appraise ap = new Entity.Appraise();

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (this.radioButton1.Checked)
                {
                    ap.aID = int.Parse(this.textBox1.Text);
                    dataGridView1.DataSource = BLL.AppraiseBLL.Appraise3(ap);
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("未查找到您所要的信息");
                    }
                        return;
                }
                if (this.radioButton2.Checked)
                {
                    ap.pID = int.Parse(this.textBox2.Text);
                    dataGridView1.DataSource = BLL.AppraiseBLL.Appraise4(ap);
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("未查找到您所要的信息");
                    }
                    return;
                }
                if (this.radioButton3.Checked)
                {
                    ap.aRate = this.comboBox1.Text;
                    dataGridView1.DataSource = BLL.AppraiseBLL.Appraise5(ap);
                    int i = this.dataGridView1.Rows.Count;
                    if (i == 0)
                    {

                        Msg.Box.Show("未查找到您所要的信息");
                    }
                    return;
                }
                else
                {
                    Msg.Box.Show("您还未勾选查询方式");
                    return;

                }
            }
            catch
            {

                Msg.Box.Show("您的填写有误，请重新填写");
                return;


            }
        }

        private void PAppraise_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.AppraiseBLL.Appraise2(ap);
        }
    }
}
