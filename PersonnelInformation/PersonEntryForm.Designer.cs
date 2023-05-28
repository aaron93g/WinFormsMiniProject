namespace PersonnelInformation
{
    partial class PersonEntryForm
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            addNameButton = new Button();
            peopleListBox = new ListBox();
            viewInfoLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(51, 59);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(122, 25);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(316, 59);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(121, 25);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(179, 56);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 31);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(443, 56);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 31);
            lastNameTextBox.TabIndex = 3;
            // 
            // addNameButton
            // 
            addNameButton.Location = new Point(572, 56);
            addNameButton.Name = "addNameButton";
            addNameButton.Size = new Size(130, 31);
            addNameButton.TabIndex = 4;
            addNameButton.Text = "Add Name";
            addNameButton.UseVisualStyleBackColor = true;
            addNameButton.Click += addNameButton_Click;
            // 
            // peopleListBox
            // 
            peopleListBox.FormattingEnabled = true;
            peopleListBox.ItemHeight = 25;
            peopleListBox.Location = new Point(179, 191);
            peopleListBox.Name = "peopleListBox";
            peopleListBox.Size = new Size(348, 129);
            peopleListBox.TabIndex = 5;
            peopleListBox.SelectedIndexChanged += peopleListBox_SelectedIndexChanged;
            // 
            // viewInfoLabel
            // 
            viewInfoLabel.AutoSize = true;
            viewInfoLabel.Location = new Point(189, 163);
            viewInfoLabel.Name = "viewInfoLabel";
            viewInfoLabel.Size = new Size(328, 25);
            viewInfoLabel.TabIndex = 6;
            viewInfoLabel.Text = "Click on a name to view address:";
            // 
            // PersonEntryForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 363);
            Controls.Add(viewInfoLabel);
            Controls.Add(peopleListBox);
            Controls.Add(addNameButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "PersonEntryForm";
            Text = "Entry Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button addNameButton;
        private ListBox peopleListBox;
        private Label viewInfoLabel;
    }
}