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
    public partial class PopupDetailPetugas : Form
    {
        private int _idPetugas;
        public PopupDetailPetugas(int id, string nama ,string jabatan)
        {
            InitializeComponent();
            _idPetugas = id;
            txtNama.Text = nama;
            txtJabatan.Text = jabatan;
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
            var controller = new PetugasController();
            var petugas = new Model.Entity.Petugas
            {
                IdPetugas = _idPetugas,
                NamaPetugas = txtNama.Text,
                Jabatan = txtJabatan.Text,
                IdSel = Convert.ToInt32(cmbIdSel.SelectedValue),
            };

            if (controller.UpdatePetugas(petugas))
            {
                DialogResult = DialogResult.OK; // Indikasikan bahwa perubahan 
                MessageBox.Show("Data berhasil diperbarui.");
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data.");
            }

        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
           // Konfirmasi penghapusan
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var controller = new PetugasController();
                if (controller.HapusPetugas(_idPetugas))
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
       
        private void PopupDetailPetugas_FormClosing_1(object sender, FormClosingEventArgs e)
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
