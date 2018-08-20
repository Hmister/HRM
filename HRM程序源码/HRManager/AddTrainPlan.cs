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
    public partial class AddTrainPlan : Form
    {
        public AddTrainPlan()
        {
            InitializeComponent();
        }

        private void AddTrainPlan_Load(object sender, EventArgs e)
        {
            DataTable dt = BLL.TrainPlanBLL.bb();
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "LeName";
            this.comboBox1.ValueMember = "LeID";
            this.comboBox1.SelectedIndex=0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entity.Train ss = new Entity.Train();
            try
            {
            ss.leID = int.Parse(this.comboBox1.SelectedValue.ToString());
            ss.tpTeacher = this.textBox1.Text;
            ss.tpAdr = this.textBox2.Text;
            }
            catch (Exception he)
            {
                Msg.Box.Show(he.Message);
                return;
            }

             int i = 0;
            try
            {
                i = int.Parse(this.textBox3.Text);
            }
            catch
            {
                Msg.Box.Show("请输入正确的格式！");
                return;
            }


            ss.tpCount = i;
            ss.tpStart = dateTimePicker1.Value;
            ss.tpStop = dateTimePicker2.Value;
            TimeSpan ts = dateTimePicker2.Value.AddMinutes(5) - dateTimePicker1.Value;
            if (ts.Seconds <= 0)
            {
                Msg.Box.Show("结束时间不可早于开始时间！");
                return;
            }

               bool isTrue = BLL.TrainPlanBLL.sss(ss);
           
                if (isTrue == true)
                {
                    Msg.Box.Show("恭喜您，添加培训计划成功");
                this.textBox1.Clear();
                this.textBox2.Clear();
                this.textBox3.Clear();
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }
    }
}
