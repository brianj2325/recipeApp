using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RecipeFormApp
{
    public partial class frmRegistration : Form
    {

        string connectionString = @"Data Source = OfficeComputer\SQLEXPRESS; Initial Catalog = UserRegistrationDB; Integrated Security=True;";

        public frmRegistration()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtConfirmPsswd.PasswordChar = '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill in the mandatory fields");
            else if (txtPassword.Text != txtConfirmPsswd.Text)
                MessageBox.Show("Passwords do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successful");
                    Clear();
                }
            }
        }

        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtUsername.Text = txtPassword.Text = txtConfirmPsswd.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fr1 = new FormLogin();
            fr1.ShowDialog();
            this.Close();
        }
    }
}
