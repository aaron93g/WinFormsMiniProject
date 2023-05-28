namespace PersonnelInformation
{
    partial class AddressEntryForm
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
            lastNameTextBox2 = new TextBox();
            firstNameTextBox2 = new TextBox();
            lastNameLabel2 = new Label();
            firstNameLabel2 = new Label();
            streetAddressLabel = new Label();
            streetAddressTextBox = new TextBox();
            cityLabel = new Label();
            cityTextBox = new TextBox();
            stateLabel = new Label();
            stateTextBox = new TextBox();
            postalCodeLabel = new Label();
            postalCodeTextBox = new TextBox();
            emailAddress = new Label();
            emailAddressTextBox = new TextBox();
            saveAddressButton = new Button();
            SuspendLayout();
            // 
            // lastNameTextBox2
            // 
            lastNameTextBox2.Location = new Point(574, 6);
            lastNameTextBox2.Name = "lastNameTextBox2";
            lastNameTextBox2.Size = new Size(194, 35);
            lastNameTextBox2.TabIndex = 7;
            // 
            // firstNameTextBox2
            // 
            firstNameTextBox2.Location = new Point(216, 6);
            firstNameTextBox2.Name = "firstNameTextBox2";
            firstNameTextBox2.Size = new Size(172, 35);
            firstNameTextBox2.TabIndex = 6;
            // 
            // lastNameLabel2
            // 
            lastNameLabel2.AutoSize = true;
            lastNameLabel2.Location = new Point(447, 9);
            lastNameLabel2.Name = "lastNameLabel2";
            lastNameLabel2.Size = new Size(117, 30);
            lastNameLabel2.TabIndex = 5;
            lastNameLabel2.Text = "Last Name:";
            // 
            // firstNameLabel2
            // 
            firstNameLabel2.AutoSize = true;
            firstNameLabel2.Location = new Point(88, 9);
            firstNameLabel2.Name = "firstNameLabel2";
            firstNameLabel2.Size = new Size(118, 30);
            firstNameLabel2.TabIndex = 4;
            firstNameLabel2.Text = "First Name:";
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Location = new Point(49, 96);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new Size(151, 30);
            streetAddressLabel.TabIndex = 4;
            streetAddressLabel.Text = "Street Address:";
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(206, 93);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(225, 35);
            streetAddressTextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(537, 99);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(53, 30);
            cityLabel.TabIndex = 4;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(596, 96);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(172, 35);
            cityTextBox.TabIndex = 6;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(136, 170);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(64, 30);
            stateLabel.TabIndex = 4;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(206, 170);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(172, 35);
            stateTextBox.TabIndex = 6;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(463, 173);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(127, 30);
            postalCodeLabel.TabIndex = 4;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(596, 170);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(172, 35);
            postalCodeTextBox.TabIndex = 6;
            // 
            // emailAddress
            // 
            emailAddress.AutoSize = true;
            emailAddress.Location = new Point(128, 276);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(148, 30);
            emailAddress.TabIndex = 4;
            emailAddress.Text = "Email Address:";
            // 
            // emailAddressTextBox
            // 
            emailAddressTextBox.Location = new Point(276, 273);
            emailAddressTextBox.Name = "emailAddressTextBox";
            emailAddressTextBox.Size = new Size(397, 35);
            emailAddressTextBox.TabIndex = 6;
            // 
            // saveAddressButton
            // 
            saveAddressButton.Location = new Point(343, 354);
            saveAddressButton.Name = "saveAddressButton";
            saveAddressButton.Size = new Size(168, 34);
            saveAddressButton.TabIndex = 8;
            saveAddressButton.Text = "SAVE";
            saveAddressButton.UseVisualStyleBackColor = true;
            saveAddressButton.Click += saveAddressButton_Click;
            // 
            // AddressEntryForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 419);
            Controls.Add(saveAddressButton);
            Controls.Add(lastNameTextBox2);
            Controls.Add(emailAddressTextBox);
            Controls.Add(postalCodeTextBox);
            Controls.Add(stateTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(streetAddressTextBox);
            Controls.Add(firstNameTextBox2);
            Controls.Add(lastNameLabel2);
            Controls.Add(emailAddress);
            Controls.Add(postalCodeLabel);
            Controls.Add(stateLabel);
            Controls.Add(cityLabel);
            Controls.Add(streetAddressLabel);
            Controls.Add(firstNameLabel2);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddressEntryForm";
            Text = "Address Entry Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastNameTextBox2;
        private TextBox firstNameTextBox2;
        private Label lastNameLabel2;
        private Label firstNameLabel2;
        private Label streetAddressLabel;
        private TextBox streetAddressTextBox;
        private Label cityLabel;
        private TextBox cityTextBox;
        private Label stateLabel;
        private TextBox stateTextBox;
        private Label postalCodeLabel;
        private TextBox postalCodeTextBox;
        private Label emailAddress;
        private TextBox emailAddressTextBox;
        private Button saveAddressButton;
    }
}