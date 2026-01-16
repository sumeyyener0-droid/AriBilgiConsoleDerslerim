namespace _260116_1_atama_operatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              atama operatörleri
            +=
            -=
            *=
            /=
            %=
            ++
            --
            + strıng olarak birleştir
            
           */

            int sayi1 = 900;
            //kodun içinde herhangi bir yerde sayi1 e yeni deger eklemesi gerekiyor
            //sayi yenisayi1 olarak devam edecektir

            //int sayi1=sayi1+10;//bunun yerine aşagıdaki atama işleöi yapılarak yeni değişken tanımlaması yapılmaz sayi1 değişkeni yeni al
            //aldığı değer üzerinden işlem görmesini sağlar
            //kod ilerledi,sayi1 için  yeni bir bir işlem gerekli oldu, örneğin %20 arttırmak gibi  //sayi1=sayi1+10;
            sayi1 += 10;

            //kod ilerledi,sayi1 için  yeni bir bir işlem gerekli oldu, örneğin %20 arttırmak gibi
            //int yenisayi2=yenisayi1+yenisayi1*20/100;
            //sayi1 artık sayi2 olarak devam edecek
            //sayi1=sayi1+sayi1*20/100;
            sayi1 += sayi1 * 20 / 100;

            //*************************************
            int sayi2 = 100;//değerini 5 ile çarpalaım
            //sayi2=sayi2*5
            sayi2 *= 5;

            Console.WriteLine("sayi2=100, sayi2 degeri 5 ile çarptık:" + sayi2);
            int sayi3 = 450;
            //sayi3 9 ile bölündüğünde sonucunu atama operatörü ile yazalım
            sayi3 /= 9;
            Console.WriteLine("450 degerinin 9 ile bölünmesi:" + sayi3);

            int sayi4 = 845;
            // sayi4 degerinin 9 ile bölünmesinden kalanı atama opetaörü ile yazınız
            sayi4 %= 9;
            Console.WriteLine("845 degerinin 9 ile bölünmesinden kalan:" + sayi4);

            int deger1 = 10;
            deger1++;//deger1 in degeri 1 arttırıldı
            Console.WriteLine("deger1=10 degeri++ ile arttırıldı" + deger1);
            deger1 += 1;
            Console.WriteLine("deger1=10 +=1 ile arttırıldı:" + deger1);
            int deger2 = ++deger1;//deger1 in degeri 1 arttırılır ve deger 2 atanır
            Console.WriteLine("++deger1:" + deger2);

            // int deger3=deger2++ + 10; //ilkin deger2 degeri deger 3 e eşitlenir sonra ++ işlemi deger2 ye uygulanmır
            int deger3 = ++deger2 + 10;//deger2 nin degeri 1 arttırılır ve 10 ile toplanarak deger3 e atanır




            //****************************

            int s1 = 10;
            int s2 = 20;
            int toplam = s1 + s2;//30
            Console.WriteLine("hesaplanan toplam:" + toplam);
            Console.WriteLine("string toplam:" + s1+s2);//1020
            Console.WriteLine("hesaplanan toplam:" + (s1+s2));//30
            Console.WriteLine(s1 + s2);//30 olacaktır string bir ifade + işleminden önce yok
            Console.WriteLine(""+s1+s2);//1020 olacaktır + işleminden önce"" var


            //-------------------------
            //bölme işlemi için bazı notlar
            // 10/2=5, 10m 2 nin katıdır
            //1424 2 ve 3 ün katı mıdır
            int kat1 = 1425;
            Console.WriteLine("1425,2 nin katı mı?"+kat1%2);
            Console.WriteLine("1425,3 ün katı mıdır?"+kat1%3);

        }
    }
}
