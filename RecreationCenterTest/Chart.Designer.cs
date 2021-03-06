
namespace RecreationCenter
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.EarningsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VisitorsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.homeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EarningsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // EarningsChart
            // 
            this.EarningsChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EarningsChart.BorderlineColor = System.Drawing.SystemColors.WindowText;
            this.EarningsChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.EarningsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.EarningsChart.Legends.Add(legend1);
            this.EarningsChart.Location = new System.Drawing.Point(35, 95);
            this.EarningsChart.Margin = new System.Windows.Forms.Padding(4);
            this.EarningsChart.Name = "EarningsChart";
            this.EarningsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Revenue";
            series1.YValuesPerPoint = 2;
            this.EarningsChart.Series.Add(series1);
            this.EarningsChart.Size = new System.Drawing.Size(674, 359);
            this.EarningsChart.TabIndex = 0;
            this.EarningsChart.Text = "Chart";
            title1.Name = "Customer Entry According to Days";
            this.EarningsChart.Titles.Add(title1);
            this.EarningsChart.Click += new System.EventHandler(this.visitChart_Click);
            // 
            // VisitorsChart
            // 
            this.VisitorsChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VisitorsChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea2.Name = "ChartArea1";
            this.VisitorsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.VisitorsChart.Legends.Add(legend2);
            this.VisitorsChart.Location = new System.Drawing.Point(35, 462);
            this.VisitorsChart.Margin = new System.Windows.Forms.Padding(4);
            this.VisitorsChart.Name = "VisitorsChart";
            this.VisitorsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Visitors";
            series2.YValuesPerPoint = 3;
            this.VisitorsChart.Series.Add(series2);
            this.VisitorsChart.Size = new System.Drawing.Size(674, 351);
            this.VisitorsChart.TabIndex = 1;
            this.VisitorsChart.Text = "Chart";
            title2.Name = "Customer Entry According to Days";
            this.VisitorsChart.Titles.Add(title2);
            this.VisitorsChart.Click += new System.EventHandler(this.VisitorsChart_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Crimson;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeBtn.Location = new System.Drawing.Point(35, 29);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(5);
            this.homeBtn.Size = new System.Drawing.Size(87, 39);
            this.homeBtn.TabIndex = 9;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(325, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chart";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(748, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.VisitorsChart);
            this.Controls.Add(this.EarningsChart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EarningsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart EarningsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VisitorsChart;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label label1;
    }
}