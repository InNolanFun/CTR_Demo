
namespace Framework_Test
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenul1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenul2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenul3 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色岗位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.用户ToolStripMenuItem,
            this.登录ToolStripMenuItem,
            this.登出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenul1,
            this.TSMenul2,
            this.TSMenul3});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // TSMenul1
            // 
            this.TSMenul1.Name = "TSMenul1";
            this.TSMenul1.Size = new System.Drawing.Size(148, 22);
            this.TSMenul1.Text = "数据1录入";
            this.TSMenul1.Click += new System.EventHandler(this.TotalToolStripMenuItem_Click);
            // 
            // TSMenul2
            // 
            this.TSMenul2.Name = "TSMenul2";
            this.TSMenul2.Size = new System.Drawing.Size(148, 22);
            this.TSMenul2.Text = "数据2录入";
            this.TSMenul2.Click += new System.EventHandler(this.TotalToolStripMenuItem_Click);
            // 
            // TSMenul3
            // 
            this.TSMenul3.Name = "TSMenul3";
            this.TSMenul3.Size = new System.Drawing.Size(148, 22);
            this.TSMenul3.Text = "数据总表查询";
            this.TSMenul3.Click += new System.EventHandler(this.TotalToolStripMenuItem_Click);
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.角色岗位ToolStripMenuItem,
            this.菜单功能ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户ToolStripMenuItem.Text = "基础配置";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.TotalToolStripMenuItem_Click);
            // 
            // 角色岗位ToolStripMenuItem
            // 
            this.角色岗位ToolStripMenuItem.Name = "角色岗位ToolStripMenuItem";
            this.角色岗位ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.角色岗位ToolStripMenuItem.Text = "角色/岗位设置";
            this.角色岗位ToolStripMenuItem.Click += new System.EventHandler(this.TotalToolStripMenuItem_Click);
            // 
            // 菜单功能ToolStripMenuItem
            // 
            this.菜单功能ToolStripMenuItem.Name = "菜单功能ToolStripMenuItem";
            this.菜单功能ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.菜单功能ToolStripMenuItem.Text = "菜单功能设置";
            this.菜单功能ToolStripMenuItem.Visible = false;
            this.菜单功能ToolStripMenuItem.Click += new System.EventHandler(this.TotalToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.TotalToolStripMenuItem_Click);
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.登录ToolStripMenuItem.Text = "登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.login);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 425);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl1_ControlRemoved);
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.登出ToolStripMenuItem.Text = "登出";
            this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenul1;
        private System.Windows.Forms.ToolStripMenuItem TSMenul2;
        private System.Windows.Forms.ToolStripMenuItem TSMenul3;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色岗位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单功能ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
    }
}

