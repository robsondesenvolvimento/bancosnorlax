using BancoSnorlax.Data.Context;
using BancoSnorlax.Data.Repositories;
using BancoSnorlax.Domain.Entities;
using BancoSnorlax.Services.Common.Erros;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace BancoSnorlax.Test
{
    public class BancoSnorlaxAccount
    {
        [Fact]
        public void BancoSnorlaxTryExceptValidatorAgencyAndNegativeValue()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var databaseContext = new DatabaseContext(options);

            var _accountRepository = new AccountRepository(databaseContext);

            var account = new Account { Agency = 0, Number = 1000, Sale = 1000.00, NegativeSale = -1001.00 };

            var error = Assert.Throws<AccountException>(() => _accountRepository.Add(account));
            error.ListErrors[0].Should().Be("Código da agência não pode ser zero.");
            error.ListErrors[1].Should().Be("Não é permitido saldo abaixo de -1000.00.");
        }

        [Fact]
        public void BancoSnorlaxAddAndFindAccount()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var databaseContext = new DatabaseContext(options);

            var _accountRepository = new AccountRepository(databaseContext);

            var account = new Account { Agency = 1, Number = 1000, Sale = 1000.00, NegativeSale = -1000.00 };

            var acc = _accountRepository.Add(account);
            acc.Should().NotBeNull();
            acc.Id.Should().Be(1);

            var find = _accountRepository.Find(1);
            find.Should().NotBeNull();
        }
    }
}
