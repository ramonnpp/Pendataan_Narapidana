using Guna.UI2.AnimatorNS;
using Pendataan_Narapidana.Controller;
using Pendataan_Narapidana.Model.Entity;
using Pendataan_Narapidana.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendataan_Narapidana.View
{
    public partial class PopupDetailPengunjung : Form
    {
        private int _idPengunjung;
        private PengunjungController _controller;
        public PopupDetailPengunjung(int id, string nama, string alamat, string hubungan, string nohp, int idNarapidana)
        {
            InitializeComponent();
            _idPengunjung = id;
            txtNama.Text = nama;
            txtAlamat.Text = alamat;
            txtHubungan.Text = hubungan;
            txtNoHp.Text = nohp;
            txtIdNarapidana.Text = idNarapidana.ToString();
            _controller = new PengunjungController();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Get the data from the form
            var controller = new PengunjungController();
            var pengunjung = new Model.Entity.Pengunjung
            {
                Id_Pengunjung = _idPengunjung,
                Nama = txtNama.Text,
                Alamat = txtAlamat.Text,
                Hubungan = txtHubungan.Text,
                NoHp = txtNoHp.Text,
                Id_Narapidana = int.Parse(txtIdNarapidana.Text) // Assuming Id_Narapidana is provided
            };

            // Update the pengunjung in the repository
            _controller.UpdatePengunjung(pengunjung);
            MessageBox.Show("Data Pengunjung berhasil diperbarui.");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin menghapus pengunjung ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _controller.DeletePengunjung(_idPengunjung);
                MessageBox.Show("Data Pengunjung berhasil dihapus.");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PopupDetailPengunjung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK && DialogResult != DialogResult.Cancel)
            {
                var result = MessageBox.Show("Apakah Anda yakin ingin menutup tanpa menyimpan perubahan?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Batalkan penutupan
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
