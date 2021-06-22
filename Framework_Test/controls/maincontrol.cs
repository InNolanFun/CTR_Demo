using System;
using System.Windows.Forms;

namespace Framework_Test.controls
{
    public partial class maincontrol : UserControl
    {
        public maincontrol(string modulename)
        {
            InitializeComponent();
            setmodulename(modulename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }
    }
}
