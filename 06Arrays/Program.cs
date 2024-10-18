using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Formatları

            //2,4,6,8
            //Samsun, İstanbul, Ankara, Amasya
            //DeğişkenTürü [] DiziAdı =new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Sarı";
            //colors[3] = "Yeşil";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[2]);

            //int[] numbers=new int[10];
            //numbers[0] = 55;
            //numbers[1] = 34;
            //numbers[2] = 05;
            //numbers[3] = 29;
            //numbers[7] = 1950;

            //Console.WriteLine(numbers[1]);

            //string[] cities = { "Prag", "Roma", "Atina", "Samsun", "Amasya" };
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Beyaz", "Sarı", "Yeşil","Mavi","Turuncu" };

            //for(int i=0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 55, 85, 5, 34, 6, 29, 1950, 2004, 1357 };
            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    if (numbers[i] %3==0)
            //    {  Console.WriteLine(numbers[i]); }  

            //char[] symbols = { 'a', 'b', 'c', '*','/','T'};
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //Dizi içindeki en büyük sayıyı bulma

            //int[] myArray = { 1, 2, 55, 88, 12, 43, 77, 123, 5 };
            //int maxNumber= myArray[0];

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = {"Talha","Kayra","Ömer","Ayşegül","Ekrem" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 55, 5, 34, 29,432,221};
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i ++)
            //{ Console.WriteLine(numbers[i]); }

            //int[] numbers = { 55, 5, 34, 29, 432, 221 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{ Console.WriteLine(numbers[i]); }

            #endregion

            #region Dizi Metotları

            //Dizide aranan elemanın index numarası
            //string[] customers = {"Talha","Kayra","Ömer","Ayşegül","Ekrem"};
            //int index = Array.IndexOf(customers, "Ömer");
            //Console.WriteLine(index);

            //int[] numbers = { 55, 5, 34, 29, 44, 123, 99 };
            //Console.WriteLine("Dizinin en büyük elemanı: "+numbers.Max()+"| Dizinin en küçük elemanı: "+numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5]; 
            //for(int i=0;i<cities.Length;i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------");

            //for(int i =0; i<cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10, 20, 30, 40, 50};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //Dizi içindeki sayıları çift tek olarak ayırma

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 57, 438, 39, 0 };
            //Console.WriteLine("Çift Sayılar: ");
            
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
