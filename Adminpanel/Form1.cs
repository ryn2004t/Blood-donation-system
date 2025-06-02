using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Shared;
using UserPanel;

namespace Adminpanel
{
    public partial class AdminForm : Form
    {
        private int _userId;
        private ObservableCollection<string> BloodCounts;
        BloodDonationDataSet myDataSet = new BloodDonationDataSet();

        public AdminForm(int userId)
        {
            InitializeComponent();
            BloodCounts = new ObservableCollection<string>();
            _userId = userId;
        }
       // string username = SessionManager.LoggedInUsername; // <-- First one
         // string username = userRow.username; // <-- This hides the first one (bad)

        private void ShowMdiChildForm<T>() where T : Form, new()
        {
            var existingForm = this.MdiChildren.OfType<T>().FirstOrDefault();
            if (existingForm != null)
            {
                existingForm.BringToFront();
                return;
            }

            var childForm = new T
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            childForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users form2 = new Users();
            form2.Show();
        }

        private void donationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donations u = new Donations();
            u.Show();
        }

        public void CheckBloodCounts()
        {
            var allBloodTypes = new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", "Unknown" };
            var bloodCounts = allBloodTypes.ToDictionary(bt => bt, bt => 0);
            var debugOutput = new StringBuilder();

            try
            {
                string connectionString = @"Server=DESKTOP-68EHAK4;Database=BloodDonation;User Id=sa;Password=12345678;";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT donation_id, LTRIM(RTRIM(blood_type)) as clean_blood_type FROM donations";
                    using (var cmd = new SqlCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bloodType = reader.IsDBNull(1) ? null : reader.GetString(1);
                            string standardizedType = ParseBloodType(bloodType);
                            if (bloodCounts.ContainsKey(standardizedType))
                                bloodCounts[standardizedType]++;
                            else
                                bloodCounts["Unknown"]++;
                        }
                    }
                }

                var displayData = allBloodTypes.Select(bt => new
                {
                    BloodType = bt,
                    Count = bloodCounts[bt],
                    Status = bloodCounts[bt] < 2 && bt != "Unknown" ? "LOW" : "OK"
                }).ToList();

                dataGridView1.DataSource = displayData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private string ParseBloodType(string bloodType)
        {
            if (string.IsNullOrWhiteSpace(bloodType)) return "Unknown";
            bloodType = bloodType.Trim().ToUpper();

            if (bloodType.StartsWith("AB") && bloodType.Length >= 3)
                return "+-".Contains(bloodType[2]) ? "AB" + bloodType[2] : "Unknown";
            else if (bloodType.Length >= 2 && "ABO".Contains(bloodType[0].ToString()))
                return "+-".Contains(bloodType[1]) ? bloodType[0] + bloodType[1].ToString() : "Unknown";

            return "Unknown";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBloodCounts();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            

          //  string username = SessionManager.LoggedInUsername;
            try
            {
                var usersTableAdapter = new BloodDonationDataSetTableAdapters.usersTableAdapter();
                usersTableAdapter.Fill(myDataSet.users);

                var userRow = myDataSet.users.FindByid(_userId);

                if (userRow != null)
                {
                    string dusername = userRow.username;
                    label3.Text = "Welcome, " + SessionManager.LoggedInUser;

                }
                else
                {
                    label3.Text = "User not found.";
                    MessageBox.Show("No user found for ID: " + _userId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in AdminForm_Load: " + ex.Message);
            }
        }
        

        private void hospitalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hospitals h = new hospitals();
            h.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arrangeHorizantalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Users form2 = new Users();
            form2.Show();
        }

        private void donationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Donations form2 = new Donations();
            form2.Show();
        }

        private void hospitalsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hospitals form2 = new hospitals();
            form2.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

