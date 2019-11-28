using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_db
{
    public partial class Add_Student_Form : Form
    {
        public Add_Student_Form()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            String fname = txtbox_fname.Text;
            String lname = txtbox_lname.Text;
            DateTime dob = dtime_bd.Value;
            string gender = "Male";
            if (radioButton_female.Checked)
            {
                gender = "Female";
            }

            Student student = new Student();
            if (check_entry())
            {
                student.InsertStudent(fname, lname, dob, gender);
                MessageBox.Show("Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
            }
            
            
        }

        private Boolean check_entry()
        {
            if (String.IsNullOrEmpty(txtbox_fname.Text) || String.IsNullOrEmpty(txtbox_lname.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
