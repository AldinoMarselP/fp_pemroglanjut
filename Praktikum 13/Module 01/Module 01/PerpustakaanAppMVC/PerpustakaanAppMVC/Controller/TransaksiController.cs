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
    public class TransaksiController
    {
        //deklarasi objek Repository untuk menjalankan operasi CRUD
        private TransaksiRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Transaksi> ReadById(string id)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadById(id);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Transaksi> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="tglp"></param>
        /// <returns></returns>
        public List<Transaksi> ReadByTglp(string tglp)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByTglp(tglp);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="tglk"></param>
        /// <returns></returns>
        public List<Transaksi> ReadByTglk(string tglk)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByTglk(tglk);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data transaksi
        /// </summary>
        /// <returns></returns>
        public List<Transaksi> ReadAll()
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Transaksi transaksi)
        {
            int result = 0;

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(transaksi.ID))
            {
                MessageBox.Show("ID Transaksi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(transaksi.Nama))
            {
                MessageBox.Show("Nama Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(transaksi.Merek))
            {
                MessageBox.Show("Merek Motor harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong

            if (string.IsNullOrEmpty(transaksi.Tglp))
            {
                MessageBox.Show("Tanggal pinjam harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(transaksi.Bayar))
            {
                MessageBox.Show("Pembayaran harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransaksiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(transaksi);
            }

            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data transaksi gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Transaksi transaksi)
        {
            int result = 0;

            if (string.IsNullOrEmpty(transaksi.ID))
            {
                MessageBox.Show("ID Transaksi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(transaksi.Nama))
            {
                MessageBox.Show("Nama Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(transaksi.Merek))
            {
                MessageBox.Show("Merek Motor harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(transaksi.Tglp))
            {
                MessageBox.Show("Tanggal Pinjam harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(transaksi.Bayar))
            {
                MessageBox.Show("Pembayaran harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(transaksi);
            }

            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data transaksi gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Transaksi transaksi)
        {
            int result = 0;

            // cek nilai id yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(transaksi.ID))
            {
                MessageBox.Show("ID Transaksi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(transaksi);
            }

            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data transaksi gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
