using BancoSnorlax.Domain.Contracts;
using BancoSnorlax.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSnorlax.Data.Repositories
{
    public interface IAccountRepository : IReadBankSnorlax<Account>, IWriteBankSnorlax<Account>
    {
    }
}
