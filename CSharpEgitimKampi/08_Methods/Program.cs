using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Metotlar 
            // solunda mor renkli küp metot 
            //customer --> listeler , ekle ,sil , guncelle
            // void 
            /*
                        void customerList()
                        {
                            Console.WriteLine("Ali Yıldız");
                            Console.WriteLine("Ayşe Yıldız");
                            Console.WriteLine("Hakan Öztürk");
                            Console.WriteLine("Merve Çınar");
                        }
                        customerList();
                        customerList();
            */
            /*
                    void Sum()
                        {
                            int x = 1;
                            int y = 2;
                            int z = x + y;
                            Console.WriteLine(z);
                        }

                        Sum();

                        */
            #endregion

            #region Geriye deger dondurmeyen parametreli metot
            /*    void WriteMethod(string name,string surName)
                {
                    Console.WriteLine("Adınız "+ name +" Soyadınız " +surName);
                }
                WriteMethod("Mehmet","Yıldız");
                WriteMethod("Aysegül","Kaya");


                */
            #endregion


            #region Geriye deger dondurmeyen string parametreli metot
            /*   void WriteMethod(string customerName)
               {
                   Console.WriteLine(customerName);
               }
               WriteMethod("mehmet yıldırım");
               void CustomerCard(string name,string surName)
               {
                   Console.WriteLine("Müsteri : " + name+" "+surName);
               }
            CustomerCard("Mehmet ","Yıldız");
            CustomerCard();

               */

            #endregion


            #region Geriye deger dondurmeyen int parametreli metotlar 
            /*
                        void Sum(int number1,int number2,int number3)
                        {
                            int result = number1 + number2 + number3;
                            Console.WriteLine(result);
                        }
            */
            #endregion

            #region Geriye Deger Donduren Metotlar 
            /*  string CustomerName()
              {
                  return "Buse Yıldız";
              }
              CustomerName();
            */
            /*   string studentCard()
               {
                   string name = "ali";
                   string surname = "kaya";
                   return name + " " + surname;
               }
               Console.WriteLine(studentCard()); */

            #endregion


            #region Geriye Deger donduren parametreli Metotlar 
            /*
                        string CountryCard(string countryName,string capital,string flagColor)
                        {
                            string cardInfo = "Ülke "+countryName + "-Başkent " + capital +"-Bayrak Rengi " + flagColor;
                            return cardInfo;
                        }
                        string x, y, z;
                        Console.WriteLine("ülke adını giriniz ");
                        x = Console.ReadLine();
                        Console.WriteLine("Başkent adını giriniz ");
                        y = Console.ReadLine();
                        Console.WriteLine("Bayrak adını giriniz ");
                        z = Console.ReadLine();

                        Console.WriteLine(CountryCard(x, y, z));
                        Console.WriteLine(CountryCard("Türkiye,"Ankara","Kırmızı-Beyaz"));

                        */
            #endregion


            #region Geriye Deger Donduren Int Parametreli Metotlar 

            /*  int sum(int number1,int number2)
              {
                  int result = number1 + number2;
                  return result;
              }

              Console.WriteLine(sum(45,98));
              Console.WriteLine(sum(36,25));
              Console.WriteLine(sum(44,36));
              Console.WriteLine(sum(14,20));
            */
            #endregion


            #region OrnekUygulama
   
            /*string ExamResult(string student ,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student+" isimli ogrenci sinavi gecti "+" ortalama "+result;
                }
                else
                {
                    return student + " isimli ogrenci sinavi gecemedi" + " ortalama " + result;
                }
            }

            Console.WriteLine(ExamResult("ali", 25, 41, 85));
            Console.WriteLine(ExamResult("ayşe", 36, 88, 33));
            */

            #endregion

            Console.Read();

        }
      
     

    }
}
