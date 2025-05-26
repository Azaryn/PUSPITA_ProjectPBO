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
            //DatabaseGeneratedAttribute = new DatabaseLogin();

        }

        private void Lgn_Button(object sender, EventArgs e)
        {
            string username = InputUsername.Text;
            string password = InputPassword.Text;
            bool Valid = userContext.Validate(username, password, out int userId);
            //try
            //{
            if (Valid)
            {
                //Dashboard_Admin Dadmin = new Dashboard_Admin();
                Dashboard_Petani Dpetani = new Dashboard_Petani();
                this.Hide();
                Dpetani.Show();
            }
            //}
            //catch (np)
            //{ 

            //}
        }

        private void RegisterP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void btnLoginSebagaiAdmin(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
        }
    }
}
