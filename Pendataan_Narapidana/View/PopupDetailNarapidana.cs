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
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendataan_Narapidana.View
{
    public partial class PopupDetailNarapidana : Form
    {
        private byte[] _foto;
        private int _idNarapidana;
        public PopupDetailNarapidana(int id, string nama, string pidana, string alamat,
                              string pekerjaan, DateTime tanggalMasuk,
                              DateTime tanggalKeluar, byte[] foto)
        {
            InitializeComponent();
            _idNarapidana = id;
            txtNama.Text = nama;
            txtPidana.Text = pidana;
            txtAlamat.Text = alamat;
            txtPekerjaan.Text = pekerjaan;
            dtpMasuk.Value = tanggalMasuk;
            dtpKeluar.Value = tanggalKeluar;

            if (foto != null)
            {
                using (MemoryStream ms = new MemoryStream(foto))
                {
                    pbFoto.Image = Image.FromStream(ms);
                }
            }
            LoadSel();
        }

        private void LoadSel()
        {
            var selRepository = new SelRepository();
            var selList = selRepository.AmbilSemua();

            cmbIdSel.DataSource = selList;
            cmbIdSel.DisplayMember = "TipeSel"; // Nama kolom yang akan ditampilkan
            cmbIdSel.ValueMember = "IdSel"; // Kolom yang menjadi nilai
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var controller = new NarapidanaController();
                var selController = new SelController(); // Controller untuk operasi pada Sel

                // Buat objek Narapidana baru berdasarkan input
                var narapidana = new Model.Entity.Narapidana
                {
                    Id_Narapidana = _idNarapidana,
                    Nama = txtNama.Text,
                    Pidana = txtPidana.Text,
                    Alamat = txtAlamat.Text,
                    Pekerjaan = txtPekerjaan.Text,
                    TanggalMasuk = dtpMasuk.Value,
                    TanggalKeluar = dtpKeluar.Value,
                    IdSel = Convert.ToInt32(cmbIdSel.SelectedValue),
                    Foto = _foto
                };

                // Ambil data narapidana lama (sebelum diubah)
                var narapidanaLama = controller.GetNarapidanaById(_idNarapidana);

                if (narapidanaLama == null)
                {
                    MessageBox.Show("Data narapidana lama tidak ditemukan.");
                    return;
                }

                // Periksa apakah narapidana pindah sel
                if (narapidanaLama.IdSel != narapidana.IdSel)
                {
                    // Kurangi penghuni pada sel lama
                    if (!selController.KurangiPenghuni(narapidanaLama.IdSel))
                    {
                        MessageBox.Show("Gagal mengurangi penghuni dari sel lama.");
                        return;
                    }

                    // Tambah penghuni pada sel baru
                    if (!selController.TambahPenghuni(narapidana.IdSel))
                    {
                        // Jika gagal menambah penghuni pada sel baru, kembalikan penghuni ke sel lama
                        selController.TambahPenghuni(narapidanaLama.IdSel);
                        MessageBox.Show("Gagal menambah penghuni ke sel baru. Kapasitas mungkin penuh.");
                        return;
                    }
                }

                // Lakukan update data narapidana
                if (controller.EditNarapidana(narapidana))
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Data berhasil diperbarui.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data narapidana.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Konfirmasi penghapusan
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var controller = new NarapidanaController();
                if (controller.HapusNarapidana(_idNarapidana))
                {
                    MessageBox.Show("Data berhasil dihapus.", "Berhasil");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.");
                }
            }

        }
        private void btnUbahFoto_Click(object sender, EventArgs e)
        {
            // Pilih gambar baru untuk mengganti foto
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var image = Image.FromFile(openFileDialog.FileName);
                    pbFoto.Image = image;

                    // Konversi gambar ke byte[]
                    using (var ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        _foto = ms.ToArray();
                    }
                }
            }
        }

        private void PopupDetailNarapidana_FormClosing_1(object sender, FormClosingEventArgs e)
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
    }
}
