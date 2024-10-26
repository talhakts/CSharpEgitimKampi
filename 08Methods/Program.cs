using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _08Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // ()
            // Geriye Değer Döndürmeyen Metotlar
            // Customer----> Listele, ekle, sil, güncelle
            // Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Talha Aktaş");
            //    Console.WriteLine("Kayra Aktaş");
            //    Console.WriteLine("Ömer Faruk Aktaş");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}
            //Sum();



            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Talha Aktaş");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Talha", "Aktaş");

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(3, 5, 8);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Talha Aktaş";
            //}

            //customerName();

            //string studentCard()
            //{
            //    string name = "Talha";
            //    string surname = "Aktaş";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital, string flagColor)
            //{
            //    string cardInfo="Ülke: "+countryName+" - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;            
            //}

            //string x, y, z;

            //Console.Write("Ülke adını giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z=Console.ReadLine();

            //Console.Write(CountryCard(x, y, z));

            //Console.Write(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(18,22));
            //Console.WriteLine(Sum(44,222));
            //Console.WriteLine(Sum(55,92));
            //Console.WriteLine(Sum(34,29));

            #endregion

            #region Örnek Uygulama

            //string examResullt(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student+ " isimli öğrenci sınavı geçti "+"Ortalama: "+result;

            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci başarısız oldu " + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(examResullt("Ali", 44, 12, 72));
            //Console.WriteLine(examResullt("Ayşe", 84, 42, 77));

            #endregion


            Console.Read();
        }
    }
}
