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
    public partial class FindBug : Form
    {
        public FindBug()
        {
            InitializeComponent();
        }

     
        //关闭窗体
        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //窗体最小化
        private void lbl_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }


        //退出按钮样式
        private void lbl_Close_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }

        private void lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));

        }


        //最小化按钮样式
        private void lbl_Min_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }

        private void lbl_Min_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));

        }


        //提交按钮样式
        private void btn_submit_MouseEnter(object sender, EventArgs e)
        {
            this.btn_submit.BackgroundImage = Image.FromFile(@"Source\Login\btn_m_e.png");
        }

        private void btn_submit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_submit.BackgroundImage = Image.FromFile(@"Source\Login\btn_m_u.png");
        }


        //重填按钮样式
        private void btn_reset_MouseEnter(object sender, EventArgs e)
        {
            this.btn_reset.BackgroundImage = Image.FromFile(@"Source\Login\btn_m_e.png");

        }

        private void btn_reset_MouseLeave(object sender, EventArgs e)
        {
            this.btn_reset.BackgroundImage = Image.FromFile(@"Source\Login\btn_m_u.png");

        }

       
        //重填按钮
        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txt_bugTitle.Text = String.Empty;
            this.txt_call.Text = String.Empty;
            this.txt_bugText.Text = String.Empty;
            this.rad_type1.Checked=false;
            this.rad_type2.Checked = false;
            this.rad_type3.Checked = false;
        }


        //提交按钮
        private void btn_submit_Click(object sender, EventArgs e)
        {
            Entity.FindBug fb = new Entity.FindBug();
            try
            {
                //字符串变量type接收问题类型
                int Type=-1;
                if (this.rad_type1.Checked)
                {
                    Type = 0;
                }
                else if (this.rad_type2.Checked)
                {
                    Type = 1;
                }
                else
                {
                    Type = 2;
                }

                fb.title = this.txt_bugTitle.Text;
                fb.type = Type;
                fb.call = this.txt_call.Text;
                fb.text = this.txt_bugText.Text;
                if (BLL.FindBugBLL.SubQuestion(fb))
                {
                    Msg.Box.Show("感谢您的反馈,我们将会及时处理！");
                    this.Hide();
                }
            }
            catch (Entity.HrmException he)
            {
                Msg.Box.Show(he.Message);
            }
        }



        

    }
}
