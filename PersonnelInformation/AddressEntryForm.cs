using PersonnelAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelInformation
{
    public partial class AddressEntryForm : Form
    {

        // Saves the obj reference passed through the form construction
        PersonModel _model;

        // Scribes property values from people listbox to address forms text boxes
        public AddressEntryForm(PersonModel model)
        {
            InitializeComponent();

            _model = model;

            firstNameTextBox2.Text = model.FirstName;
            lastNameTextBox2.Text = model.LastName;
            streetAddressTextBox.Text = model.Addresses.Street;
            cityTextBox.Text = model.Addresses.City;
            stateTextBox.Text = model.Addresses.State;
            postalCodeTextBox.Text = model.Addresses.PostalCode;
            emailAddressTextBox.Text = model.Addresses.Email;


        }


        // Saves updated information to the _model reference obj
        private void saveAddressButton_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                Street = streetAddressTextBox.Text,
                City = cityTextBox.Text,
                State = stateTextBox.Text,
                PostalCode = postalCodeTextBox.Text,
                Email = emailAddressTextBox.Text,
            };

            _model.FirstName = firstNameTextBox2.Text;
            _model.LastName = lastNameTextBox2.Text;
            _model.Addresses = address;

            

            this.Close();
        }

        
    }
}
