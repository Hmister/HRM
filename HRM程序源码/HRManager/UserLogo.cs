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
    public partial class UserLogo : Form
    {
        public UserLogo(Main m,Entity.Users u)
        {
            this.ma = m;
            this.users = u;
            InitializeComponent();
            string path = @"Source\User\" + users.logo + ".png";
            this.pic_logo.Image = Image.FromFile(path);
        }

        //是否使用系统头像
        private bool ifUseSys = false;
        private string logoID = "";
        private string logoPath = "";
        
        //传入对象
        Main ma = null;
        Entity.Users users = null;


        //选中像按钮样式
        private void ChangeLogo(object sender)
        {
            foreach (var pic in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {

                if (pic == sender as PictureBox)
                {
                    pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(144)))));
                }
                else
                {
                   pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(146)))), ((int)(((byte)(173)))));
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChangeLogo(sender);
            this.pic_logo.Image =pictureBox1.Image;
            logoID = "1";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChangeLogo(sender);
            this.pic_logo.Image = pictureBox2.Image;
            logoID = "2";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeLogo(sender);
            this.pic_logo.Image = pictureBox3.Image;
            logoID = "3";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChangeLogo(sender);
            this.pic_logo.Image = pictureBox4.Image;
            logoID = "4";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ChangeLogo(sender);
            this.pic_logo.Image = pictureBox8.Image;
            logoID = "5";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ChangeLogo(sender);
            this.pic_logo.Image = pictureBox7.Image;
            logoID = "6";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ChangeLogo(sender);
            this.pic_logo.Image = pictureBox6.Image;
            logoID = "7";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeLogo(sender);
            this.pic_logo.Image = pictureBox5.Image;
            logoID = "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (logoID == "" && ifUseSys == false)
            {
                Msg.Box.Show("您未修改头像！");
                {
                    return;
                }
            }
            if (ifUseSys == false)
            {
                users.logo = logoID;
                if (BLL.quanli.UpLogo(users) == true)
                {
                    Msg.Box.Show("恭喜您，修改成功！");
                    ma.LoadUserLogo();

                }
            }
            else
            {
                //使用本地图片
                string logo= BLL.FileUse.LocalLogo(logoPath);
                users.logo = logo;
                if (BLL.quanli.UpLogo(users) == true)
                {
                    Msg.Box.Show("恭喜您，修改成功！");
                    ma.LoadUserLogo();
                    ifUseSys = false;
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr=this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ifUseSys = true;
                logoPath = this.openFileDialog1.FileName;
                this.pic_logo.Image = Image.FromFile(logoPath);
            }
        }
    }
}
