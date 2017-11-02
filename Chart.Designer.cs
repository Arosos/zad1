namespace zad1
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.AverageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MaxChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MinChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FunctionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.AverageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AverageChart
            // 
            chartArea1.Name = "ChartArea1";
            this.AverageChart.ChartAreas.Add(chartArea1);
            this.AverageChart.Location = new System.Drawing.Point(12, 12);
            this.AverageChart.Name = "AverageChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.AverageChart.Series.Add(series1);
            this.AverageChart.Size = new System.Drawing.Size(377, 365);
            this.AverageChart.TabIndex = 0;
            this.AverageChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Średnie przystosowanie";
            this.AverageChart.Titles.Add(title1);
            // 
            // MaxChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MaxChart.ChartAreas.Add(chartArea2);
            this.MaxChart.Location = new System.Drawing.Point(395, 12);
            this.MaxChart.Name = "MaxChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.MaxChart.Series.Add(series2);
            this.MaxChart.Size = new System.Drawing.Size(377, 365);
            this.MaxChart.TabIndex = 1;
            this.MaxChart.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Maksymalne przystosowanie";
            this.MaxChart.Titles.Add(title2);
            // 
            // MinChart
            // 
            chartArea3.Name = "ChartArea1";
            this.MinChart.ChartAreas.Add(chartArea3);
            this.MinChart.Location = new System.Drawing.Point(12, 384);
            this.MinChart.Name = "MinChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series1";
            this.MinChart.Series.Add(series3);
            this.MinChart.Size = new System.Drawing.Size(377, 365);
            this.MinChart.TabIndex = 2;
            this.MinChart.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Minimalne przystosowanie";
            this.MinChart.Titles.Add(title3);
            // 
            // FunctionChart
            // 
            chartArea4.Name = "ChartArea1";
            this.FunctionChart.ChartAreas.Add(chartArea4);
            this.FunctionChart.Location = new System.Drawing.Point(395, 384);
            this.FunctionChart.Name = "FunctionChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            this.FunctionChart.Series.Add(series4);
            this.FunctionChart.Size = new System.Drawing.Size(377, 365);
            this.FunctionChart.TabIndex = 3;
            this.FunctionChart.Text = "chart4";
            title4.Name = "Title1";
            title4.Text = "Wykres funkcji";
            this.FunctionChart.Titles.Add(title4);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 733);
            this.Controls.Add(this.FunctionChart);
            this.Controls.Add(this.MinChart);
            this.Controls.Add(this.MaxChart);
            this.Controls.Add(this.AverageChart);
            this.Name = "Chart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Wykresy dla populacji n = ";
            ((System.ComponentModel.ISupportInitialize)(this.AverageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart AverageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MaxChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MinChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart FunctionChart;
    }
}