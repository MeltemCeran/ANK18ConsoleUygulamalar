namespace ChessGame
{
    internal class Program
    {
        static void TahtaHazirla(string[,] tahta)
        {
            for (int i = 0; i < tahta.GetLength(0); i++)
            {
                for (int j = 0; j < tahta.GetLength(1); j++)
                {
                    tahta[i, j] = "#";

                }

            }
        }

        static void Yaz(string[,] tahta)
        {
            for (int i = 0; i < tahta.GetLength(0); i++)
            {
                for (int j = 0; j < tahta.GetLength(1); j++)
                {
                    Console.Write(" " + tahta[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
        static void GidebilecegiYerleriBelirle(string[,] tahta, int x, int y)
        {
            int gx = x, gy = y;
            //önce yatay sağ
            gx++;
            while (gx <= 7)
            {
                tahta[gx, gy] = "X";
                gx++;
            }
            gx = x;
            //sonra yatay sol
            gx--;
            while (gx >= 0)
            {
                tahta[gx, gy] = "X";
                gx--;
            }
            //sonra yukarı
            gx = x;
            gy++;
            while (gy <= 7)
            {
                tahta[gx, gy] = "X";
                gy++;
            }
            //aşağı
            gy = y;
            gy--;
            while (gy >= 0)
            {
                tahta[gx, gy] = "X";
                gy--;
            }
        }
        static void Main(string[] args)
        {
            int x, y;
            string[,] tahta = new string[8, 8];
            TahtaHazirla(tahta);
            Yaz(tahta);
            do
            {
                Console.WriteLine("Kalenin x konumunu yazınız");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalenin y konumunu yazınız");
                y = Convert.ToInt32(Console.ReadLine());
            } while (x < 0 || x > 7 || y < 0 || y > 7);

            //o zaman doğru girilmiş demektir (buraya geldiği zaman)
            //o koordinatların olduğu yere K ekle
            tahta[x, y] = "K";
            GidebilecegiYerleriBelirle(tahta, x, y);
            Yaz(tahta);

        }
    }
}
