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
    public partial class Data_Install : UserControl
    {
        public Data_Install()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ls = new ConnectDB.DB_ContractMessage.ValueGroup
            {
                length_of_work = length_of_work_textBox.Text,
                UName = Name_comBox.Text,
                Production_capacity = Production_capacity_textBox.Text,
                Remarks = Remarks_textBox.Text,
                workshop = workshop_textBox.Text,
                Work_content = Work_content_textBox.Text
            };
            new ConnectDB.DB_ContractMessage().Insert_DB(new List<ConnectDB.DB_ContractMessage.ValueGroup> { ls });
            //show in dgv
            var dgv = dataGridView1;
            var rowc = dgv.Rows.Count - 1;
            dgv.Rows.Add();
            dgv[0, rowc].Value = ls.UName;
            dgv[1, rowc].Value = ls.Work_content;
            dgv[2, rowc].Value = ls.length_of_work;
            dgv[3, rowc].Value = ls.workshop;
            dgv[4, rowc].Value = ls.Production_capacity;
            dgv[5, rowc].Value = ls.Remarks;
            //reset text
            length_of_work_textBox.Text =
            Name_comBox.Text =
            Production_capacity_textBox.Text =
            Remarks_textBox.Text =
            workshop_textBox.Text =
            Work_content_textBox.Text =
            "";
            Name_comBox.Select();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 删除行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ty = e.GetType();
            var rowc = dataGridView1.SelectedRows;
            if (rowc.Count != 0) {
                var rowls = new List<DataGridViewRow>();
                foreach (DataGridViewRow item in rowc) {
                    rowls.Add(item);
                }
                foreach (DataGridViewRow item in rowc) {
                    dataGridView1.Rows.Remove(item);
                }
            } else {
                var cells = dataGridView1.SelectedCells;
                if (cells.Count != 0) {
                    foreach (DataGridViewTextBoxCell item in cells) {
                        dataGridView1.Rows.RemoveAt(item.RowIndex);
                    }
                }
            }
        }

        private void Data_Install_Load(object sender, EventArgs e)
        {
            var usmsg = new ConnectDB.DB_UserGroup().Search_DB();
            var namels = (from ConnectDB.DB_UserGroup.UserGroup i in usmsg select i.USName).ToList();

            lsdetail = (from ConnectDB.DB_UserGroup.UserGroup i in usmsg select i).ToList();
            listCombobox = namels;
            Name_comBox.Items.Clear();
            Name_comBox.Items.AddRange(listCombobox.ToArray());
        }
        private List<ConnectDB.DB_UserGroup.UserGroup> lsdetail = new List<ConnectDB.DB_UserGroup.UserGroup>();
        private List<string> listCombobox = new List<string>();
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            selectCombobox(Name_comBox, listCombobox);
        }

        #region 设置Combobox的方法
        //得到Combobox的数据，返回一个List
        public List<string> getComboboxItems(ComboBox cb)
        {
            //初始化绑定默认关键词
            List<string> listOnit = new List<string>();
            //将数据项添加到listOnit中
            for (int i = 0; i < cb.Items.Count; i++) {
                listOnit.Add(cb.Items[i].ToString());
            }
            return listOnit;
        }
        //模糊查询Combobox
        public void selectCombobox(ComboBox cb, List<string> listOnit)
        {
            //输入key之后返回的关键词
            List<string> listNew = new List<string>();
            //清空combobox
            cb.Items.Clear();
            //清空listNew
            listNew.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit) {
                if (item.Contains(cb.Text)) {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }
            //combobox添加已经查询到的关键字
            cb.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            cb.SelectionStart = cb.Text.Length;
            //保持鼠标指针原来状态，有时鼠标指针会被下拉框覆盖，所以要进行一次设置
            Cursor = Cursors.Default;
            //自动弹出下拉框
            cb.DroppedDown = true;
        }
        #endregion

        private void Name_comBox_TextChanged(object sender, EventArgs e)
        {
            if (listCombobox.Contains(Name_comBox.Text)) {
                workshop_textBox.Text = (from i in lsdetail where i.USName == Name_comBox.Text select i.USworkshop).ToList()[0];
            }
        }
    }
}
