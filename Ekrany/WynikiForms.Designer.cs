
namespace POSK2.Ekrany
{
    partial class WynikiForms
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
            this.WyjscieDoMenuButton = new System.Windows.Forms.Button();
            this.WynikiWykresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WynikiLiczbyLabel = new System.Windows.Forms.Label();
            this.WynikiOpis = new System.Windows.Forms.Label();
            this.SredniaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WynikiWykresChart)).BeginInit();
            this.SuspendLayout();
            // 
            // WyjscieDoMenuButton
            // 
            this.WyjscieDoMenuButton.Location = new System.Drawing.Point(476, 600);
            this.WyjscieDoMenuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WyjscieDoMenuButton.Name = "WyjscieDoMenuButton";
            this.WyjscieDoMenuButton.Size = new System.Drawing.Size(196, 56);
            this.WyjscieDoMenuButton.TabIndex = 0;
            this.WyjscieDoMenuButton.Text = "Powrót do menu";
            this.WyjscieDoMenuButton.UseVisualStyleBackColor = true;
            this.WyjscieDoMenuButton.Click += new System.EventHandler(this.WyjscieDoMenuButton_Click);
            // 
            // WynikiWykresChart
            // 
            chartArea1.Name = "ChartArea1";
            this.WynikiWykresChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.WynikiWykresChart.Legends.Add(legend1);
            this.WynikiWykresChart.Location = new System.Drawing.Point(686, 66);
            this.WynikiWykresChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WynikiWykresChart.Name = "WynikiWykresChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.WynikiWykresChart.Series.Add(series1);
            this.WynikiWykresChart.Size = new System.Drawing.Size(450, 469);
            this.WynikiWykresChart.TabIndex = 13;
            this.WynikiWykresChart.Text = "chart1";
            // 
            // WynikiLiczbyLabel
            // 
            this.WynikiLiczbyLabel.AutoSize = true;
            this.WynikiLiczbyLabel.Location = new System.Drawing.Point(142, 99);
            this.WynikiLiczbyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WynikiLiczbyLabel.Name = "WynikiLiczbyLabel";
            this.WynikiLiczbyLabel.Size = new System.Drawing.Size(0, 25);
            this.WynikiLiczbyLabel.TabIndex = 3;
            // 
            // WynikiOpis
            // 
            this.WynikiOpis.AutoSize = true;
            this.WynikiOpis.Location = new System.Drawing.Point(550, 25);
            this.WynikiOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WynikiOpis.Name = "WynikiOpis";
            this.WynikiOpis.Size = new System.Drawing.Size(71, 25);
            this.WynikiOpis.TabIndex = 4;
            this.WynikiOpis.Text = "Wyniki";
            // 
            // SredniaLabel
            // 
            this.SredniaLabel.AutoSize = true;
            this.SredniaLabel.Location = new System.Drawing.Point(163, 510);
            this.SredniaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SredniaLabel.Name = "SredniaLabel";
            this.SredniaLabel.Size = new System.Drawing.Size(64, 25);
            this.SredniaLabel.TabIndex = 5;
            this.SredniaLabel.Text = "label1";
            // 
            // WynikiForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.ControlBox = false;
            this.Controls.Add(this.SredniaLabel);
            this.Controls.Add(this.WynikiOpis);
            this.Controls.Add(this.WynikiLiczbyLabel);
            this.Controls.Add(this.WynikiWykresChart);
            this.Controls.Add(this.WyjscieDoMenuButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WynikiForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WynikiForms";
            ((System.ComponentModel.ISupportInitialize)(this.WynikiWykresChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WyjscieDoMenuButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart WynikiWykresChart;
        private System.Windows.Forms.Label WynikiLiczbyLabel;
        private System.Windows.Forms.Label WynikiOpis;
        private System.Windows.Forms.Label SredniaLabel;
    }
}