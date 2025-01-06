using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul0","Varşova" };

            //foreach (string n in cities)
            //{
            //    Console.WriteLine(n);
            //}

            //int[] numbers = { 25, 64, 12, 963, 025, 45, 2, 7065, 354, 8958, 52 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 25, 64, 12, 963, 025, 45, 2, 7065, 354, 8958, 52 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 25, 64, 12, 963, 025, 45, 2, 7065, 354, 8958, 52 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine("Toplam : " + total);

            //List<int> numbers = new List<int>()
            //{
            //    12,75,62,78,28,90,72
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string nazo = "nazo";
            //foreach (char n in nazo)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("*************** Not Hesaplama Uygulaması ***************");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------------");
            //Console.Write("Sınıfınızda kaç tane öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------------------------------");
            //Console.WriteLine();
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrencinin Adı: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExam = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} Adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExam += value;
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExam / 3;
            //}

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("---------------------------------------------------------");
            //    Console.WriteLine($"{studentNames[i]} Adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı öğrenci sınıfı geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı öğrenci sınıfta kaldı");
            //    }
            //    Console.WriteLine("---------------------------------------------------------");
            //}

            #endregion

            Console.Read();
        }
    }
}