using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd") { Console.WriteLine("Şifre Doğru"); }
            //else { Console.WriteLine("Şifre Yanlış"); }

            //string capital, country;
            //Console.Write("Başkent Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else {
            //    Console.Write("Hatalı Bilgi");
            //}

            //int number;
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else {
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result;
            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2=int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: "+average);
            //result = "Hatalı Giriş Yaptınız.";

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine("Sınav: "+result);


            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city=Console.ReadLine();

            //if (city == "samsun" | city == "ankara" | city == "bursa")
            //{

            //    Console.WriteLine("Şehir Mevcut");

            //}
            //else { Console.WriteLine("Şehir Mevcut Değil"); }

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else { Console.Write("Hoşgeldiniz"); }
            //Console.Read();
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2= int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");

            //}
            //else { Console.Write("Sayı tektir"); }



            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("******* C# Eğitim Kampı Restoran *******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar ");
            //Console.WriteLine("3-Pizzalar ");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğinizi menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Ana Yemekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------------Ana Yemekler------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Çorbalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("------------------Çorbalar------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Pizzalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita Pizza");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("------------------Pizzalar------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------İçecekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine("4-Çay");
            //    Console.WriteLine("------------------İçecekler------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Tatlılar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Künefe");
            //    Console.WriteLine("3-Kazandibi");
            //    Console.WriteLine("------------------Tatlılar------------------");

            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen ay girişi yapınız: ");
            //int monthnumber = int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi Yaptınız!"); break;

                    
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Sonuç: "+result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    default:Console.WriteLine("Hatalı Giriş Yaptınız"); break;


            //}



            #endregion
            Console.Read();
        }
    }
}
