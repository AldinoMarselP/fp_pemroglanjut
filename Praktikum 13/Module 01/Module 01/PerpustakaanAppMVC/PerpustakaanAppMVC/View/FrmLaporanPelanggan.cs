using System;
using System.Windows.Forms;
using System.Collections.Generic;

using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Controller;

namespace PerpustakaanAppMVC.View
{
    public partial class FrmLaporanPelanggan : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Pelanggan> listOfPelanggan = new List<Pelanggan>();

        // deklarasi objek controller
        private PelangganController controller = new PelangganController();

        public FrmLaporanPelanggan()
        {
            InitializeComponent();
            InisialisasiListView();            
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwPelanggan.View = System.Windows.Forms.View.Details;
            lvwPelanggan.FullRowSelect = true;
            lvwPelanggan.GridLines = true;

            lvwPelanggan.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwPelanggan.Columns.Add("ID Pelanggan", 91, HorizontalAlignment.Center);
            lvwPelanggan.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            lvwPelanggan.Columns.Add("Alamat", 200, HorizontalAlignment.Center);
            lvwPelanggan.Columns.Add("No.Telepon", 100, HorizontalAlignment.Center);
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            if (rdoSemua.Checked)
            {
                TampilkanSemuaPelanggan();
            }
            else if (rdoBerdasarkanId.Checked)
            {
                TampilkanPelangganBerdasarkanId();
            }
            else if (rdoBerdasarkanNama.Checked)
            {
                TampilkanPelangganBerdasarkanNama();
            }
            else if (rdoBerdasarkanTelepon.Checked)
            {
                TampilkanPelangganBerdasarkanTelepon();
            }
            else if (rdoBerdasarkanAlamat.Checked)
            {
                TampilkanPelangganBerdasarkanAlamat();
            }
        }

        private void TampilkanSemuaPelanggan()
        {
            // kosongkan listview
            lvwPelanggan.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPelanggan = controller.ReadAll();

            // ekstrak objek pelanggan dari collection
            foreach (var pelanggan in listOfPelanggan)
            {
                var noUrut = lvwPelanggan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.Id);
                item.SubItems.Add(pelanggan.Nama);
                item.SubItems.Add(pelanggan.Alamat);
                item.SubItems.Add(pelanggan.Telepon);

                // tampilkan data pelanggan ke listview
                lvwPelanggan.Items.Add(item);
            }
        }

        private void TampilkanPelangganBerdasarkanNama()
        {
            // kosongkan listview
            lvwPelanggan.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPelanggan = controller.ReadByNama(txtNama.Text);

            // ekstrak objek pelanggan dari collection
            foreach (var pelanggan in listOfPelanggan)
            {
                var noUrut = lvwPelanggan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.Id);
                item.SubItems.Add(pelanggan.Nama);
                item.SubItems.Add(pelanggan.Alamat);
                item.SubItems.Add(pelanggan.Telepon);

                // tampilkan data pelanggan ke listview
                lvwPelanggan.Items.Add(item);
            }
        }

        private void TampilkanPelangganBerdasarkanAlamat()
        {
            // kosongkan listview
            lvwPelanggan.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPelanggan = controller.ReadByAlamat(txtAlamat.Text);

            // ekstrak objek pelanggan dari collection
            foreach (var pelanggan in listOfPelanggan)
            {
                var noUrut = lvwPelanggan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.Id);
                item.SubItems.Add(pelanggan.Nama);
                item.SubItems.Add(pelanggan.Alamat);
                item.SubItems.Add(pelanggan.Telepon);

                // tampilkan data pelanggan ke listview
                lvwPelanggan.Items.Add(item);
            }
        }

        private void TampilkanPelangganBerdasarkanId()
        {
            // kosongkan listview
            lvwPelanggan.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPelanggan = controller.ReadById(txtId.Text);

            // ekstrak objek pelanggan dari collection
            foreach (var pelanggan in listOfPelanggan)
            {
                var noUrut = lvwPelanggan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.Id);
                item.SubItems.Add(pelanggan.Nama);
                item.SubItems.Add(pelanggan.Alamat);
                item.SubItems.Add(pelanggan.Telepon);

                // tampilkan data pelanggan ke listview
                lvwPelanggan.Items.Add(item);
            }
        }

        private void TampilkanPelangganBerdasarkanTelepon()
        {
            // kosongkan listview
            lvwPelanggan.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPelanggan = controller.ReadByTelepon(txtTelepon.Text);

            // ekstrak objek pelanggan dari collection
            foreach (var pelanggan in listOfPelanggan)
            {
                var noUrut = lvwPelanggan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pelanggan.Id);
                item.SubItems.Add(pelanggan.Nama);
                item.SubItems.Add(pelanggan.Alamat);
                item.SubItems.Add(pelanggan.Telepon);

                // tampilkan data pelanggan ke listview
                lvwPelanggan.Items.Add(item);
            }
        }
    }
}
