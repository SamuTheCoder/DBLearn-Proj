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
        private int selectedDepartmentId;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked;";
        public DepartmentsForm(string university_name, string university_address)
        {
            InitializeComponent();
            this.university_name = university_name;
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

        private void deptGridView_selectionChanged(object sender, EventArgs e)
        {
            if (deptGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = deptGridView.SelectedRows[0];
                selectedDepartmentId = Convert.ToInt32(selectedRow.Cells["department_id"].Value);
            }
        }

        private void addDeptBtn_Click(object sender, EventArgs e)
        {
            using (addDepartment addDept = new addDepartment(university_name))
            {
                if (addDept.ShowDialog() == DialogResult.OK)
                {
                    listDeptsBtn_Click(sender, e);
                }
            }
        }

        private void removeDeptBtn_Click(object sender, EventArgs e)
        {
            if (deptGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department to remove");
                return;
            }

            string selectedDeptID = deptGridView.SelectedRows[0].Cells["department_id"].Value.ToString();

            try
            {
                sqlConnection.Open();
                string query = $"DELETE FROM dblearn.department WHERE department_id = '{selectedDeptID}'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int affectedRows = sqlCommand.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Department removed successfully");
                }
                else
                {
                    MessageBox.Show("Failed to remove department");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove department: {ex.Message}");
            }
            finally
            {
                selectedDeptID = "";
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchBox.Text;
            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a department name to search");
                return;
            }

            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT * FROM dblearn.department WHERE university_name = '{this.university_name}' AND department_name LIKE '%{searchQuery}%'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.SelectCommand = sqlCommand;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            deptGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void teachersBtn_Click(object sender, EventArgs e)
        {
            if (deptGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department to view teachers");
                return;
            }

            DataGridViewRow selectedRow = deptGridView.SelectedRows[0];
            if (selectedRow == null || selectedRow.Cells["department_id"].Value == null)
            {
                MessageBox.Show("Please select a valid department to view teachers");
                return;
            }

            string department_name = selectedRow.Cells["department_name"].Value.ToString();

            TeachersForm teachersForm = new TeachersForm(university_name, department_name);
            teachersForm.Show();
        }

        private void goToCourseBtn_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Department ID couldn't be verified");
                return;
            }
            string query = $"SELECT * FROM dblearn.department WHERE department_id = '{selectedDepartmentId}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (count == 0)
            {
                MessageBox.Show("Department ID is invalid");
                sqlConnection.Close();
                return;
            }
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            if (!string.IsNullOrEmpty(university_name))
            {
                CoursesForm coursesForm = new CoursesForm(university_name, selectedDepartmentId);
                coursesForm.Show();
            }
        }

        private void calcDeptCredsBtn_Click(object sender, EventArgs e)
        {
            if(deptGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a department to calculate credits");
                return;
            }

            int department_id = Convert.ToInt32(deptGridView.SelectedRows[0].Cells["department_id"].Value);
            int totalCredits = GetTotalCreditsFromDept(department_id);
            MessageBox.Show($"Total credits for department {department_id}: {totalCredits}");
        }

        private int GetTotalCreditsFromDept(int department_id)
        {
            sqlConnection.Open();

            int totalCredits = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT dblearn.GetTotalCreditsByDepartment(@department_id)", sqlConnection))
            {
                cmd.Parameters.AddWithValue("@department_id", department_id);
                totalCredits = Convert.ToInt32(cmd.ExecuteScalar());
            }

            sqlConnection.Close();
            return totalCredits;
        }
    }
}
