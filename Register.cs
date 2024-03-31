using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class Register : Form
    {
        public SqlConnection connection;
        public Register()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=SYOMAIRAYS\\SQLEXPRESS;Initial Catalog=syomai;Integrated Security=True;");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text;
            string username = txtBoxUser.Text;
            string password = txtBoxPass.Text;
            string confPassword = txtBoxConfPass.Text;

            string encryptedPassword = EncryptPassword(password);

            if (password != confPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            string query;
            string message;

            if (rbtnAdmin.Checked)
            {
                if (IsAdminUsernameTaken(username))
                {
                    MessageBox.Show("Username is taken by another admin");
                    return;
                }

                query = "INSERT INTO ADMINISTRATOR ( A_Email, A_Username, A_Password) VALUES (@Email, @Username, @Password);";
                message = "Admin registration successful";
            }
            else if (rbtnCust.Checked)
            {
                if (IsCustomerUsernameTaken(username))
                {
                    MessageBox.Show("Username is taken by another customer");
                    return;
                }

                query = "INSERT INTO CUSTOMERS ( C_Email, C_Username, C_Password) VALUES (@Email, @Username, @Password);";
                message = "Customer registration successful";
            }
            else
            {
                MessageBox.Show("Please select user type");
                return;
            }

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", encryptedPassword);
                command.ExecuteNonQuery();

                MessageBox.Show(message);
                txtBoxEmail.Clear();
                txtBoxUser.Clear();
                txtBoxPass.Clear();
                txtBoxConfPass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }



        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsAdminUsernameTaken(string username)
        {
            bool isUATaken = false;

            string query = "SELECT COUNT(*) FROM ADMINISTRATOR WHERE A_Username = @Username";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", username);

            try
            {
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    isUATaken = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                connection.Close();
            }

            return isUATaken;
        }

        private bool IsCustomerUsernameTaken(string username)
        {
            bool isUCTaken = false;

            string query = "SELECT COUNT(*) FROM ADMINISTRATOR WHERE C_Username = @Username";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", username);

            try
            {
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    isUCTaken = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                connection.Close();
            }


            return isUCTaken;
        }

        private void chkBoxSPwd_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPass.UseSystemPasswordChar = false;
            txtBoxConfPass.UseSystemPasswordChar = false;

        }
    }
}
