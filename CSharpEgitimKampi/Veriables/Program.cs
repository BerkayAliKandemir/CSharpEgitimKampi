using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veriables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            /*   double number;
               number = 4.85;
               Console.WriteLine(number); */
            /*

                             Console.WriteLine("****Fiyat Listesi ******");
                             Console.WriteLine();
                             double applePrice, orangePrice, strawberryPrice, patato, tomato;
                             applePrice = 14.85;
                             orangePrice = 20.95;
                             strawberryPrice = 45;
                             patato = 9.74;
                             tomato = 6.88;

                             Console.WriteLine($"-----Elma Birim Fiyatı : {applePrice} TL");
                             Console.WriteLine($"-----Portakal Birim Fiyatı : {orangePrice} TL");
                             Console.WriteLine($"-----Çilek Birim Fiyatı : {strawberryPrice} TL");
                             Console.WriteLine($"-----Patates Birim Fiyatı : {patato} TL");
                             Console.WriteLine($"-----Domates Birim Fiyatı : {tomato} TL");

                             double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
                             appleGram = 1.245;
                             orangeGram = 2.650;
                             strawberryGram = 0.750;
                             patatoGram = 4.859;
                             tomatoGram = 3.745;

                             double appleTotalPrice = appleGram * applePrice;
                             double orangeTotalPrice = orangeGram * orangePrice;
                             double strawberryTotalPrice = strawberryGram * strawberryPrice;
                             double patatoTotalPrice = patatoGram * patato;
                             double tomatoTotalPrice = tomatoGram * tomato;

                             Console.WriteLine($"Alınan Urun :Elma Birim Fiyatı {applePrice} - Gram {appleGram} - Toplam Tutar = {appleTotalPrice} ");
                             Console.WriteLine($"Alınan Urun :Portakal Birim Fiyatı {orangePrice} - Gram {orangeGram} - Toplam Tutar = {orangeTotalPrice} ");
                             Console.WriteLine($"Alınan Urun :Çilek Birim Fiyatı {strawberryPrice} - Gram {strawberryGram} - Toplam Tutar = {strawberryTotalPrice} ");
                             Console.WriteLine($"Alınan Urun :Patates Birim Fiyatı {patato} - Gram {patatoGram} - Toplam Tutar = {patatoTotalPrice} ");
                             Console.WriteLine($"Alınan Urun :Domates Birim Fiyatı {tomato} - Gram {tomatoGram} - Toplam Tutar = {tomatoTotalPrice} ");
                             Console.WriteLine();
                             Console.WriteLine();
                             double allTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

                             Console.WriteLine($"Toplam ücret : {allTotalPrice.ToString("0.##")}");

                             */





            #endregion


            #region Char Degiskenler
            //ABCDEFG
            //DEF...
            //TOPLANTI SAAT 20:00 'DE
            //      char symbol;
            //    symbol = 'a';
            //  Console.WriteLine(symbol);

            #endregion 


            #region Klavye veri girişi String İfadeler
            /*       Console.WriteLine("-*******Csharp Hava Yolları  Yolcu Bilgisi");
                   Console.WriteLine();

                   string passangerName, passangerSurname,passangerDistrict ,passangerCity,passangerAge,
                       passangerIdentityNumber;
                   Console.Write("Yolcu Adı :");
                   passangerName = Console.ReadLine();

                   Console.Write("Yolcu Soyadı :");
                   passangerSurname = Console.ReadLine();

                   Console.Write("İlçe Bilgisi: ");
                   passangerDistrict= Console.ReadLine();

                   Console.Write("Şehir Bilgisi:");
                   passangerCity = Console.ReadLine();

                   Console.Write("Yolcu Yaş : ");
                   passangerAge = Console.ReadLine();

                   Console.Write("TC Kimlik No: ");
                   passangerIdentityNumber = Console.ReadLine();


                   Console.WriteLine("---------------");
                   Console.WriteLine($"Yolcu TC Kimlik No: {passangerIdentityNumber} Yolcu : {passangerName} {passangerSurname} {passangerDistrict} / {passangerCity} {passangerAge} ");

       */

            #endregion


            #region Klavyeden Tam Sayi Girisleri ve Donusumleri

            //ABC12D
        /*    int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen Adlığınız Ayakkabı Sayısını Giriniz :");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Adlığınız Computer Sayısını Giriniz :");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Adlığınız Sandalye Sayısını Giriniz :");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Adlığınız Televizyon Sayısını Giriniz :");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = tvCount * tvPrice + chairPrice * chairCount + computerCount * computerPrice +
                shoesCount * shoesPrice;
            Console.WriteLine();
            Console.WriteLine($"Toplam Tutar : {totalPrice}");

            */

            #endregion

            #region Klavyeden Ondalikli Sayi İslemleri
            /*    double exam1, exam2, exam3,result;
                Console.Write("Lütfen 1. Sınav Notu Giriniz : ");
                exam1 = double.Parse(Console.ReadLine());

                Console.Write("Lütfen 2. Sınav Notu Giriniz : ");
                exam2 = double.Parse(Console.ReadLine());

                Console.Write("Lütfen 3. Sınav Notu Giriniz : ");
                exam3 = double.Parse(Console.ReadLine());


                result = (exam1 + exam2 + exam3) / 3;
                Console.WriteLine();
                Console.WriteLine($"Sınav Ortalamanız : {result}");
            */
            #endregion

            #region Klavyeden Karakter Girişi

            char gender;
            Console.Write("Lütfen Cinsiyet Giriniz:");
            gender = Char.Parse(Console.ReadLine());

            Console.WriteLine($"Seçtiğiniz Cinsiyet {gender}");


            #endregion




            Console.Read();
        }
    }
}
