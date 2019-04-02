using RegistrationEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Course_Filter_By_Department
{
    public partial class CourseFilteringByDepartmentForm : Form
    {
        RegistrationEntities RegistrationEntities;

        public CourseFilteringByDepartmentForm()
        {
            InitializeComponent();
        }

        public CourseFilteringByDepartmentForm(RegistrationEntities RE)
        {
            InitializeComponent();
            RegistrationEntities = RE;
            errorLabel.Text = String.Empty;
            fillListBoxWithEverythingInCourseTable();
            loadDepartmentComboBox();
        }

        private void loadDepartmentComboBox()
        {
            List<string> departmentsAlreadyInComboBox = new List<string>();
            foreach (Course c in RegistrationEntities.Courses)
            {
                if (!departmentsAlreadyInComboBox.Contains(c.Department.ToLower()))
                {
                    departmentsAlreadyInComboBox.Add(c.Department.ToLower());
                    departmentComboBox.Items.Add(c.Department.ToLower());
                }
            }
        }

        private void fillListBoxWithEverythingInCourseTable()
        {
            string listBoxEntry = null;
            foreach (Course c in RegistrationEntities.Courses)
            {
                listBoxEntry = c.Id.ToString().PadRight(10) + c.Name.PadRight(54) + c.Number.PadRight(14)
                               + c.Credits.ToString().PadRight(14) + c.Department;
                filteringCoursesListBox.Items.Add(listBoxEntry);
            }
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;

            if (departmentComboBox.SelectedItem != null)
            {
                filteringCoursesListBox.Items.Clear();
                string departmentSelected = (string)departmentComboBox.SelectedItem;
                string listBoxEntry = null;
                
                foreach (Course c in RegistrationEntities.Courses)
                {
                    if (c.Department.ToLower() == departmentSelected)
                    {
                        listBoxEntry = c.Id.ToString().PadRight(10) + c.Name.PadRight(54) + c.Number.PadRight(14)
                               + c.Credits.ToString().PadRight(14) + c.Department;
                        filteringCoursesListBox.Items.Add(listBoxEntry);
                    }
                }
            }

            else
            {
                errorLabel.Text = "Error: You must select a department.";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;
            departmentComboBox.SelectedItem = null;
            filteringCoursesListBox.Items.Clear();
            fillListBoxWithEverythingInCourseTable();
        }
    }
}
