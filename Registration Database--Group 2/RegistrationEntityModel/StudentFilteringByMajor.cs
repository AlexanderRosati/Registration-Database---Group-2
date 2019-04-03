using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationEntityModel
{
    public partial class StudentFilteringByMajor : Form
    {
        RegistrationEntities registrationEntities;
        Student student;
        Major major;
        public StudentFilteringByMajor()
        {
            InitializeComponent();
            registrationEntities = new RegistrationEntities();
            registrationEntities.Students.Load();
            studentsList.DataSource = registrationEntities.Students.Local.ToBindingList();
            studentsList.DisplayMember = nameof(student.Name);
            registrationEntities.Majors.Load();
            majorsComboBox.DataSource = registrationEntities.Majors.Local.ToBindingList();
            majorsComboBox.DisplayMember = nameof(major.College);


            //updateStudentsList();
            //updateMajorsList();

            var erics = registrationEntities.Students.Where(s => s.Name.StartsWith("E")).ToList();
            erics = erics.Where(s => s.Major.College == "CECS").ToList();
            foreach (var eric in erics)
            {
                ericsClassesLabel.Text += $"{eric.Name} - {eric.Major.Name} - {eric.Major.College}{Environment.NewLine}";
            }

            // linq to ojbects without lambda extensions syntax
            /*
            var query = from Student student in RegistrationEntities.Students
                        where student.Name == "Eric"
                        select student;
           foreach( var result in query )
            {
                result.
            }
            */

            //RegistrationEntities.Students.Remove()
        }

        private void InitializeComponent()
        {
            this.majorsComboBox = new System.Windows.Forms.ComboBox();
            this.studentsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.majorsComboBox.FormattingEnabled = true;
            this.majorsComboBox.Location = new System.Drawing.Point(267, 151);
            this.majorsComboBox.Name = "comboBox1";
            this.majorsComboBox.Size = new System.Drawing.Size(121, 21);
            this.majorsComboBox.TabIndex = 0;
            this.majorsComboBox.Text = "Choose a major";
            // 
            // studentsList
            // 
            this.studentsList.FormattingEnabled = true;
            this.studentsList.Location = new System.Drawing.Point(570, 151);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(120, 95);
            this.studentsList.TabIndex = 1;
            // 
            // StudentFilteringByMajor
            // 
            this.ClientSize = new System.Drawing.Size(974, 512);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.majorsComboBox);
            this.Name = "StudentFilteringByMajor";
            this.ResumeLayout(false);

        }
    }

    }
}
