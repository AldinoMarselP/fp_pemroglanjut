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
    public partial class FrmPelanggan : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Pelanggan> listOfPelanggan = new List<Pelanggan>();

        // deklarasi objek controller
        private PelangganController controller;

        // constructor
        public FrmPelanggan()
        {
            InitializeComponent();            

            // membuat objek controller
            controller = new PelangganController();

            InisialisasiListView();
            LoadDataPelanggan();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwPelanggan.View = System.Windows.Forms.View.Details;
            lvwPelanggan.FullRowSelect = true;
            lvwPelanggan.GridLines = true;

            lvwPelanggan.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwPelanggan.Columns.Add("ID Pelanggan", 91, HorizontalAlignment.Center);
            lvwPelanggan.Columns.Add("Nama", 300, HorizontalAlignment.Left);
            lvwPelanggan.Columns.Add("Alamat", 300, HorizontalAlignment.Center);
            lvwPelanggan.Columns.Add("No.Telepon", 150, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataPelanggan()
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

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Pelanggan pelanggan)
        {
            // tambahkan objek pelanggan yang baru ke dalam collection
            listOfPelanggan.Add(pelanggan);

            int noUrut = lvwPelanggan.Items.Count + 1;

            // tampilkan data pelanggan yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pelanggan.Id);
            item.SubItems.Add(pelanggan.Nama);
            item.SubItems.Add(pelanggan.Alamat);
            item.SubItems.Add(pelanggan.Telepon);

            lvwPelanggan.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Pelanggan pelanggan)
        {
            // ambil index data pelanggan yang edit
            int index = lvwPelanggan.SelectedIndices[0];

            // update informasi pelanggan di listview
            ListViewItem itemRow = lvwPelanggan.Items[index];
            itemRow.SubItems[1].Text = pelanggan.Id;
            itemRow.SubItems[2].Text = pelanggan.Nama;
            itemRow.SubItems[3].Text = pelanggan.Alamat;
            itemRow.SubItems[4].Text = pelanggan.Telepon;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // buat objek form entry data mahasiswa
            FrmEntryPelanggan frmEntry = new FrmEntryPelanggan("Tambah Data Pelanggan", controller);

            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;

            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwPelanggan.SelectedItems.Count > 0)
            {
                // ambil objek pelanggan yang mau diedit dari collection
                Pelanggan pelanggan = listOfPelanggan[lvwPelanggan.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryPelanggan frmEntry = new FrmEntryPelanggan("Edit Data Pelanggan", pelanggan, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;

                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwPelanggan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pelanggan ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek pelanggan yang mau dihapus dari collection
                    Pelanggan pelanggan = listOfPelanggan[lvwPelanggan.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(pelanggan);
                    if (result > 0) LoadDataPelanggan();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data pelanggan belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // kosongkan listview
            lvwPelanggan.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
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
    }
}
