using BancoSnorlax.Domain.Contracts;
using BancoSnorlax.Domain.Entities;

namespace BancoSnorlax.Data.Repositories
{
    public interface IAccountRepository : IReadBankSnorlax<Account>, IWriteBankSnorlax<Account>
    {
    }
}
