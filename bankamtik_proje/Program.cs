using System.ComponentModel.Design;
using System.Threading.Channels;

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
                        ParaTransferleri();
                        break;
                    case 4:
                        EgitimOdemeleri();
                        break;
                    case 5:
                        Odemeler();
                        break;
                    case 6:
                        BilgiGuncelleme();
                        break;
                    case 0:
                        Console.WriteLine("Çıkış yapılıyor");
                        Environment.Exit(0);//çıkış yapma işlemi
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
            while (true) //ana menüye dönme
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

        static void ParaTransferleri()
        {
            Console.WriteLine("Para Transferleri");
            Console.WriteLine("1-Başka Hesaba EFT");
            Console.WriteLine("2-Başka Hesaba Havale");
            Console.WriteLine("9-Ana Menü");
            Console.WriteLine("0-ÇIKIŞ");
            Console.WriteLine("Seçiminizi yapınız");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("EFT");
                    string iban;
                    int sonSecim;
                    while (true)
                    {
                        Console.WriteLine("26 haneli ve TR ile başlayan iban giriniz.");
                        iban = Console.ReadLine();
                        if (iban.StartsWith("TR") && iban.Length == 26)//startwish başlangıç karakteri kontrol
                        {
                            Console.WriteLine("İban doğrulandı.İşlem yapılıyor");
                            break;//doğru ise döngüden çıkar
                        }
                        else
                        {
                            Console.WriteLine("Hatalı İban TEKRAR DENEYİNİZ.");
                        }
                        Console.WriteLine("Para gönderme işlemi başarıyla tamamlandı.");
                        Console.WriteLine("9-ANA MENÜYE DÖN");
                        Console.WriteLine("0-ÇIKIŞ");
                        Console.WriteLine("Seçim yapınız");
                        sonSecim = Convert.ToInt32(Console.ReadLine());
                        if (sonSecim == 9)
                        {
                            Console.WriteLine("ANA MENÜYE AKTARILIYORSUNUZ");
                        }
                        else if (sonSecim == 0)
                        {
                            Console.WriteLine("ÇIKIŞ yapılmaktadır");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı tuşlama yaptınız.Tekrar deneyiniz");
                        }

                    }
                    break;
                case 2:
                    Console.WriteLine("Havale");
                    while (true)
                    {

                        Console.WriteLine("Hesap numarasını giriniz.");
                        int hesapNumara = Convert.ToInt32(Console.ReadLine());
                        if (hesapNumara.ToString().Length == 11 && bakiye >= tutar)
                        {
                            Console.WriteLine("Hesap numarası doğrulandı.Para Hesaba Gönderildi");
                        }
                        else if (hesapNumara.ToString().Length == 11 && bakiye < tutar)
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı hesap numarası.TEKRAR DENEYİNİZ");
                        }
                    }
                    break;
                case 9:
                    Console.WriteLine("ANA MENÜYE AKTARILIYORSUNUZ");
                    break;
                case 0:
                    Console.WriteLine("ÇIKIŞ");
                    break;
                default:
                    Console.WriteLine("Hatalı tuşlama yaptınız.Tekrar deneyiniz");
                    Console.ReadLine();
                    return;

            }

        }

        static void EgitimOdemeleri()
        {
            Console.WriteLine("Eğitim Ödemeleri");
            Console.WriteLine("9-ANA MENÜ");
            Console.WriteLine("0 - ÇIKIŞ");
            Console.WriteLine("Seçiminizi yapınız");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 9:
                    Console.WriteLine("ANA MENÜYE aktarılıyorsunuz.");
                    break;
                case 0:
                    Console.WriteLine("ÇIKIŞ");
                    break;
                default:
                    Console.WriteLine("Hatalı tuşlama yaptınız .Tekrar deneyiniz");
                    Console.ReadLine();
                    return;
            }


        }

        static void Odemeler()
        {
            Console.WriteLine("ÖDEMELER");
            Console.WriteLine("1-Elektrik Faturası");
            Console.WriteLine("2-Telefon Faturası");
            Console.WriteLine("3-İnternet Faturası");
            Console.WriteLine("4-Su Faturası");
            Console.WriteLine("5-OGS Ödemeleri");
            Console.WriteLine("9-ANA MENÜ");
            Console.WriteLine("0-ÇIKIŞ");
            Console.WriteLine("Seçim yapınız");
            int secim = Convert.ToInt32(Console.ReadLine());
            double faturaTutari = 0;

            switch (secim)
            {
                case 1://elektrik faturası
                case 2://telefon faturası
                case 3://internet faturası
                case 4://su faturası
                case 5://ogs ödemeleri
                    Console.WriteLine("Fatura ödenecek tutar:{fatura tutarı} TL");
                    if (bakiye >= faturaTutari)
                    {
                        Console.WriteLine("Bakiyeniz bu ödeme için yeterli.");
                        Console.Write("Ödemeyi onaylıyor musunuz? (E/H): ");//bu kısım yeni burayı incele!!!
                        string onay = Console.ReadLine().ToUpper();

                        if (onay == "E")
                        {
                            bakiye -= faturaTutari; // Bakiyeden düşüyoruz
                            Console.WriteLine($"Ödeme başarıyla yapıldı. Kalan Bakiye: {bakiye} TL");


                        }
                        else
                        {
                            Console.WriteLine("Ödeme işlemi kullanıcı tarafından iptal edildi.");
                        }
                    }
                    else
                    {
                        double eksik = faturaTutari - bakiye;
                        Console.WriteLine($"Yetersiz Bakiye! Ödeme yapılamaz. Eksik tutar: {eksik} TL");
                    }
                    break;

                case 9:
                    Console.WriteLine("ANA MENÜ");
                    break;
                case 0:
                    Console.WriteLine("ÇIKIŞ");
                    break;
                default:
                    Console.WriteLine("Hatalı tuşlama yaptınız.Tekrar deneyiniz");
                    Console.ReadLine();
                    return;
            }
        }

        static void BilgiGuncelleme()
        {
            Console.WriteLine("Bilgi Güncelleme");
            Console.WriteLine("1-Şifre Güncelleme");
            Console.WriteLine("9-ANA MENÜ");
            Console.WriteLine("0-ÇIKIŞ");
            Console.WriteLine("Seçiminizi yapınız");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {

                case 1:
                    Console.WriteLine("Şifre Güncelleme İşlemi");
                    while (true)
                    {

                        string mevcutSifre = "1234";

                        Console.Write("Mevcut şifrenizi giriniz: ");
                        string girilenEskiSifre = Console.ReadLine();


                        if (girilenEskiSifre != mevcutSifre)
                        {
                            Console.WriteLine(" Mevcut şifrenizi yanlış girdiniz. İşlem iptal edildi.");
                            return;
                        }
                        Console.Write("Yeni şifrenizi belirleyin: ");
                        string yeniSifre = Console.ReadLine();

                        Console.Write("Yeni şifreyi tekrar girin: ");
                        string yeniSifreTekrar = Console.ReadLine();

                        if (yeniSifre == yeniSifreTekrar)
                        {
                            mevcutSifre = yeniSifre; // Şifre güncellendi
                            Console.WriteLine("Tebrikler! Şifreniz başarıyla güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("HATA: Yeni şifreler birbiriyle eşleşmiyor!");
                        }
                    }
                    break;
                case 9:
                    Console.WriteLine("ANA MENÜYE AKTARILIYORSUNUZ.");
                    break;
                case 0:
                    Console.WriteLine("ÇIKIŞ");
                    break;
                default:
                    Console.WriteLine("Hatalı tuşlama yaptınız.Tekrar deneyiniz");
                    Console.ReadLine();
                    return;
            }
        }

    }
}
