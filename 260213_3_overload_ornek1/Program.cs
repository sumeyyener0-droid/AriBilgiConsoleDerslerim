namespace _260213_3_overload_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long s1 = DortIslem();
            long s2 = DortIslem();

            Console.WriteLine("2 sayının toplamı"+DortIslem((int) s1,(int)s2));

            Console.WriteLine("2 sayının çarpımı" + DortIslem((double)s1, (double)s2));

            Console.WriteLine("2 sayının farkı:"+DortIslem((long)s1,(long)s2));

            
            Console.WriteLine("büyük sayının küçük sayıdan kalanı:" + DortIslem((float)s1, (float)s2));

            Console.WriteLine("büyük sayının küçük sayıya bölümünden bölümü veren sayı:" + DortIslem((short)s1, (short)s2));

        }

        static int DortIslem(int s1,int s2)
        {
            return s1 + s2;
        }

        static double DortIslem(double s1,double s2)
        {

            return s1 * s2;
        }

        static long DortIslem()
        {
            Console.WriteLine("sayı giriniz:");
            int d1 = Convert.ToInt32(Console.ReadLine());
            return d1;
        }

        static float DortIslem(float s1,float s2)
        {
           
            if(s1>s2)
            {
                
                float sonuc= s1 % s2;
                return sonuc;
            }
            return s2 % s1;
        }

        static int DortIslem(short s1,short s2)
        {
            if(s1>s2)
            {
                int bolum = s1 / s2;
                    return bolum;
            }
            return s2 / s1;
        }


    }
}
