namespace Enrollment_Filtering_Form
{
    partial class EnrollmentFilteringForm
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
            this.filteredResultsListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filteredResultsListView
            // 
            this.filteredResultsListView.FullRowSelect = true;
            this.filteredResultsListView.Location = new System.Drawing.Point(12, 165);
            this.filteredResultsListView.Name = "filteredResultsListView";
            this.filteredResultsListView.Size = new System.Drawing.Size(1008, 293);
            this.filteredResultsListView.TabIndex = 1;
            this.filteredResultsListView.UseCompatibleStateImageBehavior = false;
            this.filteredResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name:";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(115, 108);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentNameTextBox.TabIndex = 3;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(221, 107);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Apply";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(221, 136);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // EnrollmentFilteringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 496);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filteredResultsListView);
            this.Name = "EnrollmentFilteringForm";
            this.Text = "Enrollment Filtering Form";
            this.Load += new System.EventHandler(this.EnrollmentFilteringForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filteredResultsListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button resetButton;
    }
}

