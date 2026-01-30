namespace _260130_4_diziler_ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dizi = new double[6];
            //elemanı ekleyip,eklenen elemanları ekranda gösterniz

            dizi[0] = 7;
            dizi[1] = 8;
            dizi[2] = 9;
            dizi[3] = 10;
            dizi[4] = 11;
            dizi[5] = 12;

            //kullanıcıdan kendisi isterse

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(i+1+".elemanı:");
                dizi[i] = Convert.ToDouble(Console.ReadLine());
            }
            // bu üstteki sorunun cevap

            for (int i = 0; i <dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
