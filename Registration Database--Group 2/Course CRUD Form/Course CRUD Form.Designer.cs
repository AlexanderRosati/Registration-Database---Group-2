namespace Course_CRUD_Form
{
	partial class CourseCRUDForm
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
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseNumberTextBox = new System.Windows.Forms.TextBox();
            this.CourseCreditsTextBox = new System.Windows.Forms.TextBox();
            this.CourseDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.DeleteCourseButton = new System.Windows.Forms.Button();
            this.UpdateCourseButton = new System.Windows.Forms.Button();
            this.ClearCourseInputButton = new System.Windows.Forms.Button();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(127, 43);
            this.CourseNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(333, 22);
            this.CourseNameTextBox.TabIndex = 0;
            // 
            // CourseNumberTextBox
            // 
            this.CourseNumberTextBox.Location = new System.Drawing.Point(127, 75);
            this.CourseNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseNumberTextBox.Name = "CourseNumberTextBox";
            this.CourseNumberTextBox.Size = new System.Drawing.Size(333, 22);
            this.CourseNumberTextBox.TabIndex = 1;
            // 
            // CourseCreditsTextBox
            // 
            this.CourseCreditsTextBox.Location = new System.Drawing.Point(127, 107);
            this.CourseCreditsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseCreditsTextBox.Name = "CourseCreditsTextBox";
            this.CourseCreditsTextBox.Size = new System.Drawing.Size(333, 22);
            this.CourseCreditsTextBox.TabIndex = 2;
            // 
            // CourseDepartmentTextBox
            // 
            this.CourseDepartmentTextBox.Location = new System.Drawing.Point(127, 139);
            this.CourseDepartmentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseDepartmentTextBox.Name = "CourseDepartmentTextBox";
            this.CourseDepartmentTextBox.Size = new System.Drawing.Size(333, 22);
            this.CourseDepartmentTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Credits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(36, 176);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(40, 17);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "Error";
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(525, 47);
            this.AddCourseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(123, 33);
            this.AddCourseButton.TabIndex = 10;
            this.AddCourseButton.Text = "Add";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // DeleteCourseButton
            // 
            this.DeleteCourseButton.Location = new System.Drawing.Point(525, 222);
            this.DeleteCourseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteCourseButton.Name = "DeleteCourseButton";
            this.DeleteCourseButton.Size = new System.Drawing.Size(123, 33);
            this.DeleteCourseButton.TabIndex = 11;
            this.DeleteCourseButton.Text = "Delete";
            this.DeleteCourseButton.UseVisualStyleBackColor = true;
            this.DeleteCourseButton.Click += new System.EventHandler(this.DeleteCourseButton_Click);
            // 
            // UpdateCourseButton
            // 
            this.UpdateCourseButton.Location = new System.Drawing.Point(525, 85);
            this.UpdateCourseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateCourseButton.Name = "UpdateCourseButton";
            this.UpdateCourseButton.Size = new System.Drawing.Size(123, 33);
            this.UpdateCourseButton.TabIndex = 12;
            this.UpdateCourseButton.Text = "Update";
            this.UpdateCourseButton.UseVisualStyleBackColor = true;
            this.UpdateCourseButton.Click += new System.EventHandler(this.UpdateCourseButton_Click);
            // 
            // ClearCourseInputButton
            // 
            this.ClearCourseInputButton.Location = new System.Drawing.Point(525, 126);
            this.ClearCourseInputButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearCourseInputButton.Name = "ClearCourseInputButton";
            this.ClearCourseInputButton.Size = new System.Drawing.Size(123, 33);
            this.ClearCourseInputButton.TabIndex = 13;
            this.ClearCourseInputButton.Text = "Clear";
            this.ClearCourseInputButton.UseVisualStyleBackColor = true;
            this.ClearCourseInputButton.Click += new System.EventHandler(this.ClearCourseInputButton_Click);
            // 
            // CourseListBox
            // 
            this.CourseListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 17;
            this.CourseListBox.Location = new System.Drawing.Point(40, 273);
            this.CourseListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(907, 242);
            this.CourseListBox.TabIndex = 14;
            // 
            // CourseCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 554);
            this.Controls.Add(this.CourseListBox);
            this.Controls.Add(this.ClearCourseInputButton);
            this.Controls.Add(this.UpdateCourseButton);
            this.Controls.Add(this.DeleteCourseButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseDepartmentTextBox);
            this.Controls.Add(this.CourseCreditsTextBox);
            this.Controls.Add(this.CourseNumberTextBox);
            this.Controls.Add(this.CourseNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(979, 591);
            this.Name = "CourseCRUDForm";
            this.Text = "Course Form";
            this.Load += new System.EventHandler(this.CourseCRUDForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CourseNameTextBox;
		private System.Windows.Forms.TextBox CourseNumberTextBox;
		private System.Windows.Forms.TextBox CourseCreditsTextBox;
		private System.Windows.Forms.TextBox CourseDepartmentTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.Button AddCourseButton;
		private System.Windows.Forms.Button DeleteCourseButton;
		private System.Windows.Forms.Button UpdateCourseButton;
		private System.Windows.Forms.Button ClearCourseInputButton;
        private System.Windows.Forms.ListBox CourseListBox;
    }
}

