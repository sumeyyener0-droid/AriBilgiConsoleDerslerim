namespace _260210_3_method_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = SayiAl();
            int s2 = SayiAl();
            int s3 = SayiAl();
            //S1 EN BÜYÜK İSE
            Siralama(s1, s2, s3);
            //S2 EN BÜYÜK İSE
            Siralama(s1, s2, s3);
            //S3 EN BÜYÜK İSE
            Siralama(s1, s2, s3);


        }
        static int SayiAl()
            {

            Console.WriteLine("sayı giriniz:");
            return Convert.ToInt32(Console.ReadLine());
        }
       static void Siralama(int x, int y,int z)
        {
            if(x>y && x>z)
            {
                if(y>z)
                {
                    Console.WriteLine(x+">"+y+">"+z);
                }
                else if (z>y)
                {
                    Console.WriteLine(x + ">" + z + ">" + y);
                }
                    
                else 
                    {
                    Console.WriteLine(x + ">" + z + ">" + y);
                }
            }
        }

        #region My Code but not short
        /*
       static void Siralama(int d1,int d2,int d3)
       {
           int siralama;
           if(d1>d2 && d1>d3)
           {
               if (d2>d3)
               {
                   //d1>d2>d3
                   Console.WriteLine(d1+">"+d2+">"+d3);
               }
               else
               {
                   Console.WriteLine(d1+">"+d3+">"+d2);

               }
           }

       */ 
        #endregion
    }
}

