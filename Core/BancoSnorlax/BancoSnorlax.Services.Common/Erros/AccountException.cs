using System;

namespace BancoSnorlax.Services.Common.Erros
{
    public class AccountException : Exception
    {
        public string[] ListErrors { get; init; }

        public AccountException(string[] listErrors)
        {
            ListErrors = listErrors;
        }
    }
}
