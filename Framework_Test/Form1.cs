using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            var conn = new ContractMessage().Create();

        }
    }
}
