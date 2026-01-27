namespace _260107_2_dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while döngüsü ilkin koşulaele alır,koşul doğru isedöngü içinde işleme alır.
            //do while 1 defa  koşula bakmadan işlem yapar,sonra koşula bakar,koşul doğru isedöngü içinde kodlar tekrar işleme alınır
            /*
                        while(true)
                        {
                            //2. adım kodlar işleme alınır
                        }

                        do//do=> yap
                        {
                            //1.adım döngü kodlarının yazıldığı bu alan 1 kez işleme alınır 1 kez işleme alındıktan sonra
                            // aşagıdaki gibi koşula bırakılır
                            //kod alanı bittiğini aşagıdaki while yapısı ile anlaşılır
                        } while (true);//2.adım koşul doğru ise tekrarkod alanına dönülür ve kodlar işleme alınır
            */
            int sayi = 1;
            //while (sayi>0)//0>0=>false
            //{
            // Console.WwriteLine("sayi 0 dan büyüktür:");
            //}
            //*****************
            //do while
            Console.WriteLine("*************** do while********");

            do
            {
                Console.WriteLine("sayı 0 dan buyuktur:");
            }while(sayi>0);
            Console.ReadLine();

        }
    }
}
