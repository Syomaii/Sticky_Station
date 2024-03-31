using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LogInForm
{
    public partial class AdminDashboard : Form
    {
        static bool sidebarExpand;
        SqlConnection con;
        public AdminDashboard()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=SYOMAIRAYS\\SQLEXPRESS;Initial Catalog=syomai;Integrated Security=True;");
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            panelView.Visible = false;
            panelView.Enabled = false; 
            panelAddUsers.Visible = false;
            panelAddUsers.Enabled = false;
            panelAddProd.Enabled = false;
            panelAddProd.Visible = false;
            panelOrders.Enabled = false;
            panelOrders.Visible = false;
            panelProd.Visible = false;
            panelProd.Enabled = false; 
            panelOrders.Enabled = false;
            logoPic.BringToFront();
            lblAdmin.BringToFront();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) 
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width) 
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
                
        private void loadDataGridUsers()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT C_ID AS CustomerID," +
                                "C_Username AS Username," +
                                "C_Firstname AS Firstname," +
                                "C_Lastname AS Lastname," +
                                "C_Age AS Age," +
                                "C_Email AS Email," +
                                "C_Address AS Address," +
                                "C_UserType AS Type " + 
                                "FROM CUSTOMERS", con);

            com.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvView.DataSource = data;
            con.Close();
        }

        private void loadDataGridProducts()
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT P_ID AS ProductID, " +
                                       "P_IMAGE AS ProductImage, " +
                                       "P_NAME AS ProductName, " +
                                       "P_QUANTITY AS ProductQuantity, " +
                                       "P_PRICE AS ProductPrice " +
                                 "FROM PRODUCTS", con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                data.Clear();
                dataAdapter.Fill(data);
                dgvProducts.DataSource = data;
                DataGridViewImageColumn pImage = new DataGridViewImageColumn();
                pImage = (DataGridViewImageColumn)dgvProducts.Columns[1];
                pImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
                /*
                 SqlCommand com = new SqlCommand("SELECT P_ID AS ProductID, " +
                                       "P_IMAGE, " +
                                       "P_NAME AS ProductName, " +
                                       "P_QUANTITY AS ProductQuantity, " +
                                       "P_PRICE AS ProductPrice " +
                                 "FROM PRODUCTS", con);

                SqlDataReader reader = com.ExecuteReader();

                DataTable data = new DataTable();
                data.Load(reader);
                data.Columns.Add("PIMAGE", typeof(byte[]));
                foreach (DataRow row in data.Rows)
                {
                    string imagePath = row["PIMAGE"].ToString();
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        row["PIMAGE"] = File.ReadAllBytes(imagePath);
                    }
                }

                dgvProducts.DataSource = data;
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void loadDataGridOrders()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT O_ID AS OrderId," +
                    "PRODUCT_ID AS ProductID," +
                    "PRODUCT_NAME AS ProductName," +
                    "ORDERED_QUANTITY AS OrderedQuantity," +
                    "PRODUCT_PRICE AS ProductPrice," +
                    "ORDER_TOTAL_PRICE AS OrderTotalPrice," +
                    "ORDER_DATE AS OrderDate " +
                    "FROM ORDERS", con);


            com.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvOrders.DataSource = data;
            con.Close();
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelAddUsers.Visible = false;
            panelAddUsers.Enabled = false;
            panelAddProd.Visible = false;
            panelAddProd.Enabled = false;
            panelView.Enabled = false;
            panelView.Visible = false;
            panelProd.Visible = false;
            panelProd.Enabled = false;
            panelOrders.Enabled = false;
            panelOrders.Visible = false;
            lblAdmin.Visible = true;
            logoPic.Visible = true;
            sidebar.BringToFront();
            searchUsers.BringToFront();
            clearSBarUsers.BringToFront();
            sidebarTimer.Start();
            if (sidebarExpand)
            {
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            logoPic.Visible = false;
            panelView.Visible = false;
            panelView.Enabled = false;
            panelOrders.Visible = false;
            panelOrders.Enabled = false;
            panelProd.Enabled = true;
            panelProd.Visible = true;
            panelAddUsers.Visible = false;
            panelAddUsers.Enabled = false;
            panelAddProd.Visible = false;
            panelAddProd.Enabled = false;
            panelOrders.Enabled = false;
            panelOrders.Visible = false;
            panelProd.BringToFront();
            sidebar.BringToFront();
            sidebarTimer.Start();
            if (sidebarExpand)
            {
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            loadDataGridProducts();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            logoPic.Visible = false;
            panelView.Visible = false;
            panelView.Enabled = false;
            panelProd.Enabled = false;
            panelProd.Visible = false;
            panelAddUsers.Visible = false;
            panelAddUsers.Enabled = false;
            panelAddProd.Visible = false;
            panelAddProd.Enabled = false;
            panelOrders.Enabled = true;
            panelOrders.Visible = true;
            panelOrders.BringToFront();
            sidebar.BringToFront();
            sidebarTimer.Start();
            if (sidebarExpand)
            {
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            loadDataGridOrders();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            logoPic.Visible = false;
            panelView.Visible = true;
            panelView.Enabled = true;
            panelOrders.Visible = false;
            panelOrders.Enabled = false;
            panelProd.Enabled = false;
            panelProd.Visible = false;
            panelAddUsers.Visible = false;
            panelAddUsers.Enabled = false;
            panelAddProd.Visible = false;
            panelAddProd.Enabled = false;
            panelOrders.Enabled = false;
            panelOrders.Visible = false;
            panelView.BringToFront();
            sidebar.BringToFront();
            sidebarTimer.Start();
            if (sidebarExpand)
            {
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            loadDataGridUsers();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeAdd_Click(object sender, EventArgs e)
        {
            panelAddUsers.Visible = false;
            panelAddUsers.Enabled = false;
            lblAdmin.Visible = true;
            logoPic.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(rbtnAdmin.Checked)
            {
                string Firstname = txtBoxFName.Text;
                string Lastname = txtBoxLname.Text;
                string Age = txtBoxAge.Text;
                string Email = txtBoxEmail.Text;
                string Address = txtBoxAddress.Text;
                string Username = txtBoxUName.Text;
                string Password = txtBoxPassword.Text;

                string insertQuery = @"INSERT INTO ADMINISTRATOR (A_Firstname, A_Lastname, A_Age, A_Email, A_Address, A_UserType, A_Username, A_Password)
                      VALUES (@Firstname, @Lastname, @Age, @Email, @Address, 'admin', @Username, @Password)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Firstname", Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", Lastname);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(Age));
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Administrator added successfully.");
                            txtBoxFName.Clear();
                            txtBoxLname.Clear();
                            txtBoxAge.Clear();
                            txtBoxEmail.Clear();
                            txtBoxAddress.Clear();
                            rbtnAdmin.Checked = false;
                            txtBoxUName.Clear();
                            txtBoxPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add admin.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else if(rbtnCustomer.Checked)
            {
                string Firstname = txtBoxFName.Text;
                string Lastname = txtBoxLname.Text;
                string Age = txtBoxAge.Text;
                string Email = txtBoxEmail.Text;
                string Address = txtBoxAddress.Text;
                string Username = txtBoxUName.Text;
                string Password = txtBoxPassword.Text;

                string encryptedPwd = EncryptPassword(Password);

                string insertQuery = @"INSERT INTO CUSTOMERS (C_Firstname, C_Lastname, C_Age, C_Email, C_Address, C_UserType, C_Username, C_Password)
                      VALUES (@Firstname, @Lastname, @Age, @Email, @Address, 'customer', @Username, @Password)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Firstname", Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", Lastname);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(Age));
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", encryptedPwd);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully.");
                            txtBoxFName.Clear();
                            txtBoxLname.Clear();
                            txtBoxAge.Clear();
                            txtBoxEmail.Clear();
                            txtBoxAddress.Clear();
                            rbtnCustomer.Checked = false;
                            txtBoxUName.Clear();
                            txtBoxPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                loadDataGridUsers();
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            uploadPhoto.Filter = "Select image(*.JpG; *.png; *.Gif) | *.JpG; *.png; *.Gif";
            if(uploadPhoto.ShowDialog() == DialogResult.OK)
            {
                prodImage.Image = Image.FromFile(uploadPhoto.FileName);
                txtBoxImgPath.Text = uploadPhoto.FileName;
            }
        }

        private void closeProd_Click(object sender, EventArgs e)
        {
            panelAddUsers.Visible = false;
            panelAddUsers.Enabled = false;
            panelAddProd.Enabled = false;
            panelAddProd.Visible = false;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            MemoryStream memstr = new MemoryStream();
            prodImage.Image.Save(memstr, prodImage.Image.RawFormat);
            string PName = txtBoxPName.Text;
            string PDesc = txtBoxPDesc.Text;
            int PQuantity = int.Parse(txtBoxQuantity.Text); // Assuming P_Quantity is an INT field
            double PPrice = double.Parse(txtBoxPrice.Text); // Assuming P_Price is a DOUBLE field

            string insertQuery = @"INSERT INTO PRODUCTS (P_IMAGE, P_NAME, P_QUANTITY, P_PRICE, P_DESCRIPTION)
                           VALUES (@Image, @Name, @Quantity, @Price, @Description)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@Image", memstr.ToArray());
                cmd.Parameters.AddWithValue("@Name", PName);
                cmd.Parameters.AddWithValue("@Quantity", PQuantity);
                cmd.Parameters.AddWithValue("@Price", PPrice);
                cmd.Parameters.AddWithValue("@Description", PDesc);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added successfully.");
                        prodImage.Image = null;
                        txtBoxImgPath.Clear();
                        txtBoxImgPath.Clear();
                        txtBoxPName.Clear();
                        txtBoxPDesc.Clear();
                        txtBoxQuantity.Clear();
                        txtBoxPrice.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            loadDataGridProducts();
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            panelAddUsers.Visible = false;
            panelAddUsers.Enabled = false;
            panelView.Enabled = false;
            panelView.Visible = false;
            panelOrders.Enabled = false;
            panelOrders.Visible = false;
            panelOrders.Enabled = false;
            panelOrders.Visible = false;
            panelAddProd.Visible = true;
            panelAddProd.Enabled = true;
            panelAddProd.BringToFront();

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            panelAddProd.Visible = false;
            panelAddProd.Enabled = false;
            panelView.Enabled = false;
            panelView.Visible = false;
            panelOrders.Enabled = false;
            panelOrders.Visible = false;
            panelOrders.Enabled = false;
            panelOrders.Visible = false;
            panelAddUsers.Visible = true;
            panelAddUsers.Enabled = true;
            panelAddUsers.BringToFront();
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
