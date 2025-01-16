using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pendataan_Narapidana.Controller;
using Pendataan_Narapidana.Model;
using System.Data.SQLite;

namespace Pendataan_Narapidana.View
{
    public partial class Login : Form
    {
        private UserController _controller;

        public Login()
        {
            InitializeComponent();
            _controller = new UserController();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_controller.Login(username, password))
            {
                MessageBox.Show("Login Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Pendataan_Narapidana.View.Menu menuForm = new Pendataan_Narapidana.View.Menu();
                menuForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
