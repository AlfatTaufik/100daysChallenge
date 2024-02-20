using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DESKTOP_I__02_
{
    public partial class PromotionPage : Form
    {
        private readonly string userEmail;

        public PromotionPage(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            LoadProfileInfo();
            LoadDataForDataGridView();
        }

        private void LoadProfileInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"
                        SELECT employee.name AS EmployeeName, 
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
                                txtPost.Text = reader["JobName"].ToString();
                                txtCur.Text = reader["jobLevelName"].ToString();
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
                    txtPost.ReadOnly = true;
                    txtCur.ReadOnly = true;
                    txtDep.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataForDataGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"
                        SELECT department.name AS Department, 
                               job.name AS Position
                        FROM job
                        JOIN job_level ON job.job_level_id > job_level.id
                        JOIN department ON job.department_id = department.id
                        WHERE job_level.name = @currentJobLevel";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@currentJobLevel", txtCur.Text);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);

                        // Clean
                        dataGridView1.Columns.Clear();

                        // Kolom Action (Apply)
                        DataGridViewButtonColumn applyColumn = new DataGridViewButtonColumn();
                        applyColumn.Name = "Action";
                        applyColumn.Text = "Apply";
                        applyColumn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(applyColumn);

                        dataGridView1.DataSource = dataTable;
                        dataGridView1.CellClick += DataGridView1_CellClick; // Perubahan event handler ke CellClick
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {
                ApplyPromotion(e.RowIndex);
            }
        }

        private void ApplyPromotion(int rowIndex)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Ambil data dari DataGridView
                    string departmentName = dataGridView1.Rows[rowIndex].Cells["Department"].Value.ToString();
                    string positionName = dataGridView1.Rows[rowIndex].Cells["Position"].Value.ToString();

                    // Insert ke dalam tabel promotion
                    string insertQuery = @"
    INSERT INTO promotion (job_id, employee_id, status, created_at)
    VALUES (
        (SELECT TOP 1 id FROM job ORDER BY NEWID()),
        (SELECT TOP 1 id FROM employee ORDER BY NEWID()),
        'Pending', -- Set the status directly to 'Pending'
        GETDATE()
    )";

                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                    {
                        // You don't need these parameters as your query doesn't use them
                        // cmdInsert.Parameters.AddWithValue("@employeeId", userEmail);
                        // cmdInsert.Parameters.AddWithValue("@departmentName", txtDep.Text);
                        // cmdInsert.Parameters.AddWithValue("@positionName", txtPost.Text);

                        cmdInsert.ExecuteNonQuery();
                    }

                    // Nonaktifkan tombol Apply dan ubah teksnya
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView1.Rows[rowIndex].Cells["Action"];

                    if (buttonCell.Value.ToString() != "Pending")
                    {
                        buttonCell.Value = "Pending";
                        buttonCell.ReadOnly = true;
                        buttonCell.FlatStyle = FlatStyle.Flat; // Optional: Ubah tampilan tombol
                        buttonCell.Style.ForeColor = Color.Gray; // Optional: Ubah warna teks tombol

                        // ... (Tambahkan operasi lain yang mungkin diperlukan)
                    }

                    MessageBox.Show("Promotion request telah diajukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Gantilah ini dengan event handler yang sesuai jika diperlukan
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen(userEmail);
            mainScreen.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //handler
        }
    }
}
