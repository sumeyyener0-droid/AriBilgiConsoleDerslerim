namespace _260203_1_dizinin_siralama_sorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elemansayisi = 5;
            int[] dizi = new int[elemansayisi];

            for(int i=0; i<dizi.Length; i++)
            {
                Console.WriteLine(i+1+".sayıyı giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<dizi.Count();k++)
            {
                for(int k=0; k<dizi.Count(); k++)
                {
                    int buyuksayi:
                        if (dizi[k] > dizi[i])
                    {
                        buyuksayi = dizi[k];
                        dizi[i] = buyuksayi;
                        dizi[k] = 0;
                    }
                }
                  
            }
        }
    }
}
