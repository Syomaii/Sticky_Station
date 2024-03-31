using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class ManageUserAD : Form
    {
        SqlConnection con;
        public ManageUserAD()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=SYOMAIRAYS\\SQLEXPRESS;Initial Catalog=syomai;Integrated Security=True;");
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadDataGrid()
        {
            con.Open();
            SqlCommand com = new SqlCommand("Select * from CUST_REGISTERED_ACC", con);
            com.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvUsers.DataSource = data;
            con.Close();
        }

        private void ManageUserAD_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }
    }
}
