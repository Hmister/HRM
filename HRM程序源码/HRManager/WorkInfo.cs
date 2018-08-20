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
    public partial class WorkInfo : Form
    {
        public WorkInfo()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Entity.Work wr = new Entity.Work();
            Entity.Department dp = new Entity.Department();
            Entity.Person pr = new Entity.Person();
            if (radioButton1.Checked)
            {

                wr.wTime = this.dateTimePicker1.Value;
                dataGridView1.DataSource = BLL.WorkBLL.work5(wr, this.dateTimePicker2.Value);
                int i = this.dataGridView1.Rows.Count;
                if (i == 0)
                {

                    Msg.Box.Show("未查找到您所要的信息！");


                }
            }
            else if (radioButton2.Checked)
            {
                dp.depID = int.Parse(this.comboBox1.SelectedValue.ToString());

                dataGridView1.DataSource = BLL.WorkBLL.work2(dp);
                int i = this.dataGridView1.Rows.Count;
                if (i == 0)
                {

                    Msg.Box.Show("未查找到您所要的信息");

                }
            }
            else
            {
                Msg.Box.Show("您还未勾选查询方式!");
                return;
            }

            
        }

        private void WorkInfo_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BLL.WorkBLL.Work4();
            Entity.Person pr = new Entity.Person();
            this.comboBox1.DataSource = BLL.WorkBLL.Work3();
            comboBox1.DisplayMember = "DepName";
            comboBox1.ValueMember = "DepID";
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            //调用保存对话框   
            SaveFileDialog dlg = new SaveFileDialog();
            //默然文件后缀   
            dlg.DefaultExt = "xls ";
            //文件后缀列表   
            dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
            //默然路径是系统当前路径   
            dlg.InitialDirectory = Directory.GetCurrentDirectory() + @"\Files\Excel\Work\";
            //打开保存对话框   
            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            //返回文件路径   
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效   
            if (fileNameString.Trim() == "")
            { return; }
            //定义表格内数据的行数和列数   
            int rowscount = dataGridView1.Rows.Count;
            int colscount = dataGridView1.Columns.Count;
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
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (dataGridView1.Columns[i].Visible == true)
                    {
                        objExcel.Cells[1, displayColumnsCount] = dataGridView1.Columns[i].HeaderText.Trim();
                        displayColumnsCount++;
                    }
                }
                //向Excel中逐行逐列写入表格中的数据   
                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    displayColumnsCount = 1;
                    //写入每行每列数据
                    for (int col = 0; col < colscount; col++)
                    {
                        if (dataGridView1.Columns[col].Visible == true)
                        {
                            try
                            {
                                objExcel.Cells[row + 2, displayColumnsCount] = dataGridView1.Rows[row].Cells[col].Value.ToString().Trim();
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
                objWorkbook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
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
            Msg.Box.Show("表格成功导出至：" + fileNameString + "!");
        }
    }
}
