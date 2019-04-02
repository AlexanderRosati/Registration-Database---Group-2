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
        }

        public enrollmentCRUDForm(RegistrationEntities RE)
        {
            InitializeComponent();
            RegistrationEntities = RE;

        }
    }
}
