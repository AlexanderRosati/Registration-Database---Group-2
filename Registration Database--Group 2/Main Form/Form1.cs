using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Major_CRUD_Operations_Form;

namespace Main_Form
{
    public partial class mainForm : Form
    {
        //Do not allow more than one form to be opened at a time
        private bool formIsOpen;

        private RegistrationEntities RegistrationEntities;

        public mainForm()
        {
            InitializeComponent();
            formIsOpen = false;
            RegistrationEntities = new RegistrationEntities();
        }

        private void majorCRUDButton_Click(object sender, EventArgs e)
        {
            if (formIsOpen == false)
            { 
                formIsOpen = true;
                majorCRUDForm majorCRUDForm = new majorCRUDForm(RegistrationEntities);
                majorCRUDForm.Show();
                formIsOpen = false;
            }
        }
    }
}
