using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Student_db
{
    public partial class Student_Info : Form
    {
        public Student_Info()
        {
            InitializeComponent();
        }

        private void Student_Info_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            
        }

        private void agebot_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series age = chart1.Series.Add("Age");
            age.ChartType = SeriesChartType.Line;
            age.Points.AddXY(0, 0);
            age.Points.AddXY(1, 5);
            age.Points.AddXY(2, 0);


        }

        private void gradebot_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series grade = chart1.Series.Add("grade");
            grade.ChartType = SeriesChartType.Line;
            grade.Points.AddXY(0, -10);
            grade.Points.AddXY(1, 15);
            grade.Points.AddXY(2, 25);
        }
    }
}