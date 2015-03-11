using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assignment
{      // Class used for plotting the DFT of a signal
    public partial class FormPlot : Form
    {
        //an instance of signal processor to be used in processing the passed complex array before plotting it.
        private SignalProcessor signalProcessor;
       
        private double[] data;
        public FormPlot(Complex[] data)
        {
            InitializeComponent();
            signalProcessor = new SignalProcessor();
            //convert the DFT complex array into an array of doubles before plotting it.
            this.data = SignalProcessor.GetAbsolutes(data);
            
            
        }

        private void FormPlot_Load(object sender, EventArgs e)
        {
            //On loading the form, add the data points to the charts
            this.chartDFT.Series.Clear();
            this.chartDFT.Legends.Clear();
            //add chart title
            this.chartDFT.Titles.Add("Plot of absolute DFT of signal, y[n]");
            this.chartDFT.Series.Add("Frequenz");
            this.chartDFT.ChartAreas[0].AxisX.Title = "n";
            this.chartDFT.ChartAreas[0].AxisY.Title = "|Y[k]|";
            this.chartDFT.Series["Frequenz"].ChartType = SeriesChartType.FastPoint;
            this.chartDFT.Series["Frequenz"].YValuesPerPoint = 1;
            this.chartDFT.Series["Frequenz"].BorderWidth = 2;
            this.chartDFT.Series["Frequenz"].MarkerStyle = MarkerStyle.Circle;
            for (int index = 0; index < this.data.Length; index++)
            {
                DataPoint dp = new DataPoint(index, data[index]);
                dp.Color = index % 2 == 0 ? Color.Red : Color.Green;
                this.chartDFT.Series["Frequenz"].Points.Add(dp);
            }
   

        }

        private void chartDFT_Click(object sender, EventArgs e)
        {
           // this.Close();
      }

       
    }
}
