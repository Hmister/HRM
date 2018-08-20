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
    public partial class MyInfo : Form
    {
        //对象
        Main m = null;
        Entity.Person p = null;
        public MyInfo(Main ma, Entity.Person per)
        {
            this.m = ma;
            this.p = per;
            InitializeComponent();
            show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            m.LoadMenu();
        }

        public void show()
        {
            System.Data.DataTable dt = EBLL.MyInfoBLL.MInfo(p);
            //显示姓名
            this.textbox1.Text = dt.Rows[0][3].ToString();
            //显示年龄
            this.textBox2.Text = dt.Rows[0][6].ToString();
            //显示性别
            if (dt.Rows[0][4].ToString() == "男")
            {
                this.radioButton1.Checked = true;
            }
            else
            {
                this.radioButton2.Checked = true;

            }
            //显示民族
            this.textBox3.Text = dt.Rows[0][5].ToString();
            //显示手机号码
            this.textBox4.Text = dt.Rows[0][8].ToString();
            //显示qq号
            this.textBox5.Text = dt.Rows[0][9].ToString();
            //显示邮箱
            this.textBox6.Text = dt.Rows[0][10].ToString();
            //显示专业
            this.textBox7.Text = dt.Rows[0][12].ToString();
            //毕业院校
            this.textBox8.Text = dt.Rows[0][13].ToString();
            //显示政治面貌
            this.textBox9.Text = dt.Rows[0][14].ToString();
            //显示工号
            this.textBox10.Text = dt.Rows[0][0].ToString();
            //显示爱好
            this.textBox11.Text = dt.Rows[0][16].ToString();
            //显示身份证号码
            this.textBox12.Text = dt.Rows[0][18].ToString();
            //婚姻状态
            this.comboBox1.Text = dt.Rows[0][15].ToString();
            //显示生日
            this.dateTimePicker1.Value = DateTime.Parse(dt.Rows[0][17].ToString());



        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            Entity.Person p = new Entity.Person();
            try
            {
                p.pID = int.Parse(this.textBox10.Text);
                p.pName = this.textbox1.Text;
                char sex;
                if (this.radioButton1.Checked)
                {
                    sex = char.Parse(this.radioButton1.Text);
                }
                else
                {

                    sex = char.Parse(this.radioButton2.Text);
                }
                p.pSex = sex;
                p.pEthnic = this.textBox3.Text;
                p.pAge = int.Parse(this.textBox2.Text);
                p.pPhone = this.textBox4.Text;
                p.pQQ = this.textBox5.Text;
                p.pMail = this.textBox6.Text;
                p.pSubject = this.textBox7.Text;
                p.pSchool = this.textBox8.Text;
                p.pFaction = this.textBox9.Text;
                p.pMarry = this.comboBox1.Text;
                p.pInteresting = this.textBox11.Text;
                p.pBirthday = this.dateTimePicker1.Value;
                p.pCardID = this.textBox12.Text;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bool xMY = EBLL.MyInfoBLL.XMY(p);
            if (xMY == true)
            {
                MessageBox.Show("恭喜您，信息修改成功！", "成功提示",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass(p);
            cp.ShowDialog();
        }
    }
}
