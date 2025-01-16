using Guna.UI2.AnimatorNS;
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

    public partial class DaftarSel : Form
    {
        private readonly SelController _controller;
        public DaftarSel()
        {
            InitializeComponent();
            _controller = new SelController();
            LoadSel();
            ConfigureDataGridView();
        }

        private void LoadSel()
        {
            try
            {
                var selList = _controller.AmbilSemuaSel();

                if (selList.Count == 0)
                {
                    MessageBox.Show("Tidak ada data sel ditemukan.", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvSel.DataSource = null;
                dgvSel.DataSource = selList;

                // Atur tampilan DataGridView
                dgvSel.Columns["IdSel"].HeaderText = "ID";
                dgvSel.Columns["TipeSel"].HeaderText = "Tipe Sel";
                dgvSel.Columns["Kapasitas"].HeaderText = "Kapasitas";
                dgvSel.Columns["Lokasi"].HeaderText = "Lokasi";
                dgvSel.Columns["JumlahPenghuni"].HeaderText = "Jumlah Penghuni";
                dgvSel.Columns["NomorSel"].HeaderText = "Nomor Sel";


                dgvSel.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            using (var form = new FormTambahSel())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSel(); // Refresh data setelah menambah
                }
            }
        }

        private void dgvSel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvSel.Rows[e.RowIndex];

                var idSel = Convert.ToInt32(selectedRow.Cells["IdSel"].Value);
                var tipesel = selectedRow.Cells["TipeSel"].Value.ToString();
                var kapasitas = Convert.ToInt32(selectedRow.Cells["Kapasitas"].Value);
                var lokasi = selectedRow.Cells["Lokasi"].Value.ToString();
                var jumlahpenghuni = Convert.ToInt32(selectedRow.Cells["JumlahPenghuni"].Value);
                var nomersel = selectedRow.Cells["NomorSel"].Value.ToString();
                var popup = new PopupDetailSel(idSel,tipesel,kapasitas,lokasi,jumlahpenghuni,nomersel);
                if (popup.ShowDialog() == DialogResult.OK || popup.DialogResult == DialogResult.Yes)
                {
                    LoadSel(); // Refresh data setelah edit atau hapus
                }

            }
        }


        private void ConfigureDataGridView()
        {
            dgvSel.AllowUserToResizeColumns = false;
            dgvSel.AllowUserToResizeRows = false;
            dgvSel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSel.RowTemplate.Height = 30;
            foreach (DataGridViewColumn column in dgvSel.Columns)
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

            var selList = _controller.AmbilSemuaSel();

            // Filter data berdasarkan kategori dan keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                switch (selectedFilter)
                {
                    case "Tipe Sel":
                        selList = selList.Where(n => n.TipeSel.ToLower().Contains(keyword)).ToList();
                        break;
                    case "Lokasi":
                        selList = selList.Where(n => n.Lokasi.ToLower().Contains(keyword)).ToList();
                        break;
                    case "Nomor Sel":
                        selList = selList.Where(n => n.NomorSel.ToString().ToLower().Contains(keyword)).ToList();
                        break;
                    default:
                        selList = selList.Where(n =>
                            n.TipeSel.ToLower().Contains(keyword) ||
                            n.Lokasi.ToLower().Contains(keyword) ||
                            n.NomorSel.ToString().ToLower().Contains(keyword))
                            .ToList();
                        break;
                }
            }

            dgvSel.DataSource = null;
            dgvSel.DataSource = selList;
            ConfigureDataGridView();
        }

       
    }
}
