using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using System.IO;
using System.Data.SQLite;
using Pendataan_Narapidana.Controller;
using Pendataan_Narapidana.Model.Repository;

namespace Pendataan_Narapidana.View
{
    public partial class FormTambahNarapidana : Form
    {
        private byte[] narapidanaFoto; // Deklarasi variabel narapidanaFoto

        private readonly NarapidanaController _controller;


        public FormTambahNarapidana()
        {
            _controller = new NarapidanaController();
            InitializeComponent();
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



        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidasiInput())
            {
                string jenisKelamin = chkPria.Checked ? "Laki - Laki" : "Wanita";

                try
                {
                    // ID Sel yang dipilih dari ComboBox
                    int idSel = Convert.ToInt32(cmbIdSel.SelectedValue);

                    // Tambahkan narapidana baru
                    bool result = _controller.TambahNarapidana(
                        txtNama.Text,
                        jenisKelamin,
                        txtPidana.Text,
                        txtAlamat.Text,
                        txtPekerjaan.Text,
                        dtpMasuk.Value,
                        dtpKeluar.Value,
                        idSel,
                        narapidanaFoto
                    );

                    if (result)
                    {
                        // Tambahkan penghuni ke sel
                        var selController = new SelController();
                        if (!selController.TambahPenghuni(idSel))
                        {
                            MessageBox.Show("Gagal menambah penghuni ke sel. Kapasitas mungkin penuh.", "Peringatan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Jika penambahan narapidana berhasil tetapi penambahan penghuni sel gagal, rollback
                            _controller.HapusNarapidanaTerakhir(); // Pastikan ada metode ini untuk menghapus data yang baru saja dimasukkan
                        }
                        else
                        {
                            MessageBox.Show("Data berhasil disimpan!", "Sukses",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data!", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Log kesalahan
                    Console.WriteLine($"Error: {ex.Message}");
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama harus diisi!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!chkPria.Checked && !chkWanita.Checked)
            {
                MessageBox.Show("Jenis kelamin harus dipilih!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (chkPria.Checked && chkWanita.Checked)
            {
                MessageBox.Show("Hanya satu jenis kelamin yang boleh dipilih!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPidana.Text))
            {
                MessageBox.Show("Pidana harus diisi!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpKeluar.Value < dtpMasuk.Value)
            {
                MessageBox.Show("Tanggal keluar tidak boleh lebih awal dari tanggal masuk!",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnPilihGambar_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pbFoto.Image = Image.FromFile(filePath);
                    narapidanaFoto = File.ReadAllBytes(filePath);
                }
            }
        }

        private void chkPria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPria.Checked)
            {
                chkWanita.Checked = false;
            }
        }

        private void chkWanita_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWanita.Checked)
            {
                chkPria.Checked = false;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}