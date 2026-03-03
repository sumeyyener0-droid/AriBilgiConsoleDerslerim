namespace bankamtik_proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM UYGULAMASI");
            KartliIslem();
            KartsizIslem();
            BaslangicMenusu();
            AnaMenu();
        }
        static void KartliIslem()
        {
            Console.WriteLine("Kartlı İşlem Menüsü ");
            AnaMenu();

            string girilenSifre = Console.ReadLine();
            string sifre = "ab18";
            int hak = 3;
            while (hak>0)
            {
                Console.WriteLine("şifre:");
                Console.ReadLine();

                if(girilenSifre==sifre)
                {
                    Console.WriteLine("Şifre Doğru.Ana Menüye geçiş");
                    AnaMenu();
                    return;
                }
                else
                {
                    Console.WriteLine("Girilen Şifre Yanlış.Tekrar Deneyiniz");
                    Console.WriteLine("Kalan hak:"+hak);
                    hak--;
                    if(hak==0)
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
        static void BaslangicMenusu()
        {
            
            Console.WriteLine("1-Kartlı İşlem");
            Console.WriteLine("2-Kartsız İşlem");
            string secim =Console.ReadLine();
            if(secim=="1")
            {
                KartliIslem();
            }
            else if(secim=="2")
            {
                KartsizIslem();
            }
            else
            {
                Console.WriteLine("Geçersiz işlem.Tekrar deneyiniz.");
                BaslangicMenusu();
            }
        }
        static void AnaMenu()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Para Çekme İşlemi");
                    break;
                case "2":
                    Console.WriteLine("Para Yatırma İşlemi");
                    break;
                case "3":
                    Console.WriteLine("Para Transferleri İşlemi");
                    break;
                case "4":
                    Console.WriteLine("Eğtim Ödemeleri İşlemi");
                    break;
                case "5":
                    Console.WriteLine("Ödemeler İşlemi");
                    break;
                case "6":
                    Console.WriteLine("Bilgi Güncelleme İşlemi");
                    break;
                case "0":
                    Console.WriteLine("Çıkış İşslemi");
                    break;
                default:
                    Console.WriteLine("Hatalı tuşlama Tekrar Deneyiniz.");
                    Console.ReadLine();
                    AnaMenu();
                    break;
            }
            
        }

    }
}
