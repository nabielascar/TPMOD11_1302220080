using AljabarLibraries;
namespace AljabarDriver
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Pilih operasi:");
                Console.WriteLine("1. Akar Persamaan Kuadrat");
                Console.WriteLine("2. Hasil Kuadrat");
                Console.WriteLine("0. Keluar");

                int pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        AkarPersamaanKuadrat();
                        break;
                    case 2:
                        HasilKuadrat();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Coba lagi.");
                        break;
                }
            }
        }

        static void AkarPersamaanKuadrat()
        {
            Console.WriteLine("Masukkan koefisien a, b, dan c (dipisahkan spasi): ");
            string[] koefisienStr = Console.ReadLine().Split(' ');

            if (koefisienStr.Length != 3)
            {
                Console.WriteLine("Jumlah koefisien tidak valid.");
                return;
            }

            double[] koefisien = new double[3];
            for (int i = 0; i < 3; i++)
            {
                koefisien[i] = double.Parse(koefisienStr[i]);
            }

            double[] akar = Aljabar.AkarPersamaanKuadrat(koefisien);

            if (akar != null)
            {
                Console.WriteLine("Akar-akar persamaan:");
                for (int i = 0; i < akar.Length; i++)
                {
                    Console.WriteLine(akar[i]);
                }
            }
            else
            {
                Console.WriteLine("Persamaan tidak memiliki akar real.");
            }
        }

        static void HasilKuadrat()
        {
            Console.WriteLine("Masukkan koefisien a dan b (dipisahkan spasi): ");
            string[] koefisienStr = Console.ReadLine().Split(' ');

            if (koefisienStr.Length != 2)
            {
                Console.WriteLine("Jumlah koefisien tidak valid.");
                return;
            }

            double[] koefisien = new double[2];
            for (int i = 0; i < 2; i++)
            {
                koefisien[i] = double.Parse(koefisienStr[i]);
            }

            double[] hasilKuadrat = Aljabar.HasilKuadrat(koefisien);

            Console.WriteLine("Hasil kuadrat dari ({0}x + {1})^2 :", koefisien[0], koefisien[1]);
            for (int i = 0; i < hasilKuadrat.Length; i++)
            {
                Console.Write(hasilKuadrat[i] + " ");


            }
            Console.WriteLine("");

        }
    }
}
