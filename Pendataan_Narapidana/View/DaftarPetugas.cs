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
using Pendataan_Narapidana.Controller;
using Pendataan_Narapidana.Model.Entity;

namespace Pendataan_Narapidana.View
{
    public partial class DaftarPetugas : Form
    {
        private readonly PetugasController _controller;
        public DaftarPetugas()
        {
            InitializeComponent();
            _controller = new PetugasController();
            LoadPetugas();
        }
        private void LoadPetugas()
        {
            var petugasList = _controller.AmbilSemuaPetugas();
            dgvPetugas.DataSource = petugasList;
            dgvPetugas.Refresh();  
            ConfigureDataGridView();
            dgvPetugas.Columns["Sel"].Visible = false;
            dgvPetugas.Columns["IdSel"].Visible = false;
            dgvPetugas.Columns["IdPetugas"].Visible = false;

            foreach (DataGridViewColumn column in dgvPetugas.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvPetugas.Columns["DetailSel"].HeaderText = "Tugas diSel";
        }
        private void dgvPetugas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvPetugas.Rows[e.RowIndex];

                var idPetugas = Convert.ToInt32(selectedRow.Cells["IdPetugas"].Value);
                var nama = selectedRow.Cells["NamaPetugas"].Value.ToString();
                var jabatan = selectedRow.Cells["Jabatan"].Value.ToString();
                var popup = new PopupDetailPetugas(idPetugas, nama, jabatan);

                if (popup.ShowDialog() == DialogResult.OK)
                {
                    LoadPetugas(); // Memastikan data di-refresh setelah edit
                }
            }
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            using (var form = new FormTambahPetugas())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPetugas();
                }
            }
        }
        private void ConfigureDataGridView()
        {
            dgvPetugas.AllowUserToResizeColumns = false;
            dgvPetugas.AllowUserToResizeRows = false;
            dgvPetugas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPetugas.RowTemplate.Height = 30;
            foreach (DataGridViewColumn column in dgvPetugas.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Menyusun header kolom ke tengah
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(); // Panggil fungsi pencarian
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(); // Panggil fungsi pencarian
        }

        private void ApplySearchFilter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedFilter = cmbSearch.SelectedItem?.ToString() ?? "Semua";

            var petugasList = _controller.AmbilSemuaPetugas();

            // Filter data berdasarkan kategori dan keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                switch (selectedFilter)
                {
                    case "Nama":
                       petugasList = petugasList.Where(n => n.NamaPetugas.ToLower().Contains(keyword)).ToList();
                        break;
                    case "Jabatan":
                        petugasList = petugasList.Where(n => n.Jabatan.ToLower().Contains(keyword)).ToList();
                        break;
                    case "IdSel":
                        petugasList = petugasList
                            .Where(n => n.IdSel.ToString().ToLower().Contains(keyword))
                            .ToList();
                        break;
                    default:
                        petugasList = petugasList.Where(n =>
                            n.NamaPetugas.ToLower().Contains(keyword) ||
                            n.Jabatan.ToLower().Contains(keyword) ||
                            n.IdSel.ToString().ToLower().Contains(keyword))
                            .ToList();
                        break;
                }
            }

            dgvPetugas.DataSource = null;
            dgvPetugas.DataSource = petugasList;
            ConfigureDataGridView();
            dgvPetugas.Columns["Sel"].Visible = false;
            dgvPetugas.Columns["IdSel"].Visible = false;
            dgvPetugas.Columns["IdPetugas"].Visible = false;

            foreach (DataGridViewColumn column in dgvPetugas.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvPetugas.Columns["DetailSel"].HeaderText = "Tugas diSel";
        }

      
    }

}

