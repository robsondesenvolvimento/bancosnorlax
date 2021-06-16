using System.Collections.Generic;

namespace BancoSnorlax.Domain.Contracts
{
    public interface IReadBankSnorlax<T>
    {
        IEnumerable<T> ListALL();
        T Find(int id);
    }
}
