using PUSPITA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUSPITA.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputanUsername != null && InputanPassword != null)
                {
                    string username = InputanUsername.Text;
                    string password = InputanPassword.Text;
                    string alamat = InputanAlamat.Text;
                    RegisterContext registerContext = new RegisterContext();
                    bool isRegistered = registerContext.Register(username, password, alamat);
                    if (isRegistered)
                    {
                        MessageBox.Show("Registrasi Berhasil!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        FormLogin formLogin = new FormLogin();
                        formLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registrasi Gagal. Silahkan coba lagi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
