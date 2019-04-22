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
            this.majorComboBox.Location = new System.Drawing.Point(72, 52);
            this.majorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(160, 24);
            this.majorComboBox.TabIndex = 0;
            // 
            // filterStudentsListBox
            // 
            this.filterStudentsListBox.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.filterStudentsListBox.FormattingEnabled = true;
            this.filterStudentsListBox.ItemHeight = 17;
            this.filterStudentsListBox.Location = new System.Drawing.Point(241, 52);
            this.filterStudentsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterStudentsListBox.Name = "filterStudentsListBox";
            this.filterStudentsListBox.Size = new System.Drawing.Size(1607, 378);
            this.filterStudentsListBox.TabIndex = 1;
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(16, 52);
            this.majorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(47, 17);
            this.majorLabel.TabIndex = 2;
            this.majorLabel.Text = "Major:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(237, 32);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 17);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(344, 32);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // collegeLabel
            // 
            this.collegeLabel.AutoSize = true;
            this.collegeLabel.Location = new System.Drawing.Point(1333, 32);
            this.collegeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Size = new System.Drawing.Size(59, 17);
            this.collegeLabel.TabIndex = 5;
            this.collegeLabel.Text = "College:";
            // 
            // majorListBoxLabel
            // 
            this.majorListBoxLabel.AutoSize = true;
            this.majorListBoxLabel.Location = new System.Drawing.Point(837, 32);
            this.majorListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.majorListBoxLabel.Name = "majorListBoxLabel";
            this.majorListBoxLabel.Size = new System.Drawing.Size(47, 17);
            this.majorListBoxLabel.TabIndex = 6;
            this.majorListBoxLabel.Text = "Major:";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(20, 97);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(213, 28);
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
            this.errorLabel.Location = new System.Drawing.Point(16, 177);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(91, 15);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Lorem Ipsum";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(20, 134);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(213, 28);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // studentFilteringByMajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 453);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1299, 490);
            this.Name = "studentFilteringByMajorForm";
            this.Text = "Filtering Students By Major Form";
            this.Load += new System.EventHandler(this.studentFilteringByMajorForm_Load);
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

