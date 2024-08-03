using System.Runtime.CompilerServices;

namespace İkiBoyutluDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iki boyutlu array

            //int[,] dizi = new int[2, 3];

            //int[,] dizi2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //Console.WriteLine($"0,0 {dizi[0, 0]}");

            //Soru1) 



            int[,] orijinalMatris = new int[5, 5];

            MatrisiYap(orijinalMatris);

            Console.WriteLine("---------------");


            int birVar = 0;

            while (birVar < 5)
            {
                int sutun = new Random().Next(5);
                int satir = new Random().Next(5);

                if (orijinalMatris[sutun, satir] == 0)
                {
                    orijinalMatris[sutun, satir] = 1;
                    birVar++;
                }
            }

            MatrisiYap(orijinalMatris);

            Console.WriteLine("---------------");

            //jagged array 
            //nunu iki boyutluda yapabiliyosun

            int[][] duzensizDizi = new int[3][];

            int[] dizi1 = {1, 2, 3};
            duzensizDizi[0] = dizi1;

            int[] dizi2 = {4, 5, 6, 7};
            duzensizDizi[1] = dizi2;

            int[] dizi3 = { 8, 9 };
            duzensizDizi[2] = dizi3;

            Console.WriteLine(duzensizDizi[1][3]);

            foreach (var item in duzensizDizi)
            {
                foreach (var i in item)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }



            //5 elemanın her biri birer dizi.


        }

        static void MatrisiYap(int[,] orijinalMatris)
        {
            for (int j = 0; j < orijinalMatris.GetLength(0); j++)
            {
                for (int i = 0; i < orijinalMatris.GetLength(1); i++)
                {
                    Console.Write($" {orijinalMatris[j, i]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
