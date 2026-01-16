namespace operatör_devamı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //****************************

            int s1 = 10;
            int s2 = 20;
            int toplam = s1 + s2;//30
            Console.WriteLine("hesaplanan toplam:" + toplam);
            Console.WriteLine("string toplam:" + s1 + s2);//1020
            Console.WriteLine("hesaplanan toplam:" + (s1 + s2));//30
            Console.WriteLine(s1 + s2);//30 olacaktır string bir ifade + işleminden önce yok
            Console.WriteLine("" + s1 + s2);//1020 olacaktır + işleminden önce"" var


            //-------------------------
            //bölme işlemi için bazı notlar
            // 10/2=5, 10m 2 nin katıdır
            //1424 2 ve 3 ün katı mıdır
            int kat1 = 1425;
            Console.WriteLine("1425,2 nin katı mı?" + kat1 % 2);
            Console.WriteLine("1425,3 ün katı mıdır?" + kat1 % 3);

        }
    }
}

        }
    }
}
