using System;
using System.Configuration;
using System.Windows.Forms;

namespace Framework_Test.controls
{
    public partial class maincontrol : UserControl
    {
        public maincontrol(string modulename)
        {
            InitializeComponent();
            setmodulename(modulename);
            module = modulename;
        }
        private string module = "";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }
        public void setmodulename(string name)
        {

        }
        private void maincontrol_Load(object sender, EventArgs e)
        {
            switch (module) {
                case "数据1录入":
                case "数据2录入":
                    DateInstall();
                    break;
                case "数据总表查询":
                    SearchAllMessage();
                    break;
                case "用户管理":
                    UserSetting();
                    break;
                case "角色/岗位设置":
                    Position_setting();
                    break;
                case "菜单功能设置":
                    Menu_function_settings();
                    break;
                case "修改密码":
                    ChangePSQ();
                    break;
                default:
                    break;
            }
        }

        private void Menu_function_settings()
        {

            throw new NotImplementedException();
        }

        private void Position_setting()
        {
            throw new NotImplementedException();
        }

        private void ChangePSQ()
        {
            show_tableLayoutPanel.Controls.Add(new pswchange() { Dock = DockStyle.Fill }, 1, 0);
        }

        private void UserSetting()
        {
            show_tableLayoutPanel.Controls.Add(new UserSettingGUI() { Dock = DockStyle.Fill }, 1, 0);
        }

        private void SearchAllMessage()
        {
            show_tableLayoutPanel.Controls.Add(new showdrew() { Dock = DockStyle.Fill }, 1, 0);
        }

        private void DateInstall()
        {
            show_tableLayoutPanel.Controls.Add(new Data_Install { Dock = DockStyle.Fill }, 1, 0);
        }
    }
}
