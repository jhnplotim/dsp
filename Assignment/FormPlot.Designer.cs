namespace Assignment
{
    partial class FormPlot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.formPlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartDFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formPlotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDFT
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDFT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDFT.Legends.Add(legend1);
            this.chartDFT.Location = new System.Drawing.Point(41, 12);
            this.chartDFT.Name = "chartDFT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDFT.Series.Add(series1);
            this.chartDFT.Size = new System.Drawing.Size(650, 374);
            this.chartDFT.TabIndex = 0;
            this.chartDFT.Text = "Plot of the absolute value of the FFT";
            this.chartDFT.Click += new System.EventHandler(this.chartDFT_Click);
            // 
            // formPlotBindingSource
            // 
            this.formPlotBindingSource.DataSource = typeof(Assignment.FormPlot);
            // 
            // FormPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 439);
            this.Controls.Add(this.chartDFT);
            this.Name = "FormPlot";
            this.Text = "FormPlot";
            this.Load += new System.EventHandler(this.FormPlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formPlotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDFT;
        private System.Windows.Forms.BindingSource formPlotBindingSource;

    }
}