using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_db
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student_Form addstdform = new Add_Student_Form();
            addstdform.ShowDialog();
            
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Info infostudent = new Student_Info();
            infostudent.ShowDialog();
        }
    }
}
