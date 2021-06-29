using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework_Test.controls
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls) {
                if (item is TextBox) {
                    (item as TextBox).Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var conn = new ConnectDB.makeConnect();
            var usmsg = conn.GetMessage("UserGroup");
            var namels = from UserGroup i in usmsg
                         where (i.USName == textBox1.Text && i.USPsw == textBox2.Text)
                         select i;
            if (namels.Count() != 0) {
                var usdetail = namels.ToList()[0];
                this.Tag = usdetail.USPower.Split('.');
                this.ParentForm.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("用户名、密码错误，请重新输入。");
                button1_Click(new object(), new EventArgs());
            }
        }
    }
}
