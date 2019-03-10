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
    

    public partial class FormLogin : Form
    {
        
        string user;



        public FormLogin()
        {
            InitializeComponent();
            txtLoginPassword.PasswordChar = '*';
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = OfficeComputer\SQLEXPRESS; Initial Catalog = UserRegistrationDB; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tblUser WHERE Username='" + txtLoginUsername.Text + "' and Password='" + txtLoginPassword.Text + "' ";
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and password are correct");
                    user = txtLoginUsername.Text;
                    Form3 f3 = new Form3(user);
                    f3.ShowDialog();
                    this.Close();

                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password");
                }
                else
                {
                    MessageBox.Show("Username and password is not correct");
                }
                connection.Close();
            }
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3("Guest");
            f3.ShowDialog();
            this.Close();
        }
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegistration f2 = new frmRegistration();
            f2.ShowDialog();
            this.Close();
        }

        

        

        
    }
}
