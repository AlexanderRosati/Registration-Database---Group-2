using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RegistrationEntityModel;

namespace Course_CRUD_Operations_Form
{
	public partial class CourseCRUDForm : Form
	{
		/* Initializeation functions */
		private RegistrationEntities RegEnt;
		public CourseCRUDForm()
		{
			InitializeComponent();
			RegEnt = new RegistrationEntities();
		}

		public CourseCRUDForm(RegistrationEntities RE)
		{
			InitializeComponent();

			RegEnt = RE;
			UpdateCourseListBox();
			courseErrorLabel.Text = "";
		}

		/* CRUD operation functions */
		private void addCourseButton_Click(object sender, EventArgs e)
		{
			courseErrorLabel.Text = "";
			if (String.IsNullOrWhiteSpace(courseNameTextBox.Text) || String.IsNullOrWhiteSpace(courseNumTextBox.Text) ||
				String.IsNullOrWhiteSpace(courseCreditsTextBox.Text) || String.IsNullOrWhiteSpace(courseDepartmentTextBox.Text))
			{
				courseErrorLabel.Text = "Error: Missing course name, number, credits, or department information.";

			} else
			{
				Course newCourse = new Course()
				{
					Name = courseNameTextBox.Text,
					Number = courseNumTextBox.Text,
					Credits = Convert.ToInt16(courseCreditsTextBox.Text),
					Department = courseDepartmentTextBox.Text
				};

				IQueryable<Course> q = RegEnt.Courses.Where(record => record.Number == newCourse.Number);
				if(q.Count() == 0) //doesn't exist, add new course
				{
					RegEnt.Courses.Add(newCourse);
					RegEnt.SaveChanges();
					string listBoxEntry = MakeListEntry(newCourse.Id.ToString(), newCourse.Name, newCourse.Number, newCourse.Credits.ToString(), newCourse.Department);
					courseListBox.Items.Add(listBoxEntry);

					ClearTextBoxes();
				} else //Conflict: Cannot have 2 courses with same course number
				{
					courseErrorLabel.Text = $"Error: Course {newCourse.Number} already exists";
				}
			}
						
		}

		private void deleteCourseButton_Click(object sender, EventArgs e)
		{
			courseErrorLabel.Text = "";
			if(courseListBox.SelectedItem != null)
			{
				string selectedCourse = courseListBox.SelectedItem.ToString();
				int itemID = Convert.ToInt32(selectedCourse.Split(' ')[0]);

				Course temp = RegEnt.Courses.Find(itemID);

				/* TODO: Check if has students enrolled */

				RegEnt.Courses.Remove(temp);

				RegEnt.SaveChanges();
				courseListBox.Items.Clear();
				UpdateCourseListBox();
								
			} else
			{
				courseErrorLabel.Text = "Please select a course to delete from the list";
			}
		}

		private void updateCourseButton_Click(object sender, EventArgs e)
		{
			courseErrorLabel.Text = "";

			if (courseListBox.SelectedItem != null)
			{
				if (String.IsNullOrWhiteSpace(courseUpdateNameTextBox.Text) || String.IsNullOrWhiteSpace(courseUpdateNumberTextBox.Text) ||
				String.IsNullOrWhiteSpace(courseUpdateCreditsTextBox.Text) || String.IsNullOrWhiteSpace(courseUpdateDepartmentTextBox.Text))
				{
					courseErrorLabel.Text = "Error: Missing name, number, credits, or department information to update.";
				}
				else
				{
					// TODO: Check if database contains item id from list, change record
					string selectedCourse = courseListBox.SelectedItem.ToString();
					string selectedCourseNumber = courseUpdateNumberTextBox.Text;

					IQueryable<Course> query = RegEnt.Courses.Where(record => record.Number == selectedCourseNumber);
					bool isSameCourse = selectedCourse.Contains(selectedCourseNumber); //checks via course Number

					if (query.Count() == 0 || isSameCourse)
					{
						int IDofRecordToUpated = Convert.ToInt32(selectedCourse.Split(' ')[0]);

						Course courseToUpdate = RegEnt.Courses.Find(IDofRecordToUpated);
						courseToUpdate.Name = courseUpdateNameTextBox.Text;
						courseToUpdate.Number = courseUpdateNumberTextBox.Text;
						courseToUpdate.Credits = Convert.ToInt32(courseUpdateCreditsTextBox.Text);
						courseToUpdate.Department = courseUpdateDepartmentTextBox.Text;

						RegEnt.SaveChanges();
						courseListBox.Items.Clear();
						UpdateCourseListBox();
						ClearUpdateTextBoxes();
					}
				}
			} else
			{
				courseErrorLabel.Text = "Error: No course selected to update";
			}
		}


		/* Miscellaneous QOL Fuctions */
		private void UpdateCourseListBox()
		{
			string listBoxEntry = null;

			//Display all major records in database
			foreach (Course course in RegEnt.Courses)
			{
				listBoxEntry = MakeListEntry(course.Id.ToString(),	course.Name, course.Number, course.Credits.ToString(), course.Department);
				courseListBox.Items.Add(listBoxEntry);
			}
		}

		private void ClearTextBoxes()
		{
			courseNameTextBox.Text = "";
			courseNumTextBox.Text = "";
			courseCreditsTextBox.Text = "";
			courseDepartmentTextBox.Text = "";
		}
		private void ClearUpdateTextBoxes()
		{
			courseUpdateNameTextBox.Text = "";
			courseUpdateNumberTextBox.Text = "";
			courseUpdateCreditsTextBox.Text = "";
			courseUpdateDepartmentTextBox.Text = "";
		}
		private string MakeListEntry(string id, string name, string number, string creds, string dept)
		{
			return id.PadRight(10-id.Length) + name.PadRight(75-name.Length) + number.PadRight(20-number.Length) + creds.PadRight(10-creds.Length) + dept.PadRight(20-dept.Length);
		}

		private void CourseClearButton_Click(object sender, EventArgs e)
		{
			ClearTextBoxes();
		}
		private void UpdateCourseClearButton_Click(object sender, EventArgs e)
		{
			ClearUpdateTextBoxes();
		}
	}
}
