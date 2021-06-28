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
            var ls = new List<string> {
                length_of_work_textBox.Text ,
                Name_textBox.Text ,
                Production_capacity_textBox.Text ,
                Remarks_textBox.Text ,
                workshop_textBox.Text ,
                Work_content_textBox.Text
            };

            var dgv = dataGridView1;

            var rowc = dgv.Rows.Count - 1;
            dgv.Rows.Add();
            dgv[0, rowc].Value = Name_textBox.Text;
            dgv[1, rowc].Value = Work_content_textBox.Text;
            dgv[2, rowc].Value = length_of_work_textBox.Text;
            dgv[3, rowc].Value = workshop_textBox.Text;
            dgv[4, rowc].Value = Production_capacity_textBox.Text;
            dgv[5, rowc].Value = Remarks_textBox.Text;

            //reset text
            length_of_work_textBox.Text =
            Name_textBox.Text =
            Production_capacity_textBox.Text =
            Remarks_textBox.Text =
            workshop_textBox.Text =
            Work_content_textBox.Text =
            "";
            Name_textBox.Select();
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
    }
}
