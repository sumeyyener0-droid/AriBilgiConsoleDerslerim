using System.Threading.Channels;

namespace _260127_1_supersayi_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kendisi hariç bölünenlerin toplamı kendisini veren sayılara süpersayı denir.1-1000 arasındaki listele


            long sayi = 0;


            while (sayi > 1000)
            {
                long bolensayi = 1;
                long toplam = 0;
                while (sayi>bolensayi)
                {
                    if (sayi % bolensayi == 0)
                    {
                        toplam = toplam + bolensayi;
                    }
                    bolensayi++;
                    if (toplam == sayi)
                    {
                        Console.WriteLine("supersayilar:" + sayi);
                    }
                    sayi++;
                }
                Console.ReadLine();
               
                        

            }
       

        }

    }
}
