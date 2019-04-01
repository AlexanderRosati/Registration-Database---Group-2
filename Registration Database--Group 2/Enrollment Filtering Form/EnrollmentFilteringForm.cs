using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrationEntityModel;

namespace Enrollment_Filtering_Form
{
    public partial class EnrollmentFilteringForm : Form
    {

        //Registration entities reference
        RegistrationEntities RegistrationEntities;

        //The filtered results listview columns
        List<Tuple<string, int>> resultsColumns;

        //The filtered results
        List<Enrollment> results;

        //The name filter
        string searchFilter;

        //Constructors
        public EnrollmentFilteringForm()
        {
            InitializeComponent();
        }

        public EnrollmentFilteringForm(RegistrationEntities RE)
        {
            InitializeComponent();
            RegistrationEntities = RE;
        }

        //Initialization
        private void EnrollmentFilteringForm_Load(object sender, EventArgs e)
        {

            //Initialize collumns
            resultsColumns = new List<Tuple<string, int>>() {
                new Tuple<string, int>("Id", 100),
                new Tuple<string, int>("Section ID", 200),
                new Tuple<string, int>("Student ID", 250),
                new Tuple<string, int>("Grade", 200)
            };

            //Initialize results list
            results = new List<Enrollment>();

            //Initialize search filter
            searchFilter = "";

            //Retrieve initial query
            RetrieveItems();

            //Populate list view with query results
            PopulateListview();
        }

        //Updates the results list with the enrollments pertaining to the current query
        private void RetrieveItems()
        {

            //Clear results
            results.Clear();

            //For each enrollment
            foreach (Enrollment result in RegistrationEntities.Enrollments.ToList())
            {

                //If the search filter is found in the current result
                if (result.Student.Name.Contains(searchFilter))
                {

                    //Add the result to the list
                    results.Add(result);
                }
            }
        }

        private void PopulateListview()
        {

            //Clear existing contents
            filteredResultsListView.Clear();

            //For each column
            foreach (Tuple<string, int> column in resultsColumns)
            {

                //Add the column to the listview
                filteredResultsListView.Columns.Add(column.Item1, column.Item2);
            }

            //For each item
            foreach (Enrollment enrollment in results)
            {

                //Format item information
                string studentInfo = $"{enrollment.StudentID.ToString()} ({enrollment.Student.Name})";

                string[] itemData = new string[4] { enrollment.Id.ToString(), enrollment.SectionID.ToString(), studentInfo, enrollment.Grade };
                
                //Create a new listview item for the component
                ListViewItem newItem = new ListViewItem(itemData);

                //Add a new item to the listview
                filteredResultsListView.Items.Add(newItem);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

            //Get the new search filter
            searchFilter = studentNameTextBox.Text;

            //Update results
            RetrieveItems();
            PopulateListview();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            //Reset the search filter
            searchFilter = "";

            //Update results
            RetrieveItems();
            PopulateListview();
        }
    }
}
