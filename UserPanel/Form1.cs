using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserPanel
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=YOUR_SERVER;database=BloodDonation;user=sa;password=YOUR_PASSWORD");


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void donorinfo_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String[] bg = {"A+", "A-", "B+", "B-", "O-", "O+", "AB+", "AB-"};
            //blood.Items.AddRange(bg);

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            label3.Text = "Hii  " + SessionManager.LoggedInUser.ToUpper() + " :)";
            String[] bg = { "A+", "A-", "B+", "B-", "O-", "O+", "AB+", "AB-" };
            blood.Items.AddRange(bg);
            date.Text = DateTime.Today.ToString("yyyy-MM-dd");
            String[] gen = { "Male", "Female" };
            gender1.Items.AddRange(gen);

            link1.Text = "Visit DSC Lebanon"; // Display text
            link1.Links.Add(0, link1.Text.Length, "https://dsclebanon.org/en/about"); // Add the link

            link2.Text = "Visit Red Cross Lebanon"; // Display text
            link2.Links.Add(0, link2.Text.Length, "https://www.redcrossblood.org/"); // Add the link
            dataGridView1.ReadOnly = false; // Allow editing
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select entire row
            dataGridView1.AllowUserToAddRows = false;
            //LoadDonations();

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void addinfo_Click(object sender, EventArgs e)
        {
            //{
            //    string blood1 = blood.Text;
            //    string age1 = age.Text;
            //    string date1 = date.Text;
            //    string gen = gender.Text;

            //    // Retrieve logged-in user's ID (replace with actual session logic)
            //    int userId = GetLoggedInUserId(); // Function to get user_id

            //    if (userId == 0) // Ensure user ID exists
            //    {
            //        MessageBox.Show("Error: No valid user logged in.");
            //        return;
            //    }

            //    string query = "INSERT INTO donations (user_id, blood_type, donation_date, gender, age) VALUES (@userId, @blood1, @date1, @gen, @age1)";

            //    using (SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678"))
            //    {
            //        try
            //        {
            //            conn.Open();
            //            using (SqlCommand cmd = new SqlCommand(query, conn))
            //            {
            //                cmd.Parameters.AddWithValue("@userId", userId);
            //                cmd.Parameters.AddWithValue("@blood1", blood1);
            //                cmd.Parameters.AddWithValue("@date1", Convert.ToDateTime(date1)); // Ensure correct date format
            //                cmd.Parameters.AddWithValue("@gen", gen);
            //                cmd.Parameters.AddWithValue("@age1", Convert.ToInt32(age1)); // Convert age to integer

            //                cmd.ExecuteNonQuery();
            //                MessageBox.Show("Donation registered successfully!");
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error: " + ex.Message);
            //        }
            //    }

            //    // Reset fields
            //    blood.Text = "";
            //    age.Text = "";
            //    date.Text = "";
            //    gender.Text = "";

            //    // Refresh DataGridView
            //    LoadUserData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // string connectionString = "server=YOUR_SERVER;database=BloodDonation;user=sa;password=YOUR_PASSWORD";

            // using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //conn.Open();
            //string query = "SELECT user_id, blood_type, age, gender, donation_date FROM donations";

            //using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            //{
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}
        }
        private void LoadDonations()
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT blood_type, donation_date, gender, age FROM donations";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        // dataGridView1.DataSource = userTable; // Bind the data
                        dataGridView1.ReadOnly = false;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView1.AllowUserToAddRows = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading donations: " + ex.Message);
                }
            }
        }
        private int GetLoggedInUserId()
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678"))
            {
                conn.Open();
                string query = "SELECT id FROM users WHERE username=@username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", SessionManager.LoggedInUser);

                    object result = cmd.ExecuteScalar();
                    return (result != null) ? Convert.ToInt32(result) : 0; // Return user_id
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)


        {





            int userId = SessionManager.LoggedInUserId; // Get user ID from session

            // Prevent inserting invalid user_id
            if (userId == 0)
            {
                MessageBox.Show("Error: Logged-in user ID is invalid.");
                return;
            }

            // Retrieve Hospital Information
            string hospitalName = GetSelectedHospital(); // Get selected radio button value
            List<string> locations = GetCheckedLocations(); // Get checked locations

            if (string.IsNullOrEmpty(hospitalName) || locations.Count == 0)
            {
                MessageBox.Show("Error: Hospital name or location missing.");
                return;
            }

          
            string bloodType = blood.Text;
            string gender = gender1.SelectedItem?.ToString();
            string donationDate = date.Text;
            string ageText = age1.Text;

          
            int age = 0; // Initialize with a default value
            if (!int.TryParse(ageText, out age) || age <= 0)
            {
                MessageBox.Show("Error: Age must be a valid positive number.");
                return;
            }
          
            DateTime parsedDate;
            if (!DateTime.TryParse(donationDate, out parsedDate))
            {
                MessageBox.Show("Error: Please enter a valid donation date.");
                return;
            }

            // Ensure gender is selected
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Error: Please select a gender.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678"))
            {
                try
                {
                    conn.Open();

                    //MessageBox.Show("Debug: Hospital Name → " + hospitalName);
                    //MessageBox.Show("Debug: Locations → " + string.Join(", ", locations));

                    // Insert Hospital Data
                    foreach (string location in locations)
                    {
                        string hospitalQuery = "INSERT INTO hospitals (user_id, hospital_name, location) VALUES (@userId, @hospitalName, @location)";
                        using (SqlCommand hospitalCmd = new SqlCommand(hospitalQuery, conn))
                        {
                            hospitalCmd.Parameters.AddWithValue("@userId", userId);
                            hospitalCmd.Parameters.AddWithValue("@hospitalName", hospitalName);
                            hospitalCmd.Parameters.AddWithValue("@location", location);

                            hospitalCmd.ExecuteNonQuery();
                        }
                    }

                    //MessageBox.Show("Debug: Blood Type → " + bloodType);
                    //MessageBox.Show("Debug: Donation Date → " + parsedDate);
                    //MessageBox.Show("Debug: Gender → " + gender);
                    //MessageBox.Show("Debug: Age → " + age);

                    // Insert Donation Data
                    string donationQuery = "INSERT INTO donations (user_id, blood_type, donation_date, gender, age) VALUES (@userId, @bloodType, @donationDate, @gender, @age)";
                    using (SqlCommand donationCmd = new SqlCommand(donationQuery, conn))
                    {
                        donationCmd.Parameters.AddWithValue("@userId", userId);
                        donationCmd.Parameters.AddWithValue("@bloodType", bloodType);
                        donationCmd.Parameters.AddWithValue("@donationDate", parsedDate);
                        donationCmd.Parameters.AddWithValue("@gender", gender); 
                        donationCmd.Parameters.AddWithValue("@age", age);

                        donationCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Hospital and donation information saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during database save: " + ex.Message);
                }
            }

          
            blood.Text = "";
            age1.Text = "";
            date.Text = "";
            gender1.SelectedIndex = -1; 

            sp.Checked = false;
            gm.Checked = false;
            an.Checked = false;
            jb.Checked = false;
            jn.Checked = false;
            dsc.Checked = false;
            redcross.Checked = false;

           
            LoadUserData();
        }



        private string GetSelectedHospital()
        {
            if (dsc.Checked) return "DSC Lebanon";
            if (redcross.Checked) return "Red Cross";

            MessageBox.Show("Error: No hospital selected.");
            return "";
        }
        private List<string> GetCheckedLocations()
        {
            List<string> selectedLocations = new List<string>();

            if (sp.Checked) selectedLocations.Add("Spears");
            if (gm.Checked) selectedLocations.Add("Gemmayze");
            if (an.Checked) selectedLocations.Add("Antelias");
            if (jn.Checked) selectedLocations.Add("Jounieh");
            if (jb.Checked) selectedLocations.Add("Jbeil");

            if (selectedLocations.Count == 0)
            {
                MessageBox.Show("Error: No location selected.");
            }

            return selectedLocations;
            //sp.Checked = false;
            //gm.Checked = false;
            //an.Checked = false;
            //jb.Checked = false;
            //jn.Checked = false;
            //dsc.Checked = false;
            //redcross.Checked = false;
        }
        private void LoadHospitalData()
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678"))
            {
                conn.Open();
                string query = "SELECT hospital_name, location FROM hospitals WHERE user_id=@userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", SessionManager.LoggedInUserId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable hospitalTable = new DataTable();
                        adapter.Fill(hospitalTable);
                        dataGridView1.DataSource = hospitalTable;
                    }
                }
            }
        }
        private void LoadUserData()
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678"))
            {
                conn.Open();
                string query = "SELECT d.donation_id, h.hospital_name, h.location, d.donation_date, d.blood_type, d.gender, d.age " +
                "FROM hospitals h INNER JOIN donations d ON h.user_id = d.user_id " +
                "WHERE h.user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", SessionManager.LoggedInUserId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable userTable = new DataTable();
                        adapter.Fill(userTable);
                        dataGridView1.DataSource = userTable;
                    }
                }
            }
        }

        private void hospital_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donorinfo.BringToFront();
            donorinfo.Visible = true;

            blood.Text = "";
            age1.Text = "";
            date.Text = "";
            gender1.SelectedIndex = -1;

            sp.Checked = false;
            gm.Checked = false;
            an.Checked = false;
            jb.Checked = false;
            jn.Checked = false;
            dsc.Checked = false;
            redcross.Checked = false;
            LoadUserData();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                object cellValue = dataGridView1.SelectedRows[0].Cells["donation_id"].Value; 

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedId))
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678"))
                        {
                            try
                            {
                                conn.Open();
                                string deleteQuery = "DELETE FROM donations WHERE donation_id = @selectedId";
                                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@selectedId", selectedId);
                                    cmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Record deleted successfully!");
                                LoadUserData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting record: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Selected row does not contain a valid ID.");
                }
            }
            else
            {
                MessageBox.Show("Error: Please select a record to delete.");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

               
                SetSelectedHospital(selectedRow.Cells["hospital_name"].Value.ToString());

               
                string[] locationsArray = selectedRow.Cells["location"].Value.ToString().Split(',');
                SetCheckedLocations(locationsArray.ToList());

               
                blood.SelectedItem = selectedRow.Cells["blood_type"].Value.ToString();
                gender1.SelectedItem = selectedRow.Cells["gender"].Value.ToString();
                age1.Text = selectedRow.Cells["age"].Value.ToString();
                date.Value = Convert.ToDateTime(selectedRow.Cells["donation_date"].Value);

                MessageBox.Show("Edit mode activated. Modify fields and press Save.");
            }
            else
            {
                MessageBox.Show("Error: Please select a row to edit.");
            }
        }
        private void SetSelectedHospital(string hospitalName)
        {
            if (hospitalName == "DSC Lebanon") dsc.Checked = true;
            else if (hospitalName == "Red Cross") redcross.Checked = true;
            else MessageBox.Show("Error: Hospital name not recognized.");
        }
        private void SetCheckedLocations(List<string> locations)
        {
            sp.Checked = locations.Contains("SP Hospital");
            gm.Checked = locations.Contains("GM Hospital");
            an.Checked = locations.Contains("AN Hospital");
            jb.Checked = locations.Contains("JB Hospital");
            jn.Checked = locations.Contains("JN Hospital");
            dsc.Checked = locations.Contains("DSC Hospital");
            redcross.Checked = locations.Contains("Red Cross");
        }

        private void saveUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No record selected for update.");
                return;
            }

            object cellValue = dataGridView1.SelectedRows[0].Cells["donation_id"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int selectedId))
            {
                MessageBox.Show("Invalid donation ID.");
                return;
            }

          
            if (!DateTime.TryParse(date.Text.Trim(), out DateTime parsedDate))
            {
                MessageBox.Show("Invalid date format.");
                return;
            }
            if (parsedDate.Date != DateTime.Today)
            {
                MessageBox.Show("You can only enter today's date: " + DateTime.Today.ToString("yyyy-MM-dd"));
                return;
            }


          
            if (!int.TryParse(age1.Text.Trim(), out int age) || age <= 0)
            {
                MessageBox.Show("Age must be a valid number.");
                return;
            }

          
            string bloodType = blood.SelectedItem?.ToString() ?? blood.Text;
            string gender = gender1.SelectedItem?.ToString() ?? gender1.Text;

            if (string.IsNullOrEmpty(bloodType) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select blood type and gender.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678"))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"
                UPDATE donations 
                SET blood_type = @bloodType, 
                    donation_date = @donationDate, 
                    gender = @gender, 
                    age = @age 
                WHERE donation_id = @selectedId";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        cmd.Parameters.AddWithValue("@bloodType", bloodType);
                        cmd.Parameters.AddWithValue("@donationDate", parsedDate);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@age", age);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!");
                            LoadUserData();
                        }
                        else
                        {
                            MessageBox.Show("No record was updated. Please check the selected record.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }
            }

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(date.Text.Trim(), out DateTime parsedDate))
            {
                MessageBox.Show("Invalid date format.");
                return;
            }
            if (parsedDate.Date != DateTime.Today)
            {
                MessageBox.Show("You can only enter today's date: " + DateTime.Today.ToString("yyyy-MM-dd"));
                return;
            }
        }
    }
}