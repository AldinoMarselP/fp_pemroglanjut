namespace PerpustakaanAppMVC.View
{
    partial class FrmLaporanTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLaporanTransaksi));
            this.rdoSemua = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanNama = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanID = new System.Windows.Forms.RadioButton();
            this.lvwTransaksi = new System.Windows.Forms.ListView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.rdoBerdasarkanTglk = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanTglp = new System.Windows.Forms.RadioButton();
            this.dtmPinjam = new System.Windows.Forms.DateTimePicker();
            this.dtmKembali = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rdoSemua
            // 
            this.rdoSemua.AutoSize = true;
            this.rdoSemua.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSemua.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoSemua.Location = new System.Drawing.Point(86, 8);
            this.rdoSemua.Name = "rdoSemua";
            this.rdoSemua.Size = new System.Drawing.Size(125, 19);
            this.rdoSemua.TabIndex = 0;
            this.rdoSemua.TabStop = true;
            this.rdoSemua.Text = "Semua Transaksi";
            this.rdoSemua.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanNama
            // 
            this.rdoBerdasarkanNama.AutoSize = true;
            this.rdoBerdasarkanNama.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanNama.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanNama.Location = new System.Drawing.Point(86, 32);
            this.rdoBerdasarkanNama.Name = "rdoBerdasarkanNama";
            this.rdoBerdasarkanNama.Size = new System.Drawing.Size(199, 19);
            this.rdoBerdasarkanNama.TabIndex = 1;
            this.rdoBerdasarkanNama.TabStop = true;
            this.rdoBerdasarkanNama.Text = "Berdasarkan Nama Pelanggan";
            this.rdoBerdasarkanNama.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanID
            // 
            this.rdoBerdasarkanID.AutoSize = true;
            this.rdoBerdasarkanID.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanID.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanID.Location = new System.Drawing.Point(86, 57);
            this.rdoBerdasarkanID.Name = "rdoBerdasarkanID";
            this.rdoBerdasarkanID.Size = new System.Drawing.Size(174, 19);
            this.rdoBerdasarkanID.TabIndex = 2;
            this.rdoBerdasarkanID.TabStop = true;
            this.rdoBerdasarkanID.Text = "Berdasarkan ID Transaksi";
            this.rdoBerdasarkanID.UseVisualStyleBackColor = true;
            // 
            // lvwTransaksi
            // 
            this.lvwTransaksi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lvwTransaksi.HideSelection = false;
            this.lvwTransaksi.Location = new System.Drawing.Point(12, 138);
            this.lvwTransaksi.Name = "lvwTransaksi";
            this.lvwTransaksi.Size = new System.Drawing.Size(821, 427);
            this.lvwTransaksi.TabIndex = 3;
            this.lvwTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(291, 33);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(299, 20);
            this.txtNama.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(291, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(93, 20);
            this.txtID.TabIndex = 4;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.BackColor = System.Drawing.SystemColors.Control;
            this.btnTampilkanData.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilkanData.Location = new System.Drawing.Point(635, 10);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(118, 64);
            this.btnTampilkanData.TabIndex = 5;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = false;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // rdoBerdasarkanTglk
            // 
            this.rdoBerdasarkanTglk.AutoSize = true;
            this.rdoBerdasarkanTglk.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanTglk.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanTglk.Location = new System.Drawing.Point(86, 104);
            this.rdoBerdasarkanTglk.Name = "rdoBerdasarkanTglk";
            this.rdoBerdasarkanTglk.Size = new System.Drawing.Size(197, 19);
            this.rdoBerdasarkanTglk.TabIndex = 6;
            this.rdoBerdasarkanTglk.TabStop = true;
            this.rdoBerdasarkanTglk.Text = "Berdasarkan Tanggal Kembali";
            this.rdoBerdasarkanTglk.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanTglp
            // 
            this.rdoBerdasarkanTglp.AutoSize = true;
            this.rdoBerdasarkanTglp.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanTglp.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanTglp.Location = new System.Drawing.Point(86, 80);
            this.rdoBerdasarkanTglp.Name = "rdoBerdasarkanTglp";
            this.rdoBerdasarkanTglp.Size = new System.Drawing.Size(189, 19);
            this.rdoBerdasarkanTglp.TabIndex = 7;
            this.rdoBerdasarkanTglp.TabStop = true;
            this.rdoBerdasarkanTglp.Text = "Berdasarkan Tanggal Pinjam";
            this.rdoBerdasarkanTglp.UseVisualStyleBackColor = true;
            // 
            // dtmPinjam
            // 
            this.dtmPinjam.Location = new System.Drawing.Point(291, 80);
            this.dtmPinjam.Name = "dtmPinjam";
            this.dtmPinjam.Size = new System.Drawing.Size(126, 20);
            this.dtmPinjam.TabIndex = 8;
            // 
            // dtmKembali
            // 
            this.dtmKembali.Location = new System.Drawing.Point(291, 104);
            this.dtmKembali.Name = "dtmKembali";
            this.dtmKembali.Size = new System.Drawing.Size(126, 20);
            this.dtmKembali.TabIndex = 9;
            // 
            // FrmLaporanTransaksi
            // 
            this.AcceptButton = this.btnTampilkanData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(845, 577);
            this.Controls.Add(this.dtmKembali);
            this.Controls.Add(this.dtmPinjam);
            this.Controls.Add(this.rdoBerdasarkanTglp);
            this.Controls.Add(this.rdoBerdasarkanTglk);
            this.Controls.Add(this.btnTampilkanData);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lvwTransaksi);
            this.Controls.Add(this.rdoBerdasarkanID);
            this.Controls.Add(this.rdoBerdasarkanNama);
            this.Controls.Add(this.rdoSemua);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLaporanTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Data Transaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSemua;
        private System.Windows.Forms.RadioButton rdoBerdasarkanNama;
        private System.Windows.Forms.RadioButton rdoBerdasarkanID;
        private System.Windows.Forms.ListView lvwTransaksi;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.RadioButton rdoBerdasarkanTglk;
        private System.Windows.Forms.RadioButton rdoBerdasarkanTglp;
        private System.Windows.Forms.DateTimePicker dtmPinjam;
        private System.Windows.Forms.DateTimePicker dtmKembali;
    }
}