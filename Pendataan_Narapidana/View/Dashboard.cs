using System;
using System.Linq;
using System.Windows.Forms;
using Pendataan_Narapidana.Controller; // Pastikan namespace sesuai

namespace Pendataan_Narapidana.View
{
    public partial class Dashboard : Form
    {
        private readonly NarapidanaController _narapidanaController;
        private readonly SelController _selController;
        private readonly PengunjungController _pengunjungController;

        public Dashboard()
        {
            InitializeComponent();

            // Inisialisasi controller
            _narapidanaController = new NarapidanaController();
            _selController = new SelController();
            _pengunjungController = new PengunjungController();

            // Memuat data ke dashboard
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // Ambil data narapidana
                var narapidanaList = _narapidanaController.AmbilSemuaNarapidana();

                // Ambil data sel
                var selList = _selController.AmbilSemuaSel();

                // Ambil data pengunjung
                var pengunjungList = _pengunjungController.GetAllPengunjung();

                // Filter data narapidana untuk DataGridView
                var filteredNapiList = narapidanaList.Select(n => new
                {
                    Nama = n.Nama,
                    Pidana = n.Pidana,
                    Sel = n.DetailSel // Asumsi DetailSel adalah nama sel
                }).ToList();

                // Bind data narapidana ke DataGridView
                dgvdashboard.DataSource = null;
                dgvdashboard.DataSource = filteredNapiList;

                // Atur header DataGridView
                dgvdashboard.Columns["Nama"].HeaderText = "Nama Narapidana";
                dgvdashboard.Columns["Pidana"].HeaderText = "Tindak Pidana";
                dgvdashboard.Columns["Sel"].HeaderText = "Sel";

                // Update statistik
                UpdateStatistik(filteredNapiList, selList, pengunjungList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistik(dynamic filteredNapiList, dynamic selList, dynamic pengunjungList)
        {
            try
            {
                // Hitung jumlah narapidana
                int jumlahNarapidana = filteredNapiList.Count;

                // Hitung jumlah sel
                int jumlahSel = selList.Count;

                // Hitung jumlah pengunjung
                int jumlahPengunjung = pengunjungList.Count;

                // Tampilkan statistik di label
                lblJumlahNapi.Text = $"  {jumlahNarapidana}";
                lblJumlahSel.Text = $" {jumlahSel}";
                lblJumlahPengunjung.Text = $" {jumlahPengunjung}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memperbarui statistik: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvdashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = dgvdashboard.Rows[e.RowIndex];
                    string nama = selectedRow.Cells["Nama"].Value.ToString();
                    string pidana = selectedRow.Cells["Pidana"].Value.ToString();
                    string sel = selectedRow.Cells["Sel"].Value.ToString();

                    MessageBox.Show($"Nama: {nama}\nPidana: {pidana}\nSel: {sel}", "Detail Narapidana");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
