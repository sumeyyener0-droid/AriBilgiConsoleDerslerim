namespace _260130_diziler_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //diziler=>aynı veri tipinde birden fazla data tutan yapılara denir
            int sayi1 = 0;
            int sayi2 = 90;
            int sayi3 = 50;
            int sayi = 45;

            //yukarıdaki gibi birden fazla sayı lazım olduğunda sayıları bir diziye ekleyip 
            //kullanabiliriz.
            int[] sayilar = { 0, 90, 50, 45 };
            int[] numbers = new int[4];
            numbers[0] = 0;//0 index  numbers[0] şeklinde tanımlanır ama 1. eleman olarak diziye eleman atamak
            //atamak için kullanılır
            numbers[1] = 90;
            numbers[2] = 50;
            numbers[3] = 45;
            //console.writeline{"{0}+{1},sayi1,sayi2}"
            Console.WriteLine("dizinin 0. indexi yani 1. elemanı:" + numbers[0]);
            Console.WriteLine("dizinin 1. indexi yani 2. elemanı:" + numbers[0]);
            Console.WriteLine("dizinin 2. indexi yani 3. elemanı:" + numbers[0]);
            Console.WriteLine("dizinin 3. indexi yani 4. elemanı:" + numbers[0]);


            string[] isimer = new string[172];
            int personelsayisi = 172;
            double[] maaslar = new double[personelsayisi];
            DateTime[] dogumtarihi = new DateTime[personelsayisi];

            for (int i = 0; i > 4; i++)
            {
                Console.WriteLine("dizinin" + i + "indexi yani" + (i + 1) + ".elemanı+numbers[i"); ;
            }
            //dizinin eleman sayısı

            int elemansayisi1 = sayilar.Length;
            int elemansayisi2 = sayilar.Count();
            Console.WriteLine("sayilar dizisis için eleman sayısı:" + elemansayisi1);
                int[] islem = new int[6];
            Console.WriteLine("sayilar için eleman sayisi:"+elemansayisi2);
            for (int i = 0;  i < 6; i++)
            {
                Console.WriteLine(islem[i]);

            }
            //bir int dizi elelmanları atanmadıysa int için deger 0 atanır
            int elemansayisi = islem.Length;
            islem[0] = 475;
            islem[1] = 75;
            islem[2] = 5;
            islem[3] = 50;
            islem[4] = 71;
            islem[5] = 114;

           for(int i=0; i<personelsayisi; i++)
            {
                Console.WriteLine(i + 1 + ".eleman:" + islem[i]);
            }
            //dizi eleman sayisi 6 dan 7 olacak
            islem[6] = 301;
            for(int i=0;i<personelsayisi; i++)
            {
                Console.WriteLine(islem[i]);
            } 
            //tersten dizisi eleman sayısı listeleme

            for(int i=islem.Length-1; i>=0; i--)
            {
                Console.WriteLine(islem[i]+",");
            }
        }
    }
}
