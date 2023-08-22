using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_37_22_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int input, last = 0;

            Console.Write("Girilecek Sayı Adedi: ");
            input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++) 
            {
                Console.Clear();
                Console.Write("{0}. Sayı: ", (i + 1));
                int add = int.Parse(Console.ReadLine());
                numbers.Add(add);
                last = last + add;
            }

            Console.WriteLine("_________________________");

            for (int i = 0;i < numbers.Count;i++) 
            {
                Console.WriteLine("{0}. Index Değeri: {1}",i,numbers[i]);
            }

            double avarage =(double) last / numbers.Count;

            Console.WriteLine("_________________________");
            Console.Write("Toplam: {0}; Ortalama: {1}",last,Math.Round(avarage,2));



            Console.ReadKey();
        }
    }
}
