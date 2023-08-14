using System;
using System.Windows.Forms;
using System.Collections.Generic;

using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Controller;

namespace PerpustakaanAppMVC.View
{
    public partial class FrmLaporanTransaksi : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Transaksi> listOfTransaksi = new List<Transaksi>();

        // deklarasi objek controller
        private TransaksiController controller = new TransaksiController();

        public FrmLaporanTransaksi()
        {
            InitializeComponent();
            InisialisasiListView();

            dtmPinjam.CustomFormat = "dd-MM-yyyy";
            dtmPinjam.Format = DateTimePickerFormat.Custom;
            String tanggalp = dtmPinjam.Text;

            dtmKembali.CustomFormat = "dd-MM-yyyy";
            dtmKembali.Format = DateTimePickerFormat.Custom;
            String tanggalk = dtmKembali.Text;
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwTransaksi.View = System.Windows.Forms.View.Details;
            lvwTransaksi.FullRowSelect = true;
            lvwTransaksi.GridLines = true;

            lvwTransaksi.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("ID Transaksi", 91, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Nama Pelanggan", 200, HorizontalAlignment.Left);
            lvwTransaksi.Columns.Add("Merek Motor", 200, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Tanggal Pinjam", 100, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Tanggal Kembali", 100, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            if (rdoSemua.Checked)
            {
                TampilkanSemuaTransaksi();
            }
            else if (rdoBerdasarkanNama.Checked)
            {
                TampilkanMotorBerdasarkanNama();
            }
            else if (rdoBerdasarkanID.Checked)
            {
                TampilkanMotorBerdasarkanID();
            }
            else if (rdoBerdasarkanTglp.Checked)
            {
                TampilkanMotorBerdasarkanTglp();
            }
            else if (rdoBerdasarkanTglk.Checked)
            {
                TampilkanMotorBerdasarkanTglk();
            }
        }

        private void TampilkanSemuaTransaksi()
        {
            // kosongkan listview
            lvwTransaksi.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTransaksi = controller.ReadAll();

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfTransaksi)
            {
                var noUrut = lvwTransaksi.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Tglk);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwTransaksi.Items.Add(item);
            }
        }

        private void TampilkanMotorBerdasarkanNama()
        {
            // kosongkan listview
            lvwTransaksi.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTransaksi = controller.ReadByNama(txtNama.Text);

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfTransaksi)
            {
                var noUrut = lvwTransaksi.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Tglk);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwTransaksi.Items.Add(item);
            }
        }

        private void TampilkanMotorBerdasarkanID()
        {
            // kosongkan listview
            lvwTransaksi.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTransaksi = controller.ReadById(txtID.Text);

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfTransaksi)
            {
                var noUrut = lvwTransaksi.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Tglk);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwTransaksi.Items.Add(item);
            }
        }

        private void TampilkanMotorBerdasarkanTglp()
        {
            // kosongkan listview
            lvwTransaksi.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTransaksi = controller.ReadByTglp(dtmPinjam.Text);

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfTransaksi)
            {
                var noUrut = lvwTransaksi.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Tglk);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwTransaksi.Items.Add(item);
            }
        }

        private void TampilkanMotorBerdasarkanTglk()
        {
            // kosongkan listview
            lvwTransaksi.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTransaksi = controller.ReadByTglk(dtmKembali.Text);

            // ekstrak objek transaksi dari collection
            foreach (var transaksi in listOfTransaksi)
            {
                var noUrut = lvwTransaksi.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(transaksi.ID);
                item.SubItems.Add(transaksi.Nama);
                item.SubItems.Add(transaksi.Merek);
                item.SubItems.Add(transaksi.Tglp);
                item.SubItems.Add(transaksi.Tglk);
                item.SubItems.Add(transaksi.Status);

                // tampilkan data transaksi ke listview
                lvwTransaksi.Items.Add(item);
            }
        }
    }
}
