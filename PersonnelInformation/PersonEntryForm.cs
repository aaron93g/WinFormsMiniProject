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
    public partial class PersonEntryForm : Form
    {
        BindingList<PersonModel> people = new BindingList<PersonModel>();
        AddressModel address = new AddressModel
        {
            Street = "empty",
            City = "empty",
            State = "empty",
            PostalCode = "empty",
            Email = "empty"
        };

        public PersonEntryForm()
        {
            InitializeComponent();

            peopleListBox.DataSource = people;
            peopleListBox.DisplayMember = nameof(PersonModel.FullName);
        }


        // Create a person obj with naming properties to add to our people list/listbox
        private void addNameButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Addresses = address
            };

            people.Add(person);
        }

        // Select an obj from the people list/listbox to bring up and edit their addresses information
        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)peopleListBox.SelectedItem;
            AddressEntryForm addresses = new AddressEntryForm(person);


            addresses.Show();
        }


    }
}
