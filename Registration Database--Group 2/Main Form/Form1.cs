using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Student_CRUD_Operations_Form;
using RegistrationEntityModel;

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
                Major_CRUD_Operations_Form.majorCRUDForm majorCRUDForm = new Major_CRUD_Operations_Form.majorCRUDForm(RegistrationEntities);
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
                Student_CRUD_Operations_Form.studentCRUDForm studentCRUDForm = new Student_CRUD_Operations_Form.studentCRUDForm(RegistrationEntities);
                studentCRUDForm.Show();
            }

            else
            {
                MessageBox.Show("You can only have one form open at a time.");
            }
        }
    }
}
