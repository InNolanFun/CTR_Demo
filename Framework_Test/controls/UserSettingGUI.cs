using HZH_Controls.Controls;
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
    public partial class UserSettingGUI : UserControl
    {
        public UserSettingGUI()
        {
            InitializeComponent();
        }

        private void UserSettingGUI_Load(object sender, EventArgs e)
        {
            var conn = new ConnectDB.makeConnect();
            conn.GetMessage("user");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert to db

            //show tree
            for (int j = 0; j < 3; j++) {
                var tno = new TreeNode($"厂区{j}");
                for (int i = 0; i < 5; i++) {
                    tno.Nodes.Add(new TreeNode($"姓名{i}{j}") { });
                }
                treeView1.Nodes.Add(tno);
            }
            treeView1.ExpandAll();
            treeView1.CheckBoxes = true;
            //init
            foreach (var item in panel1.Controls) {
                if (item is TextBox) {
                    (item as TextBox).Text = "";
                }
            }
        }
    }
}
