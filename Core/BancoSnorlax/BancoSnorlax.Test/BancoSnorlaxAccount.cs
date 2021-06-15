using BancoSnorlax.Domain.Entities;
using System;
using Xunit;
using FluentAssertions;
using Moq;
using BancoSnorlax.Domain.Contracts;
using BancoSnorlax.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using BancoSnorlax.Data.Repositories;
using BancoSnorlax.Services.Common.Validators;
using BancoSnorlax.Services.Common.Erros;

namespace BancoSnorlax.Test
{
    public class BancoSnorlaxAccount
    {
        [Fact]
        public void BancoSnorlaTryExceptValidatorAgencyAndNegativeValue()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var _accountRepository = new AccountRepository(new(options));            

            var account = new Account { Agency = 0, Number = 1000, Sale = 1000.00, NegativeSale = -1001.00 };

            var error = Assert.Throws<AccountException>(() => _accountRepository.Add(account));
            error.ListErrors[0].Should().Be("Código da agência não pode ser zero.");
            error.ListErrors[1].Should().Be("Não é permitido saldo abaixo de -1000.00.");
        }
    }
}
