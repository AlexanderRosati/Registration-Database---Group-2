using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RegistrationEntityModel;

namespace Course_CRUD_Form
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
			ErrorLabel.Text = String.Empty;
		}

		private void AddCourseButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";
			if (String.IsNullOrWhiteSpace(CourseNameTextBox.Text) || String.IsNullOrWhiteSpace(CourseNumberTextBox.Text) ||
				String.IsNullOrWhiteSpace(CourseCreditsTextBox.Text) || String.IsNullOrWhiteSpace(CourseDepartmentTextBox.Text))
			{
				ErrorLabel.Text = "Error: Missing course name, number, credits, or department information.";

			}
			else
			{
				Course newCourse = new Course()
				{
					Name = CourseNameTextBox.Text,
					Number = CourseNumberTextBox.Text,
					Credits = Convert.ToInt16(CourseCreditsTextBox.Text),
					Department = CourseDepartmentTextBox.Text
				};

				IQueryable<Course> q = RegEnt.Courses.Where(record => record.Number == newCourse.Number);
				if (q.Count() == 0) //doesn't exist, add new course
				{
					RegEnt.Courses.Add(newCourse);
					RegEnt.SaveChanges();
					string listBoxEntry = MakeListEntry(newCourse.Id.ToString(), newCourse.Name, newCourse.Number, newCourse.Credits.ToString(), newCourse.Department);
					listBox1.Items.Add(listBoxEntry);
					ClearTextBoxes();
				}
				else //Conflict: Cannot have 2 courses with same course number
				{
					ErrorLabel.Text = $"Error: Course {newCourse.Number} already exists";
				}
			}
		}

		private void UpdateCourseButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";

			if (listBox1.SelectedItem != null)
			{
				if (String.IsNullOrWhiteSpace(CourseNameTextBox.Text) || String.IsNullOrWhiteSpace(CourseNumberTextBox.Text) ||
				String.IsNullOrWhiteSpace(CourseCreditsTextBox.Text) || String.IsNullOrWhiteSpace(CourseDepartmentTextBox.Text))
				{
					ErrorLabel.Text = "Error: Missing name, number, credits, or department information to update.";
				}
				else
				{
					string selectedCourse = listBox1.SelectedItem.ToString();
					string selectedCourseNumber = CourseNumberTextBox.Text;

					IQueryable<Course> query = RegEnt.Courses.Where(record => record.Number == selectedCourseNumber);
					bool isSameCourse = selectedCourse.Contains(selectedCourseNumber); //checks via course Number

					if (query.Count() == 0 || isSameCourse)
					{
						int IDofRecordToUpated = Convert.ToInt32(selectedCourse.Split(' ')[0]);

						Course courseToUpdate = RegEnt.Courses.Find(IDofRecordToUpated);
						courseToUpdate.Name = CourseNameTextBox.Text;
						courseToUpdate.Number = CourseNumberTextBox.Text;
						courseToUpdate.Credits = Convert.ToInt32(CourseCreditsTextBox.Text);
						courseToUpdate.Department = CourseDepartmentTextBox.Text;

						RegEnt.SaveChanges();
						UpdateCourseListBox();
						ClearTextBoxes();
					}
				}
			}
			else
			{
				ErrorLabel.Text = "Error: No course selected to update";
			}
		}

		private void DeleteCourseButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";
			if (listBox1.SelectedItem != null)
			{
				string selectedCourse = listBox1.SelectedItem.ToString();
				int itemID = Convert.ToInt32(selectedCourse.Split(' ')[0]);

				Course temp = RegEnt.Courses.Find(itemID);

				/* TODO: Check if has students enrolled? */

				RegEnt.Courses.Remove(temp);
				RegEnt.SaveChanges();
				UpdateCourseListBox();

			}
			else
			{
				ErrorLabel.Text = "Error: Please select a course to delete.";
			}
		}

		private void ClearCourseInputButton_Click(object sender, EventArgs e)
		{
			ClearTextBoxes();
		}

		private void UpdateCourseListBox()
		{
			listBox1.Items.Clear();

			//Display all major records in database
			foreach (Course course in RegEnt.Courses)
			{
				listBox1.Items.Add(MakeListEntry(course.Id.ToString(), course.Name, course.Number, course.Credits.ToString(), course.Department));
			}
		}
		private void ClearTextBoxes()
		{
			CourseNameTextBox.Text = "";
			CourseNumberTextBox.Text = "";
			CourseCreditsTextBox.Text = "";
			CourseDepartmentTextBox.Text = "";
		}
		private string MakeListEntry(string id, string name, string number, string creds, string dept)
		{
			return id.PadRight(8) + name.PadRight(50) + number.PadRight(10) + creds.PadRight(8) + dept;
		}

		//Auto-fills required input boxes with selected item's information for easier updating
		private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBox1.SelectedItem != null)
			{
				string selectedCourse = listBox1.SelectedItem.ToString();
				int IDofSelectedCourse = Convert.ToInt32(selectedCourse.Split(' ')[0]);
				Course courseFromDatabase = RegEnt.Courses.Find(IDofSelectedCourse);

				CourseNameTextBox.Text = courseFromDatabase.Name;
				CourseNumberTextBox.Text = courseFromDatabase.Number;
				CourseCreditsTextBox.Text = courseFromDatabase.Credits.ToString();
				CourseDepartmentTextBox.Text = courseFromDatabase.Department;
			}

		}

	}
}
