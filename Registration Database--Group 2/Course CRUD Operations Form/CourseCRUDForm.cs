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
			updateCourseListBox();
			courseErrorLabel = "";
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
					string listBoxEntry = $"{newCourse.Id.ToString()}	{newCourse.Name}	{newCourse.Number}	{newCourse.Credits.ToString()}	{newCourse.Department}";
					courseListBox.Items.Add(listBoxEntry);

					clearTextBoxes();
				} else
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
				string listBoxEntry = courseListBox.SelectedItem.ToString();
				//string listBoxEntryID = cellstr(get(handles.courseListBox, 'String'));
				int itemID = Convert.ToInt32(listBoxEntry.Split(' ')[0]);

				Course temp = RegEnt.Courses.Find(itemID);

				/* TODO: Check if has students enrolled */

				RegEnt.Courses.Remove(temp);
				RegEnt.SaveChanges();
				courseListBox.Items.Clear(); //Thought loop may be faster/more efficient but it's most complex to code
				updateCourseListBox();
								
			} else
			{
				courseErrorLabel.Text = "Please select a course to delete from the list";
			}
		}

		private void updateCourseButton_Click(object sender, EventArgs e)
		{
			courseErrorLabel.Text = "";

			if (String.IsNullOrWhiteSpace(courseUpdateNameTextBox.Text) || String.IsNullOrWhiteSpace(courseUpdateNumberTextBox.Text) ||
				String.IsNullOrWhiteSpace(courseUpdateCreditsTextBox.Text) || String.IsNullOrWhiteSpace(courseUpdateDepartmentTextBox.Text))
			{
				courseErrorLabel.Text = "Error: Did not put any name, number, credits, or department information to update.";
			}
			else if (courseListBox.SelectedItem != null)
			{
				courseErrorLabel.Text = "Error: No course selected to update";
			}
			else
			{
				// TODO: Check if database contains item id from list, change record
			}
			
		}


		/* Miscellaneous QOL Fuctions */
		private void updateCourseListBox()
		{
			string listBoxEntry = null;

			//Display all major records in database
			foreach (Course course in RegEnt.Courses)
			{
				listBoxEntry = $"{course.Id.ToString()}	{course.Name}	{course.Number}	{course.Credits.ToString()}	{course.Department}";
				courseListBox.Items.Add(listBoxEntry);
			}
		}

		private void clearTextBoxes()
		{
			courseNameTextBox.Text = "";
			courseNumTextBox.Text = "";
			courseCreditsTextBox.Text = "";
			courseDepartmentTextBox.Text = "";
		}
		private void clearUpdateTextBoxes()
		{
			courseUpdateNameTextBox.Text = "";
			courseUpdateNumberTextBox.Text = "";
			courseUpdateCreditsTextBox.Text = "";
			courseUpdateDepartmentTextBox.Text = "";
		}

		private void courseClearButton_Click(object sender, EventArgs e)
		{
			clearTextBoxes();
		}

		private void updateCourseClearButton_Click(object sender, EventArgs e)
		{
			clearUpdateTextBoxes();
		}

	}
}
