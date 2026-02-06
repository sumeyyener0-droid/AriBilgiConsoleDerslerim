
namespace _260206_1_method_tanim
{
    internal class Program
    {
        //ctrl+m+o=> bütün methodları gizler
        //ctrlm+l=>gizli methodları gösterir
        //ctrl+k+d=> hata yoksa düzenler,varsa yapmaz

        //string[]=>string bir dizi int[],double[]ArrayList...olabilir
        //args=>değişken->parametre dizi,sayılar,isimler,sehirler olabilir
        //main(string[] args)=> string bir dizisi olan main adına method(functıon)->topla,fark maaszam,getirki,sibilgileri
        //void=>method türü_>int,double(var dısında tüm veri tipleri kullanılabilir)
        //static=>erişim belirleyiciisi bir yapıya(değişken,method,class)erişimi yanikullanmak için izin olup olmadığını
        //erişim belirleyicisi sağlar(publicprivate gibi)
        //mtehod nedir=>sürekli kodlanan bir kod varsa bu kodu sürekli kodlamak yerine onu bir format ile sürekli
        //kullanabileceğiniz halde tutmak için method içine kodlarız ve her lazım olduğunda method çağırmak yeterli olacaktır,
        //artık aynı kodu tekrar tekrar yazmaya gerek yoktur.

        //aşagıdaki yapı ile method yapalım
        /*
           Erişim Belirleyicileri
       1-public => herkese açık
       2-private=> özel, sadece tanımlandığı yerde kullanılabilir
       3-internal=> aynı proje altında kullanılabilir
       4-protected=> kalıtım verdiği class larda kullanılabilir
       5-internal protected=> aynı proje altında ve kalıtım verdiği class larda kullanılabilir
       6-static=> tanımlama yapmadan direk kullanma imkanı sağlar.
        class lar konusunda erişim belirleyicileri ayrıntılı bir şekilde incelenecektir

        **************************************************
        
        method çeşitleri
        1-değer döndürmeyen void method
        2-değer döndüren return method
        3-aşırı yüklenmiş overload methodu

         */



        /// <summary>
        /// büyük sayı ile küçük sayıyı toplar
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)

        {
            Console.WriteLine("1. sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Toplam(sayi1, sayi2);
                //bu 2 sayının büyükden küçük sayı çıkartan fark adında metod kodlayınız



            }


        static void Toplam(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("2 sayının toplamı:" + toplam);
        }
        /// <summary>
        /// büyük sayıdan küçük sayıyı çıkartır
        /// </summary>
        /// <param name="deger1"></param>
        /// <param name="deger2"></param>

        static void Fark(int deger1, int deger2)
        {

            if (deger1 < deger2) 
            {
                int fark = deger2 - deger1;

            }
            else
            {
                int fark = deger1 - deger2;

                Console.WriteLine("Büyük sayıdan küçük sayı farkı:" + fark);
            }
        }
        //büyük sayıya küçük sayının bölünmesinde kalanı veren ModAl adında method kodlayınız
       
        /// <summary>
        /// bu 2 sayının modunu hesaplar
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        
        static void ModAl(int d1,int d2)
        {
            int kalanhesapla;
            if(d1>d2)
            {
                 kalanhesapla = d1 % d2;
            }
            else
            {
                 kalanhesapla = d2 % d1;
            }
            Console.WriteLine("büyük sayıdan küçük sayının modu:"+kalanhesapla);
        }

    }
}
