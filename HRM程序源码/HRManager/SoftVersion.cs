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
    public partial class SoftVersion : Form
    {
        public SoftVersion()
        {
            InitializeComponent();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
           
            if (BLL.Common.ToInternet() == false)
            {
                Msg.Box.Show("未能连接至互联网！");
                return;
            }
            if (BLL.Common.ToVPS() == false)
            {
                Msg.Box.Show("连接服务器失败！");
                return;
            }

            if (BLL.Common.CheckUp()>200)
            {
                bool IsUpdate = Msg.Box.RShow("检测到有更新的版本是否前往官方网站下载？",Msg.Box.Ico.Question);
                if (IsUpdate == true)
                {
                    System.Diagnostics.Process.Start("explorer.exe", "http://www.sanmco.com/download/");
                }
                return;
            }
            Msg.Box.Show("恭喜您,您的软件为最新版本！");
        }
    }
}
