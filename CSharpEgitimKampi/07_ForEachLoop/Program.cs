using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ForEach Dongusu
            // foreach (1;2;3;4)
            //1 degisken türü
            //2 degisken adi
            //3 ın 
            //4 liste , koleksiyon ,dizi

            //   string[] cities = { "milano", "roma", "budapeste", "ankara", "istanbul", "varsova" };
            //   foreach (string x in cities)
            //    {
            //      Console.WriteLine(x);
            //  }


            /*  int[] number = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
              foreach (int number in number)
              {
                  if (number % 2 == 0) { 
                      Console.WriteLine(number);
                  }
              }

              int[] number = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
              int total = 0;
              foreach(int i in numbers)
              {
                  total += i;
              }
              Console.WriteLine();
            */
            /*       List<int> numbers = new List<int>()
                 {
                     1,2,3,4,5,8
                 };
                   foreach (int number in numbers)
                   {
                       Console.WriteLine(number);
                   }
                   string word = "merhaba";
                   foreach (char c in word)
                   {

                   }
            */
            #endregion


            #region Ornek Sınav Uygulaması 
            /*
            Console.WriteLine("******** C# Egitim Kampi Sinav Uygulamasi");
            Console.WriteLine();
            Console.WriteLine("\n \n \n");

            //Sınıftaki ogrenci sayısını kullanıcıdan alma 
            Console.WriteLine("------------------");
            Console.Write("Sınıftaki ogrenci sayısını giriniz: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");

            // ogrenci isimleri ve  not ortalaması giriniz 
            string[] studentName = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Lütfen {i+1}. ogrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();

                double totalExam = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Lütfen {studentName[i]} adlı ogrencinin {j+1}. notunu giriniz :");
                    double value= double.Parse(Console.ReadLine());
                    totalExam += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExam / 3;
            }

            for (int i = 0; i <studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı ogrencinin ortalaması {studentExamAvg[i]}");
                Console.WriteLine("---------");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı ogrenci dersi gecti");

                }else
                {
                    Console.WriteLine($"{studentName[i]} adlı ogrenci dersten kaldı");
                }
            }*/

            #endregion

            Console.Read();
        }
    }
}
