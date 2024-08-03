namespace MetodOrnekler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int sayi;
            // sayi = Convert.ToInt32(Console.ReadLine());
            // F(sayi);
            // Console.WriteLine(sayi); // hangi değer gelir?


            // Soru2
            //sayi = Convert.ToInt32(Console.ReadLine());
            // H(sayi);  // neden altını çiziyor?


            //// Soru3

            //sayi = Convert.ToInt32(Console.ReadLine());
            //H(ref sayi);
            //Console.WriteLine(sayi);  // hangi değer gelir?


            //// Soru4

            //sayi = Convert.ToInt32(Console.ReadLine());
            //U(sayi);  // neden altını çiziyor?


            //// Soru5

            //sayi = Convert.ToInt32(Console.ReadLine());
            //U(out sayi);
            //Console.WriteLine(sayi);  // hangi değer gelir?


            //1)Kendisine parametre olarak dik kenarlarının uzunluğu verilen bir üçgenin hipotenüsünü ref/out parametresi ile bulunuz
            //Hipotenüsü ref/out ile tanımlayın, ona göre metod içerisinde hesaplayıp değerini atayın. Ayrıca bu metod üçgenin alanını döndürsün.

                double x = 5;
                double y = 12;
             Console.WriteLine(Alan( x,  y, out double hipo));


        }

        static double Alan(double x, double y, out double hipo)
        {
            hipo = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine(hipo);
            return (x * y) / 2;

        }
        

        static void F(int x)
        {
            x++;
        }

        static void H(ref int x)
        {
            x++;
        }

        static void U(out int x)
        {
            x = 2;
            x = 9 * x;
        }
    }
}
