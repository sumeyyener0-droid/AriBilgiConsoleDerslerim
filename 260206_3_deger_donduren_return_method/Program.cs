namespace _260206_3_deger_donduren_return_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method=> Metot
            //function=> Fonksiyon
            //parametre=> dışarıdan girilen değer
            //**********************************
            //Değer döndüren return method=>
            //1)Method adından önce var dışında bir değişken adı (byte,sbyte,short,ushort,int, uint,long, ulong, float, double,decimal,DateTime, bool, object) varsa bu değer döndüren bir method'tur.
            //2)Değer döndüren method kod içinde , kodun bittiğini gösteren return anahtar kelimesini yazmak zorundayız

            int s1=98,s2=2;
            Console.WriteLine(Cizgi();
            Cizgi();
            int deger1 = 90;

            int islem=Topla(s1, s2);//toplam() işlem sonucunda int tipinde değer verecektir
            /*
             -------------ÖNEMLİ------------------
            değer döndüren method işlem sonucunda method adından önce yazılan veri tipinde değer getirir 
            bu özellik kod içinde return metodları değişken gibi kullanma kolaylığı sağlar.
             */

        }

        static string Cizgi()
        {
            return "----------------------";
        }

        static int Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("2 sayının toplamı:"+toplam);
            return toplam;//int ile belirtilen method ile min int aralığına sahip veri tipleri yazılabilir değer alan
            //alan değişken sayı verilmelidir return ile berbaber method sonlanır bundan dolayı return yazıldığı yer çok önemlidir
        }


        static void ToplaVoid(int sayi1,int sayi2)//deger döndürmez void içeriyor
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("2 sayının toplamı:" + toplam);
        }
    }
}
