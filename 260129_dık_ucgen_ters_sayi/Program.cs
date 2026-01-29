
namespace _260129_dık_ucgen_ters_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dik üçgenin karakter sayısı max alınacak şekilde max değerden 0 doğru aynı satırda

            string yildiz = "*";
            
            for (int i=1; i<25; i++)
            {
                Console.Write(yildiz);
                for (int k=i; k>=0; k--)
                {
                    Console.Write(k+",");
                }

                Console.WriteLine();

                yildiz += "*";
            }
        }
    }
}
