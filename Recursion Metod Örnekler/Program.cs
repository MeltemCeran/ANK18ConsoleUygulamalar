namespace Recursion_Metod_Örnekler
{
    internal class Program
    {

        //Tanım: Kendisini çağıran metodlara öz yinelemeli metodlar denir.
        //Metodun tanım kısmında (ne yapılacağını yazarken kendisini de tekrar çağırırsa buna özyineleme recursion denir.
        //recursion için 2 temel kural = 
        //1)Temel adım( base step) 
        //2)Temel adıma erişene kadar yapılan işlemler bütünü, genel adım.

        static void Main(string[] args)
        {

            Console.WriteLine(F(4));
            Console.WriteLine(GeriyeToplam(5));
            Console.WriteLine(Obeb(202,64));
            Console.WriteLine(SayiUssu(2,4));
            Console.WriteLine("slm");


            

        }

        static double F(int x)
        {
            // Temel adım
            if (x == 0)
                return 1;

            if (x < 0)
                throw new Exception("Negatif sayıların faktöriyeli hesaplanamaz.");


            return x * F(x - 1);
        }
        static int GeriyeToplam(int x)
        {
            if (x == 1)
                return 1;

            if (x == 0)
                return 0;

            return x + GeriyeToplam(x - 1);

        }

        static int Obeb(int a, int b)
        {
            if (a % b == 0)
                return b;

            return Obeb(b, a % b);

        }

        static int SayiUssu(int x, int y)
        {
            if (y == 0)
                return 1;
            if (y == 1)
                return x;

            return SayiUssu(x , y-1) * x;
        }
    }
}
