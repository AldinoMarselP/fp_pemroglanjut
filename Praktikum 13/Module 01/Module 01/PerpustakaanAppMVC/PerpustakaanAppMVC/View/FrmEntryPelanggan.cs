using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Controller;

namespace PerpustakaanAppMVC.View
{
    public partial class FrmEntryPelanggan : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Pelanggan pelanggan);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PelangganController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Pelanggan pelanggan;

        // constructor default
        public FrmEntryPelanggan()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FrmEntryPelanggan(string title, PelangganController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryPelanggan(string title, Pelanggan obj, PelangganController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            pelanggan = obj; // set objek pelanggan yang akan diedit

            // untuk edit data, tampilkan data lama
            txtId.Text = pelanggan.Id;
            txtNama.Text = pelanggan.Nama;
            txtAlamat.Text = pelanggan.Alamat;
            txtTelepon.Text = pelanggan.Telepon;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) pelanggan = new Pelanggan();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            pelanggan.Id = txtId.Text;
            pelanggan.Nama = txtNama.Text;
            pelanggan.Alamat = txtAlamat.Text;
            pelanggan.Telepon = txtTelepon.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(pelanggan);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(pelanggan); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtId.Clear();
                    txtNama.Clear();
                    txtAlamat.Clear();
                    txtTelepon.Clear();

                    txtId.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(pelanggan);

                if (result > 0)
                {
                    OnUpdate(pelanggan); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // tutup form entry mahasiswa
            this.Close();
        }
    }
}
