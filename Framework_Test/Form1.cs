using Framework_Test.controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Framework_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 0;
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Control($"testmodule{i++}");
        }

        private void TotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tl = sender as ToolStripMenuItem;
            Add_Control($"{tl.Text}");
        }

        private void Add_Control(string modulename)
        {
            var tabpage = new TabPage(modulename);
            var Exis = false;
            foreach (TabPage item in tabControl1.Controls) {//判断是否已存在
                if (item.Text == modulename) {
                    tabControl1.SelectedTab = item;
                    Exis = true;
                    break;
                }
            }
            if (!Exis) {//不存在,则新增
                var control = new controls.maincontrol(modulename) {
                    Dock = DockStyle.Fill
                };
                tabpage.Controls.Add(control);
                tabControl1.Controls.Add(tabpage);
                tabControl1.SelectedTab = tabpage;
            }
        }

        private void tabControl1_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var use = new ConnectDB.DB_UserGroup();
            use.Create();
            var s = from ConnectDB.DB_UserGroup.UserGroup i in use.Search_DB() where (i.USName == "t" & i.USPsw == "t") select i;
            if (s.Count() == 0) {
                use.Insert_DB(new List<ConnectDB.DB_UserGroup.UserGroup> {
                    new ConnectDB.DB_UserGroup.UserGroup { USName = "t", USPsw = "t", USPower = "0" } ,
                    new ConnectDB.DB_UserGroup.UserGroup { USName = "t1", USPsw = "t", USPower = "1" } ,
                    new ConnectDB.DB_UserGroup.UserGroup { USName = "t2", USPsw = "t", USPower = "2" } ,
                    new ConnectDB.DB_UserGroup.UserGroup { USName = "tnull", USPsw = "t" },
                });
            }
            new ConnectDB.DB_ContractMessage().Create();
            //debug
            //Createdebugmsg();

            login(null, null);
        }
        private void Createdebugmsg()
        {
            var usglst = new List<ConnectDB.DB_UserGroup.UserGroup>();
            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 8; j++) {
                    var usg = new ConnectDB.DB_UserGroup.UserGroup();
                    usg.USName = $"姓名{i}{j}";
                    usg.USNumber = $"Number_{i}_{j}";
                    usg.USworkshop = $"车间{i}";
                    usglst.Add(usg);
                }
            }
            var changecount = new ConnectDB.DB_UserGroup().Insert_DB(usglst);
        }
        private void login(object sender, EventArgs e)
        {
            menuStrip1.Items[2].Visible = true;//登录
            menuStrip1.Items[3].Visible = false;//登出
            menuStrip1.Items[0].Visible = menuStrip1.Items[1].Visible = false;//功能
            this.Visible = false;
            var loginf = new LogInForm();
            if (loginf.ShowDialog() == DialogResult.OK) {//登录成功
                var powerls = loginf.Tag.ToString();
                if (powerls == "0" || powerls == "1") {
                    menuStrip1.Items[0].Visible = true;//功能1
                }
                if (powerls == "0" || powerls == "2") {
                    menuStrip1.Items[1].Visible = true;//功能2
                }
                this.Visible = true;
                menuStrip1.Items[2].Visible = false;//登录
                menuStrip1.Items[3].Visible = true;//登出
            } else {//登录失败
                this.Visible = true;
                menuStrip1.Items[2].Visible = true;//登录
                menuStrip1.Items[3].Visible = false;//登出
                menuStrip1.Items[0].Visible = menuStrip1.Items[1].Visible = false;//功能
            }
        }

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Items[2].Visible = true;//登录
            menuStrip1.Items[3].Visible = false;//登出
            menuStrip1.Items[0].Visible = menuStrip1.Items[1].Visible = false;//功能
        }
    }
}
