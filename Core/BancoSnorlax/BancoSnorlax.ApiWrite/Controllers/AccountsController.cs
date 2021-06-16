using BancoSnorlax.Data.Repositories;
using BancoSnorlax.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BancoSnorlax.ApiWrite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Account account)
        {
            if (!ModelState.IsValid) return BadRequest(account);

            var accountNew = _accountRepository.Add(account);

            return Created("", accountNew);
        }
    }
}
