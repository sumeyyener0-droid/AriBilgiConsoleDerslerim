namespace _260213_2_Overload_methodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //overload method=> aşırı yüklenmiş method
            //aynı isimde birden fazla işlevi gören methodlara overload method denir
            /*
             aşırı yüklenmiş methodlar aşağıdaki kurallara göre yapılmalıdır
            1- aynı isimde olmalı
            2-farklı sayıda parametreye sahip olmalı,eğer aynı sayıda parametre içeren başka overload method varsa parametre tipi
            en az bir tanesi farklı olmalıdır.
            3-void ya da return olması overload özelliğini değiştirmez.
            */
            Console.WriteLine();
            Console.Write(true);
            Matematik("");
            int s1 = Matematik();
            int s2 = Matematik();
            Matematik(s1, s2);
            Console.WriteLine("2 sayının toplamı:" + Matematik(s1, s2));

            double d1 = Matematik();
            double d2 = Matematik();
            Console.WriteLine("küçük sayıdan büyük sayıya kadar toplamı:"+Matematik((double) d1,(double) d2));

        }



        /// <summary>
        /// sayı girişi ve girilen sayıyı da int olarak verir
        /// </summary>
        /// <returns></returns>
        static int Matematik()
        {
            Console.WriteLine("Sayı Giriniz:");
            return Convert.ToInt32(Console.ReadLine());
        }


       /// <summary>
       /// ekrana girilen metni verir
       /// </summary>
       /// <param name="metin"></param>

        static void Matematik(string metin)//ekrana yazı yazar
        {
            Console.WriteLine(metin);
        }

        /// <summary>
        /// test1----------
        /// </summary>
        /// <param name="text"></param>
        
        static void Matematik(int text)
        {
           //isimi aynı,parametre aynı ama parametre tipi diğerinden farklı overload metod özelliği taşır
        }


        /// <summary>
        /// test2---------------
        /// </summary>
        /// <param name="text"></param>

        static void Matematik(double text)
        {
            //isimi aynı,parametre aynı ama parametre tipi diğerinden farklı overload metod özelliği taşır
        }

        static int  Matematik(int sayi1, int sayi2)
        {
            //isimi aynı,parametre aynı ama parametre tipi diğerinden farklı overload metod özelliği taşır
            return sayi1 + sayi2;
        }

        /// <summary>
        /// 2 sayı arasındaki sayıların toplamını hesaplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>

        static double Matematik(double s1,double s2)
        {
            double toplam = 0;
            if(s1>s2)
            {
                for (double i = s2; i < s1; i++)
                {
                    toplam = toplam + i;
                }
            }
            else
            {
                for (double i = s1; i < s2; i++)
                {
                    toplam = toplam + i;
                }
            }
            return toplam;
        }
    }
}
