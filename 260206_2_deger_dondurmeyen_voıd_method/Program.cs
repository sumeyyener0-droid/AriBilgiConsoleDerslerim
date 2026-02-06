namespace _260206_2_deger_dondurmeyen_voıd_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //değer döndürmeyen void method , method adından önce void ifadesi içeriyorsa değer döndürmeyen method olur.

            Cizgi();
            Console.WriteLine("adınız:");
            string ad = Console.ReadLine();

            Console.WriteLine("soyadınız:");
            string soyad = Console.ReadLine();
            AdSoyadBuyukHarf(ad, soyad);
        }
        static void Cizgi()
        {
            Console.WriteLine("------------------");
        }

        static void AdSoyadBuyukHarf(string ad, string soyad);
        {
        Console.WriteLine("ad:{0} ve soyad{1}"ad.ToUpper(),soyad.ToUpper());

        }

    }
}
