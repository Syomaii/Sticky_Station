using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class Login : Form
    {
        public SqlConnection sqlCon;
        public Login()
        {
            InitializeComponent();
            sqlCon = new SqlConnection("Data Source=SYOMAIRAYS\\SQLEXPRESS;Initial Catalog=syomai;Integrated Security=True;");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUser.Text;
            string enteredPassword = txtBoxPass.Text;

            string adminQuery = "SELECT A_Password FROM ADMINISTRATOR WHERE A_Username = @Username";
            string custQuery = "SELECT C_Password FROM CUSTOMERS WHERE C_Username = @Username";

            
            SqlCommand adminCommand = new SqlCommand(adminQuery, sqlCon);
            adminCommand.Parameters.AddWithValue("@Username", username);

           
            SqlCommand custCommand = new SqlCommand(custQuery, sqlCon);
            custCommand.Parameters.AddWithValue("@Username", username);

            try
            {
                sqlCon.Open();

                SqlDataReader custReader = custCommand.ExecuteReader();
                if (custReader.Read())
                {
                    object custPasswordObject = custReader["C_Password"];
                    string hashedPassword = custPasswordObject == DBNull.Value ? null : custPasswordObject.ToString();
                    if (hashedPassword != null && VerifyPassword(enteredPassword, hashedPassword))
                    {
                        customerForm mainForm = new customerForm();
                        mainForm.ShowDialog();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                        return;
                    }
                }
                custReader.Close();

                SqlDataReader adminReader = adminCommand.ExecuteReader();
                if (adminReader.Read())
                {
                    object adminPasswordObject = adminReader["A_Password"];
                    string hashedPassword = adminPasswordObject == DBNull.Value ? null : adminPasswordObject.ToString();
                    if (hashedPassword != null && VerifyPassword(enteredPassword, hashedPassword))
                    {
                        AdminDashboard aDashboard = new AdminDashboard();
                        aDashboard.ShowDialog();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                        return;
                    }
                }
                

                else
                {
                    MessageBox.Show("User not found");
                }
                adminReader.Close();
                
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

        }

        private string HashPassword(string password)
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


        private bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            string hashedEnteredPassword = HashPassword(enteredPassword);
            return string.Equals(hashedEnteredPassword, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }





        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void chkBoxSPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSPwd.Checked)
            {
                txtBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
