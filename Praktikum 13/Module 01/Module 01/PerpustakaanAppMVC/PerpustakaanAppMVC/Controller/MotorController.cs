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
    public class MotorController
    {
        //deklarasi objek Repository untuk menjalankan operasi CRUD
        private MotorRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan merek
        /// </summary>
        /// <param name="plat"></param>
        /// <returns></returns>
        public List<Motor> ReadByPlat(string plat)
        {
            // membuat objek collection
            List<Motor> list = new List<Motor>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MotorRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByPlat(plat);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan merek
        /// </summary>
        /// <param name="warna"></param>
        /// <returns></returns>
        public List<Motor> ReadByWarna(string warna)
        {
            // membuat objek collection
            List<Motor> list = new List<Motor>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MotorRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByWarna(warna);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan merek
        /// </summary>
        /// <param name="merek"></param>
        /// <returns></returns>
        public List<Motor> ReadByMerek(string merek)
        {
            // membuat objek collection
            List<Motor> list = new List<Motor>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MotorRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByMerek(merek);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan merek
        /// </summary>
        /// <param name="tahun"></param>
        /// <returns></returns>
        public List<Motor> ReadByTahun(string tahun)
        {
            // membuat objek collection
            List<Motor> list = new List<Motor>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MotorRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByTahun(tahun);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data motor
        /// </summary>
        /// <returns></returns>
        public List<Motor> ReadAll()
        {
            // membuat objek collection
            List<Motor> list = new List<Motor>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MotorRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Motor motor)
        {
            int result = 0;

            // cek plat yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Plat))
            {
                MessageBox.Show("No.Kendaraan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek merek yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Merek))
            {
                MessageBox.Show("Merek harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Tahun))
            {
                MessageBox.Show("Tahun Kendaraan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(motor.Warna))
            {
                MessageBox.Show("Warna harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new MotorRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(motor);
            }

            if (result > 0)
            {
                MessageBox.Show("Data motor berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data motor gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Motor motor)
        {
            int result = 0;

            // cek plat yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Plat))
            {
                MessageBox.Show("No.Kendaraan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek merek yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Merek))
            {
                MessageBox.Show("Merek harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Tahun))
            {
                MessageBox.Show("Tahun Kendaraan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(motor.Warna))
            {
                MessageBox.Show("Warna harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MotorRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(motor);
            }

            if (result > 0)
            {
                MessageBox.Show("Data motor berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data motor gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Motor motor)
        {
            int result = 0;

            // cek nilai plat yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(motor.Plat))
            {
                MessageBox.Show("No.Kendaraan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new MotorRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(motor);
            }

            if (result > 0)
            {
                MessageBox.Show("Data motor berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data motor gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
