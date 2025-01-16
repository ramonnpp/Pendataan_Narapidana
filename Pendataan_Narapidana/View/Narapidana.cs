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
using Pendataan_Narapidana.Model.Repository;


namespace Pendataan_Narapidana.View
{
    public partial class Narapidana : Form
    {
        private readonly NarapidanaController _controller;

        public Narapidana()
        {
            InitializeComponent();
            _controller = new NarapidanaController();
            LoadNarapidana();
        }


        private void LoadNarapidana()
        {
            var narapidanaList = _controller.AmbilSemuaNarapidana();

            dgvNarapidana.DataSource = null;
            dgvNarapidana.DataSource = narapidanaList;
            ConfigureDataGridView();


            dgvNarapidana.Columns["Id_Narapidana"].HeaderText = "Kode Narapidana";
            dgvNarapidana.Columns["Nama"].HeaderText = "Nama";
            dgvNarapidana.Columns["JenisKelamin"].HeaderText = "Jenis Kelamin";
            dgvNarapidana.Columns["Pidana"].HeaderText = "Pidana";
            dgvNarapidana.Columns["Alamat"].HeaderText = "Alamat";
            dgvNarapidana.Columns["Pekerjaan"].HeaderText = "Pekerjaan";
            dgvNarapidana.Columns["TanggalMasuk"].HeaderText = "Tanggal Masuk";
            dgvNarapidana.Columns["TanggalKeluar"].HeaderText = "Tanggal Keluar";


            dgvNarapidana.Columns["Sel"].Visible = false;
            dgvNarapidana.Columns["IdSel"].Visible = false;

            foreach (DataGridViewColumn column in dgvNarapidana.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvNarapidana.Columns["DetailSel"].HeaderText = "Sel";
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            using (var formTambah = new FormTambahNarapidana())
            {
                if (formTambah.ShowDialog() == DialogResult.OK)
                {
                    LoadNarapidana();
                }
            }
        }

        private void LoadData()
        {
            dgvNarapidana.DataSource = null;
            var narapidanaList = _controller.AmbilSemuaNarapidana();
            dgvNarapidana.DataSource = narapidanaList;
            dgvNarapidana.Refresh(); 
            ConfigureDataGridView();
            dgvNarapidana.Columns["Sel"].Visible = false;
            dgvNarapidana.Columns["IdSel"].Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pendataan_Narapidana.View.Menu menuForm = new Pendataan_Narapidana.View.Menu();
            menuForm.ShowDialog();
            this.Close();
        }

        private void dgvNarapidana_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var selectedRow = dgvNarapidana.Rows[e.RowIndex];

                var idNarapidana = Convert.ToInt32(selectedRow.Cells["Id_Narapidana"].Value);
                var nama = selectedRow.Cells["Nama"].Value.ToString();
                var jenisKelamin = selectedRow.Cells["JenisKelamin"].Value.ToString();
                var pidana = selectedRow.Cells["Pidana"].Value.ToString();
                var alamat = selectedRow.Cells["Alamat"].Value.ToString();
                var pekerjaan = selectedRow.Cells["Pekerjaan"].Value.ToString();
                var tanggalMasuk = Convert.ToDateTime(selectedRow.Cells["TanggalMasuk"].Value);
                var tanggalKeluar = Convert.ToDateTime(selectedRow.Cells["TanggalKeluar"].Value);
                var foto = selectedRow.Cells["Foto"].Value as byte[];
                var popup = new PopupDetailNarapidana(idNarapidana, nama, pidana, alamat,
                                                       pekerjaan, tanggalMasuk, tanggalKeluar, foto);
                if (popup.ShowDialog() == DialogResult.OK || popup.DialogResult == DialogResult.Yes)
                {
                    LoadData(); // Refresh data setelah edit atau hapus
                }

            }
        }

        private void Narapidana_Load(object sender, EventArgs e)
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

      

        private void ConfigureDataGridView()
        { 
            dgvNarapidana.AllowUserToResizeColumns = false;
            dgvNarapidana.AllowUserToResizeRows = false;
            dgvNarapidana.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNarapidana.Columns["Foto"].Visible = false; 
            dgvNarapidana.RowTemplate.Height = 30;
            dgvNarapidana.Columns["Id_Narapidana"].HeaderText = "Kode Narapidana";
            foreach (DataGridViewColumn column in dgvNarapidana.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; 
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

            var narapidanaList = _controller.AmbilSemuaNarapidana(); 

            // Filter data berdasarkan kategori dan keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                switch (selectedFilter)
                {
                    case "Nama":
                        narapidanaList = narapidanaList.Where(n => n.Nama.ToLower().Contains(keyword)).ToList();
                        break;
                    case "Tindak Pidana":
                        narapidanaList = narapidanaList.Where(n => n.Pidana.ToLower().Contains(keyword)).ToList();
                        break;
                    case "Tanggal Masuk":
                        narapidanaList = narapidanaList
                            .Where(n => n.TanggalMasuk.ToString("yyyy-MM-dd").Contains(keyword))
                            .ToList();
                        break;
                    case "IdSel":
                        narapidanaList = narapidanaList
                            .Where(n => n.IdSel.ToString().ToLower().Contains(keyword))
                            .ToList();
                        break;
                    default:
                        narapidanaList = narapidanaList.Where(n =>
                            n.Nama.ToLower().Contains(keyword) ||
                            n.Pidana.ToLower().Contains(keyword) ||
                            n.TanggalMasuk.ToString("yyyy-MM-dd").Contains(keyword) ||
                            n.IdSel.ToString().ToLower().Contains(keyword))
                            .ToList();
                        break;
                }
            }

            dgvNarapidana.DataSource = null;
            dgvNarapidana.DataSource = narapidanaList;
            ConfigureDataGridView();
            dgvNarapidana.Columns["Sel"].Visible = false;
            dgvNarapidana.Columns["IdSel"].Visible = false;
            dgvNarapidana.Columns["IdPetugas"].Visible = false;

            foreach (DataGridViewColumn column in dgvNarapidana.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvNarapidana.Columns["DetailSel"].HeaderText = "Sel";
        }

    }
}
