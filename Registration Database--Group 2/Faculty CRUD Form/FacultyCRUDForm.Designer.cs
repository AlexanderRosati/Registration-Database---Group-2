namespace Faculty_CRUD_Form
{
    partial class FacultyCRUDForm
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
            this.nameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addFacultyMemberButton = new System.Windows.Forms.Button();
            this.updateFacultyMemberButton = new System.Windows.Forms.Button();
            this.facultyListBox = new System.Windows.Forms.ListBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.IDListBoxLabel = new System.Windows.Forms.Label();
            this.nameListBoxLabel = new System.Windows.Forms.Label();
            this.phoneNumberListBoxLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.deselectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(236, 43);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Mask = "??????????????????????????????????????????????????";
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(409, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(236, 94);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumberTextBox.Mask = "(999) 000-0000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(409, 22);
            this.phoneNumberTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 43);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(153, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Faculty Member Name:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(16, 94);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(211, 17);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Faculty Member Phone Number:";
            // 
            // addFacultyMemberButton
            // 
            this.addFacultyMemberButton.Location = new System.Drawing.Point(656, 43);
            this.addFacultyMemberButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addFacultyMemberButton.Name = "addFacultyMemberButton";
            this.addFacultyMemberButton.Size = new System.Drawing.Size(180, 28);
            this.addFacultyMemberButton.TabIndex = 4;
            this.addFacultyMemberButton.Text = "Add Faculty Member";
            this.addFacultyMemberButton.UseVisualStyleBackColor = true;
            this.addFacultyMemberButton.Click += new System.EventHandler(this.addFacultyMemberButton_Click);
            // 
            // updateFacultyMemberButton
            // 
            this.updateFacultyMemberButton.Location = new System.Drawing.Point(656, 94);
            this.updateFacultyMemberButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateFacultyMemberButton.Name = "updateFacultyMemberButton";
            this.updateFacultyMemberButton.Size = new System.Drawing.Size(180, 28);
            this.updateFacultyMemberButton.TabIndex = 5;
            this.updateFacultyMemberButton.Text = "Update Faculty Member";
            this.updateFacultyMemberButton.UseVisualStyleBackColor = true;
            this.updateFacultyMemberButton.Click += new System.EventHandler(this.updateFacultyMemberButton_Click);
            // 
            // facultyListBox
            // 
            this.facultyListBox.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.facultyListBox.FormattingEnabled = true;
            this.facultyListBox.ItemHeight = 17;
            this.facultyListBox.Location = new System.Drawing.Point(20, 176);
            this.facultyListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.facultyListBox.Name = "facultyListBox";
            this.facultyListBox.Size = new System.Drawing.Size(812, 276);
            this.facultyListBox.TabIndex = 6;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(16, 122);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(100, 17);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Lorem Ipsum";
            // 
            // IDListBoxLabel
            // 
            this.IDListBoxLabel.AutoSize = true;
            this.IDListBoxLabel.Location = new System.Drawing.Point(20, 153);
            this.IDListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDListBoxLabel.Name = "IDListBoxLabel";
            this.IDListBoxLabel.Size = new System.Drawing.Size(25, 17);
            this.IDListBoxLabel.TabIndex = 10;
            this.IDListBoxLabel.Text = "ID:";
            // 
            // nameListBoxLabel
            // 
            this.nameListBoxLabel.AutoSize = true;
            this.nameListBoxLabel.Location = new System.Drawing.Point(120, 153);
            this.nameListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameListBoxLabel.Name = "nameListBoxLabel";
            this.nameListBoxLabel.Size = new System.Drawing.Size(49, 17);
            this.nameListBoxLabel.TabIndex = 11;
            this.nameListBoxLabel.Text = "Name:";
            // 
            // phoneNumberListBoxLabel
            // 
            this.phoneNumberListBoxLabel.AutoSize = true;
            this.phoneNumberListBoxLabel.Location = new System.Drawing.Point(624, 153);
            this.phoneNumberListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberListBoxLabel.Name = "phoneNumberListBoxLabel";
            this.phoneNumberListBoxLabel.Size = new System.Drawing.Size(107, 17);
            this.phoneNumberListBoxLabel.TabIndex = 12;
            this.phoneNumberListBoxLabel.Text = "Phone Number:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(24, 464);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(623, 59);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove Faculty Member";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // deselectButton
            // 
            this.deselectButton.Location = new System.Drawing.Point(656, 464);
            this.deselectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deselectButton.Name = "deselectButton";
            this.deselectButton.Size = new System.Drawing.Size(177, 59);
            this.deselectButton.TabIndex = 14;
            this.deselectButton.Text = "Deselect";
            this.deselectButton.UseVisualStyleBackColor = true;
            this.deselectButton.Click += new System.EventHandler(this.deselectButton_Click);
            // 
            // FacultyCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 528);
            this.Controls.Add(this.deselectButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.phoneNumberListBoxLabel);
            this.Controls.Add(this.nameListBoxLabel);
            this.Controls.Add(this.IDListBoxLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.facultyListBox);
            this.Controls.Add(this.updateFacultyMemberButton);
            this.Controls.Add(this.addFacultyMemberButton);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 575);
            this.MinimumSize = new System.Drawing.Size(865, 575);
            this.Name = "FacultyCRUDForm";
            this.Text = "Faculty CRUD Form";
            this.Load += new System.EventHandler(this.FacultyCRUDForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Button addFacultyMemberButton;
        private System.Windows.Forms.Button updateFacultyMemberButton;
        private System.Windows.Forms.ListBox facultyListBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label IDListBoxLabel;
        private System.Windows.Forms.Label nameListBoxLabel;
        private System.Windows.Forms.Label phoneNumberListBoxLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button deselectButton;
    }
}

