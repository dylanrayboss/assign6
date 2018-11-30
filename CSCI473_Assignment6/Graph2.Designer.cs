namespace CSCI473_Assignment6
{
    partial class Graph2
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
            this.actualGraph2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.actualGraph2)).BeginInit();
            this.SuspendLayout();
            // 
            // actualGraph2
            // 
            chartArea1.Name = "ChartArea1";
            this.actualGraph2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.actualGraph2.Legends.Add(legend1);
            this.actualGraph2.Location = new System.Drawing.Point(12, 12);
            this.actualGraph2.Name = "actualGraph2";
            this.actualGraph2.Size = new System.Drawing.Size(1061, 538);
            this.actualGraph2.TabIndex = 0;
            this.actualGraph2.Text = "chart1";
            // 
            // Graph2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 562);
            this.Controls.Add(this.actualGraph2);
            this.Name = "Graph2";
            this.Text = "Graph2";
            ((System.ComponentModel.ISupportInitialize)(this.actualGraph2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart actualGraph2;
    }
}