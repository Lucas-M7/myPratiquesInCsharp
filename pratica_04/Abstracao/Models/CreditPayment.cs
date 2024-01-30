using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao.Models
{
    public class CreditPayment : Payment
    {
        public void PayCreditCard()
        {
            Pay();
        }
    }
}