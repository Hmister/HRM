namespace HRManager
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_main = new System.Windows.Forms.Button();
            this.pic_id = new System.Windows.Forms.PictureBox();
            this.pic_pass = new System.Windows.Forms.PictureBox();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.pic_nosee = new System.Windows.Forms.PictureBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_reg = new System.Windows.Forms.Label();
            this.pic_reset = new System.Windows.Forms.PictureBox();
            this.btn_Tui = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.pic_see = new System.Windows.Forms.PictureBox();
            this.pic_tip = new System.Windows.Forms.PictureBox();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.lbl_pass_tip = new System.Windows.Forms.Label();
            this.lbl_id_tip = new System.Windows.Forms.Label();
            this.ico_all = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmnu_login = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.登陆界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.异常反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nosee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_see)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tip)).BeginInit();
            this.cmnu_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_main
            // 
            this.login_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.login_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_main.Enabled = false;
            this.login_main.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(124)))));
            this.login_main.FlatAppearance.BorderSize = 0;
            this.login_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.login_main.Location = new System.Drawing.Point(0, 0);
            this.login_main.Name = "login_main";
            this.login_main.Size = new System.Drawing.Size(500, 300);
            this.login_main.TabIndex = 6;
            this.login_main.TabStop = false;
            this.login_main.UseVisualStyleBackColor = false;
            // 
            // pic_id
            // 
            this.pic_id.Image = ((System.Drawing.Image)(resources.GetObject("pic_id.Image")));
            this.pic_id.Location = new System.Drawing.Point(212, 86);
            this.pic_id.Name = "pic_id";
            this.pic_id.Size = new System.Drawing.Size(210, 35);
            this.pic_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_id.TabIndex = 1;
            this.pic_id.TabStop = false;
            // 
            // pic_pass
            // 
            this.pic_pass.Image = ((System.Drawing.Image)(resources.GetObject("pic_pass.Image")));
            this.pic_pass.Location = new System.Drawing.Point(212, 150);
            this.pic_pass.Name = "pic_pass";
            this.pic_pass.Size = new System.Drawing.Size(210, 35);
            this.pic_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pass.TabIndex = 2;
            this.pic_pass.TabStop = false;
            // 
            // pic_user
            // 
            this.pic_user.Image = ((System.Drawing.Image)(resources.GetObject("pic_user.Image")));
            this.pic_user.Location = new System.Drawing.Point(69, 87);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(98, 99);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_user.TabIndex = 3;
            this.pic_user.TabStop = false;
            // 
            // pic_nosee
            // 
            this.pic_nosee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_nosee.Image = ((System.Drawing.Image)(resources.GetObject("pic_nosee.Image")));
            this.pic_nosee.Location = new System.Drawing.Point(391, 158);
            this.pic_nosee.Name = "pic_nosee";
            this.pic_nosee.Size = new System.Drawing.Size(25, 20);
            this.pic_nosee.TabIndex = 4;
            this.pic_nosee.TabStop = false;
            this.pic_nosee.Click += new System.EventHandler(this.pic_nosee_Click);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(221, 95);
            this.txt_id.MaxLength = 20;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(193, 19);
            this.txt_id.TabIndex = 0;
            this.txt_id.Click += new System.EventHandler(this.txt_id_Click);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(221, 160);
            this.txt_pass.MaxLength = 20;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '●';
            this.txt_pass.Size = new System.Drawing.Size(170, 19);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Click += new System.EventHandler(this.txt_pass_Click);
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(83, 242);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(107, 37);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "登 录";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.Leave += new System.EventHandler(this.btn_login_Leave);
            this.btn_login.MouseEnter += new System.EventHandler(this.btn_login_MouseEnter);
            this.btn_login.MouseLeave += new System.EventHandler(this.btn_login_MouseLeave);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btn_Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Quit.BackgroundImage")));
            this.btn_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Quit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btn_Quit.FlatAppearance.BorderSize = 0;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Quit.ForeColor = System.Drawing.Color.White;
            this.btn_Quit.Location = new System.Drawing.Point(301, 242);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(107, 37);
            this.btn_Quit.TabIndex = 3;
            this.btn_Quit.Text = "退 出";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            this.btn_Quit.MouseEnter += new System.EventHandler(this.btn_Quit_MouseEnter);
            this.btn_Quit.MouseLeave += new System.EventHandler(this.btn_Quit_MouseLeave);
            // 
            // lbl_reg
            // 
            this.lbl_reg.AutoSize = true;
            this.lbl_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_reg.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lbl_reg.ForeColor = System.Drawing.Color.White;
            this.lbl_reg.Location = new System.Drawing.Point(327, 190);
            this.lbl_reg.Name = "lbl_reg";
            this.lbl_reg.Size = new System.Drawing.Size(93, 20);
            this.lbl_reg.TabIndex = 4;
            this.lbl_reg.Text = "注册一个账号";
            this.lbl_reg.Click += new System.EventHandler(this.lbl_reg_Click);
            this.lbl_reg.MouseEnter += new System.EventHandler(this.lbl_reg_MouseEnter);
            this.lbl_reg.MouseLeave += new System.EventHandler(this.lbl_reg_MouseLeave);
            // 
            // pic_reset
            // 
            this.pic_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_reset.Image = ((System.Drawing.Image)(resources.GetObject("pic_reset.Image")));
            this.pic_reset.Location = new System.Drawing.Point(422, 156);
            this.pic_reset.Name = "pic_reset";
            this.pic_reset.Size = new System.Drawing.Size(25, 25);
            this.pic_reset.TabIndex = 9;
            this.pic_reset.TabStop = false;
            this.pic_reset.Visible = false;
            this.pic_reset.Click += new System.EventHandler(this.pic_reset_Click);
            // 
            // btn_Tui
            // 
            this.btn_Tui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btn_Tui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tui.FlatAppearance.BorderSize = 0;
            this.btn_Tui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tui.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Tui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Tui.Location = new System.Drawing.Point(459, 1);
            this.btn_Tui.Name = "btn_Tui";
            this.btn_Tui.Size = new System.Drawing.Size(40, 20);
            this.btn_Tui.TabIndex = 6;
            this.btn_Tui.TabStop = false;
            this.btn_Tui.Text = "×";
            this.btn_Tui.UseVisualStyleBackColor = false;
            this.btn_Tui.Click += new System.EventHandler(this.btn_Tui_Click);
            this.btn_Tui.MouseEnter += new System.EventHandler(this.btn_Tui_MouseEnter);
            this.btn_Tui.MouseLeave += new System.EventHandler(this.btn_Tui_MouseLeave);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_min.Location = new System.Drawing.Point(419, 1);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(40, 20);
            this.btn_min.TabIndex = 5;
            this.btn_min.TabStop = false;
            this.btn_min.Text = "—";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            this.btn_min.MouseEnter += new System.EventHandler(this.btn_min_MouseEnter);
            this.btn_min.MouseLeave += new System.EventHandler(this.btn_min_MouseLeave);
            // 
            // pic_see
            // 
            this.pic_see.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_see.Image = ((System.Drawing.Image)(resources.GetObject("pic_see.Image")));
            this.pic_see.Location = new System.Drawing.Point(391, 158);
            this.pic_see.Name = "pic_see";
            this.pic_see.Size = new System.Drawing.Size(25, 20);
            this.pic_see.TabIndex = 13;
            this.pic_see.TabStop = false;
            this.pic_see.Visible = false;
            this.pic_see.Click += new System.EventHandler(this.pic_see_Click);
            // 
            // pic_tip
            // 
            this.pic_tip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_tip.Image = ((System.Drawing.Image)(resources.GetObject("pic_tip.Image")));
            this.pic_tip.Location = new System.Drawing.Point(215, 213);
            this.pic_tip.Name = "pic_tip";
            this.pic_tip.Size = new System.Drawing.Size(23, 23);
            this.pic_tip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_tip.TabIndex = 14;
            this.pic_tip.TabStop = false;
            this.pic_tip.Visible = false;
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("宋体", 11F);
            this.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_tip.Location = new System.Drawing.Point(241, 217);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(82, 15);
            this.lbl_tip.TabIndex = 7;
            this.lbl_tip.Text = "提示信息！";
            this.lbl_tip.Visible = false;
            // 
            // lbl_pass_tip
            // 
            this.lbl_pass_tip.AutoSize = true;
            this.lbl_pass_tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.lbl_pass_tip.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_pass_tip.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_pass_tip.Location = new System.Drawing.Point(219, 160);
            this.lbl_pass_tip.Name = "lbl_pass_tip";
            this.lbl_pass_tip.Size = new System.Drawing.Size(40, 16);
            this.lbl_pass_tip.TabIndex = 8;
            this.lbl_pass_tip.Text = "密码";
            this.lbl_pass_tip.Click += new System.EventHandler(this.lbl_pass_tip_Click);
            // 
            // lbl_id_tip
            // 
            this.lbl_id_tip.AutoSize = true;
            this.lbl_id_tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.lbl_id_tip.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_id_tip.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_id_tip.Location = new System.Drawing.Point(218, 95);
            this.lbl_id_tip.Name = "lbl_id_tip";
            this.lbl_id_tip.Size = new System.Drawing.Size(40, 16);
            this.lbl_id_tip.TabIndex = 7;
            this.lbl_id_tip.Text = "帐号";
            this.lbl_id_tip.Click += new System.EventHandler(this.lbl_id_tip_Click);
            // 
            // ico_all
            // 
            this.ico_all.ContextMenuStrip = this.cmnu_login;
            this.ico_all.Icon = ((System.Drawing.Icon)(resources.GetObject("ico_all.Icon")));
            this.ico_all.Text = "登录系统";
            this.ico_all.Visible = true;
            this.ico_all.DoubleClick += new System.EventHandler(this.ico_all_DoubleClick);
            // 
            // cmnu_login
            // 
            this.cmnu_login.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登陆界面ToolStripMenuItem,
            this.异常反馈ToolStripMenuItem,
            this.关于软件ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.cmnu_login.Name = "cmnu_login";
            this.cmnu_login.Size = new System.Drawing.Size(125, 92);
            // 
            // 登陆界面ToolStripMenuItem
            // 
            this.登陆界面ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("登陆界面ToolStripMenuItem.Image")));
            this.登陆界面ToolStripMenuItem.Name = "登陆界面ToolStripMenuItem";
            this.登陆界面ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.登陆界面ToolStripMenuItem.Text = "登陆界面";
            this.登陆界面ToolStripMenuItem.Click += new System.EventHandler(this.登陆界面ToolStripMenuItem_Click);
            // 
            // 异常反馈ToolStripMenuItem
            // 
            this.异常反馈ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("异常反馈ToolStripMenuItem.Image")));
            this.异常反馈ToolStripMenuItem.Name = "异常反馈ToolStripMenuItem";
            this.异常反馈ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.异常反馈ToolStripMenuItem.Text = "异常反馈";
            this.异常反馈ToolStripMenuItem.Click += new System.EventHandler(this.异常反馈ToolStripMenuItem_Click);
            // 
            // 关于软件ToolStripMenuItem
            // 
            this.关于软件ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于软件ToolStripMenuItem.Image")));
            this.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem";
            this.关于软件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于软件ToolStripMenuItem.Text = "关于软件";
            this.关于软件ToolStripMenuItem.Click += new System.EventHandler(this.关于软件ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出程序ToolStripMenuItem.Image")));
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_back.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(130)))), ((int)(((byte)(213)))));
            this.lbl_back.Location = new System.Drawing.Point(214, 191);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(61, 19);
            this.lbl_back.TabIndex = 16;
            this.lbl_back.Text = "找回密码";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.CancelButton = this.btn_Quit;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.lbl_id_tip);
            this.Controls.Add(this.lbl_pass_tip);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.pic_tip);
            this.Controls.Add(this.pic_see);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_Tui);
            this.Controls.Add(this.pic_reset);
            this.Controls.Add(this.lbl_reg);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pic_nosee);
            this.Controls.Add(this.pic_user);
            this.Controls.Add(this.pic_pass);
            this.Controls.Add(this.pic_id);
            this.Controls.Add(this.login_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录系统";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nosee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_see)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tip)).EndInit();
            this.cmnu_login.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_main;
        private System.Windows.Forms.PictureBox pic_id;
        private System.Windows.Forms.PictureBox pic_pass;
        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.PictureBox pic_nosee;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label lbl_reg;
        private System.Windows.Forms.PictureBox pic_reset;
        private System.Windows.Forms.Button btn_Tui;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.PictureBox pic_see;
        private System.Windows.Forms.PictureBox pic_tip;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Label lbl_pass_tip;
        private System.Windows.Forms.Label lbl_id_tip;
        private System.Windows.Forms.NotifyIcon ico_all;
        private System.Windows.Forms.ToolStripMenuItem 登陆界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 异常反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip cmnu_login;
        private System.Windows.Forms.Label lbl_back;
    }
}

