using System.Security.Cryptography;

namespace _260210_2_method_ornek1
{
    internal class Program
    {
        static void main(string[] args)
        {
            00000000000000000000000000000000000000000000000000000000000000000000000000000000000
            //kullanıcıdan alınan 3 sayının toplamını veren işlemi method kullanarak
            //toplayınız
            int toplam = 0;
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("3 sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine);
                toplam = toplam + sayi;
            }
            Console.WriteLine("3 sayının toplamı:"+toplam);
            //normal çözüm ve method ile çözüm

            int s1 = SayiAl();
            toplam = Islem(s1, toplam);


            int s2 = SayiAl();
            toplam = Islem(s2, toplam);


            int s3 = SayiAl();
            toplam = Islem(s3, toplam);

            EkranaYaz("3 sayının toplamı:" + toplam);


        }
        static int SayiAl()
        {
            EkranaYaz("sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }

        static int islem(int sayi1,int toplam)
        {
            return toplam + sayi1;
        }
        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
        }



    }
}
