namespace CSCI473_Assignment6
{
    partial class Graph1
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
            this.actualGraph1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.actualGraph1)).BeginInit();
            this.SuspendLayout();
            // 
            // actualGraph1
            // 
            chartArea1.Name = "ChartArea1";
            this.actualGraph1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.actualGraph1.Legends.Add(legend1);
            this.actualGraph1.Location = new System.Drawing.Point(12, 12);
            this.actualGraph1.Name = "actualGraph1";
            this.actualGraph1.Size = new System.Drawing.Size(1087, 491);
            this.actualGraph1.TabIndex = 0;
            this.actualGraph1.Text = "chart1";
            // 
            // Graph1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 522);
            this.Controls.Add(this.actualGraph1);
            this.Name = "Graph1";
            this.Text = "Graph1";
            ((System.ComponentModel.ISupportInitialize)(this.actualGraph1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart actualGraph1;
    }
}