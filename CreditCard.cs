using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
   public class CreditCard
    {
        public CreditCard(string cardNumber,DateTime expireDate,int cvc)
        {
            DateTime ToDaydate = new DateTime(DateTime.Now.Year);
            
            int result = DateTime.Compare(expireDate, ToDaydate);

            if (cardNumber.Length!=16)
            {
                Console.WriteLine("kart numaranız 16 karater olmalı");
                return;
            }
            else if (cvc > 999||cvc <0)
            {
                Console.WriteLine("cvc numarası 3 numaradan oluşmaktadır");
                return;
            }

            else if (result>0)
            {
                Console.WriteLine("son kullanma tarihi geçmiş ");
                return;
            }
          
         

            CardNumber = cardNumber;
            Cvc = cvc;
            ExpireDate = expireDate;
        }

        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Cvc { get; set; }
    }
}
