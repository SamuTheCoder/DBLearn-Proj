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
    public partial class DegreesForm : Form
    {
        private string university_name;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked;";
        private int selectedDegreeId;
        public DegreesForm(string university_name, string university_address)
        {
            InitializeComponent();

            this.university_name = university_name;
        }

        private void DegreesForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);

            uniLabel.Text = university_name;
        }

        private void listDegreeBtn_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT * FROM dblearn.degree WHERE university_name = '{this.university_name}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            degreeGridView.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void addDegreeBtn_Click(object sender, EventArgs e)
        {
            using (addDegree addDegreeForm = new addDegree(this.university_name))
            {
                if (addDegreeForm.ShowDialog() == DialogResult.OK)
                {
                    listDegreeBtn_Click(sender, e);
                }
            }
        }

        private void rmvDegreeBtn_Click(object sender, EventArgs e)
        {
            if (degreeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a degree to remove");
                return;
            }

            try
            {
                string selectedDegree = degreeGridView.SelectedRows[0].Cells["degree_id"].Value.ToString();
                sqlConnection.Open();              
                string query = $"DELETE FROM dblearn.degree WHERE degree_id = '{selectedDegree}'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int affectedRows = sqlCommand.ExecuteNonQuery();
                if (affectedRows == 0)
                {
                    MessageBox.Show("Failed to remove degree");
                }
                else
                {
                    MessageBox.Show("Degree removed successfully");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove degree");
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }

        private void goToCoursesBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(university_name))
            {
                CoursesForm coursesForm = new CoursesForm(university_name, selectedDegreeId);
                coursesForm.Show();
            }
        }

        private void degreeGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (degreeGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = degreeGridView.SelectedRows[0];
                selectedDegreeId = Convert.ToInt32(selectedRow.Cells["degree_id"].Value);
            }
        }

        private void degreeCourseBtn_Click(object sender, EventArgs e)
        {
            if(degreeGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a degree to view courses");
                return;
            }
            string selectedDegreeId = degreeGridView.SelectedRows[0].Cells["degree_id"].Value.ToString();
            if(string.IsNullOrEmpty(selectedDegreeId))
            {
                MessageBox.Show("Please select a degree to view courses");
                return;
            }
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT c.course_id, c.course_name, c.course_description, c.credits, " +
                $"d.university_name FROM dblearn.has_courses AS hc INNER JOIN dblearn.course AS c ON " +
                $"hc.course_id = c.course_id INNER JOIN dblearn.degree AS d ON hc.degree_id = d.degree_id WHERE hc.degree_id = '{selectedDegreeId}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            degreeGridView.DataSource = dataTable;
            sqlConnection.Close();
        }
    }
}
