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
    public partial class GoodsAdd : Form
    {
        public GoodsAdd()
        {
            InitializeComponent();
        }
        Entity.Goods g = new Entity.Goods();
        bool IsUp = false;

        private void btn_find_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = int.Parse(this.txt_id.Text);
            }
            catch (Exception)
            {
                Msg.Box.Show("编号输入有误！");
                return;
            }
            try
            {
                g.gID = id;
            }
            catch(Exception)
            {
                Msg.Box.Show("该物品编号不存在！");
                return;
            }
            try
            {
                System.Data.DataTable dt = BLL.GoodsBLL.LoadGoodOnly(g);
                this.txt_name.Text = dt.Rows[0][0].ToString();
                this.txt_count.Text = dt.Rows[0][1].ToString();
                this.txt_price.Text = dt.Rows[0][2].ToString();
                IsUp = true;
            }
            catch (Exception)
            {
                Msg.Box.Show("该物品编号不存在！");
                return;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (IsUp == false)
            {
                Msg.Box.Show("请先查询出要修改的信息！");
                return;
            }
            try
            {
                g.gName = this.txt_name.Text;
                g.gCount = int.Parse(this.txt_count.Text);
                g.gPrice = double.Parse(this.txt_price.Text);
            }
            catch (Exception ex)
            {
                Msg.Box.Show(ex.Message);
                return;
            }
            if (BLL.GoodsBLL.UpAdd(g) == true)
            {
                Msg.Box.Show("恭喜您，修改成功!");
                Clear();
            }
            

        }


        private void Clear()
        {
            this.txt_id.Clear();
            this.txt_name.Clear();
            this.txt_count.Clear();
            this.txt_price.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                g.gName = this.txt_name.Text;
                g.gCount = int.Parse(this.txt_count.Text);
                g.gPrice = double.Parse(this.txt_price.Text);
            }
            catch (Exception ex)
            {
                Msg.Box.Show(ex.Message);
                return;
            }
            if (BLL.GoodsBLL.AddGoods(g) == true)
            {
                Msg.Box.Show("恭喜您，添加成功!");
                Clear();
            }
        }
    }
}
