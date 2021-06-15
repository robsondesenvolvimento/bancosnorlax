using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSnorlax.Domain.Entities
{
    public class Account
    {
        public int Agency { get; init; }
        public int Number { get; init; }
        public double Sale { get; set; }
        public double NegativeSale { get; init; } = 1000.00;
    }
}
