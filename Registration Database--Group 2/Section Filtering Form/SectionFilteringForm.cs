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

namespace Section_Filtering_Form
{
    public partial class SectionFilteringForm : Form
    {

        //The types of school semesters
        enum SEMESTER_TYPE
        {
            FALL = 0,
            WINTER = 1,
            SUMMER = 2
        };

        //The data correlating to each semester
        struct SemesterData
        {

            //The numbered year
            public int Year;

            //The semester type
            public SEMESTER_TYPE Type;
        };

        //Registration entities reference
        private RegistrationEntities RegistrationEntities;

        //The filtered results listview columns
        List<Tuple<string, int>> resultsColumns;

        //The filtered results
        List<Section> results;

        //The currently selected semester
        SemesterData selectedSemester;

        //Constructors
        public SectionFilteringForm()
        {

            InitializeComponent();
        }

        public SectionFilteringForm(RegistrationEntities RE)
        {
            InitializeComponent();
            RegistrationEntities = RE;
        }
        
        //Initialization
        private void SectionFilteringForm_Load(object sender, EventArgs e)
        {

            //Initialize listview
            filteredResultsListView.FullRowSelect = true;

            //Initialize combo box
            semesterComboBox.Items.Add("Fall");
            semesterComboBox.Items.Add("Winter");
            semesterComboBox.Items.Add("Summer");
            semesterComboBox.SelectedIndex = 0;

            //Hide error text
            errorLabel.Visible = false;

            //Initialize collumns
            resultsColumns = new List<Tuple<string, int>>() {
                new Tuple<string, int>("Id", 50),
                new Tuple<string, int>("Course ID", 150),
                new Tuple<string, int>("Faculty ID", 150),
                new Tuple<string, int>("Day", 100),
                new Tuple<string, int>("Time", 100),
                new Tuple<string, int>("Semester", 200)
            };

            //Initialize results list
            results = new List<Section>();

            //Select the current semester
            selectedSemester = new SemesterData() { Year = -1, Type = SEMESTER_TYPE.FALL };

            //Retrieve initial query
            RetrieveItems();

            //Populate list view with query results
            PopulateListview();
        }

        //Updates the results list with the sections pertaining to the current query
        private void RetrieveItems()
        {

            //Clear existing results
            results.Clear();

            //If a selection filter is active
            if (selectedSemester.Year != -1)
            {

                //For each section
                foreach (Section result in RegistrationEntities.Sections.ToList())
                {

                    //Attempt to parse the semester string
                    SemesterData semester = ReadSemester(result.Semester);

                    //If format is valid
                    if (semester.Year != -1)
                    {

                        //If filtering condition passed
                        if (FilterSemester(semester))
                        {

                            //Add to list
                            results.Add(result);
                        }
                    }
                }
            } else
            {

                //No filter active
                results = RegistrationEntities.Sections.ToList();
            }
        }

        //Converts the given semester string into a semester data struct
        //Assumed form: <type>, <year>
        //This may need to be changed upon integration
        private SemesterData ReadSemester(string semesterString)
        {

            //The result
            SemesterData data = new SemesterData();

            //Initialize result with sentinel values
            data.Year = -1;
            data.Type = SEMESTER_TYPE.FALL;

            //Parse given string
            string[] splitResults = semesterString.Split(',');

            //Verify split length
            if (splitResults.Length != 2)
            {

                //Return error data
                return data;
            }

            //Get trimmed values
            string typeString = splitResults[0].Trim();
            string yearString = splitResults[1].Trim();

            //Convert type
            switch(typeString.ToUpper())
            {
                case "FALL":

                    data.Type = SEMESTER_TYPE.FALL;
                    break;

                case "WINTER":

                    data.Type = SEMESTER_TYPE.WINTER;
                    break;
                case "SUMMER":

                    data.Type = SEMESTER_TYPE.SUMMER;
                    break;
                default:

                    //Return error data
                    return data;
            }

            //Convert year
            try
            {

                data.Year = Convert.ToInt32(yearString);
            } catch (Exception e)
            {

                //Return error data
                return data;
            }

            //Return the properly formatted semester data
            return data;
        }

        //Returns whether a given semester is included in the current selection
        private bool FilterSemester(SemesterData semester)
        {

            bool equal = (semester.Year == selectedSemester.Year) && (semester.Type == selectedSemester.Type);
            return equal;
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
            foreach (Section section in results)
            {

                //Format item information
                string courseInfo = $"{section.CourseID} ({section.Course.Name})";
                string facultyInfo = $"{section.FacultyID.ToString()} ({section.Faculty.Name})";

                string[] itemData = new string[6] {section.Id.ToString(), courseInfo, facultyInfo, section.Day, section.Time, section.Semester };

                //Create a new listview item for the component
                ListViewItem newItem = new ListViewItem(itemData);

                //Add a new item to the listview
                filteredResultsListView.Items.Add(newItem);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

            //Reset error text
            errorLabel.Visible = false;
            errorLabel.Text = "";

            //The new selected semester
            SemesterData newSelectedSemester;

            //Get semester type
            newSelectedSemester.Type = (SEMESTER_TYPE)semesterComboBox.SelectedIndex;

            try
            {

                //Get year
                newSelectedSemester.Year = Convert.ToInt32(yearTextBox.Text);

                //Set selected semester
                selectedSemester = newSelectedSemester;

                //If the given year is positive
                if (newSelectedSemester.Year > 0)
                {

                    //Update results
                    RetrieveItems();
                    PopulateListview();
                } else
                {

                    //Set error text
                    errorLabel.Text = "Must enter a positive year.";
                    errorLabel.Visible = true;
                }

            } catch (Exception exception)
            {

                //Set error text
                errorLabel.Text = "Must enter a numeric year.";
                errorLabel.Visible = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            //Reset error text
            errorLabel.Visible = false;
            errorLabel.Text = "";

            //Disable selection
            selectedSemester.Year = -1;
            selectedSemester.Type = SEMESTER_TYPE.FALL;

            //Update results
            RetrieveItems();
            PopulateListview();
        }
    }
}
