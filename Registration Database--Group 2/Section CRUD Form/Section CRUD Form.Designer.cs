namespace Section_CRUD_Form
{
	partial class SectionCRUDForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.CourseIDDropdownBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.registrationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.FacultyIDDropdownBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SectionDayTextBox = new System.Windows.Forms.TextBox();
			this.SectionTimeTextBox = new System.Windows.Forms.TextBox();
			this.SectionSemesterTextBox = new System.Windows.Forms.TextBox();
			this.Day = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.AddSectionButton = new System.Windows.Forms.Button();
			this.UpdateSectionButton = new System.Windows.Forms.Button();
			this.DeleteSectionButton = new System.Windows.Forms.Button();
			this.ClearInputsButton = new System.Windows.Forms.Button();
			this.SectionListBox = new System.Windows.Forms.ListBox();
			this.ErrorLabel = new System.Windows.Forms.Label();
			this.CourseListBox = new System.Windows.Forms.ListBox();
			this.FacultyListBox = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// CourseIDDropdownBox
			// 
			this.CourseIDDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CourseIDDropdownBox.FormattingEnabled = true;
			this.CourseIDDropdownBox.Location = new System.Drawing.Point(103, 42);
			this.CourseIDDropdownBox.Name = "CourseIDDropdownBox";
			this.CourseIDDropdownBox.Size = new System.Drawing.Size(173, 21);
			this.CourseIDDropdownBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "CourseID";
			// 
			// FacultyIDDropdownBox
			// 
			this.FacultyIDDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FacultyIDDropdownBox.FormattingEnabled = true;
			this.FacultyIDDropdownBox.Location = new System.Drawing.Point(103, 69);
			this.FacultyIDDropdownBox.Name = "FacultyIDDropdownBox";
			this.FacultyIDDropdownBox.Size = new System.Drawing.Size(173, 21);
			this.FacultyIDDropdownBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "FacultyID";
			// 
			// SectionDayTextBox
			// 
			this.SectionDayTextBox.Location = new System.Drawing.Point(103, 96);
			this.SectionDayTextBox.Name = "SectionDayTextBox";
			this.SectionDayTextBox.Size = new System.Drawing.Size(173, 20);
			this.SectionDayTextBox.TabIndex = 4;
			// 
			// SectionTimeTextBox
			// 
			this.SectionTimeTextBox.Location = new System.Drawing.Point(103, 122);
			this.SectionTimeTextBox.Name = "SectionTimeTextBox";
			this.SectionTimeTextBox.Size = new System.Drawing.Size(173, 20);
			this.SectionTimeTextBox.TabIndex = 5;
			// 
			// SectionSemesterTextBox
			// 
			this.SectionSemesterTextBox.Location = new System.Drawing.Point(103, 148);
			this.SectionSemesterTextBox.Name = "SectionSemesterTextBox";
			this.SectionSemesterTextBox.Size = new System.Drawing.Size(173, 20);
			this.SectionSemesterTextBox.TabIndex = 6;
			// 
			// Day
			// 
			this.Day.AutoSize = true;
			this.Day.Location = new System.Drawing.Point(30, 99);
			this.Day.Name = "Day";
			this.Day.Size = new System.Drawing.Size(26, 13);
			this.Day.TabIndex = 7;
			this.Day.Text = "Day";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Time";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Semester";
			// 
			// AddSectionButton
			// 
			this.AddSectionButton.Location = new System.Drawing.Point(305, 54);
			this.AddSectionButton.Name = "AddSectionButton";
			this.AddSectionButton.Size = new System.Drawing.Size(96, 26);
			this.AddSectionButton.TabIndex = 10;
			this.AddSectionButton.Text = "Add";
			this.AddSectionButton.UseVisualStyleBackColor = true;
			this.AddSectionButton.Click += new System.EventHandler(this.AddSectionButton_Click);
			// 
			// UpdateSectionButton
			// 
			this.UpdateSectionButton.Location = new System.Drawing.Point(305, 86);
			this.UpdateSectionButton.Name = "UpdateSectionButton";
			this.UpdateSectionButton.Size = new System.Drawing.Size(96, 26);
			this.UpdateSectionButton.TabIndex = 11;
			this.UpdateSectionButton.Text = "Update";
			this.UpdateSectionButton.UseVisualStyleBackColor = true;
			this.UpdateSectionButton.Click += new System.EventHandler(this.UpdateSectionButton_Click);
			// 
			// DeleteSectionButton
			// 
			this.DeleteSectionButton.Location = new System.Drawing.Point(612, 208);
			this.DeleteSectionButton.Name = "DeleteSectionButton";
			this.DeleteSectionButton.Size = new System.Drawing.Size(96, 26);
			this.DeleteSectionButton.TabIndex = 12;
			this.DeleteSectionButton.Text = "Delete";
			this.DeleteSectionButton.UseVisualStyleBackColor = true;
			this.DeleteSectionButton.Click += new System.EventHandler(this.DeleteSectionButton_Click);
			// 
			// ClearInputsButton
			// 
			this.ClearInputsButton.Location = new System.Drawing.Point(305, 118);
			this.ClearInputsButton.Name = "ClearInputsButton";
			this.ClearInputsButton.Size = new System.Drawing.Size(96, 26);
			this.ClearInputsButton.TabIndex = 13;
			this.ClearInputsButton.Text = "Clear";
			this.ClearInputsButton.UseVisualStyleBackColor = true;
			this.ClearInputsButton.Click += new System.EventHandler(this.ClearInputsButton_Click);
			// 
			// SectionListBox
			// 
			this.SectionListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SectionListBox.FormattingEnabled = true;
			this.SectionListBox.ItemHeight = 14;
			this.SectionListBox.Location = new System.Drawing.Point(28, 239);
			this.SectionListBox.Name = "SectionListBox";
			this.SectionListBox.Size = new System.Drawing.Size(680, 186);
			this.SectionListBox.TabIndex = 14;
			this.SectionListBox.SelectedIndexChanged += new System.EventHandler(this.SectionListBox_SelectedIndexChanged);
			// 
			// ErrorLabel
			// 
			this.ErrorLabel.AutoSize = true;
			this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.ErrorLabel.Location = new System.Drawing.Point(31, 175);
			this.ErrorLabel.Name = "ErrorLabel";
			this.ErrorLabel.Size = new System.Drawing.Size(29, 13);
			this.ErrorLabel.TabIndex = 15;
			this.ErrorLabel.Text = "Error";
			// 
			// CourseListBox
			// 
			this.CourseListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CourseListBox.FormattingEnabled = true;
			this.CourseListBox.ItemHeight = 15;
			this.CourseListBox.Location = new System.Drawing.Point(443, 29);
			this.CourseListBox.Name = "CourseListBox";
			this.CourseListBox.Size = new System.Drawing.Size(265, 64);
			this.CourseListBox.TabIndex = 16;
			// 
			// FacultyListBox
			// 
			this.FacultyListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FacultyListBox.FormattingEnabled = true;
			this.FacultyListBox.ItemHeight = 15;
			this.FacultyListBox.Location = new System.Drawing.Point(443, 119);
			this.FacultyListBox.Name = "FacultyListBox";
			this.FacultyListBox.Size = new System.Drawing.Size(265, 64);
			this.FacultyListBox.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label5.Location = new System.Drawing.Point(440, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 18;
			this.label5.Text = "Courses";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label6.Location = new System.Drawing.Point(440, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 15);
			this.label6.TabIndex = 19;
			this.label6.Text = "Faculty";
			// 
			// SectionCRUDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.FacultyListBox);
			this.Controls.Add(this.CourseListBox);
			this.Controls.Add(this.ErrorLabel);
			this.Controls.Add(this.SectionListBox);
			this.Controls.Add(this.ClearInputsButton);
			this.Controls.Add(this.DeleteSectionButton);
			this.Controls.Add(this.UpdateSectionButton);
			this.Controls.Add(this.AddSectionButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Day);
			this.Controls.Add(this.SectionSemesterTextBox);
			this.Controls.Add(this.SectionTimeTextBox);
			this.Controls.Add(this.SectionDayTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.FacultyIDDropdownBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CourseIDDropdownBox);
			this.Name = "SectionCRUDForm";
			this.Text = "Section";
			((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox CourseIDDropdownBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource registrationDataSetBindingSource;
		private System.Windows.Forms.ComboBox FacultyIDDropdownBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SectionDayTextBox;
		private System.Windows.Forms.TextBox SectionTimeTextBox;
		private System.Windows.Forms.TextBox SectionSemesterTextBox;
		private System.Windows.Forms.Label Day;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button AddSectionButton;
		private System.Windows.Forms.Button UpdateSectionButton;
		private System.Windows.Forms.Button DeleteSectionButton;
		private System.Windows.Forms.Button ClearInputsButton;
		private System.Windows.Forms.ListBox SectionListBox;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.ListBox CourseListBox;
		private System.Windows.Forms.ListBox FacultyListBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}

