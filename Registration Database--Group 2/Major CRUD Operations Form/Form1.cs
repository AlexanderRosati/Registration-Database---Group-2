using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatabaseClasses;

namespace Major_CRUD_Operations_Form
{
    public partial class majorCRUDForm : Form
    {
        public RegistrationEntities RegistrationEntities;

        public majorCRUDForm()
        {
            InitializeComponent();
            errorLabel.Text = String.Empty;
        }

        private void addMajorButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;

            if (majorNameTextBot.Text == String.Empty)
            {
                errorLabel.Text = "Error: You did not enter a major name.";
            }

            else if (collegeTextBox.Text == String.Empty)
            {
                errorLabel.Text = "Error: You did not enter a college name.";
            }

            else
            {

            }

            majorNameTextBot.Text = String.Empty;
            collegeTextBox.Text = String.Empty;
        }
    }
}
