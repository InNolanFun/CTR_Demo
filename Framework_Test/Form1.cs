using System;
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

        private void Add_Control(string modulename)
        {
            var tabpage = new TabPage(modulename);
            var control = new controls.maincontrol(modulename) {
                Dock = DockStyle.Fill
            };
            tabpage.Controls.Add(control);
            tabControl1.Controls.Add(tabpage);
            tabControl1.SelectedTab = tabpage;
        }

        private void tabControl1_ControlRemoved(object sender, ControlEventArgs e)
        {

        }
    }
}
