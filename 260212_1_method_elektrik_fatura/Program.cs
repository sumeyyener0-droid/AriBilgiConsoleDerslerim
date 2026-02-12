namespace _260212_1_method_elektrik_fatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
 Bir elektrik faturası için bazı şartlar ile fatura hesabı yapılmaktadır. Bu şartlar
eğer kullanılan elektrik kw olarak 0-150 arasında ise her kw için 1.06 Tl ile çarpılarak hesaplanmaktadır
--60*1.06=>       
eğer kullanılan elektrik kw olarak 150-300 arasında ise ilk 150 kw için 140 TL,
 150 kw ve üstü içinde her kw için 1.16 Tl ile çarpılarak hesaplanmaktadır
eğer kullanılan elektrik kw olarak 300-450 arasında ise ilk 150 kw için 320 TL, 300 kw ve üstü içinde her kw için 1.25 Tl ile çarpılarak hesaplanmaktadır
 eğer kullanılan elektrik kw olarak 450-650 arasında ise ilk 150 kw için 530 TL, 450 kw ve üstü içinde her kw için 1.29 Tl ile çarpılarak hesaplanmaktadır
eğer 650 ve üstü ise ilk 650 için 800 Tl, 650 ve üstü içnde 1.32 Tl   ile çarpılarak hesaplanmaktadır
bu şartlar kullanıcının gireceği harcadoğı elektriği kw cinsinden  aldoktan sonra ödeyeceği faturayı hesaplayınız?


 */
            //EkranaYaz ve Oku kullanarak method

            double odenecekTutar;

            Console.WriteLine("Ne kadar elektirik kullanıldı");
            int kw = Convert.ToInt32(Console.ReadLine());

           

            double fatura = FaturaHesabı(kw);

            Console.WriteLine("toplam fatura: " +fatura);


        }
        static double FaturaHesabı(int kw)
        {

            double odenecekTutar;


            if (kw > 0 && kw <= 150)
            {
                odenecekTutar = kw * 1.06;
            }
            else if (kw > 150 && kw < 300)
            {
                odenecekTutar = 140 + (kw - 150) * 1.16;
            }
            else if (kw > 300 && kw < 450)
            {
                odenecekTutar = 320 + (kw - 300) * 1.25;
            }
            else if (kw > 450 && kw < 650)
            {
                odenecekTutar = 530 + (kw - 450) * 1.29;
            }
            else//650 ve üstü için
            {
                odenecekTutar = 800 + (kw - 650) * 1.32;
            }
                return odenecekTutar;
        }

    }
}
