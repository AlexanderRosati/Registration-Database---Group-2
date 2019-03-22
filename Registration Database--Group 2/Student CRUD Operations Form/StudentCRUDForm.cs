using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistrationEntityModel;

namespace Student_CRUD_Operations_Form
{
    public partial class studentCRUDForm : Form
    {
        private RegistrationEntities RegistrationEntities;

        public studentCRUDForm()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            string listBoxEntry = null;

            foreach (Student s in RegistrationEntities.Students)
            {
                listBoxEntry = s.Id.ToString().PadRight(10) + s.Name.PadRight(54) + s.Major.Name;
                studentsListBox.Items.Add(listBoxEntry);
            }
        }

        public studentCRUDForm(RegistrationEntities RE)
        {
            InitializeComponent();
            RegistrationEntities = RE;
            errorLabel.Text = String.Empty;

            foreach (Major m in RegistrationEntities.Majors)
            {
                majorComboBox.Items.Add(m.Name);
            }

            UpdateListBox();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;

            if (studentNameTextBox.Text == String.Empty)
            {
                errorLabel.Text = "Error: You must enter the student's name.";
            }

            else if (majorComboBox.SelectedItem == null)
            {
                errorLabel.Text = "Error: You must select a major.";
            }

            else
            {
                IQueryable<Major> queryResultMajorTable = RegistrationEntities.Majors.Where(m => m.Name == (string)majorComboBox.SelectedItem);
                List<Major> newStudentsMajor = queryResultMajorTable.ToList();

                Student newStudent = new Student
                {
                    Name = studentNameTextBox.Text.ToLower(),
                    Major = newStudentsMajor.ElementAt(0)
                };

                newStudent = RegistrationEntities.Students.Add(newStudent);
                RegistrationEntities.SaveChanges();

                studentNameTextBox.Text = String.Empty;
                majorComboBox.SelectedItem = null;

                string listBoxEntry = newStudent.Id.ToString().PadRight(10) + newStudent.Name.PadRight(54)
                                    + newStudent.Major.Name;
                studentsListBox.Items.Add(listBoxEntry);
            }
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            studentsListBox.SelectedItem = null;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;

            if (studentsListBox.SelectedItem != null)
            {
                string listBoxEntry = (string)studentsListBox.SelectedItem;
                string IDOfRecordToRemoveString = listBoxEntry.Split(' ')[0];
                int IDOfRecordToRemoveInt = Convert.ToInt32(IDOfRecordToRemoveString);

                Student studentToRemove = RegistrationEntities.Students.Find(IDOfRecordToRemoveInt);

                if (studentToRemove.Enrollments.Count > 0)
                {
                    errorLabel.Text = "Error: You cannot delete this record because other records reference it.";
                }

                else
                {
                    RegistrationEntities.Students.Remove(studentToRemove);
                    RegistrationEntities.SaveChanges();
                    studentsListBox.Items.Clear();
                    UpdateListBox();
                }
            }

            else
            {
                errorLabel.Text = "Error: You have not selected a student to delete. Click a student below.";
            }
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = String.Empty;
            
            if (studentNameTextBox.Text == String.Empty)
            {
                errorLabel.Text = "Error: You did not enter the student's name.";
            }

            else if (majorComboBox.SelectedItem == null)
            {
                errorLabel.Text = "Error: You did not select a major.";
            }

            else if (studentsListBox.SelectedItem == null)
            {
                errorLabel.Text = "Error: You must select a student to modify.";
            }

            else
            { 
                string selectedItemComboBox = (string)majorComboBox.SelectedItem;
                string listBoxEntry = (string)studentsListBox.SelectedItem;
                string IDOfRecordToBeUpdatedString = listBoxEntry.Split(' ')[0];
                int IDOfRecordToBeUpdatedInt = Convert.ToInt32(IDOfRecordToBeUpdatedString);

                Student studentRecordToUpdate = RegistrationEntities.Students.Find(IDOfRecordToBeUpdatedInt);

                IEnumerable<Major> queryResult = from m in RegistrationEntities.Majors
                                                 where m.Name == selectedItemComboBox
                                                 select m;

                studentRecordToUpdate.Name = studentNameTextBox.Text.ToLower();
                studentRecordToUpdate.Major = queryResult.ElementAt(0);

                RegistrationEntities.SaveChanges();

                studentsListBox.Items.Clear();
                UpdateListBox();

                studentNameTextBox.Text = String.Empty;
                majorComboBox.SelectedItem = null;
            }
        }
    }
}