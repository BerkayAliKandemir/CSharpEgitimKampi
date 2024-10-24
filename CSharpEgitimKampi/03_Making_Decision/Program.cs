using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Making_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            /*   Console.Write("Lütfen Şifreyi Giriniz : ");
               string password = Console.ReadLine();

               if (password == "abcd")
               {
                   Console.WriteLine("Şifre Doğru");
               }
               else
               {
                   Console.WriteLine("Şifre Yanlış");
               }
            */

            /*   string capital, country;
               Console.Write("Başkent Giriniz : ");
               capital = Console.ReadLine();

               Console.Write("Ülkeyi Giriniz : ");
               country = Console.ReadLine();

               if(capital=="ankara" & country == "türkiye")
               {
                   Console.WriteLine("Veriler Dogru");
               }
               else
               {
                   Console.WriteLine("Hatalı Bilgi");
               }
            */
            /*  int number;
              Console.Write("Sayıyı Giriniz: ");
              number = int.Parse(Console.ReadLine());
              if (number == 5)
                  Console.WriteLine("Sayı dogru");
              else
              {
                  Console.WriteLine("Sayı hatalı");
              } */

            /*   int exam1, exam2, exam3, average;
               string result="";
               Console.Write("Sınav1: ");
               exam1 = int.Parse(Console.ReadLine());
               Console.Write("Sınav2: ");
               exam2 = int.Parse(Console.ReadLine());
               Console.Write("Sınav3: ");
               exam3 = int.Parse(Console.ReadLine());

               average = (exam1 + exam2 + exam3) / 3;

               Console.WriteLine($"Sınavların ortalaması : {average}");

               if(average>0 & average <= 50)
               {
                   result = "sonuç vasat";
               }
               if (average > 50 & average <= 70)
               {
                   result = "sonuç orta";
               }
               if (average > 70 & average <= 84)
               {
                   result = "sonuç iyi";
               }
               if (average > 84 )
               {
                   result = "sonuç çok iyi";
               }

               Console.WriteLine(result);
            */
            /*   string city;
               Console.Write("Lütfen Şehir Giriniz : ");
               city = Console.ReadLine();

               if(city=="adana" | city=="ankara" | city =="bursa" | city == "trabzon")
               {
                   Console.WriteLine("şehir mevcut");
               }
               else
               {
                   Console.WriteLine("şehir mevcut değil");
               }
            */
            /*  Console.WriteLine("Lütfen kullanıcı adı giriniz : ");
              string username = Console.ReadLine();
              if (username != "admin")
              {
                  Console.Write("bu kullanıcı adı kabul edilemez");
              }
              else
              {
                  Console.WriteLine("hos geldiniz ");
              }

              */

            #endregion


            #region Mod İşlemleri

            /*   int number;
               number = 26;
               int result = number % 5;
               Console.WriteLine(result);
            */
            /*     Console.Write("Lütfen 1. sayıyı giriniz : ");
                 int number1 = int.Parse(Console.ReadLine());
                 Console.Write("Lütfen 2. sayıyı giriniz : ");
                 int number2 = int.Parse(Console.ReadLine());

                 int result = number1 % number2;
                 Console.WriteLine($"1.sayıyı 2. sayıya bolumunden kalan : {result}");
            */

            /*
                        Console.Write("Lütfen sayı giriniz:");
                        int number = int.Parse(Console.ReadLine());
                        if (number % 2 == 0)
                        {
                            Console.Write("Sayı Çifttir");
                        }
                        else
                        {
                            Console.Write("Sayı tektir");
                        }
            */
            #endregion

            #region Char Degiskenler ile karar yapıları 
            ////char team;
            //// Console.Write("Lütfen takan senbolinü giriniz: ");
            //// team = char.Parse(Console.ReadLine());

            //// if(team=='g' | team == 'G')
            //// {
            ////     Console.WriteLine("galatasaray");
            //// }
            //// if (team == 'f' | team == 'F')
            //// {
            ////     Console.WriteLine("Fenerbahçe");
            //// }
            //// if (team == 'b' | team == 'B')
            //// {
            ////     Console.WriteLine("Beşiktaş");
            //// }
            ///
            #endregion


            #region Ornek Proje Uygulaması 
            /*    Console.WriteLine("**********C# Egitim Kampi Restoran**************");
                Console.WriteLine();
                Console.WriteLine("----------------------");
                Console.WriteLine("1 - Ana Yemekler");
                Console.WriteLine("2 - Çorbalar");
                Console.WriteLine("3 - Pizzalar");
                Console.WriteLine("4 - İçecekler");
                Console.WriteLine("5 - Tatlılar");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                string menuItem;
                Console.Write("Detay Görmek İstediginiz menü seçimi : ");
                menuItem = Console.ReadLine();
                if (menuItem == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("1-------Ana Yemekler------");
                    Console.WriteLine();
                    Console.WriteLine("1- Köri Soslu Tavuk");
                    Console.WriteLine("2- Kızartma tabagı");
                    Console.WriteLine("3- Fasulye Pilav");
                    Console.WriteLine("4- Fırında somon");
                    Console.WriteLine("5- Patlıcan Musakka");
                    Console.WriteLine("------------------------------");
                }
                if (menuItem == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("1-------Çorbalar------");
                    Console.WriteLine();
                    Console.WriteLine("1- Mercimek Çorba");
                    Console.WriteLine("2- Ezogelin Çorba");
                    Console.WriteLine("------------------------------");
                }
                if (menuItem == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("1-------Pizzalar------");
                    Console.WriteLine();
                    Console.WriteLine("1- Akdeniz Pizza");
                    Console.WriteLine("2-  Margartha Pizza");
                    Console.WriteLine("3-  Tavuklu Pizza");
                    Console.WriteLine("------------------------------");
                }
                if (menuItem == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("1-------İçecekler------");
                    Console.WriteLine();
                    Console.WriteLine("1- Kola");
                    Console.WriteLine("2-  Ayran");
                    Console.WriteLine("3-  Su");
                    Console.WriteLine("------------------------------");
                }
                if (menuItem == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine("1-------Tatlılar------");
                    Console.WriteLine();
                    Console.WriteLine("1- Triliçe");
                    Console.WriteLine("2-  Kazandibi");
                    Console.WriteLine("2-  Sütlaç");
                    Console.WriteLine("------------------------------");
                }
            */

            #endregion

            #region Switch Case 

            /*  Console.WriteLine("Lütfen Ay Girişi Yapınız : ");
              int monthNumber = int.Parse(Console.ReadLine());
              switch (monthNumber)
              {
                  case 1: Console.WriteLine("ocak "); break;
                  case 2: Console.WriteLine("subat "); break;
                  case 3: Console.WriteLine("mart "); break;
                  case 4: Console.WriteLine("nısan "); break;
                  case 5: Console.WriteLine("mayıs"); break;
                  case 6: Console.WriteLine("hazıran "); break;
                  case 7: Console.WriteLine("temmuz "); break;
                  case 8: Console.WriteLine("agustos "); break;
                  case 9: Console.WriteLine("eylul "); break;
                  case 10: Console.WriteLine("ekım "); break;
                  case 11: Console.WriteLine("kasım "); break;
                  case 12: Console.WriteLine("aralık"); break;


                  default:
                      Console.WriteLine("hatalı verı gırısı");
                      break;
              }
            */

            #endregion


            #region Switch Case Hesap Makinesi

        /*    int number1, number2, result;
            char sembol;
            Console.WriteLine("1.Sayıyı Giriniz : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sayıyı Giriniz : ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen yapmak istediginiz İşlemi giriniz : ");
            sembol = char.Parse(Console.ReadLine());

            switch (sembol)
            {
                case '+': result = number1 + number2; Console.WriteLine($"toplam {result}"); break;
                case '-': result = number1 - number2; Console.WriteLine($"çıkarma {result}"); break;
                case '*': result = number1 * number2; Console.WriteLine($"çarpma {result}"); break;
                case '/': result = number1 / number2; Console.WriteLine($"bolme {result}"); break;
                default:Console.WriteLine("hata "); break; 

            }
        */
            #endregion 
            Console.Read();
        }

    }
}
