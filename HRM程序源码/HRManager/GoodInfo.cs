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
    public partial class GoodInfo : Form
    {
        public GoodInfo()
        {
            InitializeComponent();
        }

        private void GoodInfo_Load(object sender, EventArgs e)
        {
            this.dgv_list.DataSource = BLL.GoodsBLL.LoadGoods();
        }

        private void dgv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_list.Rows.Count == 0) return;
            this.textBox1.Text = this.dgv_list.Rows[dgv_list.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.textBox2.Text = this.dgv_list.Rows[dgv_list.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.textBox3.Text = this.dgv_list.Rows[dgv_list.CurrentCell.RowIndex].Cells[2].Value.ToString();
            this.textBox4.Text = this.dgv_list.Rows[dgv_list.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string msg = "";
            Entity.GoodsCode gc = new Entity.GoodsCode();
            try
            {
                gc.gcID = int.Parse(this.txt_id.Text);
            }
            catch (Exception ex)
            {
                Msg.Box.Show(ex.Message);
                return;
            }

            if (BLL.GoodsBLL.UseCodes(gc, out msg) == true)
            {
                bool isGo=Msg.Box.RShow(msg,"发放确认",Msg.Box.Ico.Question);
                if (isGo == false) return;
                if (BLL.GoodsBLL.UpCode(gc) == true)
                {
                    Msg.Box.Show("恭喜您，物品发放成功！");
                    this.txt_id.Clear();
                }
                else
                {
                    Msg.Box.Show("抱歉，物品发放失败！");
                }
            }
            else
            {
                Msg.Box.Show(msg);
            }
        }
    }
}
