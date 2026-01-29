namespace _260129_4_for_ters_gosterme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0-50 arasında her  ekrana yazılacak sayı için büyükten küçüğe ekranda sayıları gösteriniz
            
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine(i+">=");

                for(int k=i; k>=0; k--)
                {
                    Console.WriteLine(k+",");
                }
                Console.WriteLine();
            }
        }
    }
}
