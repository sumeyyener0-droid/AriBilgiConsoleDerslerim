namespace _260212_1_elektrik_fatura_cozumhoca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYaz("harcanan elektrik değerini kw cinsinden giriniz");
            //double kw = OkuDouble();
            //EkranaYaz("Faturanız:"+FaturaHesabı(kw));  => double kw= yerine yazabilirsin
            //YUKARIDAKİ 2 SATIR KODU TEK BİR SATIR İLE KODLAYABİLİRİZ
            EkranaYaz("faturanız:" + FaturaHesabı(OkuDouble()));
        }

        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
            double kw = Convert.ToInt32(Console.ReadLine());
        }

        static double OkuDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        static double FaturaHesabı(double kw)
        {

            if (kw > 0 && kw <= 150)
            {
                return kw * 1.06;
            }
            else if (kw > 150 && kw < 300)
            {

                return 140 + (kw - 150) * 1.16;
            }
            else if (kw > 300 && kw < 450)
            {
                return 320 + (kw - 300) * 1.25;
            }
            else if (kw > 450 && kw < 650)
            {
                return 530 + (kw - 450) * 1.29;
            }
            else//650 ve üstü için
            {
                return 800 + (kw - 650) * 1.32;
            }
            
        }
    }
}
