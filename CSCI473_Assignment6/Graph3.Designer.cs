namespace CSCI473_Assignment6
{
    partial class Graph3
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
            this.actualGraph3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.actualGraph3)).BeginInit();
            this.SuspendLayout();
            // 
            // actualGraph3
            // 
            chartArea1.Name = "ChartArea1";
            this.actualGraph3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.actualGraph3.Legends.Add(legend1);
            this.actualGraph3.Location = new System.Drawing.Point(12, 12);
            this.actualGraph3.Name = "actualGraph3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.actualGraph3.Series.Add(series1);
            this.actualGraph3.Size = new System.Drawing.Size(638, 426);
            this.actualGraph3.TabIndex = 0;
            this.actualGraph3.Text = "chart1";
            // 
            // Graph3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actualGraph3);
            this.Name = "Graph3";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.actualGraph3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart actualGraph3;
    }
}