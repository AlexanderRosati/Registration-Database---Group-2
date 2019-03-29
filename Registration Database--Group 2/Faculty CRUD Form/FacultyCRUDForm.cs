using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistrationEntityModel;

namespace Faculty_CRUD_Form
{
    public partial class FacultyCRUDForm : Form
    {
        private RegistrationEntities RegistrationEntities;

        public FacultyCRUDForm()
        {
            InitializeComponent();
        }

        public FacultyCRUDForm(RegistrationEntities RE)
        {
            InitializeComponent();
            RegistrationEntities = RE;
            errorLabel.Text = String.Empty;
        }

        private void addFacultyMemberButton_Click(object sender, EventArgs e)
        {
            Faculty newFacultyMember = new Faculty()
            {
                Name = "John Baugh",
                PhoneNumber = "555-555-5555"
            };

            RegistrationEntities.Faculties.Add(newFacultyMember);
            RegistrationEntities.SaveChanges();
        }
    }
}
