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

namespace DBLearn
{
    public partial class StudentsForm : Form
    {
        private string university_name;
        private string university_address;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked";

        public StudentsForm(string university_name, string university_address)
        {
            InitializeComponent();
            this.university_name = university_name;
            this.university_address = university_address;
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        private void listStudsBtn_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT * FROM dblearn.student WHERE university_name = '{this.university_name}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            studsGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void addStudBtn_Click(object sender, EventArgs e)
        {
            using(addStudent addStudentForm = new addStudent())
            {
                if(addStudentForm.ShowDialog() == DialogResult.OK)
                {
                    listStudsBtn_Click(sender, e);
                }
            }
        }
    }
}
