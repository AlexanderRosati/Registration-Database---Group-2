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
			this.registrationDataSet = new Section_CRUD_Form.RegistrationDataSet();
			this.registrationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// CourseIDDropdownBox
			// 
			this.CourseIDDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CourseIDDropdownBox.FormattingEnabled = true;
			this.CourseIDDropdownBox.Location = new System.Drawing.Point(114, 45);
			this.CourseIDDropdownBox.Name = "CourseIDDropdownBox";
			this.CourseIDDropdownBox.Size = new System.Drawing.Size(249, 21);
			this.CourseIDDropdownBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "CourseID";
			// 
			// registrationDataSet
			// 
			this.registrationDataSet.DataSetName = "RegistrationDataSet";
			this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// registrationDataSetBindingSource
			// 
			this.registrationDataSetBindingSource.DataSource = this.registrationDataSet;
			this.registrationDataSetBindingSource.Position = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(114, 105);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(196, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// SectionCRUDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CourseIDDropdownBox);
			this.Name = "SectionCRUDForm";
			this.Text = "Section";
			((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox CourseIDDropdownBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource registrationDataSetBindingSource;
		private RegistrationDataSet registrationDataSet;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

