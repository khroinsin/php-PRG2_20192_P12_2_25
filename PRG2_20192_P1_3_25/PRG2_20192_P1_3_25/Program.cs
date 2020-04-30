using System;

namespace PRG2_20192_P1_3_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM MENULIS SYAIR ANAK AYAM ===");
            Console.WriteLine("---------------------------------------");
            //input Banyak anak Ayam
            Console.Write("Banyak Anak Ayam (N) : ");
            int N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" ");
            
            int i;
            for (i = 1; i <= N; N--)
            {
               if (N == 1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal induknya", N);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", N, N-1);
                }
            }
        }
    }
}
