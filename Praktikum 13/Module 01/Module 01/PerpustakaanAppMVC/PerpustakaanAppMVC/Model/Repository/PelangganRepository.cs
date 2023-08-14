using System;
using System.Collections.Generic;

using System.Data.SQLite;
using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Model.Context;

namespace PerpustakaanAppMVC.Model.Repository
{
    public class PelangganRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public PelangganRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Pelanggan pelanggan)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into pelanggan (id_pelanggan, nama, alamat, no_telepon)
                           values (@id_pelanggan, @nama, @alamat, @no_telepon)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_pelanggan", pelanggan.Id);
                cmd.Parameters.AddWithValue("@nama", pelanggan.Nama);
                cmd.Parameters.AddWithValue("@alamat", pelanggan.Alamat);
                cmd.Parameters.AddWithValue("@no_telepon", pelanggan.Telepon);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Pelanggan pelanggan)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update pelanggan set nama = @nama, alamat = @alamat, no_telepon = @no_telepon
                           where id_pelanggan = @id_pelanggan";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@nama", pelanggan.Nama);
                cmd.Parameters.AddWithValue("@alamat", pelanggan.Alamat);
                cmd.Parameters.AddWithValue("@id_pelanggan", pelanggan.Id);
                cmd.Parameters.AddWithValue("@no_telepon", pelanggan.Telepon);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Pelanggan pelanggan)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from pelanggan
                           where id_pelanggan = @id_pelanggan";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_pelanggan", pelanggan.Id);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Pelanggan> ReadAll()
        {
            // membuat objek collection untuk menampung objek pelanggan
            List<Pelanggan> list = new List<Pelanggan>();            

            try
            {
                // deklarasi perintah SQL
                string sql = @"select *
                               from pelanggan 
                               order by id_pelanggan";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pelanggan pelanggan = new Pelanggan();
                            pelanggan.Id = dtr["id_pelanggan"].ToString();
                            pelanggan.Nama = dtr["nama"].ToString();
                            pelanggan.Alamat = dtr["alamat"].ToString();
                            pelanggan.Telepon = dtr["no_telepon"].ToString();

                            // tambahkan objek pelanggan ke dalam collection
                            list.Add(pelanggan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian nama
        public List<Pelanggan> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek pelanggan
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from pelanggan 
                               where nama like @nama
                               order by nama";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pelanggan pelanggan = new Pelanggan();
                            pelanggan.Id = dtr["id_pelanggan"].ToString();
                            pelanggan.Nama = dtr["nama"].ToString();
                            pelanggan.Alamat = dtr["alamat"].ToString();
                            pelanggan.Telepon = dtr["no_telepon"].ToString();

                            // tambahkan objek pelanggan ke dalam collection
                            list.Add(pelanggan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian nama
        public List<Pelanggan> ReadByAlamat(string alamat)
        {
            // membuat objek collection untuk menampung objek pelanggan
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from pelanggan 
                               where alamat like @alamat
                               order by alamat";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@alamat", "%" + alamat + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pelanggan pelanggan = new Pelanggan();
                            pelanggan.Id = dtr["id_pelanggan"].ToString();
                            pelanggan.Nama = dtr["nama"].ToString();
                            pelanggan.Alamat = dtr["alamat"].ToString();
                            pelanggan.Telepon = dtr["no_telepon"].ToString();

                            // tambahkan objek pelanggan ke dalam collection
                            list.Add(pelanggan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByAlamat error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian nama
        public List<Pelanggan> ReadById(string id)
        {
            // membuat objek collection untuk menampung objek pelanggan
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from pelanggan 
                               where id_pelanggan like @id_pelanggan
                               order by id_pelanggan";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@id_pelanggan", "%" + id + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pelanggan pelanggan = new Pelanggan();
                            pelanggan.Id = dtr["id_pelanggan"].ToString();
                            pelanggan.Nama = dtr["nama"].ToString();
                            pelanggan.Alamat = dtr["alamat"].ToString();
                            pelanggan.Telepon = dtr["no_telepon"].ToString();

                            // tambahkan objek pelanggan ke dalam collection
                            list.Add(pelanggan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadById error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian nama
        public List<Pelanggan> ReadByTelepon(string telepon)
        {
            // membuat objek collection untuk menampung objek pelanggan
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from pelanggan 
                               where no_telepon like @no_telepon
                               order by no_telepon";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@no_telepon", "%" + telepon + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pelanggan pelanggan = new Pelanggan();
                            pelanggan.Id = dtr["id_pelanggan"].ToString();
                            pelanggan.Nama = dtr["nama"].ToString();
                            pelanggan.Alamat = dtr["alamat"].ToString();
                            pelanggan.Telepon = dtr["no_telepon"].ToString();

                            // tambahkan objek pelanggan ke dalam collection
                            list.Add(pelanggan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByTelepon error: {0}", ex.Message);
            }

            return list;
        }
    }
}
