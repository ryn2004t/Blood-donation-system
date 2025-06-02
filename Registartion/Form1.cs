using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodDonation;

namespace Registartion
{
    public partial class Registration: Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678");
      SqlCommand cmd = new SqlCommand();


        public string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Item 1");
            //comboBox1.Items.Add("Item 2");
            //comboBox1.Items.Add("Item 3");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {

        LoginForm loginForm = new LoginForm(); // Replace with the actual form name
        loginForm.Show();
        this.Hide(); // Hides the current form
    }

        private void Registration_Load(object sender, EventArgs e)
        {
           // cmd.CommandText = "insert into users values("
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text; // Hash this before storing!
            string role = comboBoxRole.SelectedItem.ToString(); // Admin or Donor

            //string connectionString = "server=DESKTOP-68EHAK4;database=BloodDonation;user=sa;password=12345678";

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
                conn.Open();
              String q= "INSERT INTO users (username, email, password, role) VALUES (@username, @email,  @password, @role)";

            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password); // Stored as a hash
                cmd.Parameters.AddWithValue("@role", role);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");
                    MessageBox.Show("Press Login Button");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
                conn.Close();
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            comboBoxRole.Text = "";
            }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           

           // return hasUpper && hasLower && hasSpecial;
        }
    }
    }
   

    
    
    
    

