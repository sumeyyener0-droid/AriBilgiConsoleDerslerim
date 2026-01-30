namespace _260130_3_dizi_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullancıdan alınan 7 sayıyı aldıktan sonra ekranda gösterip toplamlarını,hesaplaint[
            int[] sayilar = new int[7];
            int elemansayisi = sayilar.Count();
            int toplam = 0;
            int sayac = 0;
            while(sayac<elemansayisi)
            {
                Console.WriteLine(sayac+1+". sayıyı giriniz");
                sayilar[sayac] = Convert.ToInt16(Console.ReadLine());
                toplam += sayilar[sayac];
                sayac++;
            }
            int i = 0;
            Console.WriteLine("girilen sayılar");

            do
            {
                Console.WriteLine(i + i);
                i++;
            } while (i < elemansayisi);
            Console.WriteLine("girilen sayilar toplamı"+toplam);
         
        }
    }
}
