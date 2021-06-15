using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSnorlax.Domain.Contracts
{
    public interface IReadBankSnorlax<T>
    {
        IEnumerable<T> ListALl();
        T Find(int id);
    }
}
