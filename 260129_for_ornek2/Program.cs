using System.Net.NetworkInformation;

namespace _260129_for_ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-15000 sayıların 5 in katı olup 2 in katı olmayan sayıların sayısını ve toplamını hesapla;
            int toplam = 0, adet = 0;

            for (int i = 1; i < 15000; i++)
            {
                if (i % 5 == 0 && i % 2 != 0)
                {

                    adet++;
                    toplam += i;
                }

            }

            Console.WriteLine("1-15000 arasındaki 5 in katı olup 2 nin katı olmayan sayı adeti(0) ve" +
                    " toplamları(1)", adet, toplam);
        }

    }
}
    

