using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP_I__02_
{
    public partial class ProfileForm : Form
    {
        private readonly string userEmail;
        //private readonly string supEmail;
        public ProfileForm(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            LoadProfileInfo();
            LoadSubordinate();
            LoadPreviousJobsData();
            LoadWorkWith();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHire_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadProfileInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"SELECT employee.name AS EmployeeName, 
                                   employee.email AS EmployeeEmail, 
                                   employee.phone_number AS EmployeePhoneNumber, 
                                   employee.hire_date AS EmployeeHireDate,
                                   job.name AS JobName,
                                   job_level.name AS jobLevelName,
                                   department.name AS DepartmentName
                            FROM position
                            JOIN job ON position.job_id = job.id
                            JOIN job_level ON job.job_level_id = job_level.id
                            JOIN department ON job.department_id = department.id
                            JOIN employee ON position.employee_id = employee.id
                            WHERE employee.email = @email AND employee.deleted_at IS NULL";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["EmployeeName"].ToString();
                                txtPhone.Text = reader["EmployeePhoneNumber"].ToString();
                                txtEmail.Text = reader["EmployeeEmail"].ToString();
                                txtHire.Text = reader["EmployeeHireDate"].ToString();
                                txtPost.Text = reader["JobName"].ToString();
                                txtLevel.Text = reader["jobLevelName"].ToString();
                                txtDep.Text = reader["DepartmentName"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Informasi profil tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close(); // Tutup form jika informasi tidak ditemukan
                            }
                        }
                    }

                    txtName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtHire.ReadOnly = true;
                    txtPost.ReadOnly = true;
                    txtLevel.ReadOnly = true;
                    txtDep.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadPreviousJobsData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"SELECT department.name AS Department, 
                                   job.name AS Position
                            FROM position
                            JOIN job ON position.job_id = job.id
                            JOIN department ON job.department_id = department.id
                            JOIN employee ON position.employee_id = employee.id
                            WHERE employee.email = @email AND position.deleted_at IS NOT NULL
                            ORDER BY position.deleted_at DESC;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);

                        // Set data source untuk DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubordinate()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"SELECT employee.name AS EmployeeName, job.name AS JobName
                              FROM employee
                              JOIN position ON employee.id = position.employee_id
                              JOIN job ON position.job_id = job.id
                              where job.job_level_id < 4;";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);

                        // Set data source 
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWorkWith()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"
                SELECT e.name AS EmployeeName, j.name AS JobName
                FROM position p
                INNER JOIN employee e ON e.id = p.employee_id
                INNER JOIN job j ON j.id = p.job_id
                WHERE j.supervisor_job_id IN (
                    SELECT j1.id
                    FROM employee e1
                    INNER JOIN position p1 ON e1.id = p1.employee_id
                    INNER JOIN job j1 ON j1.id = p1.job_id
                    WHERE e1.email = @email
                )
            ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);

                        // Set data source 
                        dataGridView3.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen(userEmail);
            mainScreen.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DirectSuper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Dapatkan data employee dengan job_level.id = 3 dan supervisor_job_id = job.id
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"
                SELECT e.email AS EmployeeEmail
                FROM employee e
                INNER JOIN position p ON e.id = p.employee_id
                INNER JOIN job j ON j.id = p.job_id
                WHERE j.job_level_id > 1
                  AND j.supervisor_job_id = (
                      SELECT j1.id
                      FROM employee e1
                      INNER JOIN position p1 ON e1.id = p1.employee_id
                      INNER JOIN job j1 ON j1.id = p1.job_id
                      WHERE e1.email = @email
                  )
            ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Dapatkan email employee dengan job_level.id = 3 dan supervisor_job_id = job.id
                                string employeeEmail = reader["EmployeeEmail"].ToString();

                                // Buka halaman profil baru dengan parameter employeeEmail
                                ProfileForm newProfileForm = new ProfileForm(employeeEmail);
                                newProfileForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Anda tidak memiliki SuperVisor.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
