using System.Dynamic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DictionaryAndFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dosyaya yazma

            //StreamWriter writer = new StreamWriter("C:\\Users\\HP\\source\\Repos\\ANK18ConsoleUygulamalar\\example.txt",true);
            ////burda bir kere true yazarsak sonsuza kadar eklenen tüm stringleri alt alta ya da yanyana ekler. Yani var olanı silmez.

            //writer.WriteLine("-----ANK18-----");
            //writer.WriteLine("Meltem Ceran");
            //writer.WriteLine("Gizem Bilgiç");
            //writer.WriteLine("Yahya Alkın Bayrak");
            //writer.WriteLine("Batuhan Özbakır");
            //writer.WriteLine("Merve Yücel");
            //writer.WriteLine("Mustafa Aygar");
            //writer.WriteLine("Efnan Genç");
            //writer.WriteLine("Minel Karaköçek");
            //writer.WriteLine("Fatih Aldanmaz");
            //writer.WriteLine("Aydan Çakmak");
            //writer.WriteLine("Hüseyin Eren Gündoğan");

            //writer.Close();

            //var anlikKlasör = Directory.GetCurrentDirectory();

            //StreamReader reader = new StreamReader("C:\\Users\\HP\\source\\Repos\\ANK18ConsoleUygulamalar\\minibirhikaye.txt");

            //string line = reader.ReadLine();

            //while (line!= null)
            //{
            //    Console.WriteLine(line);
            //    line = reader.ReadLine();
            //}
            //reader.Close();


            //BowlingOyunu();
            //SozlukUygulaması();
            //SozlukUygulamasıHocanınYaptigi();


            //1'den 100'e kadar olan sayılar arasından rastgele 10 tane olarak bir listeye ekleyiniz.
            //her sayı birbirinden farklı olmalıdır.
            //Sonra başka bir listeye bu oluşturulan sayıların yerlerini rastgele yerleştirecek.
            //sayılar aynı ama diğer listede yerleri değişecek.
            //eski listedeki elemanlardan kaç tanesinin yeri değişmiş kaç tanesinin yeri değişmemiş bulunuz.

            //RastgeleListe();
            //CoolNames();
            //KelimeBulmaca();
            //KelimeBulmacaReplace(); //bu olmadı :(
            CoolNames2();


        }

        private static void CoolNames2()
        {

            string name;

            Console.WriteLine("Lütfen isminizi ve soy isminizi giriniz:");

            name = Console.ReadLine();

            List<char> charList = new List<char>();

            charList = name.ToList();

            Queue<char> queue = new Queue<char>();

            foreach (char c in charList) 
            {
                queue.Enqueue(c);
            }

            
            foreach (char c in queue)
            {
                Console.WriteLine($"  *|| {c} ||*");
                Console.Write($"            *|| {c} ||*");
                Console.WriteLine();
                Thread.Sleep(1000/2);
            }




        }

        private static void KelimeBulmacaReplace()
        {
            Console.WriteLine("Bir cümle giriniz");

            string cumle;
            cumle = Console.ReadLine();

            Console.WriteLine("Lütfen aranacak kelimeyi giriniz");
            string kelime;
            kelime = Console.ReadLine();
            string kelime2 = "slm*";

            int sayac = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle.Contains(kelime))
                {
                    cumle = cumle.Replace(kelime, kelime2);
                    Console.WriteLine(cumle);
                    sayac++;
                }
            }

            Console.WriteLine(sayac);
            Console.WriteLine(cumle);

        }

        private static void KelimeBulmaca()
        {
            Console.WriteLine("Bir cümle giriniz");

            string cumle;
            cumle = Console.ReadLine();

            Console.WriteLine("Lütfen aranacak kelimeyi giriniz");
            string kelime;
            kelime = Console.ReadLine();


            string kelime2 = "selam";

            int sayac = 0;

            int count = 0;
            int index = 0;

            while ((index = cumle.IndexOf(kelime, index)) != -1)
            {
                count++;
                index += kelime.Length;
            }

            Console.WriteLine(count);

        }

        private static void CoolNames()
        {
            string name;

            Console.WriteLine("Lütfen isminizi giriniz:");

            name = Console.ReadLine();

           
            char[] charArray = name.ToCharArray();

            for (int i = 0; i < 10; i++)
            {
                foreach (char c in charArray)
                {
                    Console.WriteLine($" *|| {c} ||*");
                    Console.Write($"            *|| {c} ||*");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }

                foreach (char c in charArray)
                {
                    Console.WriteLine($"                 *|| {c} ||*");
                    Console.Write($"                            *|| {c} ||*");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }

                foreach (char c in charArray)
                {
                    Console.WriteLine($"                                 *|| {c} ||*");
                    Console.Write($"                                            *|| {c} ||*");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }
            }




        }

        private static void RastgeleListe()
        {

            var originalList = new List<int>();


            Random randomSayi = new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = randomSayi.Next(1, 101);

                if (!originalList.Contains(number))
                {
                    originalList.Add(number);
                }
                else
                {
                    i--;
                }


            }

            int sayac = 0;
            foreach (int number in originalList)
            {
                Console.WriteLine($"Orijinal listenin {sayac}. elemanı = ||{number}||");
                sayac++;
            }




            List<int> mixedList = new List<int>();

            Random randomYer = new Random();
            int randomIndex;

            for (int i = 0; i < originalList.Count; i++)
            {
                randomIndex = randomYer.Next(10);

                while (mixedList.Contains(originalList[randomIndex]))
                {
                    randomIndex = randomYer.Next(10);
                }

                mixedList.Add(originalList[randomIndex]);

            }
            sayac = 0;
            foreach (var number in mixedList)
            {
                Console.WriteLine($"                                  Mixed listenin {sayac}. elemanı = ||{number}||");
                sayac++;
            }

            //hangilerinin yerinin değişip değişmediğine bakıcam.

            int degisenler = 0;
            int degismeyenler = 0;
            for (int i = 0; i < originalList.Count; i++)
            {
                if (originalList[i] == mixedList[i])
                {

                    degismeyenler++;
                }
                else
                {
                    degisenler++;
                }

            }

            Console.WriteLine($"Yeri değişenlerin sayısı = {degisenler}");
            Console.WriteLine($"Yeri değişmeyenlerin sayısı = {degismeyenler}");

        }

        static bool KelimeAra(string kelime)
        {

            StreamReader streamReader = new StreamReader(@"C:\Users\hp\Desktop\sozluk.txt");

            string lines = streamReader.ReadLine();


            while (lines != null)
            {
                var kelimeAnlam = lines.Split(":");

                if (kelimeAnlam[0].ToLower() == kelime.ToLower())
                {
                    Console.WriteLine(lines);
                    streamReader.Close();
                    return true;
                }

                lines = streamReader.ReadLine();

            }
            streamReader.Close();
            return false;
        }

        private static void SozlukUygulamasıHocanınYaptigi()
        {
            Console.WriteLine("----ANK18 Sözlüğe Hoşgeldiniz----");
            string kelime;
            char devam;

            do
            {
                Console.WriteLine("Kelimeyi giriniz:");
                kelime = Console.ReadLine();


                if (KelimeAra(kelime))
                {
                    Console.WriteLine("Bulunmuştur");
                }
                else
                {
                    Console.WriteLine("Bulunamamıştır.");
                }

                Console.WriteLine("Devam etmek için D,d, çıkış için C,c yazınız");
                devam = Convert.ToChar(Console.ReadLine());

                while (char.ToLower(devam) != 'd' && char.ToLower(devam) != 'c')
                {
                    Console.WriteLine("Geçersiz karakter tekrar giriniz:");
                    devam = Convert.ToChar(Console.ReadLine());
                }
            } while (char.ToLower(devam) == 'd');
            Console.WriteLine("Program sonlanmıştır.");









        }

        private static void SozlukUygulaması()
        {

            StreamReader streamReader = new StreamReader(@"C:\Users\hp\Desktop\sozluk.txt");

            string lines = streamReader.ReadLine();
            string[] linesArray;

            Console.WriteLine("----ANK18 Sözlüğe Hoşgeldiniz----");

            Console.WriteLine("Kelimeyi Yazınız:");

            string kelime = Console.ReadLine();

            while (lines != null)
            {
                Console.WriteLine(lines);
                lines = streamReader.ReadLine();
                string[] x = lines.Split(":");

                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == kelime)
                    {
                        Console.WriteLine(x[i + 1]);
                    }
                }


            }















        }

        private static void BowlingOyunu()
        {
            //100 bowling oyuncusunun puanlarını oluşturunuz. Her oyuncunun 1 adet puanı olmalıdır
            //puanlar [0,300] aralığındadır. Oyuncular.txt isimli bir dosyaya yazdırınız. 


            StreamWriter yazici = new StreamWriter("C:\\Users\\HP\\source\\Repos\\ANK18ConsoleUygulamalar\\oyuncular.txt");



            int[] oyuncular = new int[100];


            for (int i = 0; i < oyuncular.Length; i++)
            {
                oyuncular[i] = new Random().Next(0, 301);

            }

            for (int i = 0; i < oyuncular.Length; i++)
            {
                yazici.WriteLine($"{i + 1} . oyuncu puanı = {oyuncular[i]}");
            }

            yazici.Flush();

            Console.WriteLine("------------");
            int maks = oyuncular.Max();
            int min = oyuncular.Min();
            int maksadet = 0;
            int minadet = 0;


            yazici.WriteLine($"Ortalama: {oyuncular.Average()}");
            yazici.WriteLine($"Maks: {maks}");
            yazici.WriteLine($"Min: {min}");

            for (int i = 0; i < oyuncular.Length; i++)
            {
                if (oyuncular[i] == maks)
                {
                    maks++;
                }
                else if (oyuncular[i] == min)
                {
                    min++;
                }
            }
            yazici.WriteLine($"Kırpılmış ortalama: {(oyuncular.Sum()) - (maksadet * maks) - (minadet * min)}");

        }


    }
}
