namespace Student_CRUD_Operations_Form
{
    partial class studentCRUDForm
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
            this.studentNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.deselectButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.listBoxStudentLabel = new System.Windows.Forms.Label();
            this.listBoxMajorLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(96, 29);
            this.studentNameTextBox.Mask = "??????????????????????????????????????????????????";
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.studentNameTextBox.TabIndex = 0;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(12, 29);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(78, 13);
            this.studentNameLabel.TabIndex = 1;
            this.studentNameLabel.Text = "Student Name:";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(352, 32);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(36, 13);
            this.majorLabel.TabIndex = 2;
            this.majorLabel.Text = "Major:";
            // 
            // majorComboBox
            // 
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Location = new System.Drawing.Point(394, 29);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(121, 21);
            this.majorComboBox.TabIndex = 3;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(521, 29);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(98, 23);
            this.addStudentButton.TabIndex = 4;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Location = new System.Drawing.Point(625, 29);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(98, 23);
            this.updateStudentButton.TabIndex = 5;
            this.updateStudentButton.Text = "Update Student";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.updateStudentButton_Click);
            // 
            // studentsListBox
            // 
            this.studentsListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 14;
            this.studentsListBox.Location = new System.Drawing.Point(11, 95);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(757, 242);
            this.studentsListBox.TabIndex = 6;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 343);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(600, 56);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove Student";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // deselectButton
            // 
            this.deselectButton.Location = new System.Drawing.Point(618, 343);
            this.deselectButton.Name = "deselectButton";
            this.deselectButton.Size = new System.Drawing.Size(150, 56);
            this.deselectButton.TabIndex = 8;
            this.deselectButton.Text = "Deselect";
            this.deselectButton.UseVisualStyleBackColor = true;
            this.deselectButton.Click += new System.EventHandler(this.deselectButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 79);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID:";
            // 
            // listBoxStudentLabel
            // 
            this.listBoxStudentLabel.AutoSize = true;
            this.listBoxStudentLabel.Location = new System.Drawing.Point(80, 79);
            this.listBoxStudentLabel.Name = "listBoxStudentLabel";
            this.listBoxStudentLabel.Size = new System.Drawing.Size(78, 13);
            this.listBoxStudentLabel.TabIndex = 10;
            this.listBoxStudentLabel.Text = "Student Name:";
            // 
            // listBoxMajorLabel
            // 
            this.listBoxMajorLabel.AutoSize = true;
            this.listBoxMajorLabel.Location = new System.Drawing.Point(456, 79);
            this.listBoxMajorLabel.Name = "listBoxMajorLabel";
            this.listBoxMajorLabel.Size = new System.Drawing.Size(36, 13);
            this.listBoxMajorLabel.TabIndex = 11;
            this.listBoxMajorLabel.Text = "Major:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 57);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(78, 13);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.Text = "Lorem Ipsum";
            // 
            // studentCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.listBoxMajorLabel);
            this.Controls.Add(this.listBoxStudentLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.deselectButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.updateStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.majorComboBox);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.studentNameTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "studentCRUDForm";
            this.Text = "Student CRUD Operations Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox studentNameTextBox;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button updateStudentButton;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button deselectButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label listBoxStudentLabel;
        private System.Windows.Forms.Label listBoxMajorLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

