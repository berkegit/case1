using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Birinci sayıyı gir");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İKkinci sayı gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;

            Console.Write("tekrar sayı gir");

            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("ikincis sayı gir tekrar");

            sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam2 = sayi1 + sayi2;

            Console.WriteLine("Toplamlari:  " + toplam + "  " + toplam2);

            Console.ReadLine();
        }
    }
}
