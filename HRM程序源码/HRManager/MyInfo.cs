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
    public partial class MyInfo : Form
    {

        public MyInfo(PersonPlane p,Entity.Person per)
        {
            this.pp = p;
            this.p = per;
            InitializeComponent();
        }

        public MyInfo(Main m)
        {
            this.ma = m;
            InitializeComponent();
        }
        Main ma = null;
        //空PersonPanle对象
        PersonPlane pp = null;

        Entity.Person p = null;

        //选择修改
        private bool isChange = true;

        //照片名称
        private string picName = "";


        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.pp.LoadPInfo();
        }

        private void MyInfo_Load(object sender, EventArgs e)
        {
       
        }

        /// <summary>
        /// 加载已有人员信息
        /// </summary>
        public void LoadInfo()
        {
            //取消下拉事件
            this.comboBox2.SelectedIndexChanged -= new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            System.Data.DataTable dt = BLL.PersonBLL.FindOnly(p);
            this.textbox1.Text = dt.Rows[0][3].ToString();
            this.textBox3.Text = dt.Rows[0][5].ToString();
            this.textBox2.Text= dt.Rows[0][6].ToString();
            this.textBox9.Text= dt.Rows[0][14].ToString();
            this.textBox12.Text= dt.Rows[0][18].ToString();
            this.dateTimePicker2.Value=DateTime.Parse(dt.Rows[0][17].ToString());
            this.textBox4.Text= dt.Rows[0][8].ToString();
            this.textBox10.Text= dt.Rows[0][15].ToString();
            this.comboBox1.Text= dt.Rows[0][2].ToString();
            this.textBox5.Text= dt.Rows[0][9].ToString();
            this.textBox8.Text= dt.Rows[0][13].ToString();
            this.dateTimePicker1.Value=DateTime.Parse(dt.Rows[0][11].ToString());
            this.textBox6.Text= dt.Rows[0][10].ToString();
            this.comboBox2.Text= dt.Rows[0][25].ToString();
            this.comboBox3.Text = dt.Rows[0][22].ToString();
            this.textBox7.Text= dt.Rows[0][12].ToString();
            this.textBox11.Text= dt.Rows[0][16].ToString();
            picName = dt.Rows[0][7].ToString().Trim();
            if (dt.Rows[0][4].ToString() == "男")
            {
                this.radioButton1.Checked = true;
            }
            else
            {
                this.radioButton2.Checked = true;

            }
            string path = System.IO.Directory.GetCurrentDirectory() + @"\Person\" + dt.Rows[0][7].ToString().Trim()+ ".jpg";
            this.pictureBox1.Image = Image.FromFile(path);



        }

        /// <summary>
        /// 添加员工信息加载
        /// </summary>
        public void AddPerson()
        {
            isChange = false;
            //样式
            this.btn_change.Visible = false;
            this.btn_back.Visible = false;
            this.btn_add.Visible = true;
            this.btn_backMenu.Visible = true;

           

            //部门表加载
            this.comboBox2.DataSource = BLL.PersonBLL.PersonDT();
            this.comboBox2.DisplayMember = "DepName";

            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            
        }



        private void btn_change_Click(object sender, EventArgs e)
        {
          
            //加载个人信息
            try
            {
                p.pState = this.comboBox1.Text;

                p.pName = this.textbox1.Text;

                if (this.radioButton1.Checked) { p.pSex = '男'; }
                if (this.radioButton2.Checked) { p.pSex = '女'; }

                p.pEthnic = this.textBox3.Text;

                p.pAge = int.Parse(this.textBox2.Text);

                p.pPhone = this.textBox4.Text;

                p.pQQ = this.textBox5.Text;

                p.pMail = this.textBox6.Text;

                p.pInTime = DateTime.Parse(this.dateTimePicker1.Text);

                p.pSubject = this.textBox7.Text;

                p.pSchool = this.textBox8.Text;

                p.pFaction = this.textBox9.Text;

                p.pMarry = this.textBox10.Text;

                p.pInteresting = this.textBox11.Text;

                p.pBirthday = this.dateTimePicker2.Value;

                p.pCardID = this.textBox12.Text;

                p.pPic = picName;
               
            }
            catch (Exception he)
            {
                Msg.Box.Show(he.Message);
            }
            BLL.PersonBLL.UpWho(p);
            Msg.Box.Show("恭喜您，信息修改成功！");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }

            if (isChange == false)
            {
                //新新增用户的做法

                string logoPath = this.openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(logoPath);
                picName = BLL.FileUse.LocalPic(logoPath);

            }
            else
            {
                //修改用户的做法
                string logoPath = this.openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(logoPath);
                string name = BLL.FileUse.LocalPic(logoPath);
                BLL.PersonBLL.UpLogo(p,name);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox3.Text="";
            string dep=this.comboBox2.Text;
            this.comboBox3.DataSource = BLL.PersonBLL.PersonDT1(dep);
            this.comboBox3.DisplayMember = "JName";
            this.comboBox3.ValueMember = "JID";
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //添加信息
            Entity.Person pr = new Entity.Person();

            try
            {
                pr.pState = this.comboBox1.SelectedItem.ToString();

                pr.pName = this.textbox1.Text;

                if (this.radioButton1.Checked) { pr.pSex = '男'; }
                if (this.radioButton2.Checked) { pr.pSex = '女'; }

                pr.pEthnic = this.textBox3.Text;

                pr.pPhone = this.textBox4.Text;

                pr.pQQ = this.textBox5.Text;

                pr.pMail = this.textBox6.Text;

                pr.pInTime = this.dateTimePicker1.Value;

                pr.pSubject = this.textBox7.Text;

                pr.pSchool = this.textBox8.Text;

                pr.pFaction = this.textBox9.Text;

                pr.pMarry = this.textBox10.Text;

                pr.pInteresting = this.textBox11.Text;

                pr.pBirthday = this.dateTimePicker2.Value;

                pr.pCardID = this.textBox12.Text;

                pr.jID = int.Parse(this.comboBox3.SelectedValue.ToString());

                pr.pAge = int.Parse(this.textBox2.Text);


                pr.pPic = "10000";

                pr.pPwd = "123";
            }
            catch (Exception he)
            {
                Msg.Box.Show(he.Message);
                return;
            }

            if (BLL.PersonBLL.Person(pr) == true)
            { 
            Msg.Box.Show("恭喜您，新增人员成功！");
                ma.LoadPersonPanle();
            }
        }

        private void btn_backMenu_Click(object sender, EventArgs e)
        {
            ma.LoadPersonPanle();
        }
    }
}
