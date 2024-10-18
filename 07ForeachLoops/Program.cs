﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1: Değişken Türü
            //2: Değişken adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = {55,05,34,29,48,45,89,18};
            //foreach (int number in numbers)
            //{ 
            //    Console.WriteLine(number);
            //} 

            //int[] numbers = { 55, 05, 34, 29, 48, 45, 89, 18 };
            //foreach (int number in numbers)
            //{
            //    if(number%2==0)
            //    { Console.WriteLine(number); }
            //}

            //int[] numbers = { 55, 05, 34, 29, 48, 45, 89, 18 };
            //int total=0;
            //foreach (int i in numbers)
            //{
            //    total += i;

            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,555
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);            
            //}

            //Bir kelimeyi harflerine ayıran uygulama

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var? : ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isim ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for(int i=0;i<studentCount;i++)
            {
                Console.Write($"{i+1}. Öğrencinin İsmini Giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for(int j=0;j<3;j++)
                {
                        Console.Write($"{studentNames[i]} Adlı öğrencinin {j+1}. sınav notunu giriniz: " );
                        double value=double.Parse(Console.ReadLine());
                        totalExamResult += value; //Notları topluyoruz
                }
                Console.WriteLine();
                Console.WriteLine();
                    studentExamAvg[i] = totalExamResult / 3;
            }

                //Sınav ortalamaları

                for(int i = 0; i<studentCount; i++)
                {

                Console.WriteLine("------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                //Öğrencilerin geçip kalma durumları
                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                    
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("------------------------------");
            }



            #endregion

            Console.Read();
        }
    }
}
