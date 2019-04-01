using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			//CourseIDDropdownBox.SelectedIndex = 0;
		}

		public SectionCRUDForm(RegistrationEntities registrationEntities)
		{
			InitializeComponent();
			RegEnt = registrationEntities;
			
			//Initialize List of Course ID
			foreach (Course c in RegEnt.Courses)
			{
				CourseIDDropdownBox.Items.Add(c.Id.ToString());
			}
		}
	}
}
