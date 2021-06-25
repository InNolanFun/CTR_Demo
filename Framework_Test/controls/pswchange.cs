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
    public partial class pswchange : UserControl
    {
        public pswchange()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text && textBox3.Text == "") {
                MessageBox.Show("请输入新密码.");
                return;
            }
            if (textBox2.Text == textBox3.Text) {
                if (MessageBox.Show("确认修改密码？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {

                }
            } else {
                MessageBox.Show("新密码不一致，请重新输入！！！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void DoubleClick_change_passwordchar(object sender, EventArgs e)
        {
            var tex = sender as TextBox;
            if (tex.PasswordChar == '*') {
                tex.PasswordChar = '\0';
            } else {
                tex.PasswordChar = '*';
            }
        }
    }
}
