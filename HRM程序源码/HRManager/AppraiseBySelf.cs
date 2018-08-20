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
    public partial class AppraiseBySelf : Form
    {
        Entity.Users users = null;
        public AppraiseBySelf( Entity.Users u)
        {
            this.users = u;
            InitializeComponent();
        }

        Entity.Appraise a = new Entity.Appraise();
        private void AppraiseBySelf_Load(object sender, EventArgs e)
        {
            this.dgv_main.DataSource = BLL.AppraiseBLL.LoadSelf();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (this.dgv_main.Rows.Count == 0) return;
            a.aID=int.Parse(this.dgv_main.Rows[dgv_main.CurrentCell.RowIndex].Cells[0].Value.ToString());
            if (BLL.AppraiseBLL.DelSelf(a) == true)
            {
                Msg.Box.Show("恭喜您，操作成功！");
                this.dgv_main.DataSource = BLL.AppraiseBLL.LoadSelf();
            }
        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            if (this.dgv_main.Rows.Count == 0) return;
            a.aID = int.Parse(this.dgv_main.Rows[dgv_main.CurrentCell.RowIndex].Cells[0].Value.ToString());
            a.ABoss = users.uName;
                   
            if (BLL.AppraiseBLL.UpSelf(a) == true)
            {
                Msg.Box.Show("恭喜您，操作成功！");
                this.dgv_main.DataSource = BLL.AppraiseBLL.LoadSelf();
            }
        }
    }
}
