using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış.");
            //}

            //Console.Write("Başkenti giriniz: ");
            //string capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //string country = Console.ReadLine();

            //if (capital == "Ankara" && country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler doğruladı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //Console.Write("Bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number  == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı.");
            //}

            //double exam1, exam2, exam3, average;
            //string result = "";

            //Console.Write("1. Sınavı giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınavı giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınavı giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + average);

            //if (average >0 && average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 && average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 && average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average >84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen şehir girişi yapınız: ");
            //string city = Console.ReadLine();

            //if (city == "Adana" | city == "Ankara" | city == "Bursa" | city == "Trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number = 19;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("Birinci sayının ikinci sayıya bölümünden kalan: " + result);

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //char symbol = char.Parse(Console.ReadLine());

            //if (symbol == 'g' | symbol == 'G')
            //{
            //    Console.WriteLine("GALATASARAY");
            //}
            //if (symbol == 'f' | symbol == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (symbol == 'b' | symbol == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //string menuItem = (Console.ReadLine());

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;

            //    case 2: Console.WriteLine("Şubat"); break;

            //    case 3: Console.WriteLine("Mart"); break;

            //    case 4: Console.WriteLine("Nisan"); break;

            //    case 5: Console.WriteLine("Mayıs"); break;

            //    case 6: Console.WriteLine("Haziran"); break;

            //    case 7: Console.WriteLine("Temmuz"); break;

            //    case 8: Console.WriteLine("Ağustos"); break;

            //    case 9: Console.WriteLine("Eylül"); break;

            //    case 10: Console.WriteLine("Ekim"); break;

            //    case 11: Console.WriteLine("Kasım"); break;

            //    case 12: Console.WriteLine("Aralık"); break;

            //    default: Console.WriteLine("Hatalı veri girişi"); break;

            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            //char symbol = char.Parse(Console.ReadLine());
            //int result;

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result); 
            //        break;

            //    case '-': 
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result); 
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //    default: Console.WriteLine("Hatalı veri girişi"); break;
            //}

            #endregion

            Console.Read();
        }
    }
}