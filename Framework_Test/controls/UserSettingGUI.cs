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
            showresult();
        }

        private void showresult()
        {
            var usmsg = new ConnectDB.DB_UserGroup().Search_DB();
            var re = from ConnectDB.DB_UserGroup.UserGroup i in usmsg group i by i.USworkshop into g select g;
            treeView1.Nodes.Clear();
            foreach (var item in re) {
                var treno = new TreeNode(item.Key);
                foreach (var val in item) {
                    treno.Nodes.Add(new TreeNode($"姓名:{val.USName},工号:{val.USNumber},车间{val.USworkshop}"));
                }
                if (treno.Text == "车间0") {
                    treno.ExpandAll();
                }
                treeView1.Nodes.Add(treno);
            }
            treeView1.CheckBoxes = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert to db
            new ConnectDB.DB_UserGroup().Insert_DB(
                new List<ConnectDB.DB_UserGroup.UserGroup> { 
                    new ConnectDB.DB_UserGroup.UserGroup
                        {
                            USName = textBox1.Text,
                            USNumber = textBox2.Text,
                            USworkshop = textBox3.Text,
                            USRemarks = textBox4.Text,
                            USPower = comboBox1.Text,
                            USPsw = comboBox1.Text
                        } });
            showresult();
            //init
            foreach (var item in panel1.Controls) {
                if (item is TextBox) {
                    (item as TextBox).Text = "";
                }
            }
        }
    }
}
