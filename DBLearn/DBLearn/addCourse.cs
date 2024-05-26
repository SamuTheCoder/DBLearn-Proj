﻿using System;
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
    public partial class addCourse : Form
    {
        private string university_name;
        private SqlConnection sqlConnection = null;
        private string connectionString = "Revoked;";
        public addCourse(string university_name)
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(connectionString);
            this.university_name = university_name;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int course_id = int.Parse(idBox.Text);
            string course_name = nameBox.Text;
            string course_description = descBox.Text;
            int credits = int.Parse(creditsBox.Text);
            int department_id = int.Parse(deptBox.Text);

            try
            {
                sqlConnection.Open();

                string query = $"INSERT INTO dblearn.course (course_id, course_name, course_description, credits, department_id) VALUES " +
                    $"({course_id}, '{course_name}', '{course_description}', {credits}, {department_id})";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int affectedRows = sqlCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Course added successfully");
                }
                else
                {
                    MessageBox.Show("Failed to add course");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add course: " + ex.Message);
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
