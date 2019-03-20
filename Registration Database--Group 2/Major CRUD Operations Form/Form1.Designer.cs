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
            this.collegeLabel = new System.Windows.Forms.Label();
            this.addMajorButton = new System.Windows.Forms.Button();
            this.majorsListBox = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeMajorButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.listboxIDLabel = new System.Windows.Forms.Label();
            this.listBoxCollegeLabel = new System.Windows.Forms.Label();
            this.listBoxMajorLabel = new System.Windows.Forms.Label();
            this.updateCollegeLabel = new System.Windows.Forms.Label();
            this.updateMajorNameLabel = new System.Windows.Forms.Label();
            this.deselectButton = new System.Windows.Forms.Button();
            this.majorNameTextBot = new System.Windows.Forms.MaskedTextBox();
            this.collegeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.updateMajorTextBox = new System.Windows.Forms.MaskedTextBox();
            this.updateCollegeTextBox = new System.Windows.Forms.MaskedTextBox();
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
            // collegeLabel
            // 
            this.collegeLabel.AutoSize = true;
            this.collegeLabel.Location = new System.Drawing.Point(12, 83);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Size = new System.Drawing.Size(45, 13);
            this.collegeLabel.TabIndex = 2;
            this.collegeLabel.Text = "College:";
            // 
            // addMajorButton
            // 
            this.addMajorButton.Location = new System.Drawing.Point(369, 45);
            this.addMajorButton.Name = "addMajorButton";
            this.addMajorButton.Size = new System.Drawing.Size(75, 23);
            this.addMajorButton.TabIndex = 4;
            this.addMajorButton.Text = "Add Major";
            this.addMajorButton.UseVisualStyleBackColor = true;
            this.addMajorButton.Click += new System.EventHandler(this.addMajorButton_Click);
            // 
            // majorsListBox
            // 
            this.majorsListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorsListBox.FormattingEnabled = true;
            this.majorsListBox.ItemHeight = 14;
            this.majorsListBox.Location = new System.Drawing.Point(15, 166);
            this.majorsListBox.Name = "majorsListBox";
            this.majorsListBox.Size = new System.Drawing.Size(757, 214);
            this.majorsListBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(809, 47);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(84, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update Major";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeMajorButton
            // 
            this.removeMajorButton.Location = new System.Drawing.Point(15, 397);
            this.removeMajorButton.Name = "removeMajorButton";
            this.removeMajorButton.Size = new System.Drawing.Size(757, 37);
            this.removeMajorButton.TabIndex = 7;
            this.removeMajorButton.Text = "Remove Major";
            this.removeMajorButton.UseVisualStyleBackColor = true;
            this.removeMajorButton.Click += new System.EventHandler(this.removeMajorButton_Click);
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
            // listboxIDLabel
            // 
            this.listboxIDLabel.AutoSize = true;
            this.listboxIDLabel.Location = new System.Drawing.Point(12, 150);
            this.listboxIDLabel.Name = "listboxIDLabel";
            this.listboxIDLabel.Size = new System.Drawing.Size(21, 13);
            this.listboxIDLabel.TabIndex = 9;
            this.listboxIDLabel.Text = "ID:";
            // 
            // listBoxCollegeLabel
            // 
            this.listBoxCollegeLabel.AutoSize = true;
            this.listBoxCollegeLabel.Location = new System.Drawing.Point(433, 150);
            this.listBoxCollegeLabel.Name = "listBoxCollegeLabel";
            this.listBoxCollegeLabel.Size = new System.Drawing.Size(45, 13);
            this.listBoxCollegeLabel.TabIndex = 10;
            this.listBoxCollegeLabel.Text = "College:";
            // 
            // listBoxMajorLabel
            // 
            this.listBoxMajorLabel.AutoSize = true;
            this.listBoxMajorLabel.Location = new System.Drawing.Point(85, 150);
            this.listBoxMajorLabel.Name = "listBoxMajorLabel";
            this.listBoxMajorLabel.Size = new System.Drawing.Size(36, 13);
            this.listBoxMajorLabel.TabIndex = 11;
            this.listBoxMajorLabel.Text = "Major:";
            // 
            // updateCollegeLabel
            // 
            this.updateCollegeLabel.AutoSize = true;
            this.updateCollegeLabel.Location = new System.Drawing.Point(452, 87);
            this.updateCollegeLabel.Name = "updateCollegeLabel";
            this.updateCollegeLabel.Size = new System.Drawing.Size(45, 13);
            this.updateCollegeLabel.TabIndex = 14;
            this.updateCollegeLabel.Text = "College:";
            // 
            // updateMajorNameLabel
            // 
            this.updateMajorNameLabel.AutoSize = true;
            this.updateMajorNameLabel.Location = new System.Drawing.Point(452, 50);
            this.updateMajorNameLabel.Name = "updateMajorNameLabel";
            this.updateMajorNameLabel.Size = new System.Drawing.Size(67, 13);
            this.updateMajorNameLabel.TabIndex = 12;
            this.updateMajorNameLabel.Text = "Major Name:";
            // 
            // deselectButton
            // 
            this.deselectButton.Location = new System.Drawing.Point(778, 397);
            this.deselectButton.Name = "deselectButton";
            this.deselectButton.Size = new System.Drawing.Size(144, 37);
            this.deselectButton.TabIndex = 17;
            this.deselectButton.Text = "Deselect";
            this.deselectButton.UseVisualStyleBackColor = true;
            this.deselectButton.Click += new System.EventHandler(this.deselectButton_Click);
            // 
            // majorNameTextBot
            // 
            this.majorNameTextBot.Location = new System.Drawing.Point(85, 45);
            this.majorNameTextBot.Mask = "??????????????????????????????????????????????????";
            this.majorNameTextBot.Name = "majorNameTextBot";
            this.majorNameTextBot.Size = new System.Drawing.Size(275, 20);
            this.majorNameTextBot.TabIndex = 18;
            // 
            // collegeTextBox
            // 
            this.collegeTextBox.Location = new System.Drawing.Point(85, 83);
            this.collegeTextBox.Mask = "??????????????????????????????????????????????????";
            this.collegeTextBox.Name = "collegeTextBox";
            this.collegeTextBox.Size = new System.Drawing.Size(275, 20);
            this.collegeTextBox.TabIndex = 19;
            // 
            // updateMajorTextBox
            // 
            this.updateMajorTextBox.Location = new System.Drawing.Point(525, 48);
            this.updateMajorTextBox.Mask = "??????????????????????????????????????????????????";
            this.updateMajorTextBox.Name = "updateMajorTextBox";
            this.updateMajorTextBox.Size = new System.Drawing.Size(275, 20);
            this.updateMajorTextBox.TabIndex = 20;
            // 
            // updateCollegeTextBox
            // 
            this.updateCollegeTextBox.Location = new System.Drawing.Point(525, 84);
            this.updateCollegeTextBox.Mask = "??????????????????????????????????????????????????";
            this.updateCollegeTextBox.Name = "updateCollegeTextBox";
            this.updateCollegeTextBox.Size = new System.Drawing.Size(275, 20);
            this.updateCollegeTextBox.TabIndex = 21;
            // 
            // majorCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.updateCollegeTextBox);
            this.Controls.Add(this.updateMajorTextBox);
            this.Controls.Add(this.collegeTextBox);
            this.Controls.Add(this.majorNameTextBot);
            this.Controls.Add(this.deselectButton);
            this.Controls.Add(this.updateCollegeLabel);
            this.Controls.Add(this.updateMajorNameLabel);
            this.Controls.Add(this.listBoxMajorLabel);
            this.Controls.Add(this.listBoxCollegeLabel);
            this.Controls.Add(this.listboxIDLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.removeMajorButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.majorsListBox);
            this.Controls.Add(this.addMajorButton);
            this.Controls.Add(this.collegeLabel);
            this.Controls.Add(this.majorNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 500);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "majorCRUDForm";
            this.Text = "Major CRUD Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label majorNameLabel;
        private System.Windows.Forms.Label collegeLabel;
        private System.Windows.Forms.Button addMajorButton;
        private System.Windows.Forms.ListBox majorsListBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeMajorButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label listboxIDLabel;
        private System.Windows.Forms.Label listBoxCollegeLabel;
        private System.Windows.Forms.Label listBoxMajorLabel;
        private System.Windows.Forms.Label updateCollegeLabel;
        private System.Windows.Forms.Label updateMajorNameLabel;
        private System.Windows.Forms.Button deselectButton;
        private System.Windows.Forms.MaskedTextBox majorNameTextBot;
        private System.Windows.Forms.MaskedTextBox collegeTextBox;
        private System.Windows.Forms.MaskedTextBox updateMajorTextBox;
        private System.Windows.Forms.MaskedTextBox updateCollegeTextBox;
    }
}

