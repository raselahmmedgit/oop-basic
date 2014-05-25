using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBasics_AssociationRelationship
{
    public partial class DapartmentUI : Form
    {
        public DapartmentUI()
        {
            InitializeComponent();
        }

        private Department aDepartment;
        private void deptSaveButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(deptCodeTextBox.Text, deptNameTextBox.Text);
            MessageBox.Show("Created");
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(studentNameTextBox.Text, studentRegNoTextBox.Text, studentEmailTextBox.Text);
            string msg = aDepartment.Add(aStudent);
            MessageBox.Show(msg);

        }

        private void showDetailsInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aDepartment.GetAllStudents().Count.ToString());
            Student Student1 = new Student("", "1", "");
            Student Student2 = new Student("", "1", "");
            aDepartment.GetAllStudents().Add(Student1);
            aDepartment.GetAllStudents().Add(Student2);
        }
    }
}
