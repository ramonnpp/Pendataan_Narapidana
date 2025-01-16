using Pendataan_Narapidana.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendataan_Narapidana.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

       

        private void btnNarapidana_Click(object sender, EventArgs e)
        {
           
            loadform(new Narapidana());
       
            
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            loadform(new DaftarSel());
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            loadform(new DaftarPetugas());
        }

        private void btnPengunjung_Click(object sender, EventArgs e)
        {
            loadform(new Pengunjung());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda Telah Logout", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Pendataan_Narapidana.View.Login loginForm = new Pendataan_Narapidana.View.Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            loadform(new Menu());
        }
    }
}
