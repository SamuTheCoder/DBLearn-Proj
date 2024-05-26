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
            uniLabel.Text = university_name;
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
            using (addStudent addStudentForm = new addStudent(this.university_name))
            {
                if (addStudentForm.ShowDialog() == DialogResult.OK)
                {
                    listStudsBtn_Click(sender, e);
                }
            }
        }

        private void rmvStudBtn_Click(object sender, EventArgs e)
        {
            if (studsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to remove");
                return;
            }

            try
            {
                string selectedStudentId = studsGridView.SelectedRows[0].Cells["student_id"].Value.ToString();
                sqlConnection.Open();
                string query = $"DELETE FROM dblearn.student WHERE student_id = '{selectedStudentId}'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int affectedRows = sqlCommand.ExecuteNonQuery();
                if (affectedRows == 0)
                {
                    MessageBox.Show("Failed to remove student");
                }
                else
                {
                    MessageBox.Show("Student removed successfully");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove student");
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void filterNameBtn_Click(object sender, EventArgs e)
        {
            string name = filterNameBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please insert a name to filter");
                return;
            }

            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            if (name.Contains(" "))
            {
                string[] names = name.Split(' ');
                string query = $"SELECT * FROM dblearn.student WHERE university_name = '{this.university_name}' AND first_name = '{names[0]}' AND last_name LIKE '%{names[1]}%'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                studsGridView.DataSource = dataTable;
            }
            else
            {
                string query = $"SELECT * FROM dblearn.student WHERE university_name = '{this.university_name}' AND first_name LIKE '%{name}%'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                studsGridView.DataSource = dataTable;
            }
            sqlConnection.Close();
        }

        private void filterDegreeBtn_Click(object sender, EventArgs e)
        {
            string degree_name = filterDegreeBox.Text;
            if (string.IsNullOrEmpty(degree_name))
            {
                MessageBox.Show("Please insert a degree to filter");
                return;
            }

            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string getDegreeId = $"SELECT degree_id FROM dblearn.degree WHERE degree_name = '{degree_name}'";
            SqlCommand getDegreeIdCommand = new SqlCommand(getDegreeId, sqlConnection);
            string degree_id = getDegreeIdCommand.ExecuteScalar().ToString();
            if (string.IsNullOrEmpty(degree_id))
            {
                MessageBox.Show("Degree not found");
                return;
            }
            string query = $"SELECT * FROM dblearn.student WHERE university_name = '{this.university_name}' AND degree_id = '{degree_id}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            studsGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void filterGenderBtn_Click(object sender, EventArgs e)
        {
            string gender = filterGenderBox.Text;
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please insert a gender");
            }

            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT * FROM dblearn.student WHERE university_name = '{this.university_name}' AND gender = '{gender}' ";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            studsGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void updateStudBtn_Click(object sender, EventArgs e)
        {
            if(studsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update");
                return;
            }
            string address = addrBox.Text;
            if(string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please insert an address");
                return;
            }
            int student_id = Convert.ToInt32(studsGridView.SelectedRows[0].Cells["student_id"].Value);

            if(studsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update");
                return;
            }

            try
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand("UpdateStudentAddress", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@student_id", student_id);
                    sqlCommand.Parameters.AddWithValue("@new_address", address);

                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    if(affectedRows > 0)
                    {
                        MessageBox.Show("Student updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update student");
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update student: {ex.Message}");
            }
            finally
            {
                addrBox.Text = "";
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
