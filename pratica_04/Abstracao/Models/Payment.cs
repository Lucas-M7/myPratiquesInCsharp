using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao.Models
{
    public abstract class Payment
    {
        public DateTime ExpirationDate { get; set; }

        public void Pay()
        {

        }
    }
}