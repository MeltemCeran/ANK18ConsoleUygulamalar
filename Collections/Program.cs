using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");

            List<int> list = new List<int>();   

            list.Add(1);
            list.Add(20);
            list.Add(32);
            list.Remove(list.Count - 1);
            //list.Remove(32);
            //list.RemoveAt(2);

            List<int> list2 = new List<int>();

            list.Add(-1);
            list.Add(-22);
            list.Add(-32);

            foreach (int i in list2)
            {
                list.Add(i);
            }

            //Console.WriteLine(list.ElementAt(2));

            list.ForEach(x => Console.WriteLine(x + 5));

            Console.WriteLine(list.Sum());

            Console.WriteLine(list.Count);

            //Console.WriteLine(list[2]); //eleman çağırmak için

            //mülakat: liste.Add(1); ekleme yapmak için böyleli.

            Console.WriteLine("--------------");
            ArrayList list3 = new ArrayList();

            list3.Add(1);
            list3.Add("Ali");
            list3.Add(true);

            //for (int i = 0; i < list3.Count; i++)
            //{ 
            //    Console.WriteLine(list3[i]);
            //}

            foreach (var i in list3)
            {
                var type = i.GetType();
                Console.WriteLine(type); // ya da console.writeline(i.GetType) da yazılabilirdi.
            }

            Console.WriteLine("--------------");

            int a = 9;
            double b = 8;
            char karakter = 'u';
            string kelime = "selam";
            bool süt = false;

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(karakter.GetType());
            Console.WriteLine(kelime.GetType());
            Console.WriteLine(süt.GetType());
            Console.WriteLine(list.GetType()); 


        }
    }
}
