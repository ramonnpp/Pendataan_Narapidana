using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Pendataan_Narapidana.Controller;
using Pendataan_Narapidana.Model.Repository;
using Pendataan_Narapidana.Model.Context;

namespace Pendataan_Narapidana.View
{
    public partial class FormTambahPengunjung : Form
    {
        private readonly PengunjungController _controller;

        public FormTambahPengunjung()
        {
            InitializeComponent();
            _controller = new PengunjungController();

        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            // Pastikan ID Narapidana di TextBox adalah angka yang valid
            if (int.TryParse(txtIdNarapidana.Text, out int idNarapidana))
            {
                var pengunjung = new Model.Entity.Pengunjung
                {
                    Nama = txtNama.Text,
                    Alamat = txtAlamat.Text,
                    Hubungan = txtHubungan.Text,
                    NoHp = txtNoHp.Text,
                    Id_Narapidana = idNarapidana,
                    WaktuKunjungan = DateTime.Now 
                };
                _controller.AddPengunjung(pengunjung);
                MessageBox.Show("Data berhasil ditambahkan!");
                Close();
            }
            else
            {
                MessageBox.Show("ID Narapidana harus berupa angka.");
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
