using System.ComponentModel.Design;

namespace bankamtik_proje
{
    internal class Program
    {
        static double bakiye = 250;//tüm işlemlerde geçerli olsun diye sınıfa global değşken olarak tanımlandı
        static double tutar;
        static void Main(string[] args)
        {
            Console.WriteLine("ATM UYGULAMASI");
            BaslangicMenusu();


        }
        static void BaslangicMenusu()
        {

            Console.WriteLine("1-Kartlı İşlem");
            Console.WriteLine("2-Kartsız İşlem");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                KartliIslem();
            }
            else if (secim == "2")
            {
                KartsizIslem();
            }
            else
            {
                Console.WriteLine("Geçersiz işlem.Tekrar deneyiniz.");
                BaslangicMenusu();
            }
        }

        static void KartliIslem()
        {
            Console.WriteLine("Kartlı İşlem Menüsü ");
            AnaMenu();

            string girilenSifre = Console.ReadLine();
            string sifre = "ab18";
            int hak = 3;
            while (hak > 0)
            {
                Console.WriteLine("şifre:");
                Console.ReadLine();

                if (girilenSifre == sifre)
                {
                    Console.WriteLine("Şifre Doğru.Ana Menüye geçiş");
                    AnaMenu();
                    return;
                }
                else
                {
                    Console.WriteLine("Girilen Şifre Yanlış.Tekrar Deneyiniz");
                    Console.WriteLine("Kalan hak:" + hak);
                    hak--;
                    if (hak == 0)
                    {
                        Console.WriteLine("3 kez yanlış griş yapıldı.Çıkış yapılıyor.");
                        BaslangicMenusu();
                    }
                }
            }
        }

        static void KartsizIslem()
        {
            Console.WriteLine("Kartsız İşlem Menüsü");
            AnaMenu();
        }

        static void AnaMenu()
        {
            while (true)//döngü içine aldım işlem bittiğinde otomatik ana menü gelsin 
            {
                Console.WriteLine("ANA MENÜ");
                Console.WriteLine("1-PARA ÇEKME");
                Console.WriteLine("2-PARA YATIRMA");
                Console.WriteLine("3-PARA TRANSFERLERİ");
                Console.WriteLine("4-EĞTİM ÖDEMELERİ");
                Console.WriteLine("5-ÖDEMELER");
                Console.WriteLine("6-BİLGİ GÜNCELLEME");
                Console.WriteLine("0-ÇIKIŞ");

                Console.WriteLine("Seçiminizi giriniz:");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        ParaCekme();
                        break;
                    case 2:
                        ParaYatırma();
                        break;
                    case 3:
                        Console.WriteLine("Para Transferleri İşlemi");
                        break;
                    case 4:
                        Console.WriteLine("Eğtim Ödemeleri İşlemi");
                        break;
                    case 5:
                        Console.WriteLine("Ödemeler İşlemi");
                        break;
                    case 6:
                        Console.WriteLine("Bilgi Güncelleme İşlemi");
                        break;
                    case 0:
                        Console.WriteLine("Çıkış İşslemi");
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşlama Tekrar Deneyiniz.");
                        Console.ReadLine();
                        break;
                }

            }
        }


        static void ParaCekme()
        {

            Console.WriteLine("Çekilecek tutarı giriniz.");
            double tutar = Convert.ToDouble(Console.ReadLine());


            if (tutar > bakiye)
            {
                Console.WriteLine("Yetersiz Bakiye");
                Console.ReadLine();
                ParaCekme();
            }
            else
            {
                Console.WriteLine("Paranız başarıyla çekilmiştir. Kalan bakiye:" + bakiye);
                bakiye -= tutar;
            }
            while (true) ;//ana menüye dönme
            {
                Console.WriteLine("Ana menüye geçmek için 9'a basınız.");
                string secim = Console.ReadLine();
                if (secim != "9")
                {
                    Console.WriteLine("Hatalı giriş.Tekrar deneyiniz");
                    Console.ReadLine();
                }
                else
                {
                    AnaMenu();
                    return;
                }
            }

        }

        static void ParaYatırma()
        {
            Console.WriteLine("PARA YATIRMA");

            Console.WriteLine("1-Kredi Kartına");

            Console.WriteLine("2-Kendi Hesabına");

            Console.WriteLine("9-Ana Menü");

            Console.WriteLine("0-ÇIKIŞ");

            while (true)
            {

                Console.WriteLine("Yatıralacak tutarı giriniz.");
                double tutar = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Parayı nereye yatırmak istersiniz.");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Write("12 haneli kart numaranızı giriniz: ");
                        string kartNo = Console.ReadLine();

                        if (kartNo.Length != 12)
                        {
                            Console.WriteLine("Kart numarası 12 haneli olmalıdır!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Kredi kartına yatırıldı");
                            bakiye += tutar;
                        }
                        break;

                    case 2:
                        bakiye += tutar;
                        Console.WriteLine("Kendi Hesabınıza yatırıldı");
                        Console.WriteLine("Yeni bakiye: " + bakiye);
                        break;

                    case 9:
                        Console.WriteLine("ANA MENÜYE AKTARILIYORSUNUZ");
                        return;

                    case 0:
                        Console.WriteLine("ÇIKIŞ");
                        Environment.Exit(0);//çıkış yapıyor
                        return;
                    default:
                        Console.WriteLine("Hatalı tuşlama yaptınız.Tekrar deneyiniz");
                        Console.ReadLine();
                        return;
                }
            }


        }


    }
}
