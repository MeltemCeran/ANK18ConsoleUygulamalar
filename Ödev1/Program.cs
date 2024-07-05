namespace Ödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Odev();

            

            //5)Kullanıcı tarafından girilen para miktarını, dolar ve euro kurunu ve, miktarı dolar ve euro cinsinden yazdıran programı yazınız.

            double miktar, dolarKuru, euroKuru;

            Console.WriteLine("Değerini öğrenmek istediğiniz para miktarını giriniz:");
            miktar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen dolar kurunu giriniz:");
            dolarKuru = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen euro kurunu giriniz:");
            euroKuru = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Dolar: {miktar / dolarKuru} Euro: {miktar / euroKuru}");

            //6)Dik kenar uzunlukları klavyeden girilen dik üçgenin alanını hesaplayan programı yazınız.

            int a, b;

            Console.WriteLine("Lütfen dik kenar uzunluklarını yazınız:");
            a = Convert.ToInt32(Console.ReadLine()); 
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Alan: { (a * b) /2.0 }");



        }

        private static void Odev()
        {
            //1)Fiyatı klavyeden girilen bir ürünün %20 kdvli fiyatını hesaplayan programı yazınız.

            double fiyat;

            Console.WriteLine("Lütfen ürün fiyatını giriniz:");

            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ürünün kdv dahil fiyatı: {fiyat * 1.20}");

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

            Console.WriteLine($"Sonuç: {(ara * 0.4) + (final * 0.6)}");

            //4)Klavyeden girilen celcius değerini fahrenheit'e çeviren programı yazınız.

            int celcius;
            Console.WriteLine("Lütfen sıcaklığı celcius değerinden yazınız:");
            celcius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fahrenheit: {celcius * 1.8 + 32}");
        }
    }
}
