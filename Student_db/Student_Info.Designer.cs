namespace Student_db
{
    partial class Student_Info
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.agebot = new System.Windows.Forms.Button();
            this.gradebot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend";
            legend3.Title = "Legend";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend";
            series3.MarkerSize = 1;
            series3.Name = "series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(614, 481);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Name = "Student Information";
            title3.Text = "Student Information";
            this.chart1.Titles.Add(title3);
            // 
            // agebot
            // 
            this.agebot.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.agebot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agebot.Location = new System.Drawing.Point(632, 94);
            this.agebot.Name = "agebot";
            this.agebot.Size = new System.Drawing.Size(135, 58);
            this.agebot.TabIndex = 1;
            this.agebot.Text = "Show Age";
            this.agebot.UseVisualStyleBackColor = false;
            this.agebot.Click += new System.EventHandler(this.agebot_Click);
            // 
            // gradebot
            // 
            this.gradebot.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gradebot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradebot.Location = new System.Drawing.Point(632, 186);
            this.gradebot.Name = "gradebot";
            this.gradebot.Size = new System.Drawing.Size(135, 58);
            this.gradebot.TabIndex = 2;
            this.gradebot.Text = "Show Grade";
            this.gradebot.UseVisualStyleBackColor = false;
            this.gradebot.Click += new System.EventHandler(this.gradebot_Click);
            // 
            // Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 505);
            this.Controls.Add(this.gradebot);
            this.Controls.Add(this.agebot);
            this.Controls.Add(this.chart1);
            this.Name = "Student_Info";
            this.Text = "Student_Info";
            this.Load += new System.EventHandler(this.Student_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button agebot;
        private System.Windows.Forms.Button gradebot;
    }
}