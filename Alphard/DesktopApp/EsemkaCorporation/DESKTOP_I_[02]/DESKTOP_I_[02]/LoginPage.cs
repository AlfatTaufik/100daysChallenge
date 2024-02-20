using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP_I__02_
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowError("Silakan Isi Form Email");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                ShowError("Silakan Isi Form Password");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LADRMMV\\SQLEXPRESS;Initial Catalog=EsemkaCorporation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Check if the account is valid and not deleted
                    string checkAccountQuery = "SELECT COUNT(*) FROM employee WHERE email=@email AND password=@password AND deleted_at IS NULL";
                    SqlCommand checkAccountCmd = new SqlCommand(checkAccountQuery, conn);
                    checkAccountCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    checkAccountCmd.Parameters.AddWithValue("@password", txtPass.Text);
                    int count = (int)checkAccountCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login Berhasil", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        MainScreen mainScreen = new MainScreen(txtEmail.Text);
                        mainScreen.Show();
                    }
                    else
                    {
                        ShowError("Email atau password Anda Salah !.");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error: {ex.Message}");
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.ForeColor = Color.Red;

            lblError.Visible = true;
        }
    }
}
