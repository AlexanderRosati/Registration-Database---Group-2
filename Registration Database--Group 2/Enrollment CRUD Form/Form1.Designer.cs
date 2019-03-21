namespace Enrollment_CRUD_Form
{
    partial class enrollmentCRUDForm
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
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.listBoxSectionLabel = new System.Windows.Forms.Label();
            this.studentListBoxLabel = new System.Windows.Forms.Label();
            this.gradeListBoxLabel = new System.Windows.Forms.Label();
            this.addEnrollmentButton = new System.Windows.Forms.Button();
            this.updateEnrollmentButton = new System.Windows.Forms.Button();
            this.deleteEnrollmentButton = new System.Windows.Forms.Button();
            this.deselectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(64, 32);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sectionComboBox.TabIndex = 0;
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(64, 62);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentComboBox.TabIndex = 1;
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Location = new System.Drawing.Point(64, 95);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(121, 21);
            this.gradeComboBox.TabIndex = 2;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(12, 32);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(46, 13);
            this.sectionLabel.TabIndex = 3;
            this.sectionLabel.Text = "Section:";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(11, 62);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(47, 13);
            this.studentLabel.TabIndex = 4;
            this.studentLabel.Text = "Student:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(12, 95);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(39, 13);
            this.gradeLabel.TabIndex = 5;
            this.gradeLabel.Text = "Grade:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(202, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(741, 251);
            this.listBox1.TabIndex = 6;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(202, 13);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 7;
            this.IDLabel.Text = "ID:";
            // 
            // listBoxSectionLabel
            // 
            this.listBoxSectionLabel.AutoSize = true;
            this.listBoxSectionLabel.Location = new System.Drawing.Point(290, 13);
            this.listBoxSectionLabel.Name = "listBoxSectionLabel";
            this.listBoxSectionLabel.Size = new System.Drawing.Size(46, 13);
            this.listBoxSectionLabel.TabIndex = 8;
            this.listBoxSectionLabel.Text = "Section:";
            // 
            // studentListBoxLabel
            // 
            this.studentListBoxLabel.AutoSize = true;
            this.studentListBoxLabel.Location = new System.Drawing.Point(449, 13);
            this.studentListBoxLabel.Name = "studentListBoxLabel";
            this.studentListBoxLabel.Size = new System.Drawing.Size(47, 13);
            this.studentListBoxLabel.TabIndex = 9;
            this.studentListBoxLabel.Text = "Student:";
            // 
            // gradeListBoxLabel
            // 
            this.gradeListBoxLabel.AutoSize = true;
            this.gradeListBoxLabel.Location = new System.Drawing.Point(611, 13);
            this.gradeListBoxLabel.Name = "gradeListBoxLabel";
            this.gradeListBoxLabel.Size = new System.Drawing.Size(39, 13);
            this.gradeListBoxLabel.TabIndex = 10;
            this.gradeListBoxLabel.Text = "Grade:";
            // 
            // addEnrollmentButton
            // 
            this.addEnrollmentButton.Location = new System.Drawing.Point(15, 122);
            this.addEnrollmentButton.Name = "addEnrollmentButton";
            this.addEnrollmentButton.Size = new System.Drawing.Size(170, 23);
            this.addEnrollmentButton.TabIndex = 11;
            this.addEnrollmentButton.Text = "Add Enrollment";
            this.addEnrollmentButton.UseVisualStyleBackColor = true;
            this.addEnrollmentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateEnrollmentButton
            // 
            this.updateEnrollmentButton.Location = new System.Drawing.Point(15, 151);
            this.updateEnrollmentButton.Name = "updateEnrollmentButton";
            this.updateEnrollmentButton.Size = new System.Drawing.Size(170, 23);
            this.updateEnrollmentButton.TabIndex = 12;
            this.updateEnrollmentButton.Text = "Update Enrollment";
            this.updateEnrollmentButton.UseVisualStyleBackColor = true;
            // 
            // deleteEnrollmentButton
            // 
            this.deleteEnrollmentButton.Location = new System.Drawing.Point(15, 181);
            this.deleteEnrollmentButton.Name = "deleteEnrollmentButton";
            this.deleteEnrollmentButton.Size = new System.Drawing.Size(170, 23);
            this.deleteEnrollmentButton.TabIndex = 13;
            this.deleteEnrollmentButton.Text = "Remove Enrollment";
            this.deleteEnrollmentButton.UseVisualStyleBackColor = true;
            // 
            // deselectButton
            // 
            this.deselectButton.Location = new System.Drawing.Point(15, 211);
            this.deselectButton.Name = "deselectButton";
            this.deselectButton.Size = new System.Drawing.Size(170, 23);
            this.deselectButton.TabIndex = 14;
            this.deselectButton.Text = "Deselect";
            this.deselectButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 299);
            this.Controls.Add(this.deselectButton);
            this.Controls.Add(this.deleteEnrollmentButton);
            this.Controls.Add(this.updateEnrollmentButton);
            this.Controls.Add(this.addEnrollmentButton);
            this.Controls.Add(this.gradeListBoxLabel);
            this.Controls.Add(this.studentListBoxLabel);
            this.Controls.Add(this.listBoxSectionLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.sectionComboBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(971, 337);
            this.MinimumSize = new System.Drawing.Size(971, 337);
            this.Name = "Form1";
            this.Text = "Enrollment CRUD Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.ComboBox gradeComboBox;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label listBoxSectionLabel;
        private System.Windows.Forms.Label studentListBoxLabel;
        private System.Windows.Forms.Label gradeListBoxLabel;
        private System.Windows.Forms.Button addEnrollmentButton;
        private System.Windows.Forms.Button updateEnrollmentButton;
        private System.Windows.Forms.Button deleteEnrollmentButton;
        private System.Windows.Forms.Button deselectButton;
    }
}

