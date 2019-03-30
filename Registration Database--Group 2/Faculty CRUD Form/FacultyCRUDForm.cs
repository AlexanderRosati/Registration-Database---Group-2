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
            updateListBox();
        }

        private void updateListBox()
        {
            string listBoxEntry = null;
            foreach (Faculty faculty in RegistrationEntities.Faculties)
            {
                listBoxEntry = faculty.Id.ToString().PadRight(10)
                               + faculty.Name.PadRight(54)
                               + faculty.PhoneNumber;
                facultyListBox.Items.Add(listBoxEntry);
            }
        }

        private bool isNotPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length == 14)
            {
                //Determine is string is valid phone number
                bool[] boolArray = new bool[10];

                boolArray[0] = Char.IsDigit(phoneNumber.ElementAt(1));
                boolArray[1] = Char.IsDigit(phoneNumber.ElementAt(2));
                boolArray[2] = Char.IsDigit(phoneNumber.ElementAt(3));
                boolArray[3] = Char.IsDigit(phoneNumber.ElementAt(6));
                boolArray[4] = Char.IsDigit(phoneNumber.ElementAt(7));
                boolArray[5] = Char.IsDigit(phoneNumber.ElementAt(8));
                boolArray[6] = Char.IsDigit(phoneNumber.ElementAt(10));
                boolArray[7] = Char.IsDigit(phoneNumber.ElementAt(11));
                boolArray[8] = Char.IsDigit(phoneNumber.ElementAt(12));
                boolArray[9] = Char.IsDigit(phoneNumber.ElementAt(13));

                if (boolArray[0] && boolArray[1] && boolArray[2] && boolArray[3] && boolArray[4]
                    && boolArray[5] && boolArray[6] && boolArray[7] && boolArray[8] && boolArray[9])
                {
                    return false;
                }
            }

            return true;
        }

        private void addFacultyMemberButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;
            string facultyPhoneNumber = phoneNumberTextBox.Text;
            bool facultyNumberIsNotValid = isNotPhoneNumber(facultyPhoneNumber);

            if (nameTextBox.Text == String.Empty)
            {
                errorLabel.Text = "Error: You must enter the faculty member's name.";
            }

            else if (facultyNumberIsNotValid)
            {
                errorLabel.Text = "Error: You did not enter a valid phone number.";
            }

            else
            {
                Faculty newFaculty = new Faculty()
                {
                    Name = nameTextBox.Text.ToLower(),
                    PhoneNumber = phoneNumberTextBox.Text.ToLower()
                };

                RegistrationEntities.Faculties.Add(newFaculty);
                RegistrationEntities.SaveChanges();

                nameTextBox.Text = String.Empty;
                phoneNumberTextBox.ResetText();

                updateListBox();
            }
        }
    }
}
