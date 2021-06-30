using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework_Test
{
    public partial class LogInForm : Form
    {
        public LogInForm()
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
            var usmsg = new ConnectDB.DB_UserGroup().Search_DB();
            var namels = from ConnectDB.DB_UserGroup.UserGroup i in usmsg
                         where (i.USName == textBox1.Text && i.USPsw == textBox2.Text)
                         select i;
            if (namels.Count() != 0) {
                var usdetail = namels.ToList()[0];
                this.Tag = usdetail.USPower?.Split('.');
                this.DialogResult = DialogResult.OK;
            } else {
                textBox1.Select();
                MessageBox.Show("用户名、密码错误，请重新输入。");
                button1_Click(new object(), new EventArgs());
            }
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            var tex = sender as TextBox;
            if (tex.PasswordChar == '*')
            {
                tex.PasswordChar = '\0';
            }
            else
            {
                tex.PasswordChar = '*';
            }
        }
    }
}
