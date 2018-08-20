using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee
{
    public partial class Appraise : Form
    {
        //对象
        Main m = null;
        Entity.Person p = null;
        public Appraise(Main ma, Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            m.LoadMenu();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" )
            {
                MessageBox.Show("请您填写自评内容！");
                return;
            }
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("请您选择自评等级！");
                return;
            }

            Entity.Appraise ap = new Entity.Appraise();
            ap.pID = p.pID;
            ap.aTIme = DateTime.Now;
            ap.aText = this.textBox1.Text;
            ap.aRate = this.comboBox1.Text;
            if (EBLL.GoodsBLL.gets(ap) == true)
            {
                MessageBox.Show("恭喜您，自评提交成功");
                this.textBox1.Clear();

            }
            else
            {

                MessageBox.Show("抱歉，自评提交失败");
                return;
            }
        }
    }
}
