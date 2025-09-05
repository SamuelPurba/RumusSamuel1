using System;

namespace HitungLuasPersegi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perulangan utama aplikasi
            while (true)
            {
                // Tampilkan menu utama
                Console.WriteLine("=== Selamat Datang di Kalkulator Samuel ===");
                Console.WriteLine("Pilih metode perhitungan luas segitiga sama sisi:");
                Console.WriteLine("A. Berdasarkan Hipotenusa");
                Console.WriteLine("B. Berdasarkan Alas dan Tinggi");
                Console.WriteLine("Ketik 'keluar' untuk mengakhiri program.");
                Console.Write("Pilihan Anda (A/B/keluar): ");

                string? pilihanSamuel = Console.ReadLine();

                // Keluar jika user mengetik 'keluar'
                if ((pilihanSamuel ?? string.Empty).Trim().ToLower() == "keluar")
                    break;

                // Proses jika user memilih Hipotenusa
                if ((pilihanSamuel ?? string.Empty).Trim().ToLower() == "a" ||
                    (pilihanSamuel ?? string.Empty).Trim().ToLower() == "hipotenusa")
                {
                    Console.Clear();
                    Console.WriteLine("=== Perhitungan Berdasarkan Hipotenusa ===");
                    Console.Write("Masukkan nilai hipotenusa (atau ketik 'keluar'): ");
                    string inputSamuel = Console.ReadLine() ?? string.Empty;

                    if (inputSamuel.Trim().ToLower() == "keluar")
                        break;

                    if (float.TryParse(inputSamuel, out float nilaiHipotenusa) && nilaiHipotenusa > 0)
                    {
                        // Rumus Samuel untuk luas segitiga sama sisi
                        float rasioSamuel = 6f / 7f;
                        float rasioHasiholan = 1f / 2f;
                        float hasilPurba = rasioSamuel * rasioHasiholan;
                        float luasSamuel = hasilPurba * (nilaiHipotenusa * nilaiHipotenusa);

                        Console.WriteLine($"Luas segitiga (versi Samuel) dengan hipotenusa {nilaiHipotenusa} adalah {luasSamuel:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Input tidak valid. Masukkan angka positif.");
                    }
                }
                // Proses jika user memilih Alas dan Tinggi
                else if ((pilihanSamuel ?? string.Empty).Trim().ToLower() == "b" ||
                         (pilihanSamuel ?? string.Empty).Trim().ToLower() == "alas")
                {
                    Console.Clear();
                    Console.WriteLine("=== Perhitungan Berdasarkan Alas dan Tinggi ===");
                    Console.Write("Masukkan panjang alas (atau ketik 'keluar'): ");
                    string alasSamuel = Console.ReadLine() ?? string.Empty;
                    if (alasSamuel.Trim().ToLower() == "keluar")
                        break;

                    Console.Write("Masukkan panjang tinggi (atau ketik 'keluar'): ");
                    string tinggiSamuel = Console.ReadLine() ?? string.Empty;
                    if (tinggiSamuel.Trim().ToLower() == "keluar")
                        break;

                    if (float.TryParse(alasSamuel, out float nilaiAlas) && nilaiAlas > 0 &&
                        float.TryParse(tinggiSamuel, out float nilaiTinggi) && nilaiTinggi > 0)
                    {
                        float nilaiHipotenusa = (float)Math.Sqrt((nilaiAlas * nilaiAlas) + (nilaiTinggi * nilaiTinggi));
                        float rasioSamuel = 6f / 7f;
                        float rasioHasiholan = 1f / 2f;
                        float hasilPurba = rasioSamuel * rasioHasiholan;
                        float luasSamuel = hasilPurba * (nilaiHipotenusa * nilaiHipotenusa);

                        Console.WriteLine($"Luas segitiga (versi Samuel) dengan hipotenusa {nilaiHipotenusa:F2} adalah {luasSamuel:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Input tidak valid. Masukkan angka positif.");
                    }
                }
                else
                {
                    Console.WriteLine("Pilihan tidak dikenali. Silakan masukkan A, B, atau 'keluar'.");
                }

                // Konfirmasi untuk melanjutkan atau keluar
                Console.WriteLine();
                Console.WriteLine("Tekan Enter untuk menghitung lagi atau ketik 'keluar' untuk mengakhiri.");
                string? lanjutSamuel = Console.ReadLine();
                if ((lanjutSamuel ?? string.Empty).Trim().ToLower() == "keluar")
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}