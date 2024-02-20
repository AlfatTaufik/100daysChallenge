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

namespace DESKTOP_I__02_
{
    public partial class MainScreen : Form
    {
        private readonly string userEmail;
        public MainScreen(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            string name = GetNameByEmail(userEmail);
            EmpName.Text = name;
        }

        private string GetNameByEmail(string email)
        {
            string name = "";
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "SELECT name FROM employee WHERE email=@email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        // Baca hasil query menggunakan SqlDataReader
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                name = reader["name"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Untuk LogOut ?","Konfirmasi LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(userEmail);
            profileForm.Show();
            this.Hide();
        }

        private void btnMutation_Click(object sender, EventArgs e)
        {
            Mutation_Form mutation = new Mutation_Form(userEmail);
            mutation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PromotionPage promotion = new PromotionPage(userEmail);
            promotion.Show();
            this.Hide();
        }
    }
}
