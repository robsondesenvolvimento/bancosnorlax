using BancoSnorlax.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BancoSnorlax.ApiRead.Controllers
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

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_accountRepository.ListALL());
        }
    }
}
