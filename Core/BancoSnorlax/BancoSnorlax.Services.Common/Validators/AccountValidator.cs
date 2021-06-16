using BancoSnorlax.Domain.Entities;
using FluentValidation;

namespace BancoSnorlax.Services.Common.Validators
{
    public class AccountValidator : AbstractValidator<Account>
    {
        public AccountValidator()
        {
            RuleFor(account => account.Agency).GreaterThan(0).WithMessage("Código da agência não pode ser zero.");
            RuleFor(account => account.Number).GreaterThanOrEqualTo(1000).WithMessage("Agência deve ser maior que 1000.");
            RuleFor(account => account.NegativeSale).GreaterThanOrEqualTo(-1000).WithMessage("Não é permitido saldo abaixo de -1000.00.");
        }
    }
}
