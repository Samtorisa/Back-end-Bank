using BankAppAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessHistoryController : ControllerBase
    {
        private readonly DataContext _context;

        public ProcessHistoryController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProccesHistry>>> Gethistories()
        {

            return Ok(await _context.ProccesHistrys.ToListAsync());
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<ProccesHistry>>> GetHistory(int Id)
        {
            var History = await (from  ProccesHistry in _context.ProccesHistrys
                                       orderby  ProccesHistry.prhist descending
                                        select  ProccesHistry).Take(10).ToListAsync();
            
            if (History == null)
            {
                return NotFound();
            }
            return History;
//FindAsync(Id)
        }

        [HttpPost]
        public async Task<ActionResult> PostprcsHistory(ProccesHistry proccesHistry)
        {
            _context.ProccesHistrys.Add(proccesHistry);

            await _context.SaveChangesAsync();


            return Ok();

        }


    }
}
