namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 3)
                throw new ArgumentException("Array persamaan harus memiliki panjang 3 (koefisien a, b, c)");

            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double diskriminan = (b * b) - 4 * a * c;

            if (diskriminan < 0)
                return null;

            double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);

            return new double[] { akar1, akar2 };
        }


        public static double[] HasilKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 2)
                throw new ArgumentException("Array persamaan harus memiliki panjang 2 (koefisien a, b)");

            double a = persamaan[0];
            double b = persamaan[1];

            double a2 = a * a;
            double ab2 = 2 * a * b;
            double b2 = b * b;

            return new double[] { a2, ab2, b2 };
        }
    }
}

