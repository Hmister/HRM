namespace HRManager
{
    partial class SoftVersion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.txt_v = new System.Windows.Forms.TextBox();
            this.lbl_thisv = new System.Windows.Forms.Label();
            this.lbl_show = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_history = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_up);
            this.groupBox1.Controls.Add(this.txt_v);
            this.groupBox1.Controls.Add(this.lbl_thisv);
            this.groupBox1.Controls.Add(this.lbl_show);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 240);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 软件简介 ";
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_up.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_up.FlatAppearance.BorderSize = 2;
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up.Font = new System.Drawing.Font("宋体", 11F);
            this.btn_up.ForeColor = System.Drawing.Color.Transparent;
            this.btn_up.Location = new System.Drawing.Point(262, 203);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(106, 26);
            this.btn_up.TabIndex = 3;
            this.btn_up.Text = "检查更新";
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // txt_v
            // 
            this.txt_v.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.txt_v.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_v.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_v.Location = new System.Drawing.Point(137, 205);
            this.txt_v.Name = "txt_v";
            this.txt_v.ReadOnly = true;
            this.txt_v.Size = new System.Drawing.Size(107, 24);
            this.txt_v.TabIndex = 2;
            this.txt_v.Text = "V 2.0.0";
            this.txt_v.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_thisv
            // 
            this.lbl_thisv.AutoSize = true;
            this.lbl_thisv.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_thisv.Location = new System.Drawing.Point(36, 206);
            this.lbl_thisv.Name = "lbl_thisv";
            this.lbl_thisv.Size = new System.Drawing.Size(109, 20);
            this.lbl_thisv.TabIndex = 1;
            this.lbl_thisv.Text = "软件版本：";
            // 
            // lbl_show
            // 
            this.lbl_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_show.AutoSize = true;
            this.lbl_show.Location = new System.Drawing.Point(11, 30);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(1056, 160);
            this.lbl_show.TabIndex = 0;
            this.lbl_show.Text = "    人力资源管理系统， 通过提高内部员工的满意度、忠诚度，从而提高员工贡献度，即绩效，帮助管理者通过有效组织管理降低成本和加速增长来\r\n\r\n创造价值链利润。\r" +
    "\n\r\n   本软件主要功能：\r\n   1.人事管理模块\r\n   2.员工考勤管理\r\n   3.薪资计算模块\r\n   4.员工培训管理\r\n   5.人才招聘模块\r" +
    "\n";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_tip.Location = new System.Drawing.Point(12, 22);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(263, 40);
            this.lbl_tip.TabIndex = 10;
            this.lbl_tip.Text = "软件版本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_history);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1090, 195);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 更新详情 ";
            // 
            // txt_history
            // 
            this.txt_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.txt_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_history.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_history.Location = new System.Drawing.Point(8, 23);
            this.txt_history.Margin = new System.Windows.Forms.Padding(13);
            this.txt_history.Multiline = true;
            this.txt_history.Name = "txt_history";
            this.txt_history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_history.Size = new System.Drawing.Size(1072, 157);
            this.txt_history.TabIndex = 0;
            this.txt_history.Text = "2017年5月9日00:07:00 \r\nV2.0.0版本 全新发布\r\n功能如下：\r\n1.人事管理模块\r\n2.考勤管理模块\r\n3.员工信息管理\r\n4.薪资福利管理\r" +
    "\n5.人才招聘功能\r\n6.系统权限分配\r\n7.账户资料设置\r\n8.发送系统消息\r\n9.公司物资管理\r\n。。。";
            // 
            // SoftVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1114, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoftVersion";
            this.Text = "SoftVersion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.TextBox txt_v;
        private System.Windows.Forms.Label lbl_thisv;
        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_history;
    }
}