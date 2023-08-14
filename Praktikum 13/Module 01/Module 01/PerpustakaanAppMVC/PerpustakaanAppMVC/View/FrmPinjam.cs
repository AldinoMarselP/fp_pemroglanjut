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
    public partial class FrmPinjam : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Transaksi> listOfPinjam = new List<Transaksi>();

        // deklarasi objek controller
        private TransaksiController controller;

        // constructor
        public FrmPinjam()
        {
            InitializeComponent();            

            // membuat objek controller
            controller = new TransaksiController();

            InisialisasiListView();
            LoadDataPinjam();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwPinjam.View = System.Windows.Forms.View.Details;
            lvwPinjam.FullRowSelect = true;
            lvwPinjam.GridLines = true;

            lvwPinjam.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwPinjam.Columns.Add("ID Transaksi", 91, HorizontalAlignment.Center);
            lvwPinjam.Columns.Add("Nama Pelanggan", 200, HorizontalAlignment.Left);
            lvwPinjam.Columns.Add("Merek Motor", 200, HorizontalAlignment.Center);
            lvwPinjam.Columns.Add("Tanggal Pinjam", 100, HorizontalAlignment.Center);
            lvwPinjam.Columns.Add("Harga(Rp)", 120, HorizontalAlignment.Center);
            lvwPinjam.Columns.Add("Dibayar(Rp)", 120, HorizontalAlignment.Center);
            lvwPinjam.Columns.Add("Kekurangan", 120, HorizontalAlignment.Center);
            lvwPinjam.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataPinjam()
        {
            // kosongkan listview
            lvwPinjam.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPinjam = controller.ReadAll();

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfPinjam)
            {
                var noUrut = lvwPinjam.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Harga);
                item.SubItems.Add(transaksi.Bayar);
                item.SubItems.Add(transaksi.Kurang);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwPinjam.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Transaksi transaksi)
        {
            // tambahkan objek transaksi yang baru ke dalam collection
            listOfPinjam.Add(transaksi);

            int noUrut = lvwPinjam.Items.Count + 1;

            // tampilkan data transaksi yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(transaksi.ID);
            item.SubItems.Add(transaksi.Nama);
            item.SubItems.Add(transaksi.Merek);
            item.SubItems.Add(transaksi.Tglp);
            item.SubItems.Add(transaksi.Harga);
            item.SubItems.Add(transaksi.Bayar);
            item.SubItems.Add(transaksi.Kurang);
            item.SubItems.Add(transaksi.Status);

            lvwPinjam.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Transaksi transaksi)
        {
            // ambil index data transaksi yang edit
            int index = lvwPinjam.SelectedIndices[0];

            // update informasi transaksi di listview
            ListViewItem itemRow = lvwPinjam.Items[index];
            itemRow.SubItems[1].Text = transaksi.ID;
            itemRow.SubItems[2].Text = transaksi.Nama;
            itemRow.SubItems[3].Text = transaksi.Merek;
            itemRow.SubItems[4].Text = transaksi.Tglp;
            itemRow.SubItems[5].Text = transaksi.Harga;
            itemRow.SubItems[6].Text = transaksi.Bayar;
            itemRow.SubItems[7].Text = transaksi.Kurang;
            itemRow.SubItems[8].Text = transaksi.Status;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // buat objek form entry data mahasiswa
            FrmEntryPinjam frmEntry = new FrmEntryPinjam("Tambah Data Peminjaman", controller);

            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;

            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwPinjam.SelectedItems.Count > 0)
            {
                // ambil objek transaksi yang mau diedit dari collection
                Transaksi transaksi = listOfPinjam[lvwPinjam.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryPinjam frmEntry = new FrmEntryPinjam("Edit Data Peminjaman", transaksi, controller);

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
            if (lvwPinjam.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data transaksi ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek transaksi yang mau dihapus dari collection
                    Transaksi transaksi = listOfPinjam[lvwPinjam.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(transaksi);
                    if (result > 0) LoadDataPinjam();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data transaksi belum dipilih !!!", "Peringatan",
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
            lvwPinjam.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            listOfPinjam = controller.ReadByNama(txtPinjam.Text);

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfPinjam)
            {
                var noUrut = lvwPinjam.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Harga);
                item.SubItems.Add(transaksi.Bayar);
                item.SubItems.Add(transaksi.Kurang);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwPinjam.Items.Add(item);
            }
        }
    }
}
