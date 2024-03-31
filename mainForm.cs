using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class customerForm : Form
    {
        public SqlConnection sqlCon;
        public SqlCommand cmd;
        public SqlDataAdapter dataAdapter;
        public SqlDataReader dataReader;

        private PictureBox product;
        private Label productName;
        private Label productPrice;
        public customerForm()
        {
            InitializeComponent();
            sqlCon = new SqlConnection("Data Source=SYOMAIRAYS\\SQLEXPRESS;Initial Catalog=syomai;Integrated Security=True;");
        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            sqlCon.Open();
            string query = "SELECT P_IMAGE, P_NAME, P_PRICE, PID FROM PRODUCTS";
            cmd = new SqlCommand(query, sqlCon);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                long len = dataReader.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dataReader.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                product = new PictureBox();
                product.Width = 162;
                product.Height = 170;
                product.BackgroundImageLayout = ImageLayout.Zoom;
                product.BorderStyle = BorderStyle.FixedSingle;
                product.BackColor = Color.FromArgb(140, 158, 189);
                product.Cursor = Cursors.Hand;
                product.Tag = dataReader["PID"].ToString();

                productPrice = new Label();
                double price = Convert.ToDouble(dataReader["P_PRICE"]); 
                string formattedPrice = String.Format("{0:0.00}", price);
                productPrice.Text = formattedPrice;
                productPrice.BackColor = Color.FromArgb(35, 40, 45);
                productPrice.ForeColor = Color.White;
                productPrice.Width = 70;
                productPrice.TextAlign = ContentAlignment.MiddleCenter;
                productPrice.Font = new Font("Cooper Black", 11, FontStyle.Regular);

                productName = new Label();
                productName.Text = dataReader["P_NAME"].ToString();
                productName.BackColor = Color.FromArgb(35, 40, 45);
                productName.ForeColor = Color.White;
                productName.Dock = DockStyle.Bottom;
                productName.Height = 30;
                productName.Font = new Font("Cooper Black", 12, FontStyle.Regular);
                productName.TextAlign = ContentAlignment.MiddleCenter;
                productName.Padding = new Padding(0, 5, 0, 0);

                MemoryStream ms = new MemoryStream(array);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                product.BackgroundImage = bitmap;

                product.Controls.Add(productPrice);
                product.Controls.Add(productName);
                orderbox.Controls.Add(product);

                product.Click += new EventHandler(OnClick);
            }
            dataReader.Close();
            sqlCon.Close();
            
        }

        private void OnClick(object sender, EventArgs e)
        {
            string tag = ((PictureBox)sender).Tag.ToString();
            string productName = "";
            double productPrice = 0.0;
            int availableQuantity = 0; 

            try
            {
                sqlCon.Open();
                string query = "SELECT P_NAME, P_PRICE, P_QUANTITY FROM PRODUCTS WHERE PID LIKE @Tag";
                cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@Tag", tag);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        productName = reader["P_NAME"].ToString();
                        availableQuantity = Convert.ToInt32(reader["P_QUANTITY"]);
                        productPrice = Convert.ToDouble(reader["P_PRICE"]);
                    }
                }

                bool productFound = false;
                foreach (DataGridViewRow row in receipt.Rows)
                {
                    if (row.Cells["OrderName"].Value.ToString() == productName)
                    {
                        productFound = true;
                        int quantity = Convert.ToInt32(row.Cells["ProductQuantity"].Value);
                        if (quantity < availableQuantity) 
                        {
                            row.Cells["Quantity"].Value = quantity + 1; // Increase quantity
                        }
                        else
                        {
                            MessageBox.Show("Maximum quantity reached for this product.");
                        }
                        break;
                    }
                }

                if (!productFound && availableQuantity > 0)
                {
                    receipt.Rows.Add(receipt.Rows.Count + 1, productName, 1,productPrice.ToString("#,##0.00"));
                }
                else if (availableQuantity <= 0)
                {
                    MessageBox.Show("Product is out of stock.");
                }
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

        private void receipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
