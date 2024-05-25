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
    public partial class addTeacher : Form
    {
        private string university_name;
        private string department_name;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked;";

        public addTeacher(string university_name, string department_name)
        {
            InitializeComponent();
            this.university_name = university_name;
            this.department_name = department_name;

            sqlConnection = new SqlConnection(connectionString);
        }

        private void addTeacher_Load(object sender, EventArgs e)
        {

        }

        private void submitTeacherBtn_Click(object sender, EventArgs e)
        {
            int professor_id = Convert.ToInt32(idBox.Text);
            string first_name = stNameBox.Text;
            string last_name = lstNameBox.Text;
            string email = emailBox.Text;
            int n_cc = Convert.ToInt32(ccBox.Text);
            string degree = degreeBox.Text;
            string hiring_date = hiringDateBox.Text;
            string gender = genderBox.Text;
            string course = courseBox.Text;

            try
            {
                sqlConnection.Open();
                if (sqlConnection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Connection to database failed");
                    return;
                }
                using (SqlTransaction transaction = sqlConnection.BeginTransaction())
                {
                    string insertTeacherQuery = $"INSERT INTO dblearn.teacher (professor_id, first_name, last_name, email," +
                        $"n_cc, degree, department_id, hiring_date, gender, course) VALUES ('{professor_id}', '{first_name}'," +
                        $" '{last_name}', '{email}', '{n_cc}', '{degree}', (SELECT department_id FROM dblearn.department WHERE" +
                        $" department_name = '{this.department_name}'), '{hiring_date}', '{gender}', '{course}')";

                    using (SqlCommand sqlCommand = new SqlCommand(insertTeacherQuery, sqlConnection, transaction))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    string insertWorksAtQuery = $"INSERT INTO dblearn.works_at (university_name, professor_id) VALUES ('{this.university_name}', '{professor_id}')";
                    using (SqlCommand sqlCommand = new SqlCommand(insertWorksAtQuery, sqlConnection, transaction))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    MessageBox.Show("Teacher added successfully");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
