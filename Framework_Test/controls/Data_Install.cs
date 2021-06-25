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
textBoxlength_of_work.Text ,
textBoxName.Text ,
textBoxProduction_capacity.Text ,
textBoxRemarks.Text ,
textBoxworkshop.Text ,
textBoxWork_content.Text
            };
            textBoxlength_of_work.Text =
                textBoxName.Text =
                textBoxProduction_capacity.Text =
                textBoxRemarks.Text =
                textBoxworkshop.Text =
                textBoxWork_content.Text =
                "";
        }
    }
}
