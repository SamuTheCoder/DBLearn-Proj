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
    public partial class addDepartment : Form
    {
        private string university_name;
        private string connectionString = "Revoked;";
        private SqlConnection sqlConnection = null;
        public addDepartment(string university_name)
        {
            InitializeComponent();
            this.university_name = university_name;

            sqlConnection = new SqlConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addrBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string id = idBox.Text;
            string name = nameBox.Text;
            string address = addrBox.Text;
            string email = emailBox.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            try {
                sqlConnection.Open();
                if (sqlConnection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Connection to database failed");
                    return;
                }
                string query = $"INSERT INTO dblearn.department (department_id, department_name, department_address, " +
                    $"department_email, university_name) VALUES ('{id}', '{name}', '{address}', '{email}', '{this.university_name}')";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@department_id", id);
                    sqlCommand.Parameters.AddWithValue("@department_name", name);
                    sqlCommand.Parameters.AddWithValue("@department_address", address);
                    sqlCommand.Parameters.AddWithValue("@department_email", email);
                    sqlCommand.Parameters.AddWithValue("@university_name", this.university_name);

                    int affectedRows = sqlCommand.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Department added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add department");
                    }
                }
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Failed to add department: {ex.Message}");
            }
            finally
            {
                idBox.Text = "";
                nameBox.Text = "";
                addrBox.Text = "";
                emailBox.Text = "";
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
