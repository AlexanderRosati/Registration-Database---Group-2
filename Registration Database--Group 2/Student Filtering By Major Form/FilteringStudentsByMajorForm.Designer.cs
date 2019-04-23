namespace Student_Filtering_By_Major_Form
{
    partial class studentFilteringByMajorForm
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
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.filterStudentsListBox = new System.Windows.Forms.ListBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.collegeLabel = new System.Windows.Forms.Label();
            this.majorListBoxLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // majorComboBox
            // 
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Location = new System.Drawing.Point(54, 42);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(121, 21);
            this.majorComboBox.TabIndex = 0;
            // 
            // filterStudentsListBox
            // 
            this.filterStudentsListBox.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.filterStudentsListBox.FormattingEnabled = true;
            this.filterStudentsListBox.ItemHeight = 14;
            this.filterStudentsListBox.Location = new System.Drawing.Point(181, 42);
            this.filterStudentsListBox.Name = "filterStudentsListBox";
            this.filterStudentsListBox.Size = new System.Drawing.Size(1206, 312);
            this.filterStudentsListBox.TabIndex = 1;
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(12, 42);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(36, 13);
            this.majorLabel.TabIndex = 2;
            this.majorLabel.Text = "Major:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(178, 26);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(258, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // collegeLabel
            // 
            this.collegeLabel.AutoSize = true;
            this.collegeLabel.Location = new System.Drawing.Point(1000, 26);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Size = new System.Drawing.Size(45, 13);
            this.collegeLabel.TabIndex = 5;
            this.collegeLabel.Text = "College:";
            // 
            // majorListBoxLabel
            // 
            this.majorListBoxLabel.AutoSize = true;
            this.majorListBoxLabel.Location = new System.Drawing.Point(628, 26);
            this.majorListBoxLabel.Name = "majorListBoxLabel";
            this.majorListBoxLabel.Size = new System.Drawing.Size(36, 13);
            this.majorListBoxLabel.TabIndex = 6;
            this.majorListBoxLabel.Text = "Major:";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(15, 79);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(160, 23);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 144);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(70, 12);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Lorem Ipsum";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(15, 109);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(160, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // studentFilteringByMajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 368);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.majorListBoxLabel);
            this.Controls.Add(this.collegeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.filterStudentsListBox);
            this.Controls.Add(this.majorComboBox);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(979, 407);
            this.Name = "studentFilteringByMajorForm";
            this.Text = "Filtering Students By Major Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.ListBox filterStudentsListBox;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label collegeLabel;
        private System.Windows.Forms.Label majorListBoxLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

