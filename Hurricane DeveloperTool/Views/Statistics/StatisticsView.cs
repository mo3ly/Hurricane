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

namespace Hurricane_DeveloperTool.Views
{
    public partial class StatisticsView : Form, IStatisticsView
    {
        private static StatisticsView instance;

        public StatisticsView()
        {
            InitializeComponent();
            chart1.MouseMove += chart_MouseMove;
            chartTooltip.Draw += DashboardTooltip_Draw;

        }

        public static StatisticsView GetInstance(DashboardView parent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StatisticsView();
                instance.TopLevel = false;
                instance.Dock = DockStyle.Fill;
                parent.AddView(instance);
            }

            parent.SetView(instance);

            return instance;
        }

        private void StatisticsView_Load(object sender, EventArgs e)
        {

            chart2.Series[0].Points.AddXY("Thieves", 37);
            chart2.Series[0].Points.AddXY("Hunters", 42);
            chart2.Series[0].Points.AddXY("Traders", 84);

            FillChart();
        }


        Point? prevPosition = null;
        ToolTip chartTooltip = new ToolTip();
        // so expesnsive
        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            chartTooltip.RemoveAll();
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    chartTooltip.Show((int)yVal + " player(s)", chart1, pos.X, pos.Y - 15);
                    chartTooltip.ToolTipTitle = "Info";
                    chartTooltip.OwnerDraw = true;
                }
            }
        }

        private void DashboardTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            chartTooltip.BackColor = Color.FromArgb(31, 31, 31);
            chartTooltip.ForeColor = Color.White;
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void FillChart()
        {

            int blockSize = 40;

            // generates random data (i.e. 30 * blockSize random numbers)
            Random rand = new Random();
            var valuesArray = Enumerable.Range(0, blockSize * 2).Select(x => rand.Next(1, 150)).ToArray();

            // clear the chart
            chart1.Series.Clear();

            // fill the chart
            var series = chart1.Series.Add("My Series");
            series.ChartType = SeriesChartType.Spline;
            series.XValueType = ChartValueType.DateTime;
            series.YValueType = ChartValueType.Int32;
            for (int i = 0; i < valuesArray.Length; i++)
                series.Points.AddXY(DateTime.Now.AddMinutes(i).ToString("HH:mm"), valuesArray[i]);


            var chartArea = chart1.ChartAreas[series.ChartArea];

            // set view range to [0,max]
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = valuesArray.Length;

            // enable autoscroll
            chartArea.CursorX.AutoScroll = true;

            // let's zoom to [0,blockSize] (e.g. [0,100])
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Hours;
            int position = 0;
            int size = blockSize;
            chartArea.AxisX.ScaleView.Zoom(position, size);

            // disable zoom-reset button (only scrollbar's arrows are available)
            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            // set scrollbar small change to blockSize (e.g. 100)
            chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;

            chart1.ChartAreas[0].AxisX.LineColor = Color.FromArgb(60, 60, 60); 
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Gainsboro;
            chart1.ChartAreas[0].AxisY.LineColor = Color.FromArgb(60, 60, 60);
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(50, 50, 50);
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Gainsboro;

        }

        private void collapseGameLogs_Click(object sender, EventArgs e)
        {
            gameLogsPanel.Visible = !gameLogsPanel.Visible;
            collapseGameLogsArrow.Text = gameLogsPanel.Visible ? "⮝" : "⮟";
        }

        private void collapseGameStats_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
