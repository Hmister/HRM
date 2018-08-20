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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }


        //关闭窗体
        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //最小化窗体
        private void lbl_Min_Click(object sender, EventArgs e)
        {
            this.WindowState=System.Windows.Forms.FormWindowState.Minimized;
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


        //转移光标
        private void About_Load(object sender, EventArgs e)
        {
            this.txt_c.Select(0,0);
        }

       
    }
}
