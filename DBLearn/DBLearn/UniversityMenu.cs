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
    public partial class UniversityMenu : Form
    {
        private string university_name;
        private string university_address;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked";
        public UniversityMenu(string university_name, string university_address)
        {
            InitializeComponent();

            this.university_name = university_name;
            this.university_address = university_address;
        }

        private void UniversityMenu_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);

            uniLabel.Text = university_name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uniLabel_Click(object sender, EventArgs e)
        {
        }

        private void departmentsBtn_Click(object sender, EventArgs e)
        {
            DepartmentsForm departmentsForm = new DepartmentsForm(university_name, university_address);
            departmentsForm.Show();
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm(university_name, university_address);
            studentsForm.Show();
        }

        private void degreesBtn_Click(object sender, EventArgs e)
        {
            DegreesForm degreesForm = new DegreesForm(university_name, university_address);
            degreesForm.Show();
        }
    }
}
