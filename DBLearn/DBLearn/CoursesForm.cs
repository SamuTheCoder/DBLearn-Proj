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
    public partial class CoursesForm : Form
    {
        private string university_name;
        private int department_id;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked";
        public CoursesForm(string university_name, int department_id)
        {
            InitializeComponent();

            this.university_name = university_name;
            this.department_id = department_id;
        }

        private void CourserForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        private void listCoursesBtn_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"SELECT * FROM dblearn.course WHERE department_id = '{this.department_id}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            using (addCourse addCourseForm = new addCourse(this.university_name))
            {
                if (addCourseForm.ShowDialog() == DialogResult.OK)
                {
                    listCoursesBtn_Click(sender, e);
                }
            }
        }

        private void rmvCourseBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to remove");
                return;
            }

            int course_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["course_id"].Value);

            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection to database failed");
                return;
            }
            string query = $"DELETE FROM dblearn.course WHERE department_id = '{department_id}' AND course_id = '{course_id}'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            listCoursesBtn_Click(sender, e);
        }

    }
}
