using PUSPITA.Model;
using PUSPITA.Views;

namespace PUSPITA
{
    public partial class FormLogin : Form
    {
        AdminContext adminContext = new AdminContext();
        public FormLogin()
        {
            InitializeComponent();

        }

        private void Lgn_Button(object sender, EventArgs e)
        {
            string username = InputUsername.Text;
            string password = InputPassword.Text;
            bool Valid = adminContext.Validate(username, password, out int userId);
            //try
            //{
                if (Valid)
                {
                    Dashboard_Admin Dadmin = new Dashboard_Admin();
                    this.Hide();
                    Dadmin.Show();
                }
            //}
            //catch (np)
            //{ 

            //}
        }
    }
}
