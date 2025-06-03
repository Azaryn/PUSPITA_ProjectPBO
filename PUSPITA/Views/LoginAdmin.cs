using PUSPITA.Model;
using PUSPITA.Views;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUSPITA.Views
{
    public partial class LoginAdmin : Form
    {
        AdminContext adminContext = new AdminContext();
        public LoginAdmin()
        {
            InitializeComponent();
            tbPass.UseSystemPasswordChar = true;
        }

        private void btnLoginPetani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = tbPass.Text;

            try
            {
                bool Valid = adminContext.Validasi(username, password, out int adminId);
                if (Valid)
                {
                    this.Hide();
                    Dashboard_Admin dashboard = new Dashboard_Admin();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat login:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
