using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chartSin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbFunkce.SelectedIndex = 0;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            double amplitude;
                for (double i = 0; i <= 360; i++)
            {
                 amplitude = (double)nmAmpl.Value * (double)Math.Sin(2 * Math.PI * (double)nmFreq.Value * i);
                chart1.Series[0].Points.AddXY(i, amplitude);
            }
        }

        private void nmAmpl_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
