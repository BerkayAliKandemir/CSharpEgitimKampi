using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region For Dongusu 
            // donguler 

            // For (x;y;z) 
            //x başlangıç 
            //y bitiş
            // z artış azalış

            /*  int i;
              for (i=0;i<=5;i++)
              {
                  Console.WriteLine("C# Egitim Kampi");
              }*/

            /*   for (int i = 0; i < 20; i++)
               {
                   Console.WriteLine(i);
               }*/
            /*     for (int i = 3; i <= 50; i++)
                 {
                     Console.WriteLine(i);
                 }*/

            /*  Console.WriteLine("Lütfen Ekrana Yazılmasını istediğiniz adedi giriniz : ");
              int finishcount = int.Parse(Console.ReadLine());

              for (int i = 0; i < finishcount; i++)
              {
                  Console.WriteLine("Yaşasın Cumhuriyet");
              }*/







            #endregion

            #region For Dongusu ile Karar Yapıları

            /*   for (int i = 0; i <100 ; i++)
               {
                   if (i % 5 == 0)
                   {
                       Console.WriteLine(i);
                   }
               }
            */

            /*  int totalcount = 0;
              for (int i = 0; i < 10; i++)
              {
                  totalcount += i;
              }
              Console.WriteLine(totalcount);*/


            /*    int totalcount = 0;
                for (int i = 0; i < 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        totalcount += i;
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("-----");
                Console.WriteLine(totalcount); */

            /*      int count = 0;
                  for (int i = 1; i < 50; i++)
                  {
                      if (i % 7 == 0)
                      {
                          count++;
                      }
                  }
                  Console.WriteLine(count);
            */



            /*   int bacterium = 1;
               for (int i = 1; i < 24; i++)
               {
                   bacterium *= 2;
                   Console.WriteLine($"{i}. saat sonunda { bacterium}");
               }

               */

            #endregion

            #region While Dongusu 
            /*    int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine("merhaba donguler");
                    i++;
                }
            */
            /*  int i = 1;
              while (i <= 10)
              {
                  if (i % 3 == 0)
                  {
                      Console.WriteLine(i);
                  }
                  i++;
              }
            */
            /*    int i = 1;
                int sum = 0;
                while (i <= 10)
                {
                    sum += i;
                    i++;
                }

                Console.WriteLine(sum);
            */

            #endregion

            #region Ornek Sinav Sorusu 
            /*    // klavyeden 3 basamaklı sayının basamaklarını toplamını hesaplayan kodu yazınız.
                Console.WriteLine("Lütfen Sayıyı Giriniz : ");
                int number = int.Parse(Console.ReadLine());
                int ones, tens, hundreds;
                int sum = 0;

                ones = number & 10;
                tens = (number % 100) / 10;
                hundreds = number / 100;
                Console.WriteLine($"{hundreds} - {tens} - {ones}");
                sum = hundreds + tens + ones;

                Console.WriteLine(sum);

                */
            #endregion


     /*       double toplam = 0;
            string deger = " ";

            for (int i = 1; i <= 10; i++)
            {
                toplam += Math.Pow(i, 3);
               if(i != 10) { 
                    deger += $"{i} + ";
                }
                else
                {
                    deger += $"{i} = {toplam}";
                }      
               
            }
          
            Console.WriteLine(deger);

            */


            Console.Read();
        }
    }
}
