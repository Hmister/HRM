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
    public partial class AppraiseForm : Form
    {
        Entity.Users users = null;
        public AppraiseForm(Entity.Users u)
        {
            this.users = u;
            InitializeComponent();
            this.textBox2.Text = users.uName;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            Entity.Appraise ap = new Entity.Appraise();
            try
            {
                ap.pID = int.Parse(this.textBox1.Text);
                ap.aTIme = this.dateTimePicker1.Value;
                ap.ABoss = users.uName;
                ap.aRate = this.comboBox1.Text; ;
                ap.aText = this.textBox3.Text;
                ap.aType = "高层直评";
            }
            catch (Exception he)
            {
                Msg.Box.Show(he.Message);
                return;

            }

            try
            {
                if (BLL.AppraiseBLL.Appraise1(ap) == true)
                {
                    Msg.Box.Show("恭喜您，添加成功");

                }
            }
            catch (Exception)
            {
                Msg.Box.Show("您输入的工号有误！");
                return;
            }



            //清空
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.comboBox1.Text = "";





        }

        private void button3_Click(object sender, EventArgs e)
        {

            //清空
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.comboBox1.Text = "";


        }
    }
}
