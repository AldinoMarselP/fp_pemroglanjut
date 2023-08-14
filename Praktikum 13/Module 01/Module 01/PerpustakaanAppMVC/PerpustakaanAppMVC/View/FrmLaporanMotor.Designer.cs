namespace PerpustakaanAppMVC.View
{
    partial class FrmLaporanMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLaporanMotor));
            this.rdoSemua = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanMerek = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanPlat = new System.Windows.Forms.RadioButton();
            this.lvwMotor = new System.Windows.Forms.ListView();
            this.txtMerek = new System.Windows.Forms.TextBox();
            this.txtPlat = new System.Windows.Forms.TextBox();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.rdoBerdasarkanWarna = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarkanTahun = new System.Windows.Forms.RadioButton();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdoSemua
            // 
            this.rdoSemua.AutoSize = true;
            this.rdoSemua.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSemua.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoSemua.Location = new System.Drawing.Point(12, 12);
            this.rdoSemua.Name = "rdoSemua";
            this.rdoSemua.Size = new System.Drawing.Size(102, 19);
            this.rdoSemua.TabIndex = 0;
            this.rdoSemua.TabStop = true;
            this.rdoSemua.Text = "Semua Motor";
            this.rdoSemua.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanMerek
            // 
            this.rdoBerdasarkanMerek.AutoSize = true;
            this.rdoBerdasarkanMerek.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanMerek.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanMerek.Location = new System.Drawing.Point(12, 36);
            this.rdoBerdasarkanMerek.Name = "rdoBerdasarkanMerek";
            this.rdoBerdasarkanMerek.Size = new System.Drawing.Size(139, 19);
            this.rdoBerdasarkanMerek.TabIndex = 1;
            this.rdoBerdasarkanMerek.TabStop = true;
            this.rdoBerdasarkanMerek.Text = "Berdasarkan Merek";
            this.rdoBerdasarkanMerek.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanPlat
            // 
            this.rdoBerdasarkanPlat.AutoSize = true;
            this.rdoBerdasarkanPlat.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanPlat.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanPlat.Location = new System.Drawing.Point(12, 59);
            this.rdoBerdasarkanPlat.Name = "rdoBerdasarkanPlat";
            this.rdoBerdasarkanPlat.Size = new System.Drawing.Size(184, 19);
            this.rdoBerdasarkanPlat.TabIndex = 2;
            this.rdoBerdasarkanPlat.TabStop = true;
            this.rdoBerdasarkanPlat.Text = "Berdasarkan No.Kendaraan";
            this.rdoBerdasarkanPlat.UseVisualStyleBackColor = true;
            // 
            // lvwMotor
            // 
            this.lvwMotor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lvwMotor.HideSelection = false;
            this.lvwMotor.Location = new System.Drawing.Point(12, 138);
            this.lvwMotor.Name = "lvwMotor";
            this.lvwMotor.Size = new System.Drawing.Size(636, 427);
            this.lvwMotor.TabIndex = 3;
            this.lvwMotor.UseCompatibleStateImageBehavior = false;
            // 
            // txtMerek
            // 
            this.txtMerek.Location = new System.Drawing.Point(214, 35);
            this.txtMerek.Name = "txtMerek";
            this.txtMerek.Size = new System.Drawing.Size(299, 20);
            this.txtMerek.TabIndex = 4;
            // 
            // txtPlat
            // 
            this.txtPlat.Location = new System.Drawing.Point(214, 58);
            this.txtPlat.Name = "txtPlat";
            this.txtPlat.Size = new System.Drawing.Size(105, 20);
            this.txtPlat.TabIndex = 4;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.BackColor = System.Drawing.SystemColors.Control;
            this.btnTampilkanData.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilkanData.Location = new System.Drawing.Point(530, 13);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(118, 64);
            this.btnTampilkanData.TabIndex = 5;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = false;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // rdoBerdasarkanWarna
            // 
            this.rdoBerdasarkanWarna.AutoSize = true;
            this.rdoBerdasarkanWarna.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanWarna.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanWarna.Location = new System.Drawing.Point(12, 105);
            this.rdoBerdasarkanWarna.Name = "rdoBerdasarkanWarna";
            this.rdoBerdasarkanWarna.Size = new System.Drawing.Size(140, 19);
            this.rdoBerdasarkanWarna.TabIndex = 6;
            this.rdoBerdasarkanWarna.TabStop = true;
            this.rdoBerdasarkanWarna.Text = "Berdasarkan Warna";
            this.rdoBerdasarkanWarna.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarkanTahun
            // 
            this.rdoBerdasarkanTahun.AutoSize = true;
            this.rdoBerdasarkanTahun.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBerdasarkanTahun.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoBerdasarkanTahun.Location = new System.Drawing.Point(12, 82);
            this.rdoBerdasarkanTahun.Name = "rdoBerdasarkanTahun";
            this.rdoBerdasarkanTahun.Size = new System.Drawing.Size(196, 19);
            this.rdoBerdasarkanTahun.TabIndex = 7;
            this.rdoBerdasarkanTahun.TabStop = true;
            this.rdoBerdasarkanTahun.Text = "Berdasarkan Tahun Kendaran";
            this.rdoBerdasarkanTahun.UseVisualStyleBackColor = true;
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(214, 82);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(105, 20);
            this.txtTahun.TabIndex = 8;
            // 
            // txtWarna
            // 
            this.txtWarna.Location = new System.Drawing.Point(214, 105);
            this.txtWarna.Name = "txtWarna";
            this.txtWarna.Size = new System.Drawing.Size(133, 20);
            this.txtWarna.TabIndex = 9;
            // 
            // FrmLaporanMotor
            // 
            this.AcceptButton = this.btnTampilkanData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(663, 577);
            this.Controls.Add(this.txtWarna);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.rdoBerdasarkanTahun);
            this.Controls.Add(this.rdoBerdasarkanWarna);
            this.Controls.Add(this.btnTampilkanData);
            this.Controls.Add(this.txtPlat);
            this.Controls.Add(this.txtMerek);
            this.Controls.Add(this.lvwMotor);
            this.Controls.Add(this.rdoBerdasarkanPlat);
            this.Controls.Add(this.rdoBerdasarkanMerek);
            this.Controls.Add(this.rdoSemua);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLaporanMotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Data Motor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSemua;
        private System.Windows.Forms.RadioButton rdoBerdasarkanMerek;
        private System.Windows.Forms.RadioButton rdoBerdasarkanPlat;
        private System.Windows.Forms.ListView lvwMotor;
        private System.Windows.Forms.TextBox txtMerek;
        private System.Windows.Forms.TextBox txtPlat;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.RadioButton rdoBerdasarkanWarna;
        private System.Windows.Forms.RadioButton rdoBerdasarkanTahun;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.TextBox txtWarna;
    }
}