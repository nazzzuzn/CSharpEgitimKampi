using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void customerList()
            //{
            //    Console.WriteLine("Naz Uzun");
            //    Console.WriteLine("Aslı Çırak");
            //    Console.WriteLine("Fatma Özsoy");
            //    Console.WriteLine("Sıla İslam");
            //}
            //customerList();

            //void sum()
            //{
            //    int x = 3;
            //    int y = 2;
            //    int z = y + x;
            //    Console.WriteLine(z);
            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Naz");

            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}
            //customerCard("Naz", "Uzun");
            //customerCard("Aslı", "Çırak");

            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //void sum (int number1,int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(28, 61, 48);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerCard()
            //{
            //    return "Naz Uzun";
            //}
            //customerCard();

            //string studentCard()
            //{
            //    string name = "Naz";
            //    string surname = "Uzun";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkent adını giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(countryCard(x, y, z));
            //Console.WriteLine(countryCard("Türkiye","Ankara","Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren İnt Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(22, 68));
            //Console.WriteLine(Sum(44, 34));
            //Console.WriteLine(Sum(87, 92));
            //Console.WriteLine(Sum(28, 40));

            #endregion

            #region Örnek Uygulama

            //string examResult (string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " İsimli öğrenci sınavı geçti. Ortalama : " + result;
            //    }
            //    else
            //    {
            //        return student + " İsimli öğrenci sınavı geçemedi. Ortalama : " + result;
            //    }
            //}
            //Console.WriteLine(examResult("Ali", 55, 24, 36));
            //Console.WriteLine(examResult("Veli", 65, 72, 80));

            #endregion

            Console.Read();
        }
    }
}
