using System.Runtime.InteropServices;

namespace _260212_2_emekli_method_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir ülkede emeklilik hesabı cinsiyet,yaş,prim gün sayısı(Çalıştığı gün sayısı) şartlarına göre hesaplanıp
            emekli edilmektedir
           Eğer Cinsiyet kadın ise
           yaş 60 ve üstü ise, prim 7300 ise kişi maaşının 15 katı kadar ikramiye alarak emekli ediliyor

Eğer Cinsiyet erkek ise
yaş 65 ve üstü ise, prim 8500 ise kişi maaşının 17.5 katı kadar ikramiye alarak emekli ediliyor

bu şartlara kişi emekli ise alacağı ikramiye, emekli değilse emekli olmama nedenini veren yapıyı kodlayınız
NOT: Cinsiyet seçimi switch case ile yapılacaktır
 */
            string cinsiyet = "";
            while (true)
            {
                Console.WriteLine("cinsiyet giriniz");
                 cinsiyet = Convert.ToString(Console.ReadLine());
                if(cinsiyet=="kadın"|| cinsiyet=="bayan"|| cinsiyet=="bay"|| cinsiyet=="erkek")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("hatalı cinsiyet girişi");
                }

            }

                Console.WriteLine("yaş giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primgün sayısı giriniz");
            int primGun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("maaş giriniz");
            double maas = Convert.ToDouble(Console.ReadLine());


            double ikramiye=EmekliHesapla(cinsiyet,yas,primGun,maas);
            Console.ReadLine();
            if(ikramiye>0)
            {
                Console.WriteLine("emekli oldunuz ikramiyeniz:"+ikramiye);
            }
            else
            {

            }
                 
        }


        static string Cinsiyet(string metin)
        {
            Console.WriteLine(metin);
            string cinsiyet = Convert.ToString(Console.ReadLine());
            return cinsiyet;

        }
        static int Yas()
        {
            Console.WriteLine();
            return Convert.ToInt32(Console.ReadLine());
        }

        static double EmekliHesapla(string cinsiyet, int yas, int primGun, double maas)
        {
            int prim;

            switch (cinsiyet)
            {
                case "kadın":
                case "bayan":

                    if (yas >= 60 && primGun >= 7300)
                    {
                        return maas * 15;
                        Console.WriteLine("maaşınız:");

                    }
                  


                        break;

                case "erkek":
                    if (yas >= 65 && primGun >= 8500)
                    {
                        return maas * 17.5;
                        Console.WriteLine("maaşınız:");
                    }
                    break;
                default:
                    Console.WriteLine("hatalı cinsiyet girişi");
                    break;
            }
            return maas;
        }
    }
}
