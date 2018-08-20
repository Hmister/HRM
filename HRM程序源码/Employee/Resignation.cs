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
    public partial class Resignation : Form
    {
        //对象
        Main m = null;
        Entity.Person p = null;
        public Resignation(Main ma, Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            m.LoadMenu();
        }

        Entity.Resignation re = new Entity.Resignation();
        private void btn_sub_Click(object sender, EventArgs e)
        {
            re.pID = p.pID;
            System.Data.DataTable dt = EBLL.MyInfoBLL.CR(re);
            if (dt.Rows.Count != 0)
            {
                if (dt.Rows[0][6].ToString() == "驳回")
                {
                    MessageBox.Show("抱歉！您的申请被驳回!");
                    return;
                }
                if (dt.Rows[0][6].ToString() == "申请中")
                {
                    MessageBox.Show("抱歉！您的申请还在审核中！");
                    return;
                }
            }
            DialogResult dr = MessageBox.Show("是否确认提交辞职申请？","申请确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
           re.rText = this.textBox1.Text;
           bool xMY = EBLL.MyInfoBLL.TR(re);
           if (xMY == true)
           {
                 MessageBox.Show("恭喜您，申请提交成功！");
                 return;
            }
          }
    }
}
