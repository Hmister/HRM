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
    public partial class Goods : Form
    {
        //对象
        Main m = null;
        Entity.Person p = null;
        Entity.GoodsCode gc = new Entity.GoodsCode();
        Entity.Goods g = new Entity.Goods();
        public Goods(Main ma, Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
            gc.pID = p.pID;
            this.dataGridView1.DataSource = EBLL.GoodsBLL.LoadGoods();
            LoadCode();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            m.LoadMenu();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if (this.txt_id.Text == "" || this.txt_count.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            try
            {
                gc.gID= int.Parse(this.txt_id.Text);
                gc.gcCount = int.Parse(this.txt_count.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (EBLL.GoodsBLL.SearchCode(gc) == false)
            {
                MessageBox.Show("抱歉，您输入的物品编号不存在！");
                return;
            }
            g.gID = gc.gID;
            if (gc.gcCount > EBLL.GoodsBLL.SearchCount(g))
            {
                MessageBox.Show("抱歉，领取数量超过库存数量！");
                return;
            }
            if (EBLL.GoodsBLL.AddCode(gc) == true)
            {
                int code = EBLL.GoodsBLL.SearchGC(gc);
                MessageBox.Show("恭喜您，物品申领成功；请持领取码前往指定地点领取。\n您本次的兑换码为：" + code);
                //刷新列表
                LoadCode();
            }
            else
            {
                MessageBox.Show("抱歉，申领失败！");
            }

        }

        /// <summary>
        /// 待使用领取码
        /// </summary>
        private void LoadCode()
        {
            this.txt_codes.Text=EBLL.GoodsBLL.CodesList(gc);
        }


    }
}
