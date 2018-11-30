namespace CSCI473_Assignment6
{
    partial class Form1
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
            this.ChartOneButton = new System.Windows.Forms.Button();
            this.ChartTwoButton = new System.Windows.Forms.Button();
            this.ChartThreeButton = new System.Windows.Forms.Button();
            this.ChartFourButton = new System.Windows.Forms.Button();
            this.ExitPortalButton = new System.Windows.Forms.Button();
            this.perEntryUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perEntryUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartOneButton
            // 
            this.ChartOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartOneButton.Location = new System.Drawing.Point(7, 7);
            this.ChartOneButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChartOneButton.Name = "ChartOneButton";
            this.ChartOneButton.Size = new System.Drawing.Size(257, 43);
            this.ChartOneButton.TabIndex = 0;
            this.ChartOneButton.Text = "Chart One";
            this.ChartOneButton.UseVisualStyleBackColor = true;
            this.ChartOneButton.Click += new System.EventHandler(this.ChartOneButton_Click);
            // 
            // ChartTwoButton
            // 
            this.ChartTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartTwoButton.Location = new System.Drawing.Point(7, 53);
            this.ChartTwoButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChartTwoButton.Name = "ChartTwoButton";
            this.ChartTwoButton.Size = new System.Drawing.Size(257, 43);
            this.ChartTwoButton.TabIndex = 1;
            this.ChartTwoButton.Text = "Chart Two";
            this.ChartTwoButton.UseVisualStyleBackColor = true;
            this.ChartTwoButton.Click += new System.EventHandler(this.ChartTwoButton_Click);
            // 
            // ChartThreeButton
            // 
            this.ChartThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartThreeButton.Location = new System.Drawing.Point(7, 100);
            this.ChartThreeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChartThreeButton.Name = "ChartThreeButton";
            this.ChartThreeButton.Size = new System.Drawing.Size(257, 43);
            this.ChartThreeButton.TabIndex = 2;
            this.ChartThreeButton.Text = "Chart Three";
            this.ChartThreeButton.UseVisualStyleBackColor = true;
            this.ChartThreeButton.Click += new System.EventHandler(this.ChartThreeButton_Click);
            // 
            // ChartFourButton
            // 
            this.ChartFourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartFourButton.Location = new System.Drawing.Point(7, 146);
            this.ChartFourButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChartFourButton.Name = "ChartFourButton";
            this.ChartFourButton.Size = new System.Drawing.Size(257, 43);
            this.ChartFourButton.TabIndex = 3;
            this.ChartFourButton.Text = "Chart Four";
            this.ChartFourButton.UseVisualStyleBackColor = true;
            this.ChartFourButton.Click += new System.EventHandler(this.ChartFourButton_Click);
            // 
            // ExitPortalButton
            // 
            this.ExitPortalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitPortalButton.Location = new System.Drawing.Point(7, 193);
            this.ExitPortalButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitPortalButton.Name = "ExitPortalButton";
            this.ExitPortalButton.Size = new System.Drawing.Size(257, 43);
            this.ExitPortalButton.TabIndex = 4;
            this.ExitPortalButton.Text = "Exit";
            this.ExitPortalButton.UseVisualStyleBackColor = true;
            this.ExitPortalButton.Click += new System.EventHandler(this.ExitPortalButton_Click);
            // 
            // perEntryUpDown
            // 
            this.perEntryUpDown.Location = new System.Drawing.Point(279, 212);
            this.perEntryUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.perEntryUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.perEntryUpDown.Name = "perEntryUpDown";
            this.perEntryUpDown.Size = new System.Drawing.Size(120, 20);
            this.perEntryUpDown.TabIndex = 5;
            this.perEntryUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.perEntryUpDown.ValueChanged += new System.EventHandler(this.perEntryUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quarters per Entry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perEntryUpDown);
            this.Controls.Add(this.ExitPortalButton);
            this.Controls.Add(this.ChartFourButton);
            this.Controls.Add(this.ChartThreeButton);
            this.Controls.Add(this.ChartTwoButton);
            this.Controls.Add(this.ChartOneButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "CSCI 473 Assignment Six";
            ((System.ComponentModel.ISupportInitialize)(this.perEntryUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChartOneButton;
        private System.Windows.Forms.Button ChartTwoButton;
        private System.Windows.Forms.Button ChartThreeButton;
        private System.Windows.Forms.Button ChartFourButton;
        private System.Windows.Forms.Button ExitPortalButton;
        private System.Windows.Forms.NumericUpDown perEntryUpDown;
        private System.Windows.Forms.Label label1;
    }
}

