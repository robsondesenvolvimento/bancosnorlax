using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSnorlax.Domain.Contracts
{
    public interface IWriteBankSnorlax<T>
    {
        T Add(T obj);
        void Remove(int id);
    }
}
