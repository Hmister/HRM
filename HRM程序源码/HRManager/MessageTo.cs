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
    public partial class MessageTo : Form
    {
        Entity.Users user = null;
        public MessageTo(Entity.Users u)
        {
            this.user = u;
            InitializeComponent();
        }

        private void MessageTo_Load(object sender, EventArgs e)
        {
            this.dgv_history.DataSource=BLL.MessageTo.LoadMsg();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if(this.txt_text.Text=="")
            {
                Msg.Box.Show("请输入您要发送的消息！");
                return;
            }
            Entity.Message m = new Entity.Message();
            m.uID = user.uID;
            m.mText = this.txt_text.Text;
            m.mTIme = System.DateTime.Now;
            if (BLL.MessageTo.AddMsg(m) == true)
            {
                Msg.Box.Show("恭喜您，消息发送成功！");
                this.dgv_history.DataSource = BLL.MessageTo.LoadMsg();
                this.txt_text.Clear();
            }
        }


    }
}
