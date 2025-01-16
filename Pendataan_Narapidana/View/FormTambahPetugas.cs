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
using Pendataan_Narapidana.Model.Entity;

namespace Pendataan_Narapidana.View
{
    public partial class FormTambahPetugas : Form
    {
        private readonly PetugasController _controller;
        private readonly SelController _selController;
        private readonly bool _isEditMode;
        private readonly Petugas _currentPetugas;
        public FormTambahPetugas(Petugas petugas = null)
        {
            InitializeComponent();
            _controller = new PetugasController();
            _currentPetugas = petugas;
            _isEditMode = petugas != null;


            if (_isEditMode)
            {
                LoadDataToForm();
            }

            LoadSelToComboBox();
        }

        private void LoadDataToForm()
        {
            if (_currentPetugas != null)
            {
                txtNama.Text = _currentPetugas.NamaPetugas;
                txtJabatan.Text = _currentPetugas.Jabatan;
                cmbIdSel.SelectedValue = _currentPetugas.IdSel;
            }
        }

        private void LoadSelToComboBox()
        {
            try
            {
                var selController = new SelController();
                var selList = selController.AmbilSemuaSel();

                if (selList.Count == 0)
                {
                    MessageBox.Show("Tidak ada data Sel ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cmbIdSel.DataSource = selList;
                cmbIdSel.DisplayMember = "TipeSel"; // Menampilkan Tipe Sel
                cmbIdSel.ValueMember = "IdSel";    // Menyimpan IdSel sebagai nilai
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat data Sel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama petugas harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtJabatan.Text))
            {
                MessageBox.Show("Jabatan harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbIdSel.SelectedIndex == -1)
            {
                MessageBox.Show("Sel harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (ValidasiInput())
            {
                var nama = txtNama.Text;
                var jabatan = txtJabatan.Text;
                var idSel = Convert.ToInt32(cmbIdSel.SelectedValue);
                {
                    var result = _controller.TambahPetugas(nama, jabatan, idSel);
                    if (result)
                    {
                        MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
