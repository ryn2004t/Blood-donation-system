using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adminpanel.BloodDonationDataSetTableAdapters;

namespace Adminpanel
{
    public partial class Donations: Form
    {
        public Donations()
        {
            InitializeComponent();
        }
        private BloodDonationDataSetTableAdapters.usersTableAdapter usersTableAdapter = new BloodDonationDataSetTableAdapters.usersTableAdapter();

        private void donationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            int u;
            if (!int.TryParse(user_idTextBox.Text, out u))
            {
                MessageBox.Show("Please enter a valid numeric User ID.");
                return;
            }

            // Ensure the users table is loaded
            if (bloodDonationDataSet.users.Rows.Count == 0)
            {
                this.usersTableAdapter.Fill(this.bloodDonationDataSet.users);
            }

            // Check if user ID exists
            bool userExists = bloodDonationDataSet.users.AsEnumerable()
                             .Any(row => row.Field<int>("id") == u);
            if (!userExists)
            {
                MessageBox.Show("User ID is not valid.");
                return;
            }

            // Ensure donation_date is valid and assigned
            if (donation_dateDateTimePicker.Value == null || donation_dateDateTimePicker.Text.Trim() == "")
            {
                MessageBox.Show("Please select a valid donation date.");
                return;
            }

            // Set the donation_date field in the current row manually
            if (donationsBindingSource.Current is DataRowView currentRow)
            {
                currentRow["donation_date"] = donation_dateDateTimePicker.Value;
            }

            try
            {
                this.Validate(); // Validates controls
                this.donationsBindingSource.EndEdit(); // End editing current record
                this.tableAdapterManager.UpdateAll(this.bloodDonationDataSet); // Save all changes
                MessageBox.Show("Donation saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving donation: " + ex.Message);
            }
        }


        private void Donations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDonationDataSet.donations' table. You can move, or remove it, as needed.
            this.donationsTableAdapter.Fill(this.bloodDonationDataSet.donations);
           


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

           donationsBindingSource.RemoveCurrent();

            // Update database
            donationsTableAdapter.Update(bloodDonationDataSet.donations);

          //  MessageBox.Show("User deleted successfully.");
        }
    }
}
