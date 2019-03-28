namespace Course_CRUD_Operations_Form
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
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.courseNameTextBox = new System.Windows.Forms.TextBox();
			this.courseNumTextBox = new System.Windows.Forms.TextBox();
			this.courseCreditsTextBox = new System.Windows.Forms.TextBox();
			this.courseDepartmentTextBox = new System.Windows.Forms.TextBox();
			this.courseListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(84, 45);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(203, 20);
			this.idTextBox.TabIndex = 0;
			// 
			// courseNameTextBox
			// 
			this.courseNameTextBox.Location = new System.Drawing.Point(84, 71);
			this.courseNameTextBox.Name = "courseNameTextBox";
			this.courseNameTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseNameTextBox.TabIndex = 1;
			// 
			// courseNumTextBox
			// 
			this.courseNumTextBox.Location = new System.Drawing.Point(84, 97);
			this.courseNumTextBox.Name = "courseNumTextBox";
			this.courseNumTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseNumTextBox.TabIndex = 2;
			// 
			// courseCreditsTextBox
			// 
			this.courseCreditsTextBox.Location = new System.Drawing.Point(84, 123);
			this.courseCreditsTextBox.Name = "courseCreditsTextBox";
			this.courseCreditsTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseCreditsTextBox.TabIndex = 3;
			// 
			// courseDepartmentTextBox
			// 
			this.courseDepartmentTextBox.Location = new System.Drawing.Point(84, 149);
			this.courseDepartmentTextBox.Name = "courseDepartmentTextBox";
			this.courseDepartmentTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseDepartmentTextBox.TabIndex = 4;
			// 
			// courseListBox
			// 
			this.courseListBox.FormattingEnabled = true;
			this.courseListBox.Location = new System.Drawing.Point(37, 224);
			this.courseListBox.Name = "courseListBox";
			this.courseListBox.Size = new System.Drawing.Size(623, 186);
			this.courseListBox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Credits";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Department";
			// 
			// CourseCRUDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.courseListBox);
			this.Controls.Add(this.courseDepartmentTextBox);
			this.Controls.Add(this.courseCreditsTextBox);
			this.Controls.Add(this.courseNumTextBox);
			this.Controls.Add(this.courseNameTextBox);
			this.Controls.Add(this.idTextBox);
			this.Name = "CourseCRUDForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox courseNameTextBox;
		private System.Windows.Forms.TextBox courseNumTextBox;
		private System.Windows.Forms.TextBox courseCreditsTextBox;
		private System.Windows.Forms.TextBox courseDepartmentTextBox;
		private System.Windows.Forms.ListBox courseListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

