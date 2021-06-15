using BancoSnorlax.Data.Context;
using BancoSnorlax.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSnorlax.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DatabaseContext _context;

        public AccountRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Account Add(Account obj)
        {
            return _context.Accounts.Add(obj).Entity;
        }

        public Account Find(int id)
        {
            return _context.Accounts.Find(id);
        }

        public IEnumerable<Account> ListALl()
        {
            return _context.Accounts.ToList();
        }

        public void Remove(int id)
        {
            var account = Find(id);
            if (account != null) _context.Accounts.Remove(account);
        }
    }
}
