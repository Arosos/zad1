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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            chartArea5.Name = "ChartArea1";
            this.AverageChart.ChartAreas.Add(chartArea5);
            this.AverageChart.Location = new System.Drawing.Point(12, 12);
            this.AverageChart.Name = "AverageChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "Series1";
            this.AverageChart.Series.Add(series5);
            this.AverageChart.Size = new System.Drawing.Size(320, 320);
            this.AverageChart.TabIndex = 0;
            this.AverageChart.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Średnie przystosowanie";
            this.AverageChart.Titles.Add(title5);
            // 
            // MaxChart
            // 
            chartArea6.Name = "ChartArea1";
            this.MaxChart.ChartAreas.Add(chartArea6);
            this.MaxChart.Location = new System.Drawing.Point(352, 12);
            this.MaxChart.Name = "MaxChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "Series1";
            this.MaxChart.Series.Add(series6);
            this.MaxChart.Size = new System.Drawing.Size(320, 320);
            this.MaxChart.TabIndex = 1;
            this.MaxChart.Text = "chart2";
            title6.Name = "Title1";
            title6.Text = "Maksymalne przystosowanie";
            this.MaxChart.Titles.Add(title6);
            // 
            // MinChart
            // 
            chartArea7.Name = "ChartArea1";
            this.MinChart.ChartAreas.Add(chartArea7);
            this.MinChart.Location = new System.Drawing.Point(12, 338);
            this.MinChart.Name = "MinChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Name = "Series1";
            this.MinChart.Series.Add(series7);
            this.MinChart.Size = new System.Drawing.Size(320, 320);
            this.MinChart.TabIndex = 2;
            this.MinChart.Text = "chart3";
            title7.Name = "Title1";
            title7.Text = "Minimalne przystosowanie";
            this.MinChart.Titles.Add(title7);
            // 
            // FunctionChart
            // 
            chartArea8.Name = "ChartArea1";
            this.FunctionChart.ChartAreas.Add(chartArea8);
            this.FunctionChart.Location = new System.Drawing.Point(352, 338);
            this.FunctionChart.Name = "FunctionChart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series8.Name = "Series1";
            series8.YValuesPerPoint = 2;
            this.FunctionChart.Series.Add(series8);
            this.FunctionChart.Size = new System.Drawing.Size(320, 320);
            this.FunctionChart.TabIndex = 3;
            this.FunctionChart.Text = "chart4";
            title8.Name = "Title1";
            title8.Text = "Wykres funkcji";
            this.FunctionChart.Titles.Add(title8);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.FunctionChart);
            this.Controls.Add(this.MinChart);
            this.Controls.Add(this.MaxChart);
            this.Controls.Add(this.AverageChart);
            this.Name = "Chart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Wykresy dla liczby generacji n = ";
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