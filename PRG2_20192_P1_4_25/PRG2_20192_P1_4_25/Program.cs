using System;

namespace PRG2_20192_P1_4_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRGRAM SEGITIGA SIKU-SIKU\n");
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("a. Hitung Luas");
            Console.WriteLine("b. Hitung Hipotenusa");
            Console.WriteLine("c. Hitung Keliling");
            Console.WriteLine("d. Keluar");

            // input menu
            Console.Write("Menu pilihan : ");
            char menu = Convert.ToChar(Console.ReadLine());

            double Luas = 0;
            double simi = 0;
            double Kel = 0;
            switch (menu)
            {
                case 'a':
                    Console.Write("Masukkan Alas Segitiga : ");
                    double Alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Tinggi Segitiga : ");
                    double Tinggi = Convert.ToDouble(Console.ReadLine());
                    Luas = Alas * Tinggi / 2;
                    Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", Alas, Tinggi, Luas);
                    break;

                case 'b':
                    Console.Write("Masukkan Alas Segitiga : ");
                    Alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Tinggi Segitiga : ");
                    Tinggi = Convert.ToDouble(Console.ReadLine());
                    simi = Math.Sqrt((Alas * Alas) + (Tinggi * Tinggi));
                    Console.WriteLine("Sisi miring segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", Alas, Tinggi, simi);
                    break;

                case 'c':
                    Console.Write("Masukkan Alas : ");
                    Alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Tinggi : ");
                    Tinggi = Convert.ToDouble(Console.ReadLine());
                    simi = Math.Sqrt((Alas * Alas) + (Tinggi * Tinggi));
                    Kel = Alas + Tinggi + simi;
                    Console.WriteLine("Keliling segitiga dengan alas {0}, tinggi {1}, dan sisi miring {2} adalah {3} satuan", Alas, Tinggi, simi, Kel);
                    break;

                case 'd':
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }   

        }
    }
}
