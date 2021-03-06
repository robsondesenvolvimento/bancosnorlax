using BancoSnorlax.Data.Context;
using BancoSnorlax.Domain.Entities;
using BancoSnorlax.Services.Common.Erros;
using BancoSnorlax.Services.Common.Validators;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var accountValidator = new AccountValidator()?.Validate(obj);

            if (!accountValidator.IsValid)
            {
                List<string> listErrors = new();
                accountValidator.Errors.ForEach(s => listErrors.Add(s.ErrorMessage));

                throw new AccountException(listErrors.ToArray());
            }
            var add = _context.Accounts.Add(obj).Entity;
            _context.SaveChanges();
            return add;

        }

        public Account Find(int id)
        {
            var account = _context.Accounts.Find(id) ?? throw new NullReferenceException(nameof(id));
            return account;
        }

        public IEnumerable<Account> ListALL()
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
