namespace PerpustakaanAppMVC.View
{
    partial class FrmLaporanPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLaporanPelanggan));
            this.rdoSemua = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanNama = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanId = new System.Windows.Forms.RadioButton();
            this.lvwPelanggan = new System.Windows.Forms.ListView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.rdoBerdasarkanTelepon = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanAlamat = new System.Windows.Forms.RadioButton();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdoSemua
            // 
            this.rdoSemua.AutoSize = true;
            this.rdoSemua.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSemua.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoSemua.Location = new System.Drawing.Point(12, 12);
            this.rdoSemua.Name = "rdoSemua";
            this.rdoSemua.Size = new System.Drawing.Size(128, 19);
            this.rdoSemua.TabIndex = 0;
            this.rdoSemua.TabStop = true;
            this.rdoSemua.Text = "Semua Pelanggan";
            this.rdoSemua.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanNama
            // 
            this.rdoBerdasarkanNama.AutoSize = true;
            this.rdoBerdasarkanNama.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanNama.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanNama.Location = new System.Drawing.Point(12, 34);
            this.rdoBerdasarkanNama.Name = "rdoBerdasarkanNama";
            this.rdoBerdasarkanNama.Size = new System.Drawing.Size(136, 19);
            this.rdoBerdasarkanNama.TabIndex = 1;
            this.rdoBerdasarkanNama.TabStop = true;
            this.rdoBerdasarkanNama.Text = "Berdasarkan Nama";
            this.rdoBerdasarkanNama.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanId
            // 
            this.rdoBerdasarkanId.AutoSize = true;
            this.rdoBerdasarkanId.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanId.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanId.Location = new System.Drawing.Point(12, 57);
            this.rdoBerdasarkanId.Name = "rdoBerdasarkanId";
            this.rdoBerdasarkanId.Size = new System.Drawing.Size(114, 19);
            this.rdoBerdasarkanId.TabIndex = 2;
            this.rdoBerdasarkanId.TabStop = true;
            this.rdoBerdasarkanId.Text = "Berdasarkan ID";
            this.rdoBerdasarkanId.UseVisualStyleBackColor = true;
            // 
            // lvwPelanggan
            // 
            this.lvwPelanggan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lvwPelanggan.HideSelection = false;
            this.lvwPelanggan.Location = new System.Drawing.Point(12, 138);
            this.lvwPelanggan.Name = "lvwPelanggan";
            this.lvwPelanggan.Size = new System.Drawing.Size(624, 427);
            this.lvwPelanggan.TabIndex = 3;
            this.lvwPelanggan.UseCompatibleStateImageBehavior = false;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(184, 33);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(299, 20);
            this.txtNama.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(184, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(105, 20);
            this.txtId.TabIndex = 4;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.BackColor = System.Drawing.SystemColors.Control;
            this.btnTampilkanData.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilkanData.Location = new System.Drawing.Point(518, 12);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(118, 64);
            this.btnTampilkanData.TabIndex = 5;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = false;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // rdoBerdasarkanTelepon
            // 
            this.rdoBerdasarkanTelepon.AutoSize = true;
            this.rdoBerdasarkanTelepon.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanTelepon.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanTelepon.Location = new System.Drawing.Point(12, 104);
            this.rdoBerdasarkanTelepon.Name = "rdoBerdasarkanTelepon";
            this.rdoBerdasarkanTelepon.Size = new System.Drawing.Size(166, 19);
            this.rdoBerdasarkanTelepon.TabIndex = 6;
            this.rdoBerdasarkanTelepon.TabStop = true;
            this.rdoBerdasarkanTelepon.Text = "Berdasarkan No.Telepon";
            this.rdoBerdasarkanTelepon.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanAlamat
            // 
            this.rdoBerdasarkanAlamat.AutoSize = true;
            this.rdoBerdasarkanAlamat.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanAlamat.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanAlamat.Location = new System.Drawing.Point(12, 80);
            this.rdoBerdasarkanAlamat.Name = "rdoBerdasarkanAlamat";
            this.rdoBerdasarkanAlamat.Size = new System.Drawing.Size(143, 19);
            this.rdoBerdasarkanAlamat.TabIndex = 7;
            this.rdoBerdasarkanAlamat.TabStop = true;
            this.rdoBerdasarkanAlamat.Text = "Berdasarkan Alamat";
            this.rdoBerdasarkanAlamat.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(184, 80);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(299, 20);
            this.txtAlamat.TabIndex = 8;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(184, 103);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(139, 20);
            this.txtTelepon.TabIndex = 9;
            // 
            // FrmLaporanPelanggan
            // 
            this.AcceptButton = this.btnTampilkanData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(648, 577);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.rdoBerdasarkanAlamat);
            this.Controls.Add(this.rdoBerdasarkanTelepon);
            this.Controls.Add(this.btnTampilkanData);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lvwPelanggan);
            this.Controls.Add(this.rdoBerdasarkanId);
            this.Controls.Add(this.rdoBerdasarkanNama);
            this.Controls.Add(this.rdoSemua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLaporanPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Data Pelanggan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSemua;
        private System.Windows.Forms.RadioButton rdoBerdasarkanNama;
        private System.Windows.Forms.RadioButton rdoBerdasarkanId;
        private System.Windows.Forms.ListView lvwPelanggan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.RadioButton rdoBerdasarkanTelepon;
        private System.Windows.Forms.RadioButton rdoBerdasarkanAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtTelepon;
    }
}