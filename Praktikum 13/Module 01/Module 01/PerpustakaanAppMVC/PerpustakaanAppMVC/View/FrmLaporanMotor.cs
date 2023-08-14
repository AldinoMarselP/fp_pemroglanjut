using System;
using System.Windows.Forms;
using System.Collections.Generic;

using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Controller;

namespace PerpustakaanAppMVC.View
{
    public partial class FrmLaporanMotor : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Motor> listOfMotor = new List<Motor>();

        // deklarasi objek controller
        private MotorController controller = new MotorController();

        public FrmLaporanMotor()
        {
            InitializeComponent();
            InisialisasiListView();            
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwMotor.View = System.Windows.Forms.View.Details;
            lvwMotor.FullRowSelect = true;
            lvwMotor.GridLines = true;

            lvwMotor.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("No.Kendaraan", 100, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Merek", 200, HorizontalAlignment.Left);
            lvwMotor.Columns.Add("Tahun Kendaraan", 150, HorizontalAlignment.Center);
            lvwMotor.Columns.Add("Warna", 150, HorizontalAlignment.Center);
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            if (rdoSemua.Checked)
            {
                TampilkanSemuaMotor();
            }
            else if (rdoBerdasarkanPlat.Checked)
            {
                TampilkanMotorBerdasarkanPlat();
            }
            else if (rdoBerdasarkanMerek.Checked)
            {
                TampilkanMotorBerdasarkanMerek();
            }
            else if (rdoBerdasarkanWarna.Checked)
            {
                TampilkanMotorBerdasarkanWarna();
            }
            else if (rdoBerdasarkanTahun.Checked)
            {
                TampilkanMotorBerdasarkanTahun();
            }
        }

        private void TampilkanSemuaMotor()
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

        private void TampilkanMotorBerdasarkanMerek()
        {
            // kosongkan listview
            lvwMotor.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
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

        private void TampilkanMotorBerdasarkanTahun()
        {
            // kosongkan listview
            lvwMotor.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfMotor = controller.ReadByTahun(txtTahun.Text);

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

        private void TampilkanMotorBerdasarkanPlat()
        {
            // kosongkan listview
            lvwMotor.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfMotor = controller.ReadByPlat(txtPlat.Text);

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

        private void TampilkanMotorBerdasarkanWarna()
        {
            // kosongkan listview
            lvwMotor.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfMotor = controller.ReadByWarna(txtWarna.Text);

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
