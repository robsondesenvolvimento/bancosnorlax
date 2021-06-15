using BancoSnorlax.Domain.Entities;
using System;
using Xunit;
using FluentAssertions;

namespace BancoSnorlax.Test
{
    public class BancoSnorlaxAccount
    {
        private Account _account;

        public BancoSnorlaxAccount()
        {
            _account ??= new Account() { Agency = 1, Number = 1000, NegativeSale = -1000.00 };
        }

        [Fact]
        public void BancoSnorlaxConfirmImmutableNewAccount()
        {
            _account.Agency.Should().BeOneOf(1);
            _account.Number.Should().BeOneOf(1000);
        }

        [Fact]
        public void BancoSnorlaxSetPositiveSale()
        {
            _account.Sale = 1000;
            _account.Sale.Should().BePositive();
        }

        [Fact]
        public void BancoSnorlaxSetNegativeSale()
        {
            _account.Sale = -1000;
            _account.Sale.Should().BeNegative();
        }

        [Fact]
        public void BancoSnorlexNegativeSale()
        {
            _account.Sale = -1000;
            _account.Sale.Should().BeGreaterOrEqualTo(_account.NegativeSale);
        }
    }
}
