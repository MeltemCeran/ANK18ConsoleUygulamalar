namespace Ödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)Fiyatı klavyeden girilen bir ürünün %20 kdvli fiyatını hesaplayan programı yazınız.

            double fiyat;

            Console.WriteLine("Lütfen ürün fiyatını giriniz:");

            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ürünün kdv dahil fiyatı: {(fiyat * 20 / 100) + fiyat}");

            //2)Kenar uzunluğu verilen bir karenin alan ve çevresini hesaplayan programı yazınız.


            int kenar;

            Console.WriteLine("Karenin bir kenar uzunluğunu yazınız:");
            kenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Alanı: {kenar * kenar} Çevresi: {4 * kenar}");

            //3)Ara sınav ve final sınav notlarının klavyeden girildiği, ara sınavın %40'ı ile
            //final sınavının %60'ının toplamını ekrana yazdıran programı yazınız.

            double ara, final;

            Console.WriteLine("Ara sınav notunuzu giriniz: ");
            ara = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final sınav notunuzu giriniz: ");
            final = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Sonuç: {(ara * 40 / 100) + (final * 60 / 100)}");

            //4)Klavyeden girilen celcius değerini fahrenheit'e çeviren programı yazınız.

            int celcius;
            Console.WriteLine("Lütfen sıcaklığı celcius değerinden yazınız:");
            celcius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fahrenheit: {celcius * 9 / 5 + 32}");


        }
    }
}
