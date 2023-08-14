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
    public partial class FrmEntryPinjam : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Transaksi transaksi);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private TransaksiController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Transaksi transaksi;

        // constructor default
        public FrmEntryPinjam()
        {
            InitializeComponent();

            dtmPinjam.CustomFormat = "dd-MM-yyyy";
            dtmPinjam.Format = DateTimePickerFormat.Custom;
            String tanggal = dtmPinjam.Text;
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FrmEntryPinjam(string title, TransaksiController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryPinjam(string title, Transaksi obj, TransaksiController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            transaksi = obj; // set objek transaksi yang akan diedit

            // untuk edit data, tampilkan data lama

            txtId.Text = transaksi.ID;
            txtNama.Text = transaksi.Nama;
            txtMerek.Text = transaksi.Merek;
            dtmPinjam.Text = transaksi.Tglp;
            txtHarga.Text = transaksi.Harga;
            txtBayar.Text = transaksi.Bayar;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) transaksi = new Transaksi();

            // set nilai property objek mahasiswa yg diambil dari TextBox

            transaksi.ID = txtId.Text;
            transaksi.Nama = txtNama.Text;
            transaksi.Merek = txtMerek.Text;
            transaksi.Tglp = dtmPinjam.Text;
            transaksi.Harga = txtHarga.Text;
            transaksi.Bayar = txtBayar.Text;
            transaksi.Kurang = Convert.ToString(Convert.ToInt32(txtHarga.Text) - Convert.ToInt32(txtBayar.Text));
            if (transaksi.Kurang == "0")
            {
                transaksi.Status = "Lunas";
            }
            else
            {
                transaksi.Status = "Belum Lunas";
            }
            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(transaksi);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(transaksi); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtId.Clear();
                    txtNama.Clear();
                    txtMerek.Clear();
                    txtHarga.Clear();
                    txtBayar.Clear();

                    txtId.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(transaksi);

                if (result > 0)
                {
                    OnUpdate(transaksi); // panggil event OnUpdate
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
