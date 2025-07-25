using PUSPITA.Model;
using PUSPITA.Views;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUSPITA
{
    public partial class FormLogin : Form
    {
        UserContext userContext = new UserContext();
        public FormLogin()
        {
            InitializeComponent();
            InputPassword.UseSystemPasswordChar = true;
        }
        private void Lgn_Button(object sender, EventArgs e)
        {
            string username = InputUsername.Text;
            string password = InputPassword.Text;

            try
            {
                bool Valid = userContext.Validasi(username, password, out int petaniId, out string alamat);
                if (Valid)
                {
                    Users.id_petani = petaniId;
                    Users.alamat = alamat;
                    UserContext.IdPetani = petaniId;

                    this.Hide();
                    Dashboard_Petani dashboard = new Dashboard_Petani(); 
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
        }

        private void RegisterP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form LoginPetani berhasil dibuka");
        }
    }
}
