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
    public partial class TeachersForm : Form
    {
        private string university_name;
        private string department_name;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked;";

        public TeachersForm(string university_name, string department_name)
        {
            InitializeComponent();
            this.university_name = university_name;
            this.department_name = department_name;
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            uniLabel.Text = university_name;
            departmentLabel.Text = department_name;
        }

        private void uniLabel_Click(object sender, EventArgs e)
        {

        }

        private void listTeachersBtn_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT * FROM dblearn.teacher JOIN dblearn.works_at ON teacher.professor_id = " +
                $"works_at.professor_id WHERE works_at.university_name = '{this.university_name}' AND " +
                $"teacher.department_id = (SELECT department_id FROM dblearn.department WHERE department_name = '{this.department_name}')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void searchTeacherBtn_Click(object sender, EventArgs e)
        {
            string search = searchTeacherBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Please enter a name to search for");
                return;
            }
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT * FROM dblearn.teacher JOIN dblearn.works_at ON teacher.professor_id = " +
                $"works_at.professor_id WHERE works_at.university_name = '{this.university_name}' AND " +
                $"teacher.department_id = (SELECT department_id FROM dblearn.department WHERE department_name = '{this.department_name}') AND " +
                $"teacher.first_name LIKE '%{search}%'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            sqlConnection.Close();
        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            using (addTeacher addTeacher = new addTeacher(university_name, department_name))
            {
                if (addTeacher.ShowDialog() == DialogResult.OK)
                {
                    listTeachersBtn_Click(sender, e);
                }
            }

        }

        private void rmvTeacherBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to remove");
                return;
            }

            string professor_id = dataGridView1.SelectedRows[0].Cells["professor_id"].Value.ToString();
            if (string.IsNullOrEmpty(professor_id))
            {
                MessageBox.Show("Please select a valid teacher to remove");
                return;
            }

            try
            {
                sqlConnection.Open();
                using (SqlTransaction transaction = sqlConnection.BeginTransaction())
                {
                    string removeWorksAtQuery = $"DELETE FROM dblearn.works_at WHERE university_name = '{this.university_name}' AND professor_id = '{professor_id}'";
                    using (SqlCommand sqlCommand = new SqlCommand(removeWorksAtQuery, sqlConnection, transaction))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }

                    string removeTeacherQuery = $"DELETE FROM dblearn.teacher WHERE department_id = (SELECT department_id FROM dblearn.department WHERE department_name = '{this.department_name}')" +
                        $" AND professor_id = '{professor_id}'";
                    using (SqlCommand sqlCommand = new SqlCommand(removeTeacherQuery, sqlConnection, transaction))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    MessageBox.Show("Teacher removed successfully");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove teacher: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
