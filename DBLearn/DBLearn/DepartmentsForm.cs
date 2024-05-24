using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLearn
{
    public partial class DepartmentsForm : Form
    {
        private string university_name;
        private string university_address;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked";
        public DepartmentsForm(string university_name, string university_address)
        {
            InitializeComponent();
            this.university_name = university_name;
            this.university_address = university_address;
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            deptUniLabel.Text = university_name;
        }

        private void deptUniLabel_Click(object sender, EventArgs e)
        {

        }

        private void listDeptsBtn_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT * FROM dblearn.department WHERE university_name = '{this.university_name}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            deptGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void deptGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
