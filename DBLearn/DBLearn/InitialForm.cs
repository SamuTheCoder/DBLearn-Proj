using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBLearn
{
    public partial class InitialForm : Form
    {

        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked";
        private string selectedUniversityName;
        private string selectedUniversityAddress;
        public InitialForm()
        {
            InitializeComponent();

            universityDataGrid.SelectionChanged += UniversityDataGrid_selectionChanged;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            MessageBox.Show("Connection Open");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void university_btn_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM dblearn.university";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            universityDataGrid.DataSource = dataTable;
        }

        private void addUniversityBtn_Click(object sender, EventArgs e)
        {
            string universityName = universityNameTextBox.Text;
            string universityAddress = universityAddrTextBox.Text;

            if (string.IsNullOrEmpty(universityName) || string.IsNullOrEmpty(universityAddress))
            {
                MessageBox.Show("Please fill in the university name and address");
                return;
            }

            try
            {
                string sqlQuery = $"INSERT INTO dblearn.university (university_name, university_address) VALUES ('{universityName}', '{universityAddress}')";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@university_name", universityName);
                    sqlCommand.Parameters.AddWithValue("@university_address", universityAddress);

                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("University added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add university");
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add university: {ex.Message}");
            }
            finally
            {
                universityNameTextBox.Text = "";
                universityAddrTextBox.Text = "";             
            }
        }

        private void removeUniversityBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUniversityName) || string.IsNullOrEmpty(selectedUniversityAddress))
            {
                MessageBox.Show("Please select a university row first");
                return;
            }
            try
            {
                string sqlQuery = $"DELETE FROM dblearn.university WHERE university_name = '{selectedUniversityName}' AND university_address = '{selectedUniversityAddress}'";
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("University removed successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove university");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove university: {ex.Message}");
            }
            finally
            {
                selectedUniversityName = "";
                selectedUniversityAddress = "";
            }
        }
        private void UniversityDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UniversityDataGrid_selectionChanged(object sender, EventArgs e)
        {
            if (universityDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = universityDataGrid.SelectedRows[0];
                selectedUniversityName = selectedRow.Cells["university_name"].Value.ToString();
                selectedUniversityAddress = selectedRow.Cells["university_address"].Value.ToString();
                MessageBox.Show($"Selected University: {selectedUniversityName} at {selectedUniversityAddress}");
            }
        }
        private void goToUniversity_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(selectedUniversityName) && !string.IsNullOrEmpty(selectedUniversityAddress))
            {
                UniversityMenu universityMenu = new UniversityMenu(selectedUniversityName, selectedUniversityAddress);
                universityMenu.Show();
            }
            else
            {
                MessageBox.Show("Please select a university row first");
            }
        }
    }
}
