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

namespace Enrollment_CRUD_Form
{
	public partial class enrollmentCRUDForm : Form
	{
		private RegistrationEntities RegistrationEntities;

		public enrollmentCRUDForm()
		{
			InitializeComponent();
			RegistrationEntities = new RegistrationEntities();
		}

		public enrollmentCRUDForm(RegistrationEntities RE)
		{
			InitializeComponent();
			RegistrationEntities = RE;

			sectionComboBox.Items.Clear();
			studentComboBox.Items.Clear();
			gradeComboBox.Items.Clear();

			foreach (Section sec in RegistrationEntities.Sections)
			{
				sectionComboBox.Items.Add(sec.Id);
			}
			foreach (Student stu in RegistrationEntities.Students)
			{
				studentComboBox.Items.Add(stu.Id);
			}

			gradeComboBox.SelectedIndex = -1;
			string[] grades = new string[] { "A", "A-", "B", "B-", "C", "C-", "D", "D-", "F", "I" };
			gradeComboBox.DataSource = grades;

			UpdateEnrollmentListBox();
		}

		private void addEnrollmentButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";
			if (MissingInfo())
			{
				ErrorLabel.Text = "Missing selection. Please fill out Section, Student, and Grade options.";
			}
			else
			{
				Enrollment newEnrollment = new Enrollment()
				{
					SectionID = (int)sectionComboBox.SelectedItem,
					StudentID = (int)studentComboBox.SelectedItem,
					Grade = gradeComboBox.SelectedItem.ToString()
				};

				IQueryable<Enrollment> result = RegistrationEntities.Enrollments.Where(en => en.SectionID == newEnrollment.SectionID &&
					en.StudentID == newEnrollment.StudentID);

				if (result.Count() == 0)
				{
					RegistrationEntities.Enrollments.Add(newEnrollment);
					RegistrationEntities.SaveChanges();
					EnrollmentListBox.Items.Add(MakeListboxEntry(newEnrollment.Id.ToString(), newEnrollment.SectionID.ToString(),
						newEnrollment.StudentID.ToString(), newEnrollment.Grade));
					ClearInputs();

				}
				else
				{
					Student temps = RegistrationEntities.Students.Find(newEnrollment.StudentID);
					ErrorLabel.Text = $"{temps.Name} is already enrolled in section {newEnrollment.SectionID}.";
				}

			}
		}

		private void updateEnrollmentButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";

			if(EnrollmentListBox.SelectedItem != null)
			{
				if (MissingInfo())
				{
					ErrorLabel.Text = "Error: Missing information to update. All inputs should be filled.";
				} else
				{
					string selected = EnrollmentListBox.SelectedItem.ToString();
					int itemID = Convert.ToInt32(selected.Split(' ')[0]);
					Enrollment enToUpdate = RegistrationEntities.Enrollments.Find(itemID);

					IQueryable<Enrollment> result = RegistrationEntities.Enrollments.Where(en => en.SectionID == enToUpdate.SectionID &&
						en.StudentID == enToUpdate.StudentID);

					if (result.Count() == 0)
					{
						enToUpdate.SectionID = (int)sectionComboBox.SelectedItem;
						enToUpdate.StudentID = (int) studentComboBox.SelectedItem;
						enToUpdate.Grade = gradeComboBox.SelectedItem.ToString();

						RegistrationEntities.SaveChanges();
						UpdateEnrollmentListBox();
						ClearInputs();
					}
					else
					{
						Student temps = RegistrationEntities.Students.Find(enToUpdate.StudentID);
						ErrorLabel.Text = $"{temps.Name} is already enrolled in section {enToUpdate.SectionID}.";
					}
				}
			} else
			{
				ErrorLabel.Text = "Error: No enrollment selected to update";
			}

		}

		private void deleteEnrollmentButton_Click(object sender, EventArgs e)
		{
			ErrorLabel.Text = "";

			if (EnrollmentListBox.SelectedItem != null)
			{
				string selected = EnrollmentListBox.SelectedItem.ToString();
				int itemID = Convert.ToInt32(selected.Split(' ')[0]);
				Enrollment temp = RegistrationEntities.Enrollments.Find(itemID);

				RegistrationEntities.Enrollments.Remove(temp);
				RegistrationEntities.SaveChanges();
				UpdateEnrollmentListBox();
			}
			else
			{
				ErrorLabel.Text = "Error: Please select an enrollment to delete.";
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			ClearInputs();
		}

		private void ClearInputs()
		{
			sectionComboBox.SelectedIndex = -1;
			studentComboBox.SelectedIndex = -1;
			gradeComboBox.SelectedIndex = -1;

		}

		private bool MissingInfo()
		{
			return sectionComboBox.SelectedIndex < 0 || studentComboBox.SelectedIndex < 0 || gradeComboBox.SelectedIndex < 0;
		}

		private void UpdateEnrollmentListBox()
		{
			EnrollmentListBox.Items.Clear();
			foreach (Enrollment en in RegistrationEntities.Enrollments)
			{
				EnrollmentListBox.Items.Add(MakeListboxEntry(en.Id.ToString(), en.SectionID.ToString(), en.StudentID.ToString(), en.Grade));
			}
		}

		private string MakeListboxEntry(string id, string section, string student, string grade)
		{
			return id.PadRight(10) + section.PadRight(50) + student.PadRight(50) + grade;
		}

		private void EnrollmentListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(EnrollmentListBox.SelectedItem != null){
				string selected = EnrollmentListBox.SelectedItem.ToString();
				int itemID = Convert.ToInt32(selected.Split(' ')[0]);
				Enrollment enFromDB = RegistrationEntities.Enrollments.Find(itemID);

				sectionComboBox.SelectedIndex = sectionComboBox.Items.IndexOf(enFromDB.SectionID);
				studentComboBox.SelectedIndex = studentComboBox.Items.IndexOf(enFromDB.StudentID);
				gradeComboBox.SelectedIndex = gradeComboBox.Items.IndexOf(enFromDB.Grade);
			}
		}
	}	
}
