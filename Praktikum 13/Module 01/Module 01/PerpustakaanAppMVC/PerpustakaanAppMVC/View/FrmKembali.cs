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
    public partial class FrmKembali : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Transaksi> listOfKembali = new List<Transaksi>();

        // deklarasi objek controller
        private TransaksiController controller;

        // constructor
        public FrmKembali()
        {
            InitializeComponent();            

            // membuat objek controller
            controller = new TransaksiController();

            InisialisasiListView();
            LoadDataKembali();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwKembali.View = System.Windows.Forms.View.Details;
            lvwKembali.FullRowSelect = true;
            lvwKembali.GridLines = true;

            lvwKembali.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwKembali.Columns.Add("ID Transaksi", 91, HorizontalAlignment.Center);
            lvwKembali.Columns.Add("Nama Pelanggan", 200, HorizontalAlignment.Left);
            lvwKembali.Columns.Add("Merek Motor", 200, HorizontalAlignment.Center);
            lvwKembali.Columns.Add("Tanggal Pinjam", 100, HorizontalAlignment.Center);
            lvwKembali.Columns.Add("Tanggal Kembali", 100, HorizontalAlignment.Center);
            lvwKembali.Columns.Add("Harga(Rp)", 120, HorizontalAlignment.Center);
            lvwKembali.Columns.Add("Dibayar(Rp)", 120, HorizontalAlignment.Center);
            lvwKembali.Columns.Add("Kekurangan", 120, HorizontalAlignment.Center);
            lvwKembali.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataKembali()
        {
            // kosongkan listview
            lvwKembali.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfKembali = controller.ReadAll();

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfKembali)
            {
                var noUrut = lvwKembali.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Tglk);
                item.SubItems.Add(transaksi.Harga);
                item.SubItems.Add(transaksi.Bayar);
                item.SubItems.Add(transaksi.Kurang);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwKembali.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Transaksi transaksi)
        {
            // tambahkan objek transaksi yang baru ke dalam collection
            listOfKembali.Add(transaksi);

            int noUrut = lvwKembali.Items.Count + 1;

            // tampilkan data transaksi yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(transaksi.ID);
            item.SubItems.Add(transaksi.Nama);
            item.SubItems.Add(transaksi.Merek);
            item.SubItems.Add(transaksi.Tglp);
            item.SubItems.Add(transaksi.Tglk);
            item.SubItems.Add(transaksi.Harga);
            item.SubItems.Add(transaksi.Bayar);
            item.SubItems.Add(transaksi.Kurang);
            item.SubItems.Add(transaksi.Status);

            lvwKembali.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Transaksi transaksi)
        {
            // ambil index data transaksi yang edit
            int index = lvwKembali.SelectedIndices[0];

            // update informasi transaksi di listview
            ListViewItem itemRow = lvwKembali.Items[index];
            itemRow.SubItems[1].Text = transaksi.ID;
            itemRow.SubItems[2].Text = transaksi.Nama;
            itemRow.SubItems[3].Text = transaksi.Merek;
            itemRow.SubItems[4].Text = transaksi.Tglp;
            itemRow.SubItems[5].Text = transaksi.Tglk;
            itemRow.SubItems[6].Text = transaksi.Harga;
            itemRow.SubItems[7].Text = transaksi.Bayar;
            itemRow.SubItems[8].Text = transaksi.Kurang;
            itemRow.SubItems[9].Text = transaksi.Status;
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwKembali.SelectedItems.Count > 0)
            {
                // ambil objek transaksi yang mau diedit dari collection
                Transaksi transaksi = listOfKembali[lvwKembali.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryKembali frmEntry = new FrmEntryKembali("Edit Data Pengembalian", transaksi, controller);

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

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // kosongkan listview
            lvwKembali.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            listOfKembali = controller.ReadByNama(txtKembali.Text);

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfKembali)
            {
                var noUrut = lvwKembali.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Tglk);
                item.SubItems.Add(transaksi.Harga);
                item.SubItems.Add(transaksi.Bayar);
                item.SubItems.Add(transaksi.Kurang);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwKembali.Items.Add(item);
            }
        }
    }
}
