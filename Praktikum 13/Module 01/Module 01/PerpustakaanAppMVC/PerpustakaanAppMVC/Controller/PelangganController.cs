using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Model.Repository;
using PerpustakaanAppMVC.Model.Context;

namespace PerpustakaanAppMVC.Controller
{
    public class PelangganController
    {
        //deklarasi objek Repository untuk menjalankan operasi CRUD
        private PelangganRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Pelanggan> ReadById(string id)
        {
            // membuat objek collection
            List<Pelanggan> list = new List<Pelanggan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadById(id);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="telepon"></param>
        /// <returns></returns>
        public List<Pelanggan> ReadByTelepon(string telepon)
        {
            // membuat objek collection
            List<Pelanggan> list = new List<Pelanggan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByTelepon(telepon);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Pelanggan> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Pelanggan> list = new List<Pelanggan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="alamat"></param>
        /// <returns></returns>
        public List<Pelanggan> ReadByAlamat(string alamat)
        {
            // membuat objek collection
            List<Pelanggan> list = new List<Pelanggan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByAlamat(alamat);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data pelanggan
        /// </summary>
        /// <returns></returns>
        public List<Pelanggan> ReadAll()
        {
            // membuat objek collection
            List<Pelanggan> list = new List<Pelanggan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Pelanggan pelanggan)
        {
            int result = 0;

            // cek id yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pelanggan.Id))
            {
                MessageBox.Show("ID Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pelanggan.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pelanggan.Alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.Telepon))
            {
                MessageBox.Show("No.Telepon harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PelangganRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(pelanggan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pelanggan gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Pelanggan pelanggan)
        {
            int result = 0;

            // cek id yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pelanggan.Id))
            {
                MessageBox.Show("ID Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pelanggan.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pelanggan.Alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.Telepon))
            {
                MessageBox.Show("No.Telepon harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(pelanggan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pelanggan gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Pelanggan pelanggan)
        {
            int result = 0;

            // cek nilai id yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pelanggan.Id))
            {
                MessageBox.Show("ID Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(pelanggan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pelanggan gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
