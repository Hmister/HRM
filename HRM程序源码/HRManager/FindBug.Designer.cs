namespace HRManager
{
    partial class FindBug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBug));
            this.btn_FindBug = new System.Windows.Forms.Button();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_bugTitle = new System.Windows.Forms.Label();
            this.lbl_bugType = new System.Windows.Forms.Label();
            this.lbl_call = new System.Windows.Forms.Label();
            this.lbl_bugText = new System.Windows.Forms.Label();
            this.txt_bugTitle = new System.Windows.Forms.TextBox();
            this.txt_call = new System.Windows.Forms.TextBox();
            this.txt_bugText = new System.Windows.Forms.TextBox();
            this.rad_type1 = new System.Windows.Forms.RadioButton();
            this.rad_type2 = new System.Windows.Forms.RadioButton();
            this.lbl_bugTip = new System.Windows.Forms.Label();
            this.rad_type3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FindBug
            // 
            this.btn_FindBug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_FindBug.BackgroundImage")));
            this.btn_FindBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_FindBug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FindBug.Enabled = false;
            this.btn_FindBug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btn_FindBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindBug.Location = new System.Drawing.Point(0, 0);
            this.btn_FindBug.Name = "btn_FindBug";
            this.btn_FindBug.Size = new System.Drawing.Size(378, 366);
            this.btn_FindBug.TabIndex = 0;
            this.btn_FindBug.UseVisualStyleBackColor = true;
            // 
            // lbl_Close
            // 
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.lbl_Close.Location = new System.Drawing.Point(351, 10);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(25, 16);
            this.lbl_Close.TabIndex = 10;
            this.lbl_Close.Text = "×";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            this.lbl_Close.MouseEnter += new System.EventHandler(this.lbl_Close_MouseEnter);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Min.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.lbl_Min.Location = new System.Drawing.Point(324, 11);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(25, 16);
            this.lbl_Min.TabIndex = 9;
            this.lbl_Min.Text = "—";
            this.lbl_Min.Click += new System.EventHandler(this.lbl_Min_Click);
            this.lbl_Min.MouseEnter += new System.EventHandler(this.lbl_Min_MouseEnter);
            this.lbl_Min.MouseLeave += new System.EventHandler(this.lbl_Min_MouseLeave);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.lbl_Title.Location = new System.Drawing.Point(28, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(63, 14);
            this.lbl_Title.TabIndex = 8;
            this.lbl_Title.Text = "异常反馈";
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(22, 22);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 8;
            this.pic_logo.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(228)))));
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_reset.Location = new System.Drawing.Point(233, 327);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(77, 29);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "重 填";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.MouseEnter += new System.EventHandler(this.btn_reset_MouseEnter);
            this.btn_reset.MouseLeave += new System.EventHandler(this.btn_reset_MouseLeave);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(228)))));
            this.btn_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_submit.BackgroundImage")));
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_submit.Location = new System.Drawing.Point(68, 326);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(77, 29);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "提 交";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            this.btn_submit.MouseEnter += new System.EventHandler(this.btn_submit_MouseEnter);
            this.btn_submit.MouseLeave += new System.EventHandler(this.btn_submit_MouseLeave);
            // 
            // lbl_bugTitle
            // 
            this.lbl_bugTitle.AutoSize = true;
            this.lbl_bugTitle.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_bugTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_bugTitle.Location = new System.Drawing.Point(30, 50);
            this.lbl_bugTitle.Name = "lbl_bugTitle";
            this.lbl_bugTitle.Size = new System.Drawing.Size(77, 14);
            this.lbl_bugTitle.TabIndex = 14;
            this.lbl_bugTitle.Text = "反馈主题：";
            // 
            // lbl_bugType
            // 
            this.lbl_bugType.AutoSize = true;
            this.lbl_bugType.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_bugType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_bugType.Location = new System.Drawing.Point(30, 83);
            this.lbl_bugType.Name = "lbl_bugType";
            this.lbl_bugType.Size = new System.Drawing.Size(77, 14);
            this.lbl_bugType.TabIndex = 14;
            this.lbl_bugType.Text = "反馈类型：";
            // 
            // lbl_call
            // 
            this.lbl_call.AutoSize = true;
            this.lbl_call.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_call.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_call.Location = new System.Drawing.Point(30, 116);
            this.lbl_call.Name = "lbl_call";
            this.lbl_call.Size = new System.Drawing.Size(77, 14);
            this.lbl_call.TabIndex = 14;
            this.lbl_call.Text = "联系方式：";
            // 
            // lbl_bugText
            // 
            this.lbl_bugText.AutoSize = true;
            this.lbl_bugText.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_bugText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_bugText.Location = new System.Drawing.Point(30, 149);
            this.lbl_bugText.Name = "lbl_bugText";
            this.lbl_bugText.Size = new System.Drawing.Size(77, 14);
            this.lbl_bugText.TabIndex = 14;
            this.lbl_bugText.Text = "问题描述：";
            // 
            // txt_bugTitle
            // 
            this.txt_bugTitle.BackColor = System.Drawing.Color.White;
            this.txt_bugTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bugTitle.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_bugTitle.ForeColor = System.Drawing.Color.Black;
            this.txt_bugTitle.Location = new System.Drawing.Point(112, 47);
            this.txt_bugTitle.MaxLength = 20;
            this.txt_bugTitle.Name = "txt_bugTitle";
            this.txt_bugTitle.Size = new System.Drawing.Size(236, 21);
            this.txt_bugTitle.TabIndex = 0;
            // 
            // txt_call
            // 
            this.txt_call.BackColor = System.Drawing.Color.White;
            this.txt_call.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_call.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_call.ForeColor = System.Drawing.Color.Black;
            this.txt_call.Location = new System.Drawing.Point(112, 115);
            this.txt_call.MaxLength = 20;
            this.txt_call.Name = "txt_call";
            this.txt_call.Size = new System.Drawing.Size(236, 21);
            this.txt_call.TabIndex = 4;
            // 
            // txt_bugText
            // 
            this.txt_bugText.BackColor = System.Drawing.Color.White;
            this.txt_bugText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bugText.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_bugText.ForeColor = System.Drawing.Color.Black;
            this.txt_bugText.Location = new System.Drawing.Point(31, 177);
            this.txt_bugText.MaxLength = 1000;
            this.txt_bugText.Multiline = true;
            this.txt_bugText.Name = "txt_bugText";
            this.txt_bugText.Size = new System.Drawing.Size(318, 139);
            this.txt_bugText.TabIndex = 5;
            // 
            // rad_type1
            // 
            this.rad_type1.AutoSize = true;
            this.rad_type1.Location = new System.Drawing.Point(113, 83);
            this.rad_type1.Name = "rad_type1";
            this.rad_type1.Size = new System.Drawing.Size(71, 16);
            this.rad_type1.TabIndex = 1;
            this.rad_type1.TabStop = true;
            this.rad_type1.Text = "系统异常";
            this.rad_type1.UseVisualStyleBackColor = true;
            // 
            // rad_type2
            // 
            this.rad_type2.AutoSize = true;
            this.rad_type2.Location = new System.Drawing.Point(195, 83);
            this.rad_type2.Name = "rad_type2";
            this.rad_type2.Size = new System.Drawing.Size(71, 16);
            this.rad_type2.TabIndex = 2;
            this.rad_type2.TabStop = true;
            this.rad_type2.Text = "使用帮助";
            this.rad_type2.UseVisualStyleBackColor = true;
            // 
            // lbl_bugTip
            // 
            this.lbl_bugTip.AutoSize = true;
            this.lbl_bugTip.Font = new System.Drawing.Font("宋体", 9F);
            this.lbl_bugTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bugTip.Location = new System.Drawing.Point(107, 151);
            this.lbl_bugTip.Name = "lbl_bugTip";
            this.lbl_bugTip.Size = new System.Drawing.Size(251, 12);
            this.lbl_bugTip.TabIndex = 14;
            this.lbl_bugTip.Text = "* 请详细的描述你的问题,以便更快解决问题！";
            // 
            // rad_type3
            // 
            this.rad_type3.AutoSize = true;
            this.rad_type3.Location = new System.Drawing.Point(277, 83);
            this.rad_type3.Name = "rad_type3";
            this.rad_type3.Size = new System.Drawing.Size(71, 16);
            this.rad_type3.TabIndex = 3;
            this.rad_type3.TabStop = true;
            this.rad_type3.Text = "其他问题";
            this.rad_type3.UseVisualStyleBackColor = true;
            // 
            // FindBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(378, 366);
            this.ControlBox = false;
            this.Controls.Add(this.rad_type3);
            this.Controls.Add(this.rad_type2);
            this.Controls.Add(this.rad_type1);
            this.Controls.Add(this.txt_bugText);
            this.Controls.Add(this.txt_call);
            this.Controls.Add(this.txt_bugTitle);
            this.Controls.Add(this.lbl_bugText);
            this.Controls.Add(this.lbl_call);
            this.Controls.Add(this.lbl_bugType);
            this.Controls.Add(this.lbl_bugTip);
            this.Controls.Add(this.lbl_bugTitle);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_FindBug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "异常反馈";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_FindBug;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_bugTitle;
        private System.Windows.Forms.Label lbl_bugType;
        private System.Windows.Forms.Label lbl_call;
        private System.Windows.Forms.Label lbl_bugText;
        private System.Windows.Forms.TextBox txt_bugTitle;
        private System.Windows.Forms.TextBox txt_call;
        private System.Windows.Forms.RadioButton rad_type1;
        private System.Windows.Forms.RadioButton rad_type2;
        private System.Windows.Forms.Label lbl_bugTip;
        private System.Windows.Forms.RadioButton rad_type3;
        private System.Windows.Forms.TextBox txt_bugText;

    }
}