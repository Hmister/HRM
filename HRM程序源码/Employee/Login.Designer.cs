namespace Employee
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_main = new System.Windows.Forms.Button();
            this.pan_top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_id = new System.Windows.Forms.Button();
            this.btn_pass = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_main
            // 
            this.btn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_main.Enabled = false;
            this.btn_main.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(214)))));
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.Location = new System.Drawing.Point(0, 0);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(429, 294);
            this.btn_main.TabIndex = 0;
            this.btn_main.UseVisualStyleBackColor = false;
            // 
            // pan_top
            // 
            this.pan_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pan_top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_top.BackgroundImage")));
            this.pan_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_top.Location = new System.Drawing.Point(1, 1);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(427, 114);
            this.pan_top.TabIndex = 1;
            this.pan_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_top_MouseDown);
            this.pan_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pan_top_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_id
            // 
            this.btn_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btn_id.Enabled = false;
            this.btn_id.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_id.ForeColor = System.Drawing.Color.Gray;
            this.btn_id.Location = new System.Drawing.Point(151, 138);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(238, 42);
            this.btn_id.TabIndex = 3;
            this.btn_id.Text = "员工编号:";
            this.btn_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_id.UseVisualStyleBackColor = false;
            // 
            // btn_pass
            // 
            this.btn_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btn_pass.Enabled = false;
            this.btn_pass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pass.ForeColor = System.Drawing.Color.Gray;
            this.btn_pass.Location = new System.Drawing.Point(151, 182);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(238, 42);
            this.btn_pass.TabIndex = 3;
            this.btn_pass.Text = "登录密码:";
            this.btn_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pass.UseVisualStyleBackColor = false;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_id.Location = new System.Drawing.Point(233, 149);
            this.txt_id.MaxLength = 15;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(146, 23);
            this.txt_id.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_pass.Location = new System.Drawing.Point(233, 193);
            this.txt_pass.MaxLength = 15;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '●';
            this.txt_pass.Size = new System.Drawing.Size(146, 23);
            this.txt_pass.TabIndex = 1;
            // 
            // btn_go
            // 
            this.btn_go.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_go.BackgroundImage")));
            this.btn_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_go.FlatAppearance.BorderSize = 0;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_go.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_go.Location = new System.Drawing.Point(81, 254);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(85, 30);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "登 录";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.Gray;
            this.btn_exit.Location = new System.Drawing.Point(279, 254);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 30);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "退 出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbl_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(133)))), ((int)(((byte)(180)))));
            this.lbl_back.Location = new System.Drawing.Point(285, 229);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(104, 16);
            this.lbl_back.TabIndex = 4;
            this.lbl_back.Text = "找回登录密码";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(429, 294);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.btn_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pan_top);
            this.Controls.Add(this.btn_main);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRM员工端";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_id;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_back;
    }
}

