using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Student_CRUD_Operations_Form;
using Major_CRUD_Operations_Form;
using Enrollment_CRUD_Form;
using RegistrationEntityModel;

using Section_Filtering_Form;
using Enrollment_Filtering_Form;

namespace Main_Form
{
    public partial class mainForm : Form
    {
        private RegistrationEntities RegistrationEntities;

        public mainForm()
        {
            InitializeComponent();
            RegistrationEntities = new RegistrationEntities();
        }

        private void majorCRUDButton_Click(object sender, EventArgs e)
        {
            if (CanOpenNewForm())
            {
                majorCRUDForm majorCRUDForm = new Major_CRUD_Operations_Form.majorCRUDForm(RegistrationEntities);
                majorCRUDForm.Show();
            }

            else
            {
                MessageBox.Show("You can only have one form open at a time.");
            }
        }

        private bool CanOpenNewForm()
        {
            return Application.OpenForms.Count < 2;
        }

        private void studentCRUDButton_Click(object sender, EventArgs e)
        {
            if (CanOpenNewForm())
            {
                studentCRUDForm studentCRUDForm = new Student_CRUD_Operations_Form.studentCRUDForm(RegistrationEntities);
                studentCRUDForm.Show();
            }

            else
            {
                MessageBox.Show("You can only have one form open at a time.");
            }
        }

        private void enrollmentCRUDButton_Click(object sender, EventArgs e)
        {
            if (CanOpenNewForm())
            {
                enrollmentCRUDForm enrollmentCRUDForm = new enrollmentCRUDForm(RegistrationEntities);
                enrollmentCRUDForm.Show();
            }

            else
            {
                MessageBox.Show("You can only have one form open at a time.");
            }
        }

        private void sectionFilteringBySemesterButton_Click(object sender, EventArgs e)
        {
            if (CanOpenNewForm())
            {
                SectionFilteringForm sectionFilteringForm = new SectionFilteringForm(RegistrationEntities);
                sectionFilteringForm.Show();
            }

            else
            {
                MessageBox.Show("You can only have one form open at a time.");
            }
        }

        private void enrollmentFilteringByStudent_Click(object sender, EventArgs e)
        {
            if (CanOpenNewForm())
            {
                EnrollmentFilteringForm enrollmentFilteringForm = new EnrollmentFilteringForm(RegistrationEntities);
                enrollmentFilteringForm.Show();
            }

            else
            {
                MessageBox.Show("You can only have one form open at a time.");
            }
        }
    }
}
