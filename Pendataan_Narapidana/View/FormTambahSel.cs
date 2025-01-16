using Pendataan_Narapidana.Controller;
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
    public partial class FormTambahSel : Form
    {
        private readonly SelController _controller;
        private readonly bool _isEditMode;
        private readonly Sel _currentSel;

        public FormTambahSel(Sel sel = null)
        {
            InitializeComponent();
            _controller = new SelController();
            _isEditMode = sel != null;

            if (_isEditMode)
            {
                _currentSel = sel;
                LoadDataToForm();
            }
        }

        private void LoadDataToForm()
        {
            if (_currentSel != null)
            {
                txtTipeSel.Text = _currentSel.TipeSel;
                txtKapasitas.Text = _currentSel.Kapasitas.ToString();
                txtLokasi.Text = _currentSel.Lokasi;
                txtPenghuni.Text = _currentSel.JumlahPenghuni.ToString();
                txtNomorSel.Text = _currentSel.NomorSel;
            }
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtTipeSel.Text))
            {
                MessageBox.Show("Tipe Sel tidak boleh kosong.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtKapasitas.Text, out var kapasitas) || kapasitas <= 0)
            {
                MessageBox.Show("Kapasitas harus berupa angka dan lebih besar dari 0.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                MessageBox.Show("Lokasi tidak boleh kosong.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtPenghuni.Text, out var jumlahPenghuni) || jumlahPenghuni < 0)
            {
                MessageBox.Show("Jumlah Penghuni harus berupa angka dan tidak boleh negatif.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNomorSel.Text))
            {
                MessageBox.Show("Nomor Sel tidak boleh kosong.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (ValidasiInput())
            {
                try
                {
                    var tipeSel = txtTipeSel.Text;
                    var kapasitas = int.Parse(txtKapasitas.Text);
                    var lokasi = txtLokasi.Text;
                    var jumlahPenghuni = int.Parse(txtPenghuni.Text);
                    var nomorSel = txtNomorSel.Text;



                    var result = _controller.TambahSel(tipeSel, kapasitas, lokasi, jumlahPenghuni, nomorSel);

                    if (result)
                    {
                        MessageBox.Show("Data berhasil ditambahkan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan data.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
