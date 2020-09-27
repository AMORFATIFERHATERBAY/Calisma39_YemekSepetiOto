using System;

namespace Calisma39_YemekSepetiOto
{
    class Program
    {
        static void Main(string[] args)
        {
            double secim, adet, toplam = 0;
            double hesap = 0;
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("**                                                                 **");
            Console.WriteLine("**            Yemekler               **          İçecekler         **");
            Console.WriteLine("**      1-Et Döner    - 27.00Tl      **      7-Kola   - 5,50TL     **");
            Console.WriteLine("**                                                                 **");
            Console.WriteLine("**      2-Tavuk Döner - 17.00Tl      **      8-Fanta  - 5,50TL     **");
            Console.WriteLine("**                                                                 **");
            Console.WriteLine("**      3-Köfteler    - 30.00Tl      **      9-Ayran  - 3,50TL     **");
            Console.WriteLine("**                                                                 **");
            Console.WriteLine("**      4-Çorbalar    - 15.00Tl      **     10-Soda   - 2,50TL     **");
            Console.WriteLine("**                                                                 **");
            Console.WriteLine("**      5-Salatalar   - 22.50Tl      **     11-İceTea - 5.00TL     **");
            Console.WriteLine("**                                                                 **");
            Console.WriteLine("**      6-Tatlılar    - 25.00Tl      **     12-Kahve  - 7,50TL     **");
            Console.WriteLine("*********************************************************************");

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine();
                Console.Write("Alacağınız Ürünün Numarası : ");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Kaç Porsiyon Et Döner :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 27;
                    hesap = hesap + toplam;
                }
                else if (secim == 2)
                {
                    Console.Write("Kaç Porsiyon Tavuk Döner :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 17;
                    hesap = hesap + toplam;
                }
                else if (secim == 3)
                {
                    Console.Write("Kaç Porsiyon Köfte :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 30;
                    hesap = hesap + toplam;
                }
                else if (secim == 4)
                {
                    Console.Write("Kaç Kase Çorba :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 15;
                    hesap = hesap + toplam;
                }
                else if (secim == 5)
                {
                    Console.Write("Kaç Porsiyon Salata :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 12.50;
                    hesap = hesap + toplam;
                }
                else if (secim == 6)
                {
                    Console.Write("Kaç Porsiyon Tatlı :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25;
                    hesap = hesap + toplam;
                }
                else if (secim == 7)
                {
                    Console.Write("Kaç Adet Kola :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5.5;
                    hesap = hesap + toplam;
                }
                else if (secim == 8)
                {
                    Console.Write("Kaç Adet Fanta :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5.5;
                    hesap = hesap + toplam;
                }
                else if (secim == 9)
                {
                    Console.Write("Kaç Adet Ayran :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 3.5;
                    hesap = hesap + toplam;
                }
                else if (secim == 10)
                {
                    Console.Write("Kaç Adet Soda :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2.5;
                    hesap = hesap + toplam;
                }
                else if (secim == 11)
                {
                    Console.Write("Kaç Adet İce Tea :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }
                else if (secim == 12)
                {
                    Console.Write("Kaç Adet Kahve :");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7.5;
                    hesap = hesap + toplam;
                }
                else
                    Console.WriteLine("Böyle bir seçenek yok! Üzgünüz...");
                Console.WriteLine();

                Console.Write("Başka isteğiniz var mı? :");
                string cevap = Console.ReadLine();

                if (cevap == "H" || cevap == "h" || cevap == "Hayır" || cevap == "hayır" || cevap == "HAYIR" || cevap == "No" | cevap == "n" || cevap == "NO" || cevap == "N")
                    break;

                
            }
            Console.WriteLine("Toplam Tutar : " + hesap);
        
            Console.Write("Müşteri Alınan Para : ");
            double alınan = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Para üzeri.... :{0}",alınan-hesap);
        }
    }
}
