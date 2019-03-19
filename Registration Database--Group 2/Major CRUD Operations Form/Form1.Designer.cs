namespace Major_CRUD_Operations_Form
{
    partial class majorCRUDForm
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
            this.majorNameLabel = new System.Windows.Forms.Label();
            this.majorNameTextBot = new System.Windows.Forms.TextBox();
            this.collegeLabel = new System.Windows.Forms.Label();
            this.collegeTextBox = new System.Windows.Forms.TextBox();
            this.addMajorButton = new System.Windows.Forms.Button();
            this.majorsListBox = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeMajorButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // majorNameLabel
            // 
            this.majorNameLabel.AutoSize = true;
            this.majorNameLabel.Location = new System.Drawing.Point(12, 47);
            this.majorNameLabel.Name = "majorNameLabel";
            this.majorNameLabel.Size = new System.Drawing.Size(67, 13);
            this.majorNameLabel.TabIndex = 0;
            this.majorNameLabel.Text = "Major Name:";
            // 
            // majorNameTextBot
            // 
            this.majorNameTextBot.Location = new System.Drawing.Point(85, 47);
            this.majorNameTextBot.Name = "majorNameTextBot";
            this.majorNameTextBot.Size = new System.Drawing.Size(302, 20);
            this.majorNameTextBot.TabIndex = 1;
            // 
            // collegeLabel
            // 
            this.collegeLabel.AutoSize = true;
            this.collegeLabel.Location = new System.Drawing.Point(12, 83);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Size = new System.Drawing.Size(45, 13);
            this.collegeLabel.TabIndex = 2;
            this.collegeLabel.Text = "College:";
            // 
            // collegeTextBox
            // 
            this.collegeTextBox.Location = new System.Drawing.Point(85, 83);
            this.collegeTextBox.Name = "collegeTextBox";
            this.collegeTextBox.Size = new System.Drawing.Size(302, 20);
            this.collegeTextBox.TabIndex = 3;
            // 
            // addMajorButton
            // 
            this.addMajorButton.Location = new System.Drawing.Point(393, 45);
            this.addMajorButton.Name = "addMajorButton";
            this.addMajorButton.Size = new System.Drawing.Size(75, 23);
            this.addMajorButton.TabIndex = 4;
            this.addMajorButton.Text = "Add Major";
            this.addMajorButton.UseVisualStyleBackColor = true;
            this.addMajorButton.Click += new System.EventHandler(this.addMajorButton_Click);
            // 
            // majorsListBox
            // 
            this.majorsListBox.FormattingEnabled = true;
            this.majorsListBox.Location = new System.Drawing.Point(15, 140);
            this.majorsListBox.Name = "majorsListBox";
            this.majorsListBox.Size = new System.Drawing.Size(453, 251);
            this.majorsListBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(394, 83);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(84, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update Major";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // removeMajorButton
            // 
            this.removeMajorButton.Location = new System.Drawing.Point(15, 397);
            this.removeMajorButton.Name = "removeMajorButton";
            this.removeMajorButton.Size = new System.Drawing.Size(453, 37);
            this.removeMajorButton.TabIndex = 7;
            this.removeMajorButton.Text = "Remove Major";
            this.removeMajorButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(85, 110);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(78, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Lorem Ipsum";
            // 
            // majorCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.removeMajorButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.majorsListBox);
            this.Controls.Add(this.addMajorButton);
            this.Controls.Add(this.collegeTextBox);
            this.Controls.Add(this.collegeLabel);
            this.Controls.Add(this.majorNameTextBot);
            this.Controls.Add(this.majorNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "majorCRUDForm";
            this.Text = "Major CRUD Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label majorNameLabel;
        private System.Windows.Forms.TextBox majorNameTextBot;
        private System.Windows.Forms.Label collegeLabel;
        private System.Windows.Forms.TextBox collegeTextBox;
        private System.Windows.Forms.Button addMajorButton;
        private System.Windows.Forms.ListBox majorsListBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeMajorButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

