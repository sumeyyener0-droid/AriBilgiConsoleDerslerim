using System.ComponentModel.Design;

namespace _260213_1_emekli_hocacozum
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static byte Yas()
        {
            EkranaYaz("yaşınız:");
            return Convert.ToByte(Console.ReadLine());
        }

        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
        }

        static int PrimGunSayisi()
        {
            EkranaYaz("prim gün sayısı giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
        static double Maas()
        {
            EkranaYaz("maaşınızı giriniz");
            return Convert.ToDouble(Console.ReadLine());
        }


        static string Oku()
        {
            return Console.ReadLine();
        }
        static void Cizgi()
        {
            EkranaYaz("-----------------------------------");
        }

        static void EmekliHesapla(string cinsiyet)
        {
            switch (cinsiyet)
            {
                case "kadın":
                case "bayan":

                    byte girilenYasKadin = Yas();

                    if (girilenYasKadin >= 60)
                    {
                        int girilenPrim = PrimGunSayisi();

                        if (girilenPrim >= 7300)
                        {
                            //...Emekli olabilir ve ikramiye hesabı için maaş  gerekli, maaş kullanıcıdan isteyelim
                            double girilenMaas = Maas();
                            double ikramiye = girilenMaas * 15;
                            Cizgi();
                            EkranaYaz("Emekli olabilirsiniz TEBRİKLER");
                            Cizgi();
                            EkranaYaz("Alacağınız ikramiye :" + ikramiye);
                        }
                        else
                        {
                            EkranaYaz("Girilen prim yetersiz olduğundan emekli olamazsaınız. Gerekli gün sayısı:" + (7300 - girilenPrim));
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} için yaş:{1} emeklilik için yeterli değildir", cinsiyet, girilenYasKadin);
                    }
                    break;

                case "erkek":
                case "bay":

                    byte girilenYasErkek = Yas();

                    if (girilenYasErkek >= 65)
                    {
                        int girilenPrim = PrimGunSayisi();

                        if (girilenPrim >= 8500)
                        {
                            //...Emekli olabilir ve ikramiye hesabı için maaş  gerekli, maaş kullanıcıdan isteyelim
                            double girilenMaas = Maas();
                            double ikramiye = girilenMaas * 17.5;
                            Cizgi();
                            EkranaYaz("Emekli olabilirsiniz TEBRİKLER");
                            Cizgi();
                            EkranaYaz("Alacağınız ikramiye :" + ikramiye);
                        }
                        else
                        {
                            EkranaYaz("Girilen prim yetersiz olduğundan emekli olamazsaınız. Gerekli gün sayısı:" + (8500 - girilenPrim));
                        }

                    }
                    else
                    {
                        Console.WriteLine("{0} için yaş:{1} emeklilik için yeterli değildir", cinsiyet, girilenYasErkek);
                    }

                    break;
                default:
                    Console.WriteLine("Hatalı cinsiyet girişi");
                    break;
            }
        }
    }
}
