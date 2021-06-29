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
            var conn = new ConnectDB.makeConnect();
            var usmsg = conn.GetMessage("UserGroup");
            //debugmsg(conn);
            var re = from UserGroup i in usmsg group i by i.USworkshop into g select g;
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
        private void debugmsg(ConnectDB.makeConnect conn)
        {
            for (int i = 0; i < 9; i++) {
                var usg = new UserGroup();
                for (int j = 0; j < 8; j++) {
                    usg.USName = $"姓名{i}{j}";
                    usg.USNumber = $"Number_{i}_{j}";
                    usg.USworkshop = $"车间{i}";
                    insertintodb(conn, usg);
                }
            }
        }

        private void insertintodb(ConnectDB.makeConnect conn, UserGroup usg)
        {
            var USName = usg.USName;
            var USNumber = usg.USNumber;
            var USworkshop = usg.USworkshop;
            var USRemarks = usg.USRemarks;
            var USPower = usg.USPower;
            var USPsw = usg.USPsw;
            var parami = new {
                USName,
                USNumber,
                USworkshop,
                USRemarks,
                USPower,
                USPsw
            };
            var result = new ValueDetail().Insert(conn.dbls[1].Install_sql, parami);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert to db
            var new_us_msg = new UserGroup {
                USName = textBox1.Text,
                USNumber = textBox2.Text,
                USworkshop = textBox3.Text,
                USRemarks = textBox4.Text,
                USPower = comboBox1.Text,
                USPsw = comboBox1.Text
            };
            insertintodb(new ConnectDB.makeConnect(), new_us_msg);
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
