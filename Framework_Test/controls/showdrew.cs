using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Framework_Test.controls
{
    public partial class showdrew : UserControl
    {
        public showdrew()
        {
            InitializeComponent();
        }

        private void showdrew_Load(object sender, EventArgs e)
        {
            InitChart();
            show_message();
            DGVShow();
        }

        private void DGVShow()
        {
            var usmsg = new ConnectDB.DB_ContractMessage().Search_DB();
            var dt = new DataTable();
            dt.Columns.Add("姓名");
            dt.Columns.Add("工作内容");
            dt.Columns.Add("车间");
            dt.Columns.Add("工作时间");
            dt.Columns.Add("产能");
            dt.Columns.Add("备注");
            foreach (ConnectDB.DB_ContractMessage.ValueGroup item in usmsg) {
                var dr = dt.NewRow();
                dr["姓名"] = item.UName;
                dr["工作内容"] = item.Production_capacity;
                dr["车间"] = item.workshop;
                dr["工作时间"] = item.length_of_work;
                dr["产能"] = item.Work_content;
                dr["备注"] = item.Remarks;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private Queue<double> dataQueue = new Queue<double>(100);
        private int curValue = 0;
        private int num = 5;//每次删除增加几个点
        private void show_message()
        {
            UpdateQueueValue();
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataQueue.Count; i++) {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue.ElementAt(i));
            }
        }
        private void UpdateQueueValue()
        {
            if (dataQueue.Count > 100) {
                //先出列
                for (int i = 0; i < num; i++) {
                    dataQueue.Dequeue();
                }
            }
            Random r = new Random();
            for (int i = 0; i < num; i++) {
                dataQueue.Enqueue(r.Next(0, 100));
            }
        }
        /// <summary>
        /// 初始化图表
        /// </summary>
        private void InitChart()
        {
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("S1");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            //设置图表显示样式
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 100;
            this.chart1.ChartAreas[0].AxisX.Interval = 5;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "XXX显示";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //设置图表显示样式
            this.chart1.Series[0].Color = Color.Red;
            //this.chart1.Titles[0].Text = string.Format("XXX {0} 显示");
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            this.chart1.Series[0].Points.Clear();
        }
    }
}
