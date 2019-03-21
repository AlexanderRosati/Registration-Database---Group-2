using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistrationEntityModel;


namespace Major_CRUD_Operations_Form
{
    public partial class majorCRUDForm : Form
    {
        private RegistrationEntities RegistrationEntities;

        public majorCRUDForm()
        {
            InitializeComponent();
        }

        //Give new form access to RegistrationEntities Objects
        public majorCRUDForm(RegistrationEntities RE)
        {
            InitializeComponent();

            RegistrationEntities = RE;
            errorLabel.Text = String.Empty;
            updateMajorsListBox();
        }

        private void updateMajorsListBox()
        {
            string listBoxEntry = null;

            //Display all major records in database
            foreach (Major major in RegistrationEntities.Majors)
            {
                listBoxEntry = major.Id.ToString().PadRight(10)
                                      + major.Name.PadRight(50)
                                      + major.College.PadRight(50);

                majorsListBox.Items.Add(listBoxEntry);
            }
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
                //ID will start at 1 and increment by one each time
                //Remove uppercase letters so we can find duplicate records
                Major newMajor = new Major() { Name = majorNameTextBot.Text.ToLower(),
                                               College = collegeTextBox.Text.ToLower() };

                IQueryable<Major> queryResult = RegistrationEntities.Majors.Where(m => m.Name == newMajor.Name);
                
                if (queryResult.Count() == 0)
                { 

                    //newMajor now points to the newly added record
                    newMajor = RegistrationEntities.Majors.Add(newMajor);
                    RegistrationEntities.SaveChanges();

                    //Create string to add to list box
                    string listBoxEntry = newMajor.Id.ToString().PadRight(10)
                                        + newMajor.Name.PadRight(50)
                                        + newMajor.College.PadRight(50);

                    majorsListBox.Items.Add(listBoxEntry);
                


                    majorNameTextBot.Text = String.Empty;
                    collegeTextBox.Text = String.Empty;
                }
                
                else
                {
                    errorLabel.Text = "Error: This major is already in the database. You cannot add it again.";
                }
            }
        }

        private void removeMajorButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;

            string listBoxEntry = (string)majorsListBox.SelectedItem;
            string IDOfRecordToRemoveString = listBoxEntry.Split(' ')[0];
            int IDOfRecordToRemoveInt = Convert.ToInt32(IDOfRecordToRemoveString);

            Major majorToRemove = RegistrationEntities.Majors.Find(IDOfRecordToRemoveInt);

            IQueryable<Student> queryResult = RegistrationEntities.Students.Where(s => s.Major.Id == majorToRemove.Id);
            

            if (queryResult.Count() == 0)
            { 
                if (majorsListBox.SelectedItem != null)
                { 
                    RegistrationEntities.Majors.Remove(majorToRemove);
                    RegistrationEntities.SaveChanges();
                    majorsListBox.Items.Clear();
                    updateMajorsListBox();
                }

                else
                {
                    errorLabel.Text = "Error: You need to select the major to remove by clicking it below.";
                }
            }

            else
            {
                errorLabel.Text = "You cannot delete this record because other records reference it.";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;

            if (updateMajorTextBox.Text == String.Empty || updateCollegeTextBox.Text == String.Empty)
            {
                errorLabel.Text = "Error: You didn't fill in either the major name or college.";
            }

            else if (majorsListBox.SelectedItem == null)
            {
                errorLabel.Text = "Error: You didn't select a major to update.";
            }

            else
            {
                IQueryable <Major> queryResult = RegistrationEntities.Majors.Where(m => m.Name == updateMajorTextBox.Text.ToLower());
                string listBoxEntry = (string)majorsListBox.SelectedItem;

                //See if the entered major is the same as the major of the selected record
                bool majorIsSame = listBoxEntry.Contains(updateMajorTextBox.Text.ToLower());

                if (queryResult.Count() == 0 ||  majorIsSame)
                { 
                    string IDOfRecordToUpdateString = listBoxEntry.Split(' ')[0];
                    int IDOfRecordToUpdateInt = Convert.ToInt32(IDOfRecordToUpdateString);

                    Major majorToUpdate = RegistrationEntities.Majors.Find(IDOfRecordToUpdateInt);
                    majorToUpdate.Name = updateMajorTextBox.Text.ToLower();
                    majorToUpdate.College = updateCollegeTextBox.Text.ToLower();
                    RegistrationEntities.SaveChanges();

                    majorsListBox.Items.Clear();
                    updateMajorsListBox();

                    updateMajorTextBox.Text = String.Empty;
                    updateCollegeTextBox.Text = String.Empty;
                }

                else
                {
                    errorLabel.Text = $"Error: The major '{updateMajorTextBox.Text}' is already in the database.";
                }
            }
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            majorsListBox.ClearSelected();
        }
    }
}