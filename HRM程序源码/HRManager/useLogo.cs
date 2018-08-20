using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScoreAdmin
{
    public partial class useLogo : Form
    {

        //公共图片索引值
        public static int picIndex;

        public useLogo()
        {
            InitializeComponent();
        }

        private void useLogo_Load(object sender, EventArgs e)
        {

        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            this.pic1.BackColor=System.Drawing.Color.Blue;
            this.pic2.BackColor = System.Drawing.Color.White;
            this.pic3.BackColor = System.Drawing.Color.White;
            this.pic4.BackColor = System.Drawing.Color.White;
            this.pic5.BackColor = System.Drawing.Color.White;
            this.pic6.BackColor = System.Drawing.Color.White;
            picIndex = 0;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic2.BackColor = System.Drawing.Color.Blue;
            this.pic3.BackColor = System.Drawing.Color.White;
            this.pic4.BackColor = System.Drawing.Color.White;
            this.pic5.BackColor = System.Drawing.Color.White;
            this.pic6.BackColor = System.Drawing.Color.White;
            picIndex = 1;
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic2.BackColor = System.Drawing.Color.White;
            this.pic3.BackColor = System.Drawing.Color.Blue;
            this.pic4.BackColor = System.Drawing.Color.White;
            this.pic5.BackColor = System.Drawing.Color.White;
            this.pic6.BackColor = System.Drawing.Color.White;
            picIndex = 2;
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic2.BackColor = System.Drawing.Color.White;
            this.pic3.BackColor = System.Drawing.Color.White;
            this.pic4.BackColor = System.Drawing.Color.Blue;
            this.pic5.BackColor = System.Drawing.Color.White;
            this.pic6.BackColor = System.Drawing.Color.White;
            picIndex = 3;
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic2.BackColor = System.Drawing.Color.White;
            this.pic3.BackColor = System.Drawing.Color.White;
            this.pic4.BackColor = System.Drawing.Color.White;
            this.pic5.BackColor = System.Drawing.Color.Blue;
            this.pic6.BackColor = System.Drawing.Color.White;
            picIndex = 4;
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic2.BackColor = System.Drawing.Color.White;
            this.pic3.BackColor = System.Drawing.Color.White;
            this.pic4.BackColor = System.Drawing.Color.White;
            this.pic5.BackColor = System.Drawing.Color.White;
            this.pic6.BackColor = System.Drawing.Color.Blue;
            picIndex = 5;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
          
            //更新用户头像索引到数据库
            string sql_changePic = string.Format("UPDATE Teacher SET Picture={0} WHERE Name='{1}'",picIndex,Login.loginName);
            int rows = DBHelper.getRows(sql_changePic);
            if (rows > 0) {
            //提示消息
                MessageBox.Show("头像保存成功！","消息提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                this.Close();
            }
           
        }

        
    }
}
