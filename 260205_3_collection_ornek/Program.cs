using System.Collections;

namespace _260205_3_collection_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;

            string[] kart = { "ad", "soyad", "doğum tarihi", "cinsiyet", "medeniyet durum", "aylık gelir" };
            ArrayList kartItem = new ArrayList();
            Console.WriteLine("kaç kişiyi gireceksiniz");

            int kisisayisi = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i< kisisayisi; i++)
            {
                foreach(var item in kart)
                {
                    if(item=="medeni durum")
                    {
                        Console.WriteLine("bekar 1,evli için0 yazınız");
                        
                    }
                    else
                    {
                        Console.WriteLine(item+"giriniz");
                        sayac++;
                    }
                }
                

                for(int i = 0; i< kartItem.Count(); i++)
                {
                    if(sayac==0)
                    {
                        Console.WriteLine((sayac) + ":" + kartItem);
                        sayac++;
                    }
                    else if(sayac==1)
                        {

                        Console.WriteLine(kart(sayaca) + ":" + kartItem(i));
                        sayac++;
                    }
                    else if (sayac == 2)
                    {

                        Console.WriteLine(kart(sayaca) + ":" + kartItem(i));
                        sayac++;
                    }
                    else if (sayac == 3)
                    {

                        Console.WriteLine(kart(sayaca) + ":" + kartItem(i));
                        sayac++;
                    }
                    else if (sayac == 4)
                    {

                        Console.WriteLine(kart(sayaca) + ":" + kartItem(i));
                        sayac++;
                    }
                    else if (sayac == 5)
                    {

                        Console.WriteLine(kart(sayaca) + ":" + kartItem(i));
                        sayac++;
                    }
                    else if (sayac == 6)
                    {

                        Console.WriteLine(kart(sayaca) + ":" + kartItem(i));
                           
                        sayac++;
                    }

                }
                for(int i=0; i<kartItem.Count(); i++)
                {
                    Console.WriteLine(kart(sayac)+":"kartItem(i));
                    sayac++;
                    if(kart.Length ==(i+1))
                    {
                        sayac = 0;
                    }
                }
            }
        }
    }
}
