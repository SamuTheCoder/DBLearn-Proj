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
    public partial class addStudent : Form
    {
        private string university_name;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked;";

        public addStudent(string university_name)
        {
            InitializeComponent();

            this.university_name = university_name;
        }

        private void addStudent_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idBox.Text);
            string first_name = stNameBox.Text;
            string last_name = lstNameBox.Text;
            string email = emailBox.Text;
            string address = addrBox.Text;
            string gender = genderBox.Text;
            int cc = int.Parse(ccBox.Text);
            int degree_id = int.Parse(degreeBox.Text);

            try
            {
                sqlConnection.Open();

                string query = $"INSERT INTO dblearn.student (student_id, first_name, last_name, gender, " +
                    $"email, degree_id, n_cc, student_address, university_name) VALUES ({id}, '{first_name}', " +
                    $"'{last_name}', '{gender}', '{email}', {degree_id}, {cc}, '{address}', '{this.university_name}')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int affectedRows = sqlCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Student added successfully");
                }
                else
                {
                    MessageBox.Show("Student not added");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
