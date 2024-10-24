﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Temel Dizi Ornekleri 
            // 2. 4.6.8

            //degisken türü [] diziadı =new DegiskenTürü[eleman sayısı]

            /*   string[] colors = new string[4];
               colors[0] = "kırmızı";
               colors[1] = "sarı";
               colors[2] = "beyaz";
               colors[3] = "mavi";

               Console.WriteLine(colors[2]);
            */

            /*    string[] cities = new string[5];
                cities[0] = "milano";
                cities[1] = "budapeşte";
                cities[2] = "lyon";
                cities[3] = "kahire";
                cities[4] = "üsküp";
                Console.WriteLine(cities[4]);
            */

            /*  int[] numbers = new int[10];
              numbers[0] = 50;
              numbers[1] = 48;
              numbers[2] = 698;
              numbers[3] = 50;
              numbers[7] = 24;

              Console.WriteLine(numbers[5]);*/
            /*
                        string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };
                        Console.WriteLine(cities[2]);*/


            #endregion

            #region Dizideki tüm elemenları listeleme 
            /*
                        string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yesil", "turuncu", "pembe" };
                        for (int i = 0; i < colors.Length; i++)
                        {
                            Console.WriteLine(colors[i]);
                        }
            */
            /*  int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

              for (int i = 0; i < numbers.Length; i++)
              {
                  if (numbers[i] % 3 == 0)
                  {
                      Console.WriteLine(numbers[i]);
                  }

              }

              */

            /*     char[] symbols = { 'a','b','c','*','/','-'};

                 for (int i = 0; i < symbols.Length; i++)
                 {
                     Console.WriteLine(symbols[i]);

                 }*/
            /*  int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
              int maxNumber = myArray[0];
              for (int i = 0; i < myArray.Length; i++)
              {
                  if (myArray[i] > maxNumber)
                  {
                      maxNumber = myArray[i];
                  }
              }
              Console.WriteLine(maxNumber);
            */

            //string[] persons = { "ali", "ahmet", "ayse", "buse", "cem", "deniz" };
            //        Console.WriteLine(persons.Length);

            /*int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
              Array.Sort(numbers);
              for (int i = 0; i < numbers.Length; i++)
              {
                  Console.WriteLine(numbers[i])
              }
            */
            /*     int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
                  Array.Reverse(numbers);
                  for (int i = 0; i < numbers.Length; i++)
                  {
                      Console.WriteLine(numbers[i]);
                  }
            */


            #endregion

            #region Dizi metotları 

            /*  string[] customers = { "ali", "buse", "aysegul", "merve", "cınar", "kaya" };
              int index = Array.IndexOf(customers, "merve");
              Console.WriteLine(index);
            */
            /*  int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
              Console.WriteLine($"dizinin en buyuk elemanı {numbers.Max()} . En kucuk elemanı {numbers.Min()}");
         */

            #endregion

            #region kullanıcıdan deger alma

            /* string[] cities = new string[5];
             for (int i = 0; i <cities.Length; i++)
             {
                 Console.Write($"Lütfen {i+1} Şehri giriniz : ");
                 cities[i] = Console.ReadLine();
             }
             Console.WriteLine();
             Console.WriteLine("-----------");

             for (int i = 0; i < cities.Length; i++)
             {
                 Console.WriteLine(cities[i]);  
             }
            */

            /*    int[] numbers = { 10, 20, 30, 40, 50 };
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            */

            int[] numbers = { 21, 42, 33, 55, 66, 897, 748, 39, 220 };
            Console.WriteLine("çift sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Tek sayılar ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion

/*
            int[] a = new int[5] { 1, 2, 5, 7, 8 };
          
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a);
            }
*/
          
            Console.Read();
        }
    }
}