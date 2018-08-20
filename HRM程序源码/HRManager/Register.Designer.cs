namespace HRManager
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_pass1 = new System.Windows.Forms.Label();
            this.lbl_join = new System.Windows.Forms.Label();
            this.lbl_call = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_pass1 = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.ead_women = new System.Windows.Forms.RadioButton();
            this.rad_man = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Register
            // 
            this.btn_Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Register.BackgroundImage")));
            this.btn_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Register.Enabled = false;
            this.btn_Register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Location = new System.Drawing.Point(0, 0);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(378, 345);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
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
            this.lbl_Close.TabIndex = 11;
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
            this.lbl_Min.Location = new System.Drawing.Point(322, 12);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(25, 16);
            this.lbl_Min.TabIndex = 10;
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
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "注册帐号";
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(22, 22);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 5;
            this.pic_logo.TabStop = false;
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
            this.btn_submit.Location = new System.Drawing.Point(72, 295);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(77, 29);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "提 交";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            this.btn_submit.MouseEnter += new System.EventHandler(this.btn_submit_MouseEnter);
            this.btn_submit.MouseLeave += new System.EventHandler(this.btn_submit_MouseLeave);
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
            this.btn_reset.Location = new System.Drawing.Point(233, 295);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(77, 29);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "重 填";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.MouseEnter += new System.EventHandler(this.btn_reset_MouseEnter);
            this.btn_reset.MouseLeave += new System.EventHandler(this.btn_reset_MouseLeave);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_id.Location = new System.Drawing.Point(56, 59);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(77, 14);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "注册名称：";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_pass.Location = new System.Drawing.Point(56, 104);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(77, 14);
            this.lbl_pass.TabIndex = 9;
            this.lbl_pass.Text = "设置密码：";
            // 
            // lbl_pass1
            // 
            this.lbl_pass1.AutoSize = true;
            this.lbl_pass1.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_pass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_pass1.Location = new System.Drawing.Point(56, 149);
            this.lbl_pass1.Name = "lbl_pass1";
            this.lbl_pass1.Size = new System.Drawing.Size(77, 14);
            this.lbl_pass1.TabIndex = 9;
            this.lbl_pass1.Text = "确认密码：";
            // 
            // lbl_join
            // 
            this.lbl_join.AutoSize = true;
            this.lbl_join.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_join.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_join.Location = new System.Drawing.Point(56, 189);
            this.lbl_join.Name = "lbl_join";
            this.lbl_join.Size = new System.Drawing.Size(77, 14);
            this.lbl_join.TabIndex = 9;
            this.lbl_join.Text = "用户性别：";
            // 
            // lbl_call
            // 
            this.lbl_call.AutoSize = true;
            this.lbl_call.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_call.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.lbl_call.Location = new System.Drawing.Point(56, 224);
            this.lbl_call.Name = "lbl_call";
            this.lbl_call.Size = new System.Drawing.Size(77, 14);
            this.lbl_call.TabIndex = 9;
            this.lbl_call.Text = "用户年龄：";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(142, 56);
            this.txt_id.MaxLength = 20;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(178, 21);
            this.txt_id.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.White;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(142, 102);
            this.txt_pass.MaxLength = 20;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '●';
            this.txt_pass.Size = new System.Drawing.Size(178, 21);
            this.txt_pass.TabIndex = 1;
            // 
            // txt_pass1
            // 
            this.txt_pass1.BackColor = System.Drawing.Color.White;
            this.txt_pass1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass1.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_pass1.ForeColor = System.Drawing.Color.Black;
            this.txt_pass1.Location = new System.Drawing.Point(142, 147);
            this.txt_pass1.MaxLength = 20;
            this.txt_pass1.Name = "txt_pass1";
            this.txt_pass1.PasswordChar = '●';
            this.txt_pass1.Size = new System.Drawing.Size(178, 21);
            this.txt_pass1.TabIndex = 2;
            // 
            // txt_age
            // 
            this.txt_age.BackColor = System.Drawing.Color.White;
            this.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_age.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_age.ForeColor = System.Drawing.Color.Black;
            this.txt_age.Location = new System.Drawing.Point(142, 221);
            this.txt_age.MaxLength = 20;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(178, 21);
            this.txt_age.TabIndex = 5;
            // 
            // ead_women
            // 
            this.ead_women.AutoSize = true;
            this.ead_women.Location = new System.Drawing.Point(254, 189);
            this.ead_women.Name = "ead_women";
            this.ead_women.Size = new System.Drawing.Size(47, 16);
            this.ead_women.TabIndex = 4;
            this.ead_women.TabStop = true;
            this.ead_women.Text = "女士";
            this.ead_women.UseVisualStyleBackColor = true;
            // 
            // rad_man
            // 
            this.rad_man.AutoSize = true;
            this.rad_man.Location = new System.Drawing.Point(162, 189);
            this.rad_man.Name = "rad_man";
            this.rad_man.Size = new System.Drawing.Size(47, 16);
            this.rad_man.TabIndex = 3;
            this.rad_man.TabStop = true;
            this.rad_man.Text = "男士";
            this.rad_man.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(56, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "邮箱地址：";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(142, 260);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 21);
            this.textBox1.TabIndex = 6;
            // 
            // Register
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(378, 345);
            this.ControlBox = false;
            this.Controls.Add(this.rad_man);
            this.Controls.Add(this.ead_women);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_pass1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_call);
            this.Controls.Add(this.lbl_join);
            this.Controls.Add(this.lbl_pass1);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册帐号";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_pass1;
        private System.Windows.Forms.Label lbl_join;
        private System.Windows.Forms.Label lbl_call;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_pass1;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.RadioButton ead_women;
        private System.Windows.Forms.RadioButton rad_man;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}