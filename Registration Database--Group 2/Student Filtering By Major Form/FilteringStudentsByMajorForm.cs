using RegistrationEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Filtering_By_Major_Form
{
    public partial class studentFilteringByMajorForm : Form
    {
        RegistrationEntities RegistrationEntities;

        public studentFilteringByMajorForm()
        {
            InitializeComponent();
        }

        public studentFilteringByMajorForm(RegistrationEntities RE)
        {
            InitializeComponent();
            RegistrationEntities = RE;
            errorLabel.Text = String.Empty;
            fillListBoxWithEverythingInTable();
            loadMajorIntoComboBox();
        }

        private void fillListBoxWithEverythingInTable()
        {
            string listBoxEntry = null;
            foreach (Student s in RegistrationEntities.Students)
            {
                listBoxEntry = s.Id.ToString().PadRight(10) + s.Name.PadRight(54)
                               + s.Major.Name.PadRight(54) + s.Major.College;
                filterStudentsListBox.Items.Add(listBoxEntry);
            }
        }

        private void loadMajorIntoComboBox()
        {
            foreach (Major m in RegistrationEntities.Majors)
            {
                majorComboBox.Items.Add(m.Name);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;

            if (majorComboBox.SelectedItem != null)
            {
                filterStudentsListBox.Items.Clear();
                string studentRecordsMajor = null;
                string listBoxEntry = null;
                string selectedMajor = (string)majorComboBox.SelectedItem;

                foreach (Student s in RegistrationEntities.Students)
                {
                    studentRecordsMajor = s.Major.Name;

                    if (studentRecordsMajor == selectedMajor)
                    {
                        listBoxEntry = s.Id.ToString().PadRight(10) + s.Name.PadRight(54)
                                       + s.Major.Name.PadRight(54) + s.Major.College;
                        filterStudentsListBox.Items.Add(listBoxEntry);
                    }
                }
            }

            else
            {
                errorLabel.Text = "Error: You must select a major.";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;
            majorComboBox.SelectedItem = null;
            filterStudentsListBox.Items.Clear();
            fillListBoxWithEverythingInTable();
        }

        private void studentFilteringByMajorForm_Load(object sender, EventArgs e)
        {

        }
    }
}