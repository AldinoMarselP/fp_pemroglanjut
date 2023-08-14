using System;
using System.Collections.Generic;

using System.Data.SQLite;
using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Model.Context;

namespace PerpustakaanAppMVC.Model.Repository
{
    public class TransaksiRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public TransaksiRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Transaksi transaksi)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into transaksi (id_transaksi,tgl_pinjam, tgl_kembali, nama, merek, harga, bayar, kurang, status)
                           values (@id_transaksi, @tgl_pinjam, @tgl_kembali, @nama, @merek, @harga, @bayar, @kurang, @status)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_transaksi", transaksi.ID);
                cmd.Parameters.AddWithValue("@tgl_pinjam", transaksi.Tglp);
                cmd.Parameters.AddWithValue("@tgl_kembali", transaksi.Tglk);
                cmd.Parameters.AddWithValue("@nama", transaksi.Nama);
                cmd.Parameters.AddWithValue("@merek", transaksi.Merek);
                cmd.Parameters.AddWithValue("@harga", transaksi.Harga);
                cmd.Parameters.AddWithValue("@bayar", transaksi.Bayar);
                cmd.Parameters.AddWithValue("@kurang", transaksi.Kurang);
                cmd.Parameters.AddWithValue("@status", transaksi.Status);

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

        public int Update(Transaksi transaksi)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update transaksi set tgl_pinjam = @tgl_pinjam, tgl_kembali = @tgl_kembali, nama = @nama, merek = @merek, harga = @harga, bayar = @bayar, kurang = @kurang, status = @status
                           where id_transaksi = @id_transaksi";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_transaksi", transaksi.ID);
                cmd.Parameters.AddWithValue("@tgl_pinjam", transaksi.Tglp);
                cmd.Parameters.AddWithValue("@tgl_kembali", transaksi.Tglk);
                cmd.Parameters.AddWithValue("@nama", transaksi.Nama);
                cmd.Parameters.AddWithValue("@merek", transaksi.Merek);
                cmd.Parameters.AddWithValue("@harga", transaksi.Harga);
                cmd.Parameters.AddWithValue("@bayar", transaksi.Bayar);
                cmd.Parameters.AddWithValue("@kurang", transaksi.Kurang);
                cmd.Parameters.AddWithValue("@status", transaksi.Status);

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

        public int Delete(Transaksi transaksi)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from transaksi
                           where id_transaksi = @id_transaksi";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_transaksi", transaksi.ID);

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

        public List<Transaksi> ReadAll()
        {
            // membuat objek collection untuk menampung objek transaksi
            List<Transaksi> list = new List<Transaksi>();            

            try
            {
                // deklarasi perintah SQL
                string sql = @"select *
                               from transaksi 
                               order by id_transaksi";

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
                            Transaksi transaksi = new Transaksi();
                            transaksi.ID = dtr["id_transaksi"].ToString();
                            transaksi.Tglp = dtr["tgl_pinjam"].ToString();
                            transaksi.Tglk = dtr["tgl_kembali"].ToString();
                            transaksi.Nama = dtr["nama"].ToString();
                            transaksi.Merek = dtr["merek"].ToString();
                            transaksi.Harga = dtr["harga"].ToString();
                            transaksi.Bayar = dtr["bayar"].ToString();
                            transaksi.Kurang = dtr["kurang"].ToString();
                            transaksi.Status = dtr["status"].ToString();

                            // tambahkan objek transaksi ke dalam collection
                            list.Add(transaksi);
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

        public List<Transaksi> ReadById(string id)
        {
            // membuat objek collection untuk menampung objek transaksi
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from transaksi 
                               where id_transaksi like @id_transaksi
                               order by id_transaksi";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@id_transaksi", "%" + id + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Transaksi transaksi = new Transaksi();
                            transaksi.ID = dtr["id_transaksi"].ToString();
                            transaksi.Tglp = dtr["tgl_pinjam"].ToString();
                            transaksi.Tglk = dtr["tgl_kembali"].ToString();
                            transaksi.Nama = dtr["nama"].ToString();
                            transaksi.Merek = dtr["merek"].ToString();
                            transaksi.Harga = dtr["harga"].ToString();
                            transaksi.Bayar = dtr["bayar"].ToString();
                            transaksi.Kurang = dtr["kurang"].ToString();
                            transaksi.Status = dtr["status"].ToString();

                            // tambahkan objek transaksi ke dalam collection
                            list.Add(transaksi);
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


        public List<Transaksi> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek transaksi
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from transaksi 
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
                            Transaksi transaksi = new Transaksi();
                            transaksi.ID = dtr["id_transaksi"].ToString();
                            transaksi.Tglp = dtr["tgl_pinjam"].ToString();
                            transaksi.Tglk = dtr["tgl_kembali"].ToString();
                            transaksi.Nama = dtr["nama"].ToString();
                            transaksi.Merek = dtr["merek"].ToString();
                            transaksi.Harga = dtr["harga"].ToString();
                            transaksi.Bayar = dtr["bayar"].ToString();
                            transaksi.Kurang = dtr["kurang"].ToString();
                            transaksi.Status = dtr["status"].ToString();

                            // tambahkan objek transaksi ke dalam collection
                            list.Add(transaksi);
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

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian merek
        public List<Transaksi> ReadByTglp(string tglp)
        {
            // membuat objek collection untuk menampung objek transaksi
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from transaksi 
                               where tgl_pinjam like @tgl_pinjam
                               order by tgl_pinjam";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@tgl_pinjam", "%" + tglp + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Transaksi transaksi = new Transaksi();
                            //var harga = Convert.ToInt32(transaksi.Harga);

                            transaksi.ID = dtr["id_transaksi"].ToString();
                            transaksi.Tglp = dtr["tgl_pinjam"].ToString();
                            transaksi.Tglk = dtr["tgl_kembali"].ToString();
                            transaksi.Nama = dtr["nama"].ToString();
                            transaksi.Merek = dtr["merek"].ToString();
                            transaksi.Harga = dtr["harga"].ToString();
                            transaksi.Bayar = dtr["bayar"].ToString();
                            transaksi.Kurang = dtr["kurang"].ToString();
                            transaksi.Status = dtr["status"].ToString();

                            // tambahkan objek transaksi ke dalam collection
                            list.Add(transaksi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByTglp error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian merek
        public List<Transaksi> ReadByTglk(string tglk)
        {
            // membuat objek collection untuk menampung objek transaksi
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from transaksi 
                               where tgl_kembali like @tgl_kembali
                               order by tgl_kembali";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@tgl_kembali", "%" + tglk + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Transaksi transaksi = new Transaksi();
                            transaksi.ID = dtr["id_transaksi"].ToString();
                            transaksi.Tglp = dtr["tgl_pinjam"].ToString();
                            transaksi.Tglk = dtr["tgl_kembali"].ToString();
                            transaksi.Nama = dtr["nama"].ToString();
                            transaksi.Merek = dtr["merek"].ToString();
                            transaksi.Harga = dtr["harga"].ToString();
                            transaksi.Bayar = dtr["bayar"].ToString();
                            transaksi.Kurang = dtr["kurang"].ToString();
                            transaksi.Status = dtr["status"].ToString();

                            // tambahkan objek transaksi ke dalam collection
                            list.Add(transaksi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByTglk error: {0}", ex.Message);
            }

            return list;
        }
    }
}
