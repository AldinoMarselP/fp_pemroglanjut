using System;
using System.Windows.Forms;
using System.Collections.Generic;

using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Controller;

namespace PerpustakaanAppMVC.View
{
    public partial class FrmLaporanMahasiswa : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Mahasiswa> listOfMahasiswa = new List<Mahasiswa>();

        // deklarasi objek controller
        private MahasiswaController controller = new MahasiswaController();

        public FrmLaporanMahasiswa()
        {
            InitializeComponent();
            InisialisasiListView();            
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwMahasiswa.View = System.Windows.Forms.View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Npm", 91, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama", 350, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Angkatan", 80, HorizontalAlignment.Center);
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            if (rdoSemua.Checked)
            {
                TampilkanSemuaMahasiswa();
            }
            else if (rdoBerdasarkanNama.Checked)
            {
                TampilkanMahasiswaBerdasarkanNama();
            }
            else if (rdoBerdasarkanNim.Checked)
            {
                TampilkanMahasiswaBerdasarkanNim();
            }
        }

        private void TampilkanSemuaMahasiswa()
        {
            // kosongkan listview
            lvwMahasiswa.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfMahasiswa = controller.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var mhs in listOfMahasiswa)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Npm);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Angkatan);

                // tampilkan data mhs ke listview
                lvwMahasiswa.Items.Add(item);
            }
        }

        private void TampilkanMahasiswaBerdasarkanNama()
        {
            // kosongkan listview
            lvwMahasiswa.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfMahasiswa = controller.ReadByNama(txtNama.Text);

            // ekstrak objek mhs dari collection
            foreach (var mhs in listOfMahasiswa)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Npm);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Angkatan);

                // tampilkan data mhs ke listview
                lvwMahasiswa.Items.Add(item);
            }
        }

        private void TampilkanMahasiswaBerdasarkanNim()
        {
            // kosongkan listview
            lvwMahasiswa.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            Mahasiswa mhs = controller.ReadByNpm(txtNpm.Text);

            // ekstrak objek mhs dari collection
            if (mhs != null)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Npm);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Angkatan);

                // tampilkan data mhs ke listview
                lvwMahasiswa.Items.Add(item);
            }
        }
    }
}
