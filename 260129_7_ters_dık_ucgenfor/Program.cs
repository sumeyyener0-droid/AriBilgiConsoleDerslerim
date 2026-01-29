namespace _260129_7_ters_dık_ucgenfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * for ile * karakteri kullanarak ters dik üçgen yapınız
                            *
                           **
                         ****
                        *****
                       ******
                      *******
                     ********
                    *********
             */
            string yildiz = "*";

            for(int i=1; i<15; )
            {
                for(int k=15; k>i; k--)
                {
                    Console.Write("");
                }
                Console.WriteLine(yildiz);
                yildiz += "*";
            }

        }
    }
}
