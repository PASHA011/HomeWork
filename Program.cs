using System;

namespace HomeWork
{
    class Program
    {

        static void Main(string[] args)
        {
            string inputCardNumber="";
            DateTime  inputExpireDate=new DateTime() ;
            int inputCvc=132;

            try
            {
                Console.Write("kredi kartınızın numarasını giriniz : ");
                inputCardNumber = Console.ReadLine();
                Console.Write("kredi kartınızın Cvc numarasını giriniz : ");
                inputCvc = Convert.ToInt32(Console.ReadLine());
                Console.Write("kredi kartınızın son kullanma tarihi giriniz : ");
                inputExpireDate = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception)
            {
                Exception CreditCardException = new Exception("Kredi bilgileri yalnış girildi");          
            }
          
            CreditCard creditCard = new CreditCard(
              inputCardNumber,
              inputExpireDate,
              inputCvc);
        }



    }
}
