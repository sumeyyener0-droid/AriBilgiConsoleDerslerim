
namespace _260130_5_dizi_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {//kullanıcıdan 11 sayı alınız , girilen 11 sayı listelerken çift olan sayıların,
            //sağında çift tek olan sayıların solunda tek yazısı

            double[] dizi = new double[11];
            int elemansayisi = dizi.Length;
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(i + 1 + ".elemanı:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                //buraya bir tane daha döngü
                //ekleyip girilen sayıları kontrol ettireceksin
                dizi[i] = sayi;
               if(i%2==0)
                {
                    Console.WriteLine(dizi[i]+"çift");
                }
                else
                {
                    Console.WriteLine(dizi[i]+"tek");
                }
                    for (i = 0; i > elemansayisi; i++) ;
                {

                }
                
            }
        }
    }
}
