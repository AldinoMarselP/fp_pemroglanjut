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
    public partial class FrmEntryMotor : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Motor motor);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private MotorController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Motor motor;

        // constructor default
        public FrmEntryMotor()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FrmEntryMotor(string title, MotorController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryMotor(string title, Motor obj, MotorController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            motor = obj; // set objek motor yang akan diedit

            // untuk edit data, tampilkan data lama
            txtPlat.Text = motor.Plat;
            txtMerek.Text = motor.Merek;
            txtTahun.Text = motor.Tahun;
            txtWarna.Text = motor.Warna;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) motor = new Motor();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            motor.Plat = txtPlat.Text;
            motor.Merek = txtMerek.Text;
            motor.Tahun = txtTahun.Text;
            motor.Warna = txtWarna.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(motor);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(motor); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtPlat.Clear();
                    txtMerek.Clear();
                    txtTahun.Clear();
                    txtWarna.Clear();

                    txtPlat.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(motor);

                if (result > 0)
                {
                    OnUpdate(motor); // panggil event OnUpdate
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
