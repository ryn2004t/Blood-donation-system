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
    public partial class hospitals: Form
    {
        public hospitals()
        {
            InitializeComponent();
        }
        private BloodDonationDataSetTableAdapters.usersTableAdapter usersTableAdapter = new BloodDonationDataSetTableAdapters.usersTableAdapter();

        private void hospitalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int u;
            if (!int.TryParse(user_idTextBox.Text, out u))
            {
                MessageBox.Show("Please enter a valid numeric User ID.");
                return;
            }
            if (bloodDonationDataSet.users.Rows.Count == 0)
            {
                this.usersTableAdapter.Fill(this.bloodDonationDataSet.users);
            }

            bool userExists = bloodDonationDataSet.users.AsEnumerable()
                             .Any(row => row.Field<int>("id") == u);
            if (!userExists)
            {
                MessageBox.Show("user id is not valid ");
                return;
            }
            this.Validate();
            this.hospitalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bloodDonationDataSet);
            MessageBox.Show("Donation saved successfully.");

        }

        private void hospitals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDonationDataSet.hospitals' table. You can move, or remove it, as needed.
            this.hospitalsTableAdapter.Fill(this.bloodDonationDataSet.hospitals);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            hospitalsBindingSource.RemoveCurrent();

            // Update database
            hospitalsTableAdapter.Update(bloodDonationDataSet.hospitals);

            //  MessageBox.Show("User deleted successfully.");
        
    }
    }
}
