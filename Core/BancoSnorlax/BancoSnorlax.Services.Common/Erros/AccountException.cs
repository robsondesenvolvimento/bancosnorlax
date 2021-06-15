using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
