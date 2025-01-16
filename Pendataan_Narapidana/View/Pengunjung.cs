using Pendataan_Narapidana.Controller;
using Pendataan_Narapidana.Model.Repository;
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
    public partial class Pengunjung : Form
    {
        private readonly PengunjungController _controller;
        public Pengunjung()
        {
            InitializeComponent();
            _controller = new PengunjungController();
            LoadPengunjung();
            ConfigureDataGridView();
        }
        private void LoadPengunjung()
        {
            var pengunjungList = _controller.GetAllPengunjung();
            dgvPengunjung.DataSource = pengunjungList.Select(p => new
            {
                p.Id_Pengunjung,
                p.Nama,
                p.Alamat,
                p.Hubungan,
                p.NoHp,
                p.WaktuKunjungan,
                p.Id_Narapidana,
                Narapidana = p.NamaNarapidana,
              
            }).ToList();
            dgvPengunjung.Columns["Id_Narapidana"].Visible = false;
            dgvPengunjung.Columns["Id_Pengunjung"].Visible = false;

        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            var tambahForm = new FormTambahPengunjung();
            tambahForm.ShowDialog();
            LoadPengunjung();
        }


        private void ConfigureDataGridView()
        {
            dgvPengunjung.AllowUserToResizeColumns = false;
            dgvPengunjung.AllowUserToResizeRows = false;
            dgvPengunjung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPengunjung.RowTemplate.Height = 30;
            foreach (DataGridViewColumn column in dgvPengunjung.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;  
            }
        }

        private void dgvPengunjung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvPengunjung.Rows[e.RowIndex];

                var idpengunjung = Convert.ToInt32(selectedRow.Cells["Id_Pengunjung"].Value);
                var nama = selectedRow.Cells["Nama"].Value.ToString();
                var alamat = selectedRow.Cells["Alamat"].Value.ToString();
                var hubungan = selectedRow.Cells["Hubungan"].Value.ToString();
                var nohp = selectedRow.Cells["NoHp"].Value.ToString();
                var idNarapidana = Convert.ToInt32(selectedRow.Cells["Id_Narapidana"].Value);
                var popup = new PopupDetailPengunjung(idpengunjung, nama, alamat, hubungan,
                                                       nohp,idNarapidana);
                if (popup.ShowDialog() == DialogResult.OK || popup.DialogResult == DialogResult.Yes)
                {
                    LoadPengunjung(); // Refresh data setelah edit atau hapus
                }

            }
        }

        private void Pengunjung_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Narapidana narapidanaForm = new Narapidana();
            narapidanaForm.ShowDialog();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pengunjung pengunjungForm = new Pengunjung();
            pengunjungForm.ShowDialog();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(); // Panggil fungsi pencarian
        }
        private void ApplySearchFilter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedFilter = cmbSearch.SelectedItem?.ToString() ?? "Semua";

            var penggunjungList = _controller.GetAllPengunjung();

            // Filter data berdasarkan kategori dan keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                switch (selectedFilter)
                {
                    case "Narapidana":
                        penggunjungList = penggunjungList.Where(n => n.NamaNarapidana.ToLower().Contains(keyword)).ToList();
                        break;
                    case "Nama":
                        penggunjungList = penggunjungList.Where(n => n.Nama.ToLower().Contains(keyword)).ToList();
                        break;

                    default:
                        break;
                }
            }

            dgvPengunjung.DataSource = null;
            dgvPengunjung.DataSource = penggunjungList;
            ConfigureDataGridView();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(); // Panggil fungsi pencarian

        }
    }
}
