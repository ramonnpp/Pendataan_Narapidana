namespace Pendataan_Narapidana.View
{
    partial class FormTambahNarapidana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAlamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPekerjaan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPidana = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.dtpMasuk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpKeluar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnPilihGambar = new Guna.UI2.WinForms.Guna2Button();
            this.chkPria = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkWanita = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdSel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.pbFoto = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.BorderRadius = 10;
            this.txtNama.BorderThickness = 0;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(22, 77);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNama.PlaceholderText = "Nama";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(298, 36);
            this.txtNama.TabIndex = 0;
            // 
            // txtAlamat
            // 
            this.txtAlamat.AutoScroll = true;
            this.txtAlamat.BorderRadius = 10;
            this.txtAlamat.BorderThickness = 0;
            this.txtAlamat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlamat.DefaultText = "";
            this.txtAlamat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlamat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlamat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlamat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlamat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtAlamat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlamat.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.txtAlamat.ForeColor = System.Drawing.Color.Black;
            this.txtAlamat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlamat.Location = new System.Drawing.Point(22, 119);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.PasswordChar = '\0';
            this.txtAlamat.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAlamat.PlaceholderText = "Alamat";
            this.txtAlamat.SelectedText = "";
            this.txtAlamat.Size = new System.Drawing.Size(298, 36);
            this.txtAlamat.TabIndex = 1;
            // 
            // txtPekerjaan
            // 
            this.txtPekerjaan.BorderRadius = 10;
            this.txtPekerjaan.BorderThickness = 0;
            this.txtPekerjaan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPekerjaan.DefaultText = "";
            this.txtPekerjaan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPekerjaan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPekerjaan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPekerjaan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPekerjaan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtPekerjaan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPekerjaan.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.txtPekerjaan.ForeColor = System.Drawing.Color.Black;
            this.txtPekerjaan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPekerjaan.Location = new System.Drawing.Point(22, 161);
            this.txtPekerjaan.Name = "txtPekerjaan";
            this.txtPekerjaan.PasswordChar = '\0';
            this.txtPekerjaan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPekerjaan.PlaceholderText = "Pekerjaan";
            this.txtPekerjaan.SelectedText = "";
            this.txtPekerjaan.Size = new System.Drawing.Size(298, 36);
            this.txtPekerjaan.TabIndex = 2;
            // 
            // txtPidana
            // 
            this.txtPidana.BorderRadius = 10;
            this.txtPidana.BorderThickness = 0;
            this.txtPidana.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPidana.DefaultText = "";
            this.txtPidana.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPidana.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPidana.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPidana.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPidana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtPidana.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPidana.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.txtPidana.ForeColor = System.Drawing.Color.Black;
            this.txtPidana.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPidana.Location = new System.Drawing.Point(22, 203);
            this.txtPidana.Name = "txtPidana";
            this.txtPidana.PasswordChar = '\0';
            this.txtPidana.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPidana.PlaceholderText = "Pidana";
            this.txtPidana.SelectedText = "";
            this.txtPidana.Size = new System.Drawing.Size(298, 36);
            this.txtPidana.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BorderRadius = 10;
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSimpan.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(345, 396);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(300, 53);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dtpMasuk
            // 
            this.dtpMasuk.BackColor = System.Drawing.Color.Transparent;
            this.dtpMasuk.BorderRadius = 10;
            this.dtpMasuk.Checked = true;
            this.dtpMasuk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpMasuk.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.dtpMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpMasuk.Location = new System.Drawing.Point(22, 352);
            this.dtpMasuk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMasuk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMasuk.Name = "dtpMasuk";
            this.dtpMasuk.Size = new System.Drawing.Size(298, 36);
            this.dtpMasuk.TabIndex = 6;
            this.dtpMasuk.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dtpKeluar
            // 
            this.dtpKeluar.BorderRadius = 10;
            this.dtpKeluar.Checked = true;
            this.dtpKeluar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpKeluar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.dtpKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpKeluar.Location = new System.Drawing.Point(22, 432);
            this.dtpKeluar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpKeluar.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpKeluar.Name = "dtpKeluar";
            this.dtpKeluar.Size = new System.Drawing.Size(298, 36);
            this.dtpKeluar.TabIndex = 7;
            this.dtpKeluar.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnPilihGambar
            // 
            this.btnPilihGambar.BorderRadius = 10;
            this.btnPilihGambar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPilihGambar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPilihGambar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPilihGambar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPilihGambar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPilihGambar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilihGambar.ForeColor = System.Drawing.Color.White;
            this.btnPilihGambar.Location = new System.Drawing.Point(409, 327);
            this.btnPilihGambar.Name = "btnPilihGambar";
            this.btnPilihGambar.Size = new System.Drawing.Size(180, 45);
            this.btnPilihGambar.TabIndex = 10;
            this.btnPilihGambar.Text = "Pilih Gambar";
            this.btnPilihGambar.Click += new System.EventHandler(this.btnPilihGambar_Click_1);
            // 
            // chkPria
            // 
            this.chkPria.AutoSize = true;
            this.chkPria.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkPria.CheckedState.BorderRadius = 5;
            this.chkPria.CheckedState.BorderThickness = 0;
            this.chkPria.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(77)))));
            this.chkPria.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.chkPria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(77)))));
            this.chkPria.Location = new System.Drawing.Point(27, 297);
            this.chkPria.Name = "chkPria";
            this.chkPria.Size = new System.Drawing.Size(87, 21);
            this.chkPria.TabIndex = 11;
            this.chkPria.Text = "Laki-Laki";
            this.chkPria.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkPria.UncheckedState.BorderRadius = 5;
            this.chkPria.UncheckedState.BorderThickness = 0;
            this.chkPria.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkPria.CheckedChanged += new System.EventHandler(this.chkPria_CheckedChanged);
            // 
            // chkWanita
            // 
            this.chkWanita.AutoSize = true;
            this.chkWanita.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkWanita.CheckedState.BorderRadius = 5;
            this.chkWanita.CheckedState.BorderThickness = 0;
            this.chkWanita.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(77)))));
            this.chkWanita.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.chkWanita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(77)))));
            this.chkWanita.Location = new System.Drawing.Point(116, 297);
            this.chkWanita.Name = "chkWanita";
            this.chkWanita.Size = new System.Drawing.Size(101, 21);
            this.chkWanita.TabIndex = 12;
            this.chkWanita.Text = "Perempuan";
            this.chkWanita.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkWanita.UncheckedState.BorderRadius = 5;
            this.chkWanita.UncheckedState.BorderThickness = 0;
            this.chkWanita.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkWanita.CheckedChanged += new System.EventHandler(this.chkWanita_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(19, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tanggal Masuk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(19, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tanggal Keluar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "TAMBAH DATA NAPI";
            // 
            // cmbIdSel
            // 
            this.cmbIdSel.BackColor = System.Drawing.Color.Transparent;
            this.cmbIdSel.BorderRadius = 10;
            this.cmbIdSel.BorderThickness = 0;
            this.cmbIdSel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIdSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdSel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cmbIdSel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIdSel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIdSel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.cmbIdSel.ForeColor = System.Drawing.Color.Black;
            this.cmbIdSel.ItemHeight = 30;
            this.cmbIdSel.Location = new System.Drawing.Point(22, 245);
            this.cmbIdSel.Name = "cmbIdSel";
            this.cmbIdSel.Size = new System.Drawing.Size(298, 36);
            this.cmbIdSel.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(394, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Masukan Wajah Pelaku";
            // 
            // btnBatal
            // 
            this.btnBatal.BorderRadius = 10;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBatal.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(345, 461);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(300, 53);
            this.btnBatal.TabIndex = 21;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderRadius = 10;
            this.pbFoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pbFoto.ImageRotate = 0F;
            this.pbFoto.Location = new System.Drawing.Point(345, 108);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(300, 200);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 9;
            this.pbFoto.TabStop = false;
            // 
            // FormTambahNarapidana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(657, 534);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdSel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkWanita);
            this.Controls.Add(this.chkPria);
            this.Controls.Add(this.btnPilihGambar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.dtpKeluar);
            this.Controls.Add(this.dtpMasuk);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtPidana);
            this.Controls.Add(this.txtPekerjaan);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahNarapidana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahNarapidana";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtAlamat;
        private Guna.UI2.WinForms.Guna2TextBox txtPekerjaan;
        private Guna.UI2.WinForms.Guna2TextBox txtPidana;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMasuk;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpKeluar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox pbFoto;
        private Guna.UI2.WinForms.Guna2Button btnPilihGambar;
        private Guna.UI2.WinForms.Guna2CheckBox chkWanita;
        private Guna.UI2.WinForms.Guna2CheckBox chkPria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIdSel;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private System.Windows.Forms.Label label4;
    }
}