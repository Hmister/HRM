namespace HRManager
{
    partial class MoneyInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_dep = new System.Windows.Forms.ComboBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_pID = new System.Windows.Forms.TextBox();
            this.rad_salary = new System.Windows.Forms.RadioButton();
            this.rad_pID = new System.Windows.Forms.RadioButton();
            this.rad_dep = new System.Windows.Forms.RadioButton();
            this.check_moon = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_moon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_allDay = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_money = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_money)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tip
            // 
            this.lbl_tip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_tip.Location = new System.Drawing.Point(392, 22);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(345, 40);
            this.lbl_tip.TabIndex = 14;
            this.lbl_tip.Text = "公司员工工资详情";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmb_dep);
            this.groupBox1.Controls.Add(this.txt_max);
            this.groupBox1.Controls.Add(this.txt_min);
            this.groupBox1.Controls.Add(this.txt_pID);
            this.groupBox1.Controls.Add(this.rad_salary);
            this.groupBox1.Controls.Add(this.rad_pID);
            this.groupBox1.Controls.Add(this.rad_dep);
            this.groupBox1.Controls.Add(this.check_moon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_moon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_allDay);
            this.groupBox1.Controls.Add(this.btn_excel);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 116);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 按条件筛选工资详情 ";
            // 
            // cmb_dep
            // 
            this.cmb_dep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_dep.FormattingEnabled = true;
            this.cmb_dep.Location = new System.Drawing.Point(87, 71);
            this.cmb_dep.Name = "cmb_dep";
            this.cmb_dep.Size = new System.Drawing.Size(113, 24);
            this.cmb_dep.TabIndex = 28;
            // 
            // txt_max
            // 
            this.txt_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_max.Location = new System.Drawing.Point(582, 72);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(67, 26);
            this.txt_max.TabIndex = 27;
            // 
            // txt_min
            // 
            this.txt_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_min.Location = new System.Drawing.Point(485, 72);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(67, 26);
            this.txt_min.TabIndex = 27;
            // 
            // txt_pID
            // 
            this.txt_pID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_pID.Location = new System.Drawing.Point(293, 71);
            this.txt_pID.Name = "txt_pID";
            this.txt_pID.Size = new System.Drawing.Size(100, 26);
            this.txt_pID.TabIndex = 27;
            // 
            // rad_salary
            // 
            this.rad_salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rad_salary.AutoSize = true;
            this.rad_salary.Location = new System.Drawing.Point(416, 75);
            this.rad_salary.Name = "rad_salary";
            this.rad_salary.Size = new System.Drawing.Size(74, 20);
            this.rad_salary.TabIndex = 26;
            this.rad_salary.TabStop = true;
            this.rad_salary.Text = "按工资";
            this.rad_salary.UseVisualStyleBackColor = true;
            // 
            // rad_pID
            // 
            this.rad_pID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rad_pID.AutoSize = true;
            this.rad_pID.Location = new System.Drawing.Point(224, 74);
            this.rad_pID.Name = "rad_pID";
            this.rad_pID.Size = new System.Drawing.Size(74, 20);
            this.rad_pID.TabIndex = 26;
            this.rad_pID.TabStop = true;
            this.rad_pID.Text = "按工号";
            this.rad_pID.UseVisualStyleBackColor = true;
            // 
            // rad_dep
            // 
            this.rad_dep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rad_dep.AutoSize = true;
            this.rad_dep.Location = new System.Drawing.Point(18, 73);
            this.rad_dep.Name = "rad_dep";
            this.rad_dep.Size = new System.Drawing.Size(74, 20);
            this.rad_dep.TabIndex = 26;
            this.rad_dep.TabStop = true;
            this.rad_dep.Text = "按部门";
            this.rad_dep.UseVisualStyleBackColor = true;
            // 
            // check_moon
            // 
            this.check_moon.AutoSize = true;
            this.check_moon.Font = new System.Drawing.Font("宋体", 15F);
            this.check_moon.Location = new System.Drawing.Point(351, 36);
            this.check_moon.Name = "check_moon";
            this.check_moon.Size = new System.Drawing.Size(15, 14);
            this.check_moon.TabIndex = 25;
            this.check_moon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "元";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "—";
            // 
            // dtp_moon
            // 
            this.dtp_moon.CustomFormat = "yyyy-MM";
            this.dtp_moon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_moon.Location = new System.Drawing.Point(224, 28);
            this.dtp_moon.Name = "dtp_moon";
            this.dtp_moon.Size = new System.Drawing.Size(118, 26);
            this.dtp_moon.TabIndex = 24;
            this.dtp_moon.Value = new System.DateTime(2017, 5, 14, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "按月查看请选择年月并勾选:";
            // 
            // btn_allDay
            // 
            this.btn_allDay.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_allDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_allDay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_allDay.FlatAppearance.BorderSize = 2;
            this.btn_allDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allDay.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.btn_allDay.ForeColor = System.Drawing.Color.Transparent;
            this.btn_allDay.Location = new System.Drawing.Point(416, 26);
            this.btn_allDay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_allDay.Name = "btn_allDay";
            this.btn_allDay.Size = new System.Drawing.Size(136, 29);
            this.btn_allDay.TabIndex = 22;
            this.btn_allDay.Text = "计算本月全勤奖";
            this.btn_allDay.UseVisualStyleBackColor = false;
            this.btn_allDay.Click += new System.EventHandler(this.btn_allDay_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_excel.FlatAppearance.BorderSize = 2;
            this.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_excel.ForeColor = System.Drawing.Color.Transparent;
            this.btn_excel.Location = new System.Drawing.Point(961, 25);
            this.btn_excel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(114, 32);
            this.btn_excel.TabIndex = 22;
            this.btn_excel.Text = "导出Excel";
            this.btn_excel.UseVisualStyleBackColor = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_find
            // 
            this.btn_find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_find.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_find.FlatAppearance.BorderSize = 2;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btn_find.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find.Location = new System.Drawing.Point(961, 72);
            this.btn_find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(114, 32);
            this.btn_find.TabIndex = 22;
            this.btn_find.Text = "立即查询";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_money);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1090, 364);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // dgv_money
            // 
            this.dgv_money.AllowUserToAddRows = false;
            this.dgv_money.AllowUserToDeleteRows = false;
            this.dgv_money.AllowUserToResizeColumns = false;
            this.dgv_money.AllowUserToResizeRows = false;
            this.dgv_money.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_money.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_money.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_money.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column11,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgv_money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_money.Location = new System.Drawing.Point(3, 20);
            this.dgv_money.Name = "dgv_money";
            this.dgv_money.ReadOnly = true;
            this.dgv_money.RowTemplate.Height = 23;
            this.dgv_money.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_money.Size = new System.Drawing.Size(1084, 341);
            this.dgv_money.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PayID";
            this.Column1.HeaderText = "记录编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PName";
            this.Column11.HeaderText = "员工姓名";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PID";
            this.Column2.HeaderText = "员工编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PayAll";
            this.Column3.HeaderText = "应发工资";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PayBase";
            this.Column4.HeaderText = "基本工资";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PayAllDay";
            this.Column5.HeaderText = "应到天数";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PayDay";
            this.Column6.HeaderText = "实到天数";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PayAdd";
            this.Column7.HeaderText = "奖励金额";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PayDel";
            this.Column8.HeaderText = "处罚金额";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PayIn";
            this.Column9.HeaderText = "实发金额";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "PayTime";
            this.Column10.HeaderText = "发放时间";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // MoneyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1114, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_tip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoneyInfo";
            this.Text = "MoneyInfo";
            this.Load += new System.EventHandler(this.MoneyInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_money;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_moon;
        private System.Windows.Forms.CheckBox check_moon;
        private System.Windows.Forms.RadioButton rad_salary;
        private System.Windows.Forms.RadioButton rad_pID;
        private System.Windows.Forms.RadioButton rad_dep;
        private System.Windows.Forms.TextBox txt_pID;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_dep;
        private System.Windows.Forms.Button btn_allDay;
    }
}