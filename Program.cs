using System;

namespace calculatorTugas1
{
    class Program
    {
        static double penjumlahan()
        {
            double hasil = 0;
            string? keputusan;
            Console.WriteLine("Operasi Penjumlahan");

            do
            {
                Console.Write("angka : ");
                double angka = Convert.ToDouble(Console.ReadLine());

                hasil = hasil + angka;
                Console.WriteLine("Hasil Penjumlahan = " + hasil);

                Console.Write("lanjut (y/n) : ");
                keputusan = Console.ReadLine();

            } while (keputusan == "y" || keputusan == "Y");

            return hasil;

        }
        static double perkalian()
        {
            double hasil = 1;
            string? keputusan;

            Console.WriteLine("Operasi Perkalian");

            do
            {
                Console.Write("angka : ");
                double angka = Convert.ToDouble(Console.ReadLine());

                hasil = hasil * angka;
                Console.WriteLine("Hasil Perkalian = " + hasil);

                Console.Write("lanjut (y/n) : ");
                keputusan = Console.ReadLine();

            } while (keputusan == "y" || keputusan == "Y");

            return hasil;

        }
        static double pengurangan()
        {
            int i = 0;
            string? keputusan;
            double hasil = 0;

            Console.WriteLine("Operasi Pengurangan");

            do
            {
                i++;

                if (i > 1)
                {
                    Console.Write("angka : ");
                    double angka = Convert.ToDouble(Console.ReadLine());

                    hasil = hasil - angka;
                    Console.WriteLine("Hasil Pengurangan = " + hasil);
                }
                else
                {
                    Console.Write("angka 1: ");
                    double angka1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("angka 2: ");
                    double angka2 = Convert.ToDouble(Console.ReadLine());
                    hasil = angka1 - angka2;
                    Console.WriteLine("Hasil Pengurangan = " + hasil);
                }


                Console.Write("lanjut (y/n) : ");
                keputusan = Console.ReadLine();

            } while (keputusan == "y" || keputusan == "Y");

            return hasil;

        }
        static double pembagian()
        {
            int i = 0;
            string? keputusan;
            double hasil = 0;

            Console.WriteLine("Operasi Pembagian");

            do
            {
                i++;

                if (i > 1)
                {
                    Console.Write("angka : ");
                    double angka = Convert.ToDouble(Console.ReadLine());

                    hasil = hasil / angka;
                    Console.WriteLine("Hasil Pembagian = " + hasil);
                }
                else
                {
                    Console.Write("angka 1: ");
                    double angka1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("angka 2: ");
                    double angka2 = Convert.ToDouble(Console.ReadLine());
                    hasil = angka1 / angka2;
                    Console.WriteLine("Hasil Pembagian = " + hasil);
                }


                Console.Write("lanjut (y/n) : ");
                keputusan = Console.ReadLine();

            } while (keputusan == "y" || keputusan == "Y");

            return hasil;

        }


        public static void Main(string[] args)
        {
            string? decide;
            do
            {
                Console.Write("pilih simbol operasi perhitungan ( +, -, *, /) : ");
                string? operasi = Console.ReadLine();

                switch (operasi)
                {
                    case "+":
                        penjumlahan();
                        break;

                    case "-":
                        pengurangan();
                        break;

                    case "*":
                        perkalian();
                        break;

                    case "/":
                        pembagian();
                        break;

                    default:
                        Console.WriteLine("operasi tidak ada");
                        break;
                }
                Console.Write("Anda ingin keluar dari kalkulator ini (y/n):");
                decide = Console.ReadLine();

            }
            while (decide == "n" || decide == "N");
        }


    }
}



