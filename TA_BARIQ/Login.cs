using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_BARIQ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Tombol_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "Bariq" && txtPassword.Text == "0000")
            {
                MessageBox.Show("Login Berhasil! Selamat Datang Bariq");
                this.Hide();
                Form1 fm = new Form1();
                fm.Show();
            }

            else if (txtUser.Text == "" || txtPassword.Text == "")
            {
                do
                {
                    MessageBox.Show("Mohon masukkan Username dan Password Anda!");
                    return;

                }
                while (txtUser.Text == "" || txtPassword.Text == "");
            }


            else if (txtUser.Text != "Bariq" || txtPassword.Text != "0000")
            {
                do
                {
                    MessageBox.Show("Login Gagal! Username atau Password Salah!");
                    return;

                }
                while (txtUser.Text != "Bariq" || txtPassword.Text != "0000");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            txtPassword.PasswordChar = '●';
        }
    }
}
