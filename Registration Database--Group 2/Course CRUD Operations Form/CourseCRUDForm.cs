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
		RegistrationEntities RegEnt;
		public CourseCRUDForm()
		{
			InitializeComponent();

			RegEnt = new RegistrationEntities();
		}
	}
}
