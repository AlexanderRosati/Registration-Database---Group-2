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
            updateListBox();
            loadMajorIntoComboBox();
        }

        private void updateListBox()
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

        }
    }
}
