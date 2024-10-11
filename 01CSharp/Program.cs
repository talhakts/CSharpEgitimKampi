using System;
using System.Diagnostics.Eventing.Reader;

namespace _01CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            if (a + b > 8)
            {
                Console.WriteLine("Toplam 8 den büyük");


            }
            else if (a + b == 8) { Console.WriteLine("Toplam 8"); }
            else {
                Console.WriteLine("Toplam 8 den küçük");
            }
            Console.ReadKey();
        }
    }
}
