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
    public partial class PinsertAgree : Form
    {
        public PinsertAgree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entity.AgreeMent ag = new Entity.AgreeMent();
            try
            {
                ag.pID = int.Parse(this.textBox1.Text);
                ag.amStart = this.dateTimePicker1.Value;
                ag.amStop = this.dateTimePicker2.Value;
                ag.amState = this.comboBox1.Text;
                ag.AMText = this.textBox2.Text;
                ag.amBase = double.Parse(this.txt_amBase.Text);
                if (BLL.AgreeMentBLL.AgreeMent1(ag) == true)
                {

                    Msg.Box.Show("添加成功");
                    this.textBox1.Text = "";
                    this.comboBox1.SelectedIndex= 0;
                    this.txt_amBase.Text = "";

                }
                else
                {
                    Msg.Box.Show("添加失败");
                    return;
                }
            }
            catch
            {

                Msg.Box.Show("您填写的信息有误！");
                return;

            }
         

        }
    }
}
