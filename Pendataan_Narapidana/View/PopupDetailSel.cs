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
    public partial class PopupDetailSel : Form
    {
        private int _idSel;
        public PopupDetailSel(int id, string tipesel, int kapasitas, string lokasi, int jumlahpenghuni, string nomersel)
        {
            InitializeComponent();
            _idSel = id;
            txtTipeSel.Text = tipesel;
            txtKapasitas.Text = kapasitas.ToString(); 
            txtLokasi.Text = lokasi;
            txtNomorSel.Text = nomersel;
            txtPenghuni.Text = jumlahpenghuni.ToString();
            LoadSel();
        }

        private void LoadSel()
        {
            var selRepository = new SelRepository();
            var selList = selRepository.AmbilSemua();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var controller = new SelController();
            var sel = new Model.Entity.Sel
            {
                IdSel = _idSel,
                TipeSel = txtTipeSel.Text,
                Kapasitas = int.Parse(txtKapasitas.Text), 
                Lokasi = txtLokasi.Text,
                NomorSel = txtNomorSel.Text,
                JumlahPenghuni = int.Parse(txtPenghuni.Text)
            };

            if (controller.UpdateSel(sel))
            {
                DialogResult = DialogResult.OK; // Indikasikan bahwa perubahan 
                MessageBox.Show("Data berhasil diperbarui.");
                this.Close();

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
                var controller = new SelController();
                if (controller.HapusSel(_idSel))
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
       

       

        private void PopupDetailSel_FormClosing_1(object sender, FormClosingEventArgs e)
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
