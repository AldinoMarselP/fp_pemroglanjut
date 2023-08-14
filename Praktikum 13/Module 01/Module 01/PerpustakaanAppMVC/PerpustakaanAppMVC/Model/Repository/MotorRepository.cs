using System;
using System.Collections.Generic;

using System.Data.SQLite;
using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Model.Context;

namespace PerpustakaanAppMVC.Model.Repository
{
    public class MotorRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public MotorRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Motor motor)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into motor (plat, merek, thn_kendaraan, warna)
                           values (@plat, @merek, @thn_kendaraan, @warna)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@plat", motor.Plat);
                cmd.Parameters.AddWithValue("@merek", motor.Merek);
                cmd.Parameters.AddWithValue("@thn_kendaraan", motor.Tahun);
                cmd.Parameters.AddWithValue("@warna", motor.Warna);

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

        public int Update(Motor motor)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update motor set merek = @merek, thn_kendaraan = @thn_kendaraan, warna = @warna
                           where plat = @plat";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@merek", motor.Merek);
                cmd.Parameters.AddWithValue("@thn_kendaraan", motor.Tahun);
                cmd.Parameters.AddWithValue("@plat", motor.Plat);
                cmd.Parameters.AddWithValue("@warna", motor.Warna);

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

        public int Delete(Motor motor)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from motor
                           where plat = @plat";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@plat", motor.Plat);

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

        public List<Motor> ReadAll()
        {
            // membuat objek collection untuk menampung objek motor
            List<Motor> list = new List<Motor>();            

            try
            {
                // deklarasi perintah SQL
                string sql = @"select *
                               from motor 
                               order by plat";

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
                            Motor motor = new Motor();
                            motor.Plat = dtr["plat"].ToString();
                            motor.Merek = dtr["merek"].ToString();
                            motor.Tahun = dtr["thn_kendaraan"].ToString();
                            motor.Warna = dtr["warna"].ToString();

                            // tambahkan objek motor ke dalam collection
                            list.Add(motor);
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

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian merek
        public List<Motor> ReadByMerek(string merek)
        {
            // membuat objek collection untuk menampung objek motor
            List<Motor> list = new List<Motor>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from motor 
                               where merek like @merek
                               order by merek";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@merek", "%" + merek + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Motor motor = new Motor();
                            motor.Plat = dtr["plat"].ToString();
                            motor.Merek = dtr["merek"].ToString();
                            motor.Tahun = dtr["thn_kendaraan"].ToString();
                            motor.Warna = dtr["warna"].ToString();

                            // tambahkan objek motor ke dalam collection
                            list.Add(motor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByMerek error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian merek
        public List<Motor> ReadByTahun(string thn_kendaraan)
        {
            // membuat objek collection untuk menampung objek motor
            List<Motor> list = new List<Motor>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from motor 
                               where thn_kendaraan like @thn_kendaraan
                               order by thn_kendaraan";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@thn_kendaraan", "%" + thn_kendaraan + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Motor motor = new Motor();
                            motor.Plat = dtr["plat"].ToString();
                            motor.Merek = dtr["merek"].ToString();
                            motor.Tahun = dtr["thn_kendaraan"].ToString();
                            motor.Warna = dtr["warna"].ToString();

                            // tambahkan objek motor ke dalam collection
                            list.Add(motor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByTahun error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian merek
        public List<Motor> ReadByPlat(string plat)
        {
            // membuat objek collection untuk menampung objek motor
            List<Motor> list = new List<Motor>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from motor 
                               where plat like @plat
                               order by plat";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@plat", "%" + plat + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Motor motor = new Motor();
                            motor.Plat = dtr["plat"].ToString();
                            motor.Merek = dtr["merek"].ToString();
                            motor.Tahun = dtr["thn_kendaraan"].ToString();
                            motor.Warna = dtr["warna"].ToString();

                            // tambahkan objek motor ke dalam collection
                            list.Add(motor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByPlat error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian merek
        public List<Motor> ReadByWarna(string warna)
        {
            // membuat objek collection untuk menampung objek motor
            List<Motor> list = new List<Motor>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * 
                               from motor 
                               where warna like @warna
                               order by warna";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@warna", "%" + warna + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Motor motor = new Motor();
                            motor.Plat = dtr["plat"].ToString();
                            motor.Merek = dtr["merek"].ToString();
                            motor.Tahun = dtr["thn_kendaraan"].ToString();
                            motor.Warna = dtr["warna"].ToString();

                            // tambahkan objek motor ke dalam collection
                            list.Add(motor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByWarna error: {0}", ex.Message);
            }

            return list;
        }
    }
}
