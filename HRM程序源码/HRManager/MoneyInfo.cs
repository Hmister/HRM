using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//----
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace HRManager
{
    public partial class MoneyInfo : Form
    {
        public MoneyInfo()
        {
            InitializeComponent();
            this.dgv_money.DataSource = BLL.SalaryBLL.AllPay();
            //加载部门
            this.cmb_dep.DataSource = BLL.DepBLL.CDp(); ;
            this.cmb_dep.DisplayMember = "DepName";
            this.cmb_dep.ValueMember = "DepID";

        }
        Entity.Pay p = new Entity.Pay();

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.check_moon.Checked)
                {
                    //按月份查询
                    if (this.rad_dep.Checked)
                    {
                        if (this.cmb_dep.Text == "")
                        {
                            Msg.Box.Show("请先选择部门！");
                            return;
                        }
                        p.payTime = this.dtp_moon.Value;
                        p.pID = int.Parse(this.cmb_dep.SelectedValue.ToString());
                        this.dgv_money.DataSource = BLL.SalaryBLL.FindByMDep(p);
                        NoFind();
                    }
                    else if (this.rad_pID.Checked)
                    {
                        if (this.txt_pID.Text == "")
                        {
                            Msg.Box.Show("请输入员工编号！");
                            return;
                        }
                        p.payTime = this.dtp_moon.Value;
                        p.pID = int.Parse(this.txt_pID.Text);
                        this.dgv_money.DataSource = BLL.SalaryBLL.FindByMPID(p);
                        NoFind();
                    }
                    else if (this.rad_salary.Checked)
                    {
                        if(this.txt_min.Text==""||this.txt_max.Text=="")
                        {
                            Msg.Box.Show("请填写金额范围！");
                            return;
                        }
                        double min = double.Parse(this.txt_min.Text);
                        double max = double.Parse(this.txt_max.Text);
                        if (min >= max)
                        {
                            Msg.Box.Show("范围输入有误！");
                            return;
                        }
                        p.payTime = this.dtp_moon.Value;
                        p.payDel = min;
                        p.payAdd = max;
                        this.dgv_money.DataSource = BLL.SalaryBLL.FindByMMoney(p);
                        NoFind();
                    }
                    else
                    {
                        Msg.Box.Show("请选择查询方式！");
                    }

                }
                else
                {
                    //不安月份查询
                    if (this.rad_dep.Checked)
                    {
                        if (this.cmb_dep.Text == "")
                        {
                            Msg.Box.Show("请先选择部门！");
                            return;
                        }
                        p.pID = int.Parse(this.cmb_dep.SelectedValue.ToString());
                        this.dgv_money.DataSource = BLL.SalaryBLL.FindByDep(p);
                        NoFind();
                    }
                    else if (this.rad_pID.Checked)
                    {
                        if (this.txt_pID.Text == "")
                        {
                            Msg.Box.Show("请输入员工编号！");
                            return;
                        }
                        p.pID = int.Parse(this.txt_pID.Text);
                        this.dgv_money.DataSource = BLL.SalaryBLL.FindByPID(p);
                        NoFind();
                    }
                    else if (this.rad_salary.Checked)
                    {
                        if (this.txt_min.Text == "" || this.txt_max.Text == "")
                        {
                            Msg.Box.Show("请填写金额范围！");
                            return;
                        }
                        double min = double.Parse(this.txt_min.Text);
                        double max = double.Parse(this.txt_max.Text);
                        if (min >= max)
                        {
                            Msg.Box.Show("范围输入有误！");
                            return;
                        }
                        p.payDel = min;
                        p.payAdd = max;
                        this.dgv_money.DataSource = BLL.SalaryBLL.FindByMoney(p);
                        NoFind();
                    }
                    else
                    {
                        Msg.Box.Show("请选择查询方式！");
                    }

                }
            }
            catch (Exception ex)
            {
                Msg.Box.Show(ex.Message);
                return;
            }
        }
        

        /// <summary>
        /// 导出为excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excel_Click(object sender, EventArgs e)
        {

            //调用保存对话框   
            SaveFileDialog dlg = new SaveFileDialog();
            //默然文件后缀   
            dlg.DefaultExt = "xls ";
            //文件后缀列表   
            dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
            //默然路径是系统当前路径   
            dlg.InitialDirectory = Directory.GetCurrentDirectory()+ @"\Files\Excel\Money\";
            //打开保存对话框   
            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            //返回文件路径   
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效   
            if (fileNameString.Trim() == "")
            { return; }
            //定义表格内数据的行数和列数   
            int rowscount = dgv_money.Rows.Count;
            int colscount = dgv_money.Columns.Count;
            //行数必须大于0   
            if (rowscount <= 0)
            {
                Msg.Box.Show("没有数据可供保存！");
                return;
            }

            //行数不可以大于65536   
            if (rowscount > 65536)
            {
                Msg.Box.Show("本页记录过多,超过Excel表上限！");
                return;
            }

            //验证以fileNameString命名的文件是否存在，如果存在删除它   
            FileInfo file = new FileInfo(fileNameString);
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                }
                catch (Exception error)
                {
                    Msg.Box.Show(error.Message);
                    return;
                }
            }

            //Excel应用对象
            Excel.Application objExcel = null;
            //Excel工作簿对象
            Excel.Workbook objWorkbook = null;
            //Excel工作表对象
            Excel.Worksheet objsheet = null;

            try
            {
                //申明对象   
                objExcel = new Microsoft.Office.Interop.Excel.Application();
                objWorkbook = objExcel.Workbooks.Add(Missing.Value);
                objsheet = (Excel.Worksheet)objWorkbook.ActiveSheet;
                //设置EXCEL不可见   
                objExcel.Visible = false;

                //向Excel中写入表格的表头   
                int displayColumnsCount = 1;
                for (int i = 0; i < dgv_money.ColumnCount; i++)
                {
                    if (dgv_money.Columns[i].Visible == true)
                    {
                        objExcel.Cells[1, displayColumnsCount] = dgv_money.Columns[i].HeaderText.Trim();
                        displayColumnsCount++;
                    }
                }
                //向Excel中逐行逐列写入表格中的数据   
                for (int row = 0; row < dgv_money.RowCount ; row++)
                {
                    displayColumnsCount = 1;
                    //写入每行每列数据
                    for (int col = 0; col < colscount; col++)
                    {
                        if (dgv_money.Columns[col].Visible == true)
                        {
                            try
                            {
                                objExcel.Cells[row + 2, displayColumnsCount] = dgv_money.Rows[row].Cells[col].Value.ToString().Trim();
                                displayColumnsCount++;
                            }
                            catch (Exception ex)
                            {
                                Msg.Box.Show(ex.Message);
                                return;
                            }

                        }
                    }

                }
       
                //保存文件   
                objWorkbook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value,Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,Missing.Value, Missing.Value);
            }


            catch (Exception error)
            {
                Msg.Box.Show(error.Message);
                return;
            }
            finally
            {
                //关闭Excel应用   
                if (objWorkbook != null) objWorkbook.Close(Missing.Value, Missing.Value, Missing.Value);
                if (objExcel.Workbooks != null) objExcel.Workbooks.Close();
                if (objExcel != null) objExcel.Quit();

                objsheet = null;
                objWorkbook = null;
                objExcel = null;
            }
            Msg.Box.Show("表格成功导出至："+fileNameString+"!");

        }


        /// <summary>
        /// 未查找到数据
        /// </summary>
        private void NoFind()
        {
            if (this.dgv_money.RowCount == 0)
            {
                Msg.Box.Show("未查找到任何数据！");
            }
        }

        private int goDay;
        private double allDayAdd;

        private void MoneyInfo_Load(object sender, EventArgs e)
        {
            Entity.MoneyModel mm = BLL.SalaryBLL.OpenSet();
            goDay = mm.goDay;
            allDayAdd = mm.allAdd;
        }


        private DataTable CountAll()
        {
            DataTable dt = (dgv_money.DataSource as DataTable);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = int.Parse(dt.Rows[i][2].ToString());
                if (int.Parse(dt.Rows[i][5].ToString()) == int.Parse(dt.Rows[i][6].ToString()))
                {
                   
                    //更新工资
                    dt.Rows[i][7] = double.Parse(dt.Rows[i][7].ToString()) + allDayAdd;
                    BLL.SalaryBLL.UpPay(id, allDayAdd);
                    //更新记录
                    dt.Rows[i][9] = double.Parse(dt.Rows[i][9].ToString()) + allDayAdd;
                    BLL.SalaryBLL.InAdd(id, allDayAdd);
                }
                else
                {
                    //缺勤计算
                    double bmoney = BLL.SalaryBLL.SearchBase(id);
                    int days = int.Parse(dt.Rows[i][5].ToString()) - int.Parse(dt.Rows[i][6].ToString());
                    double money = (bmoney/ int.Parse(dt.Rows[i][5].ToString())) * days;
                    //更新工资
                    dt.Rows[i][8] = double.Parse(dt.Rows[i][8].ToString()) + money;
                    BLL.SalaryBLL.UpPay1(id, money);
                    //更新记录
                    dt.Rows[i][9] = double.Parse(dt.Rows[i][9].ToString()) -money;
                    BLL.SalaryBLL.InDel(id, money);
                    
                }
            }
            return dt;
        }

        private void btn_allDay_Click(object sender, EventArgs e)
        {
            if (this.dgv_money.RowCount == 0)
            {
                Msg.Box.Show("未查询任何数据，无法计算！");
                return;
            }
            if (DateTime.Parse(dgv_money.Rows[0].Cells["Column10"].Value.ToString()).Year != System.DateTime.Now.Year|| DateTime.Parse(dgv_money.Rows[0].Cells["Column10"].Value.ToString()).Month != System.DateTime.Now.Month)
            {
                Msg.Box.Show("不在当前年月，请切换至当前年月！");
                return;
            }
            if (System.DateTime.Now.Day != goDay)
            {
                Msg.Box.Show("不在工资结算日，无法计算！");
                return;
            }
            if (BLL.SalaryBLL.SearchMoon() == true)
            {
                Msg.Box.Show("本月全勤奖已计算，请勿重复计算！");
                return;
            }
            this.dgv_money.DataSource = CountAll();
            Msg.Box.Show("系统已完成计算！");

        }
    }
}
