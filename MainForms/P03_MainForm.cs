using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class P03_MainForm : Form
    {
        Thread thread_NowDate;

        public P03_MainForm()
        {
            InitializeComponent();
        }
        
        private void P03_MainForm_Load(object sender, EventArgs e)
        {
            ThreadStart StartThread = new ThreadStart(TimeShow);
            thread_NowDate = new Thread(StartThread);
            thread_NowDate.Start();
        }

        private void timNowDate_Tick(object sender, EventArgs e)
        {
            stsNowdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void TimeShow()
        {
            // 스레드가 실행 할 로직 
            while (true)
            {
                Thread.Sleep(1000);
                stsNowdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        double x;
        double _x = 99;
        Random rnd = new Random();

        private void CCP화면용_Load(object sender, LayoutEventArgs e)
        {
            button1.Text = "Start";
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(x, 3 * Math.Sin(5 * x) + 5 * Math.Cos(3 * x));

            if (chart1.Series[0].Points.Count > 100)
                chart1.Series[0].Points.RemoveAt(0);

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = x;

            x += 0.1;

            if (_x >= 100)
                _x -= rnd.NextDouble() * 4.5;

            if (_x <= 100)
                _x += rnd.NextDouble() * 0.1;

            chart2.Series[0].Points.AddXY(x, _x);

        }

        private void buttion1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Start";
            }
            else
            {
                timer1.Start();
                button1.Text = "Stop";
            }
        }


    }
}
