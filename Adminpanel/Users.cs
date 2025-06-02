using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adminpanel
{
  
        public partial class Users : Form
        {
            public Users()
            {
                InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = false;

            // Prevent focus stealing
            this.Deactivate += (s, e) => this.BringToFront();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.MdiParent != null)
            {
                this.Size = this.MdiParent.ClientSize;
            }
        
    
    // Hook validation event for role column
    usersDataGridView.CellValidating += UsersDataGridView_CellValidating;

                // Hook delete button click (assuming bindingNavigatorDeleteItem)
                bindingNavigatorDeleteItem.Click += BindingNavigatorDeleteItem_Click;
            }

            private void Users_Load(object sender, EventArgs e)
            {
                // Load all users from database
                this.usersTableAdapter.Fill(this.bloodDonationDataSet.users);

                // Filter out admins so they are not displayed
                usersBindingSource.Filter = "role <> 'admin'";

                // Bind DataGridView to the filtered BindingSource (should be done in designer)
                usersDataGridView.DataSource = usersBindingSource;

                // Optionally hide the role column if you don't want user to edit it here
                if (usersDataGridView.Columns.Contains("role"))
                {
                    usersDataGridView.Columns["role"].Visible = false;
                }
            }

            private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
            {
                if (usersBindingSource.Current == null)
                {
                    MessageBox.Show("No user selected.");
                    return;
                }

                DataRowView currentUser = (DataRowView)usersBindingSource.Current;

                // Prevent deleting admins just in case (should not be visible anyway)
                if (currentUser["role"].ToString().Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Cannot delete admin users.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;

                usersBindingSource.RemoveCurrent();

                // Update database
                usersTableAdapter.Update(bloodDonationDataSet.users);

                MessageBox.Show("User deleted successfully.");
            }

            private void UsersDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
            {
                // Check if the edited column is "role"
                if (usersDataGridView.Columns[e.ColumnIndex].Name == "role")
                {
                    string newRole = e.FormattedValue.ToString().Trim().ToLower();

                    if (newRole == "admin")
                    {
                        MessageBox.Show("Assigning the 'admin' role is not allowed.");
                        e.Cancel = true;  // Cancel editing
                    }
                }
            }

            private void usersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // Optional: Display selected row values into textboxes if you have them
                if (e.RowIndex < 0) return;
                if (usersDataGridView.Rows[e.RowIndex].IsNewRow) return;

                txtId.Text = usersDataGridView.Rows[e.RowIndex].Cells["id"].Value?.ToString() ?? "";
                txtUsername.Text = usersDataGridView.Rows[e.RowIndex].Cells["username"].Value?.ToString() ?? "";
                txtEmail.Text = usersDataGridView.Rows[e.RowIndex].Cells["email"].Value?.ToString() ?? "";
                txtPassword.Text = usersDataGridView.Rows[e.RowIndex].Cells["password"].Value?.ToString() ?? "";
                txtRole.Text = usersDataGridView.Rows[e.RowIndex].Cells["role"].Value?.ToString() ?? "";
            }

            private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bloodDonationDataSet);
                MessageBox.Show("Changes saved successfully!");
            }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            txtRole.Text = "donor";
            if (txtRole.Text == "admin")
            {
                MessageBox.Show("error please insert only donor user");
            }

        }
    }
    }
