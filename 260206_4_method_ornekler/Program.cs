namespace _260206_4_method_ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYaZ("1. sayıyı giriniz:");
            int sayi1 = IntYap();
            //int sayi1=Convert.ToInt32(Console.ReadLine());
            //int sayi1=Convert.ToInt32(oku());
            EkranaYaZ("Girilen sayı:" + sayi1);
        }
        static void EkranaYaZ(string metin)
        {
            Console.WriteLine(metin);
        }

        static string Oku()
        {
            return Console.ReadLine();
        }
        static int IntYap()
            {
            return Convert.ToInt32(Oku());
        }
    }
}
