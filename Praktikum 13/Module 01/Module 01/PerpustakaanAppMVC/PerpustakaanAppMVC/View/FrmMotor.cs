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
    public partial class FrmMotor : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Motor> listOfMotor = new List<Motor>();

        // deklarasi objek controller
        private MotorController controller;

        // constructor
        public FrmMotor()
        {
            InitializeComponent();            

            // membuat objek controller
            controller = new MotorController();

            InisialisasiListView();
            LoadDataMotor();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwMotor.View = System.Windows.Forms.View.Details;
            lvwMotor.FullRowSelect = true;
            lvwMotor.GridLines = true;

            lvwMotor.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("No.Kendaraan", 200, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Merek", 300, HorizontalAlignment.Left);
            lvwMotor.Columns.Add("Tahun Kendaraan", 150, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Warna", 200, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataMotor()
        {
            // kosongkan listview
            lvwMotor.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfMotor = controller.ReadAll();

            // ekstrak objek motor dari collection
            foreach (var motor in listOfMotor)
            {
                var noUrut = lvwMotor.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(motor.Plat);
                item.SubItems.Add(motor.Merek);
                item.SubItems.Add(motor.Tahun);
                item.SubItems.Add(motor.Warna);

                // tampilkan data motor ke listview
                lvwMotor.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Motor motor)
        {
            // tambahkan objek motor yang baru ke dalam collection
            listOfMotor.Add(motor);

            int noUrut = lvwMotor.Items.Count + 1;

            // tampilkan data motor yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(motor.Plat);
            item.SubItems.Add(motor.Merek);
            item.SubItems.Add(motor.Tahun);
            item.SubItems.Add(motor.Warna);

            lvwMotor.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Motor motor)
        {
            // ambil index data motor yang edit
            int index = lvwMotor.SelectedIndices[0];

            // update informasi motor di listview
            ListViewItem itemRow = lvwMotor.Items[index];
            itemRow.SubItems[1].Text = motor.Plat;
            itemRow.SubItems[2].Text = motor.Merek;
            itemRow.SubItems[3].Text = motor.Tahun;
            itemRow.SubItems[4].Text = motor.Warna;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // buat objek form entry data mahasiswa
            FrmEntryMotor frmEntry = new FrmEntryMotor("Tambah Data Motor", controller);

            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;

            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwMotor.SelectedItems.Count > 0)
            {
                // ambil objek motor yang mau diedit dari collection
                Motor motor = listOfMotor[lvwMotor.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryMotor frmEntry = new FrmEntryMotor("Edit Data Motor", motor, controller);

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
            if (lvwMotor.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data motor ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek motor yang mau dihapus dari collection
                    Motor motor = listOfMotor[lvwMotor.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(motor);
                    if (result > 0) LoadDataMotor();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data motor belum dipilih !!!", "Peringatan",
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
            lvwMotor.Items.Clear();

            // panggil method ReadByMerek dan tampung datanya ke dalam collection
            listOfMotor = controller.ReadByMerek(txtMerek.Text);

            // ekstrak objek motor dari collection
            foreach (var motor in listOfMotor)
            {
                var noUrut = lvwMotor.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(motor.Plat);
                item.SubItems.Add(motor.Merek);
                item.SubItems.Add(motor.Tahun);
                item.SubItems.Add(motor.Warna);

                // tampilkan data motor ke listview
                lvwMotor.Items.Add(item);
            }
        }
    }
}
