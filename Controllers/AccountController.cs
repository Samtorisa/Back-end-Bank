using BankAppAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly DataContext _context;
        
        public AccountController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Account>>> Get()
        {
           
            return Ok(await _context.Accounts.ToListAsync());
        }

        [HttpPut("{AccountId}")]

        public async Task<IActionResult> Putaddition(int AccountId,Account account)
        {
            if(AccountId != account.AccountId)
            {
                return BadRequest();
            }
            _context.Entry(account).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }catch(DbUpdateConcurrencyException)
            {
                if(!AccountExists(AccountId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
               
            
            }
                return NoContent();



        }
       private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e=>e.AccountId == id);    
        }





    }
}
