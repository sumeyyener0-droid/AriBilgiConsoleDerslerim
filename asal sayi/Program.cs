using System.Threading.Channels;

namespace asal_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi2 = 2;
            int bolensayi = 2;
            int toplamasalsayilar = 0;
            bool asalmi = true;
            while (sayi2 > bolensayi)
            {
                asalmi = true;
                if (sayi2 % bolensayi == 0)
                {
                    asalmi = false;
                    break;
                }
                bolensayi++;
            }
            if (asalmi)
            {
                toplamasalsayilar = toplamasalsayilar + sayi2;
                Console.WriteLine(sayi2 + ",");
            }
            sayi2++;
        }
       



    }
}
