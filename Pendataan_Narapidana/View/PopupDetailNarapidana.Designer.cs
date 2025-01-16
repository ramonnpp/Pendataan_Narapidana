namespace Pendataan_Narapidana.View
{
    partial class PopupDetailNarapidana
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
            this.btnUbahFoto = new Guna.UI2.WinForms.Guna2Button();
            this.pbFoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtpKeluar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpMasuk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtPidana = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPekerjaan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAlamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cmbIdSel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUbahFoto
            // 
            this.btnUbahFoto.BorderRadius = 10;
            this.btnUbahFoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUbahFoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUbahFoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUbahFoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUbahFoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUbahFoto.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnUbahFoto.ForeColor = System.Drawing.Color.White;
            this.btnUbahFoto.Location = new System.Drawing.Point(447, 304);
            this.btnUbahFoto.Name = "btnUbahFoto";
            this.btnUbahFoto.Size = new System.Drawing.Size(180, 45);
            this.btnUbahFoto.TabIndex = 21;
            this.btnUbahFoto.Text = "Edit Gambar";
            this.btnUbahFoto.Click += new System.EventHandler(this.btnUbahFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderRadius = 10;
            this.pbFoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pbFoto.ImageRotate = 0F;
            this.pbFoto.Location = new System.Drawing.Point(327, 86);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(300, 200);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 20;
            this.pbFoto.TabStop = false;
            // 
            // dtpKeluar
            // 
            this.dtpKeluar.BorderRadius = 10;
            this.dtpKeluar.Checked = true;
            this.dtpKeluar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpKeluar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.dtpKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpKeluar.Location = new System.Drawing.Point(126, 351);
            this.dtpKeluar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpKeluar.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpKeluar.Name = "dtpKeluar";
            this.dtpKeluar.Size = new System.Drawing.Size(259, 36);
            this.dtpKeluar.TabIndex = 18;
            this.dtpKeluar.Value = new System.DateTime(2024, 12, 21, 19, 45, 24, 757);
            // 
            // dtpMasuk
            // 
            this.dtpMasuk.BorderRadius = 10;
            this.dtpMasuk.Checked = true;
            this.dtpMasuk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpMasuk.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.dtpMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpMasuk.Location = new System.Drawing.Point(126, 304);
            this.dtpMasuk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMasuk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMasuk.Name = "dtpMasuk";
            this.dtpMasuk.Size = new System.Drawing.Size(259, 36);
            this.dtpMasuk.TabIndex = 17;
            this.dtpMasuk.Value = new System.DateTime(2024, 12, 21, 19, 45, 24, 757);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Lime;
            this.btnEdit.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(16, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.txtPidana.Location = new System.Drawing.Point(9, 212);
            this.txtPidana.Name = "txtPidana";
            this.txtPidana.PasswordChar = '\0';
            this.txtPidana.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPidana.PlaceholderText = "Pidana";
            this.txtPidana.SelectedText = "";
            this.txtPidana.Size = new System.Drawing.Size(300, 36);
            this.txtPidana.TabIndex = 14;
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
            this.txtPekerjaan.Location = new System.Drawing.Point(9, 170);
            this.txtPekerjaan.Name = "txtPekerjaan";
            this.txtPekerjaan.PasswordChar = '\0';
            this.txtPekerjaan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPekerjaan.PlaceholderText = "Pekerjaan";
            this.txtPekerjaan.SelectedText = "";
            this.txtPekerjaan.Size = new System.Drawing.Size(300, 36);
            this.txtPekerjaan.TabIndex = 13;
            // 
            // txtAlamat
            // 
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
            this.txtAlamat.Location = new System.Drawing.Point(9, 128);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.PasswordChar = '\0';
            this.txtAlamat.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAlamat.PlaceholderText = "Alamat";
            this.txtAlamat.SelectedText = "";
            this.txtAlamat.Size = new System.Drawing.Size(300, 36);
            this.txtAlamat.TabIndex = 12;
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
            this.txtNama.Location = new System.Drawing.Point(9, 86);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNama.PlaceholderText = "Nama";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(298, 36);
            this.txtNama.TabIndex = 11;
            // 
            // btnHapus
            // 
            this.btnHapus.BorderRadius = 10;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.FillColor = System.Drawing.Color.Red;
            this.btnHapus.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.Black;
            this.btnHapus.Location = new System.Drawing.Point(202, 415);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(180, 45);
            this.btnHapus.TabIndex = 22;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tanggal Keluar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tanggal Masuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 28.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(84, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 54);
            this.label3.TabIndex = 25;
            this.label3.Text = "DETAIL NARAPIDANA";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
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
            this.cmbIdSel.Location = new System.Drawing.Point(9, 254);
            this.cmbIdSel.Name = "cmbIdSel";
            this.cmbIdSel.Size = new System.Drawing.Size(300, 36);
            this.cmbIdSel.TabIndex = 27;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderRadius = 10;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(589, 22);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(39, 45);
            this.guna2ControlBox2.TabIndex = 28;
            // 
            // PopupDetailNarapidana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(652, 485);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.cmbIdSel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbahFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.dtpKeluar);
            this.Controls.Add(this.dtpMasuk);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtPidana);
            this.Controls.Add(this.txtPekerjaan);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupDetailNarapidana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupDetailNarapidana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopupDetailNarapidana_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUbahFoto;
        private Guna.UI2.WinForms.Guna2PictureBox pbFoto;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpKeluar;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMasuk;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtPidana;
        private Guna.UI2.WinForms.Guna2TextBox txtPekerjaan;
        private Guna.UI2.WinForms.Guna2TextBox txtAlamat;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIdSel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}