using System.Collections;//arraylist için gerekli
using System.Collections;
using System.Collections.ObjectModel;


namespace _260203_2_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list,collections,array,delegate
            //arraylist kullanmak için usıng.system.collectıons;kütüphanesi en başa eklemeniz gerekmektedir.
            ArrayList arrayList = new ArrayList();

            arrayList.Add("arı bilgi");//arraylist için eleman add ile eklenir
            arrayList.Add(45);
            arrayList.Add(25.5m);//decimal
            arrayList.Add(DateTime.Now);

            for(int i=0; i < 0; i++)//0 a bak sayilar olacak
            {
                Console.WriteLine(arrayList[i]);
            }
            ArrayList sayilar = new ArrayList();
            sayilar.Add(87);
            sayilar.Add(7);
            sayilar.Add(8);
            sayilar.Add(23);

            sayilar.Sort();//küçükten büyüğe doğru sıralama

            for(int i=0; i<sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]+"-");
            }
            Console.WriteLine();
            int kapasite = arrayList.Capacity;//kapasite 2 nin üstü şeklinde değer alır
            Console.WriteLine("kapasite,eleman sayısı değildir:" + kapasite);
            Console.WriteLine("count ile eleman sayısı:"+arrayList.Count);//count,arraylist eleman sayısını verir
            //index nedir?


           
            //bu kısım eksik düzeltme yap

                for(int i=0; i<arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            //arraylist kopyalamak
            ArrayList newlİST = new ArrayList();

            newlİST.CopyTo(arrayList.ToArray());
            for(int i=0; i<newlİST.Count; i++)
            {
                Console.WriteLine(newlİST[i]+",");
            }




        }
    }
}
