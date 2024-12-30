using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yedeklenmiş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goldA = 12;
            int maviA = 30;
            int dBFA = 15;
            int aybA = 25;
            int BakA = 0;
            int AbaA = 15;
            int gülA = 4;
            int senB = 0;
            int senayB = 0;
            int sengül = 0;
            int senAbanoz = 0;
            int senBaka = 0;
            int senMavi = 0;
            int senGold = 0;
            Console.WriteLine("bakiye gir");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            bool whileAcKapa = true;
            while (whileAcKapa)
            {
                Console.WriteLine("*****Hilmi Emstruman*****");
                Console.WriteLine("Klarnet(1)");
                Console.WriteLine("Baril(2)");
                Console.WriteLine("Klarnet Kamışı (3)");
                Console.WriteLine("Sepeti görüntüle(4)");
                Console.WriteLine("Bakiyemi görüntüle(5)");
                Console.WriteLine("Ödeme yap(6)");
                Console.WriteLine("Sepetten Ürünü sil(7)");
                Console.WriteLine("Kampanyaları Göster(8)");
                Console.WriteLine("Çıkış yap(9)");
                int sec = Convert.ToInt32(Console.ReadLine());

                switch (sec)
                {
                    case 1:
                        Console.WriteLine("Gül Ağacı Klarnet(1)");
                        Console.WriteLine("Abanoz Ağacı Klarnet(2)");
                        Console.WriteLine("Bakalit Klarnet(3)");
                        Console.WriteLine("hangi klarneti almalıyım(4)");
                        int secKlarnet = Convert.ToInt32(Console.ReadLine());
                        switch (secKlarnet)
                        {
                            case 1:
                                int gülF = 15000;

                                Console.WriteLine("Fiyatı =" + gülF);
                                Console.WriteLine("Adet =" + gülA);
                                Console.WriteLine("Sepete ekle(1) , Geri Dön(2)");
                                int sepetekle = Convert.ToInt32(Console.ReadLine());
                                if (sepetekle == 1)
                                {
                                    Console.WriteLine("Kaç adet eklemek istiyorsunuz?");
                                    int eklemek = Convert.ToInt32(Console.ReadLine());
                                    if (eklemek <= gülA)
                                    {
                                        
                                        sengül += eklemek;
                                        gülA -= eklemek;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Elimizde Yok maalesef");
                                    }
                                }
                                break;

                            case 2:
                                int AbaF = 50000;

                                Console.WriteLine("Fiyatı =" + AbaF);
                                Console.WriteLine("ADet =" + AbaA);
                                Console.WriteLine("Sepete ekle(1) , Geri Dön(2)");
                                int sepetekle2 = Convert.ToInt32(Console.ReadLine());
                                if (sepetekle2 == 1)
                                {
                                    Console.WriteLine("Kaç adet eklemek istiyorsunuz?");
                                    int eklemek = Convert.ToInt32(Console.ReadLine());

                                    if (AbaA >= 0)
                                    {
                                        senAbanoz += eklemek;
                                        AbaA -= eklemek;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Elimizde Yok maalesef");
                                    }
                                }
                                break;

                            case 3:
                                int BakF = 8000;

                                Console.WriteLine("Fiyatı =" + BakF);
                                Console.WriteLine("Adet =" + BakA);
                                Console.WriteLine("Sepete ekle(1) , Geri Dön(2)");
                                int sepetekle3 = Convert.ToInt32(Console.ReadLine());
                                if (sepetekle3 == 1)
                                {
                                    Console.WriteLine("Kaç adet eklemek istiyorsunuz?");
                                    int eklemek = Convert.ToInt32(Console.ReadLine());

                                    if (BakA >= 0)
                                    {
                                        senBaka += eklemek;
                                        BakA -= eklemek;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Elimizde Yok maalesef");
                                    }
                                }
                                break;

                            case 4:
                                Random x = new Random();
                                int a1 = x.Next(1, 4);
                                if (a1 == 1)
                                {
                                    Console.WriteLine("********************");
                                    Console.WriteLine("Bakalit klarnetler başlangıc düzeyi için gayet uygundur. Ahşap klarnetlere göre daha sağlam ve daha ucuzdur");
                                    Console.WriteLine("********************");
                                }
                                else if (a1 == 2)
                                {
                                    Console.WriteLine("********************");
                                    Console.WriteLine("Gül ağacı klarnetler tam fiyat performans ürünüdür. Metal veya pilastik klarnetlere göre daha tok ses verirler");
                                    Console.WriteLine("********************");
                                }
                                else if (a1 == 3)
                                {
                                    Console.WriteLine("********************");
                                    Console.WriteLine("Abanoz Klarnetler daha profesyoneller içindir aralarında en tok sesi abanoz klarnetten alırsınız");
                                    Console.WriteLine("********************");
                                }
                                break;

                        }
                        break;
                    case 2:

                        Console.WriteLine("Ayarlı baril(1)");
                        Console.WriteLine("Düz baril(2)");
                        Console.WriteLine("Hangi beki almalıyım(3)");
                        int secbek = Convert.ToInt32(Console.ReadLine());
                        switch (secbek)
                        {
                            case 1:
                                int aybF = 1500;

                                Console.WriteLine("Fiyatı =" + aybF);
                                Console.WriteLine("Adet =" + aybA);
                                Console.WriteLine("Sepete ekle(1) , Geri Dön(2)");
                                int sepetekle4 = Convert.ToInt32(Console.ReadLine());
                                if (sepetekle4 == 1)
                                {
                                    Console.WriteLine("Kaç adet eklemek istiyorsunuz?");
                                    int eklemek = Convert.ToInt32(Console.ReadLine());

                                    if (aybA >= 0)
                                    {
                                        senayB += eklemek;
                                        aybA -= eklemek;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Elimizde Yok maalesef");
                                    }
                                }
                                break;
                            case 2:
                                int dBF = 700;

                                Console.WriteLine("Fiyatı =" + dBF);
                                Console.WriteLine("Adet = " + dBFA);
                                Console.WriteLine("Sepete ekle(1) , Geri Dön(2)");
                                int sepetekle5 = Convert.ToInt32(Console.ReadLine());
                                if (sepetekle5 == 1)
                                {
                                    Console.WriteLine("Kaç adet eklemek istiyorsunuz?");
                                    int eklemek = Convert.ToInt32(Console.ReadLine());

                                    if (dBFA >= 0)
                                    {
                                        senB += eklemek;
                                        dBFA -= eklemek;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Elimizde Yok maalesef");
                                    }
                                }
                                break;
                            case 3:
                                Random y = new Random();
                                int a2 = y.Next(1, 3);
                                if (a2 == 1)
                                {
                                    Console.WriteLine("********************");
                                    Console.WriteLine("Düz bariller, başlangıç için idealldir. fiyatı ayarlı beklere göre daha ucuzdur.");
                                    Console.WriteLine("********************");
                                }
                                else if (a2 == 2)
                                {
                                    Console.WriteLine("********************");
                                    Console.WriteLine("Ayarlı bariller, sesi daha iyi alabilmek için adı üzerine barili ayarlamanı gerekir. Ayarlanmış bir baril ile sesi istediğiniz tonda çıkmasını sağlayabilirsinz");
                                    Console.WriteLine("********************");
                                }
                                break;

                        }
                        break;
                    case 3:
                        Console.WriteLine("10'lu Mavi kuşak(1)");
                        Console.WriteLine("10'lu Rigotti Gold(2)");
                        Console.WriteLine("Hangi Kamışı almalıyım(3)");
                        int secKamıs = Convert.ToInt32(Console.ReadLine());
                        switch (secKamıs)
                        {
                            case 1:

                                int maviF = 250;
                                Console.WriteLine("Fiyatı =" + maviF);
                                Console.WriteLine("adet =" + maviA);
                                Console.WriteLine("Sepete ekle(1) , Geri Dön(2)");
                                int sepetekle6 = Convert.ToInt32(Console.ReadLine());
                                if (sepetekle6 == 1)
                                {
                                    Console.WriteLine("Kaç adet eklemek istiyorsunuz?");
                                    int eklemek = Convert.ToInt32(Console.ReadLine());

                                    if (maviA >= 0)
                                    {
                                        senMavi += eklemek;
                                        maviA -= eklemek;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Elimzde yok maalesef");
                                    }
                                }
                                break;
                            case 2:

                                int goldF = 1000;
                                Console.WriteLine("fiyatı =" + goldF);
                                Console.WriteLine("adet =" + goldA);
                                Console.WriteLine("Sepete ekle(1) , Geri Dön(2)");
                                int sepetekle7 = Convert.ToInt32(Console.ReadLine());
                                if (sepetekle7 == 1)
                                {
                                    Console.WriteLine("Kaç adet eklemek istiyorsunuz?");
                                    int eklemek = Convert.ToInt32(Console.ReadLine());

                                    if (goldA >= 0)
                                    {
                                        senGold += eklemek;
                                        goldA -= eklemek;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Elimize yok maalesef");
                                    }
                                }
                                break;
                            case 3:
                                Random z = new Random();
                                int a3 = z.Next(1, 3);
                                if (a3 == 1)
                                {
                                    Console.WriteLine("********************");
                                    Console.WriteLine("Mavi kuşak kamışlar, fiyat performans ürünüdür. kullanımı rahattır");
                                    Console.WriteLine("********************");
                                }
                                else if (a3 == 2)
                                {
                                    Console.WriteLine("********************");
                                    Console.WriteLine("Rigotti gold kamışlar, kullanımı zor olsada çıkardığı ses daha kalitelidir");
                                    Console.WriteLine("********************");
                                }
                                break;


                        }
                        break;
                    case 4:
                        Console.WriteLine("Sepetim");
                        if (sengül == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Gül Ağacı klarnet =" + sengül);
                        }
                        if (senAbanoz == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Abanoz klarnet =" + senAbanoz);
                        }
                        if (senBaka == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Bakalit Klarnet =" + senBaka);
                        }
                        if (senayB == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Ayarlı Baril =" + senayB);
                        }
                        if (senB == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Düz Baril =" + senB);
                        }
                        if (senMavi == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("10'lu Mavi kuşak =" + senMavi);
                        }
                        if (senGold == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("10'lu Rigotti Gold Kamış =" + senGold);
                        }
                        break;
                    case 5:
                        Console.WriteLine(bakiye);
                        break;


                    case 6:
                        int toplam = (sengül * 15000) + (senAbanoz * 50000) + (senBaka * 8000) + (senayB * 1500) + (senB * 700) + (senMavi * 250) + (senGold * 1000);
                        if (sengül > 1)
                        {
                            Console.WriteLine("**********");
                            Console.WriteLine("Birden fazla olan alışverişlerde %50 indirim");
                            Console.WriteLine("**********");
                            toplam -= sengül * 7500;
                        }
                        if (senAbanoz > 1)
                        {
                            Console.WriteLine("**********");
                            Console.WriteLine("Birden fazla olan alışverişlerde %50 indirim");
                            Console.WriteLine("**********");
                            toplam -= senAbanoz * 25000;
                        }
                        if (senBaka > 1)
                        {
                            Console.WriteLine("**********");
                            Console.WriteLine("Birden fazla olan alışverişlerde %50 indirim");
                            Console.WriteLine("**********");
                            toplam -= senBaka * 4000;
                        }
                        if (senayB > 1)
                        {
                            Console.WriteLine("**********");
                            Console.WriteLine("Birden fazla olan alışverişlerde %50 indirim");
                            Console.WriteLine("**********");
                            toplam -= senayB * 750;
                        }
                        if (senB > 1)
                        {
                            Console.WriteLine("**********");
                            Console.WriteLine("Birden fazla olan alışverişlerde %50 indirim");
                            Console.WriteLine("**********");
                            toplam -= senB * 350;
                        }
                        if (senMavi > 1)
                        {
                            Console.WriteLine("**********");
                            Console.WriteLine("Birden fazla olan alışverişlerde %50 indirim");
                            Console.WriteLine("**********");
                            toplam -= senMavi * 125;
                        }
                        if (senGold > 1)
                        {
                            Console.WriteLine("**********");
                            Console.WriteLine("Birden fazla olan alışverişlerde %50 indirim");
                            Console.WriteLine("**********");
                            toplam -= senGold * 500;
                        }
                        if (toplam <= bakiye)
                        {
                            Console.WriteLine("İşleminiz Onaylandı");
                            bakiye -= toplam;
                            sengül = 0;
                            senAbanoz = 0;
                            senBaka = 0;
                            senayB = 0;
                            senB = 0;
                            senMavi = 0;
                            senGold = 0;
                        }
                        else
                        {
                            Console.WriteLine("yetersiz bakiye");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Silmek istediğiniz ürünü seçin");
                        if (sengül > 0)
                        {
                            Console.WriteLine("Gül Ağacı Klarnet(1)");
                            Console.WriteLine("********************");
                            Console.WriteLine("Sendeki =" + sengül);
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                        if (senAbanoz > 0)
                        {
                            Console.WriteLine("Abanoz Klarnet (2)");
                            Console.WriteLine("********************");
                            Console.WriteLine("Sendeki =" + senAbanoz);

                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                        if (senBaka > 0)
                        {
                            Console.WriteLine("Bakalit Klarnet(3)");
                            Console.WriteLine("********************");
                            Console.WriteLine("Sendeki =" + senBaka);
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                        if (senayB > 0)
                        {

                            Console.WriteLine("Ayarlı baril(4)");
                            Console.WriteLine("********************");
                            Console.WriteLine("Sendeki =" + senayB);
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                        if (senB > 0)
                        {
                            Console.WriteLine("Düz baril(5)");
                            Console.WriteLine("********************");
                            Console.WriteLine("Sendeki =" + senB);
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                        if (senMavi > 0)
                        {
                            Console.WriteLine("10'lu Mavi kuşak kamış(6)");
                            Console.WriteLine("********************");
                            Console.WriteLine("Sendeki =" + senMavi);
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                        if (senGold > 0)
                        {
                            Console.WriteLine("10'lu Rigotti Gold Kamış(7)");
                            Console.WriteLine("********************");
                            Console.WriteLine("Sendeki =" + senGold);
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                        int sil = Convert.ToInt32(Console.ReadLine());

                        if (sil == 1)
                        {
                            Console.WriteLine("Kaç adet silmek istiyorsunuz?");
                            int silmek = Convert.ToInt32(Console.ReadLine());
                            if (sengül >= silmek)
                            {
                                Console.WriteLine("işleminiz onaylandı");
                                sengül -=silmek;
                                gülA += silmek;
                            }
                            else
                            {
                                Console.WriteLine("ürün zaten sepette bulunmuyor yada fazla silmeye çalıştınız");
                            }
                        }
                        else if (sil == 2)
                        {
                            Console.WriteLine("Kaç adet silmek istiyorsunuz?");
                            int silmek = Convert.ToInt32(Console.ReadLine());

                            if (senAbanoz >= silmek)
                            {
                                Console.WriteLine("işleminiz onaylandı");
                                senAbanoz -= silmek;
                                AbaA += silmek;
                            }
                            else
                            {
                                Console.WriteLine("ürün zaten sepette bulunmuyor yada fazla silmeye çalıştınız");
                            }

                        }
                        else if (sil == 3)
                        {
                            Console.WriteLine("Kaç adet silmek istiyorsunuz?");
                            int silmek = Convert.ToInt32(Console.ReadLine());

                            if (senBaka >= silmek)
                            {
                                Console.WriteLine("işleminiz onaylandı");
                                senBaka -= silmek;
                                BakA += silmek;
                            }
                            else
                            {
                                Console.WriteLine("ürün zaten sepette bulunmuyor yada fazla silmeye çalıştınız");
                            }
                        }
                        else if (sil == 4)
                        {
                            Console.WriteLine("Kaç adet silmek istiyorsunuz?");
                            int silmek = Convert.ToInt32(Console.ReadLine());

                            if (senayB >= silmek)
                            {
                                Console.WriteLine("işleminiz onaylandı");
                                senayB -= silmek;
                                aybA += silmek;
                            }
                            else
                            {
                                Console.WriteLine("ürün zaten sepette bulunmuyor yada fazla silmeye çalıştınız");
                            }
                        }
                        else if (sil == 5)
                        {
                            Console.WriteLine("Kaç adet silmek istiyorsunuz?");
                            int silmek = Convert.ToInt32(Console.ReadLine());

                            if (senB >= silmek)
                            {
                                Console.WriteLine("işleminiz onaylandı");
                                senB -= silmek;
                                dBFA += silmek;
                            }
                            else
                            {
                                Console.WriteLine("ürün zaten sepette bulunmyor yada fazla silmeye çalıştınız");
                            }
                        }
                        else if (sil == 6)
                        {
                            Console.WriteLine("Kaç adet silmek istiyorsunuz?");
                            int silmek = Convert.ToInt32(Console.ReadLine());

                            if (senMavi >= silmek)
                            {
                                Console.WriteLine("işleminiz onaylandı");
                                senMavi -= silmek;
                                maviA += silmek;
                            }
                            else
                            {
                                Console.WriteLine("ürün zaten sepette bulunmuy9or yada fazla silmeye çalıştınız");
                            }
                        }
                        else if (sil == 7)
                        {
                            Console.WriteLine("Kaç adet silmek istiyorsunuz?");
                            int silmek = Convert.ToInt32(Console.ReadLine());

                            if (senGold >= silmek)
                            {
                                Console.WriteLine("işleminiz onaylandı");
                                senGold -= silmek;
                                goldA += silmek;
                            }
                            else
                            {
                                Console.WriteLine("ürün zaten sepette bulunmuyor yada fazla silmeye çalıştınız");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lütfen ekranda yazılı olan bir sayıya basınız");
                        }
                        break;
                    case 8:
                        Console.WriteLine("**********");
                        Console.WriteLine("Birden fazla olan alışverişlerde %50 indirim");
                        Console.WriteLine("**********");
                        break;

                    case 9:
                        Console.WriteLine("Çıkış yapılıyor iyi günler");
                        whileAcKapa = false;
                        break;


                }
            }
        }
    }
}
