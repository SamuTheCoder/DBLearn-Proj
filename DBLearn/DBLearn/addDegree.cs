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
    public partial class addDegree : Form
    {
        private string university_name;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked;";

        public addDegree(string university_name)
        {
            InitializeComponent();

            this.university_name = university_name;
            sqlConnection = new SqlConnection(connectionString);
        }

        private void submitDegreeBtn_Click(object sender, EventArgs e)
        {
            int degree_id = int.Parse(idBox.Text);
            string degree_name = nameBox.Text;
            string degree_level = levelBox.Text;
            int degree_credits = int.Parse(creditsBox.Text);
            string prerequisite = prereqsBox.Text;
            int department_id = int.Parse(deptIdBox.Text);
            string university_name = this.university_name;

            try
            {
                sqlConnection.Open();
                if (sqlConnection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Connection to database failed");
                    return;
                }
                string query = $"INSERT INTO dblearn.degree (degree_id, degree_name, degree_level, credits, prerequisites, department_id, university_name) VALUES " +
                    $"({degree_id}, '{degree_name}', '{degree_level}', {degree_credits}, '{prerequisite}', {department_id}, '{university_name}')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int affectedRows = sqlCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Degree added successfully");
                }
                else
                {
                    MessageBox.Show("Failed to add degree");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add degree: " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }

        private void addDegree_Load(object sender, EventArgs e)
        {

        }
    }
}
