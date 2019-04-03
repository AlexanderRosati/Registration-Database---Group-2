using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RegistrationEntityModel;

namespace Section_CRUD_Form
{
	public partial class SectionCRUDForm : Form
	{
		private RegistrationEntities RegEnt;
		public SectionCRUDForm()
		{
			InitializeComponent();
			RegEnt = new RegistrationEntities();
		}

		public SectionCRUDForm(RegistrationEntities registrationEntities)
		{
			InitializeComponent();
			RegEnt = registrationEntities;

			ErrorLabel.Text = "";

			//Initialize List of Course IDs and Faculty IDs, list on side
			CourseIDDropdownBox.Items.Clear();
			FacultyIDDropdownBox.Items.Clear();
			foreach (Course c in RegEnt.Courses)
			{
				string cID = c.Id.ToString();
				string cNumber = c.Number;
				string cName = c.Name;
				CourseIDDropdownBox.Items.Add(cID);
				CourseListBox.Items.Add(cID.PadRight(10 - cID.Length)+ cNumber.PadRight(10-cNumber.Length) + cName);
			}
			foreach (Faculty f in RegEnt.Faculties)
			{
				string fID = f.Id.ToString();
				string fName = f.Name;
				FacultyIDDropdownBox.Items.Add(fID);
				FacultyListBox.Items.Add(fID.PadRight(10 - fID.Length) + fName);
			}

			UpdateSectionListBox();
		}

		private void AddSectionButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";
			
			if(HasEmptyBoxes())
			{
				ErrorLabel.Text = "Error: Missing information. Please fill out all areas before adding.";
			}
			else
			{
				Section newSection = new Section()
				{
					CourseID = Convert.ToInt32(CourseIDDropdownBox.SelectedItem),
					FacultyID = Convert.ToInt32(FacultyIDDropdownBox.SelectedItem),
					Day = SectionDayTextBox.Text,
					Time = SectionTimeTextBox.Text,
					Semester = SectionSemesterTextBox.Text
				};

				IQueryable<Section> result = RegEnt.Sections.Where(record => record.FacultyID == newSection.FacultyID &&
				record.Day == newSection.Day && record.Time == newSection.Time);
				if (result.Count() == 0)
				{
					RegEnt.Sections.Add(newSection);
					RegEnt.SaveChanges();
					string item = MakeListEntry(newSection.Id.ToString(), newSection.CourseID.ToString(),
						newSection.FacultyID.ToString(), newSection.Day, newSection.Time, newSection.Semester);
					SectionListBox.Items.Add(item);
					ClearInputs();

				}
				else
				{
					Faculty FacName = RegEnt.Faculties.Find(newSection.FacultyID);
					ErrorLabel.Text = $"Error: {FacName.Name} is already teaching on {newSection.Day} at {newSection.Time}.";
				}
			}
		}

		private void UpdateSectionButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";

			if(SectionListBox.SelectedItem != null)
			{
				if (HasEmptyBoxes())
				{
					ErrorLabel.Text = "Error: Missing information. All inputs should be filled.";
				}
				else
				{
					string selectedSection = SectionListBox.SelectedItem.ToString();
					int IDofSectionToUpated = Convert.ToInt32(selectedSection.Split(' ')[0]);
					Section sectionToUpdate = RegEnt.Sections.Find(IDofSectionToUpated);
					if(sectionToUpdate != null)
					{
						sectionToUpdate.CourseID = Convert.ToInt32(CourseIDDropdownBox.SelectedItem);
						sectionToUpdate.FacultyID = Convert.ToInt32(FacultyIDDropdownBox.SelectedItem);
						sectionToUpdate.Day = SectionDayTextBox.Text;
						sectionToUpdate.Time = SectionTimeTextBox.Text;
						sectionToUpdate.Semester = SectionSemesterTextBox.Text;

						RegEnt.SaveChanges();
						UpdateSectionListBox();
						ClearInputs();

					} else
					{
						ErrorLabel.Text = "Error: Could not find record with that ID. This shouldn't have happened.";
					}
				}
			}else
			{
				ErrorLabel.Text = "Error: No Section selected to update.";
			}
		}

		private void DeleteSectionButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";
			if(SectionListBox.SelectedItem != null)
			{
				string selectedSection = SectionListBox.SelectedItem.ToString();
				int itemID = Convert.ToInt32(selectedSection.Split(' ')[0]);

				Section temp = RegEnt.Sections.Find(itemID);

                if (temp.Enrollments.Count > 0)
                {
                    ErrorLabel.Text = "You cannot delete this record because other records are referencing it.";
                }

                else
                {
                    RegEnt.Sections.Remove(temp);
                    RegEnt.SaveChanges();
                    UpdateSectionListBox();
                }
			}
			else
			{
				ErrorLabel.Text = "Error: Please select a section to delete.";
			}
		}

		private void ClearInputsButton_Click(object sender, EventArgs e)
		{
			ClearInputs();
		}
		private void ClearInputs()
		{
			CourseIDDropdownBox.SelectedIndex = -1;
			FacultyIDDropdownBox.SelectedIndex = -1;
			SectionDayTextBox.Text = "";
			SectionTimeTextBox.Text = "";
			SectionSemesterTextBox.Text = "";
		}

		private string MakeListEntry(string id, string courseid, string facultyid, string day, string time, string sem)
		{
			return id.PadRight(8) + courseid.PadRight(8) + facultyid.PadRight(8) +
				day.PadRight(30) + time.PadRight(30) + sem;
		}
		private void UpdateSectionListBox()
		{
			SectionListBox.Items.Clear();

			foreach(Section s in RegEnt.Sections)
			{
				SectionListBox.Items.Add(MakeListEntry(s.Id.ToString(), s.CourseID.ToString(), 
					s.FacultyID.ToString(), s.Day, s.Time, s.Semester));
			}
		}
		private bool HasEmptyBoxes()
		{
			return String.IsNullOrWhiteSpace(SectionDayTextBox.Text) || String.IsNullOrWhiteSpace(SectionTimeTextBox.Text) ||
				String.IsNullOrWhiteSpace(SectionSemesterTextBox.Text) || CourseIDDropdownBox.SelectedIndex < 0 ||
				FacultyIDDropdownBox.SelectedIndex < 0;
		}

		private void SectionListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(SectionListBox.SelectedItem != null)
			{
				string selectedSection = SectionListBox.SelectedItem.ToString();
				int IDofSectionToUpated = Convert.ToInt32(selectedSection.Split(' ')[0]);
				Section sectionFromDatabase = RegEnt.Sections.Find(IDofSectionToUpated);

				CourseIDDropdownBox.SelectedIndex = CourseIDDropdownBox.Items.IndexOf(sectionFromDatabase.CourseID.ToString()); ;
				FacultyIDDropdownBox.SelectedIndex = FacultyIDDropdownBox.Items.IndexOf(sectionFromDatabase.FacultyID.ToString());
				SectionDayTextBox.Text = sectionFromDatabase.Day;
				SectionTimeTextBox.Text = sectionFromDatabase.Time;
				SectionSemesterTextBox.Text = sectionFromDatabase.Semester;
			}

		}
	}
}
