using Azure.Core;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _userContext;
        public UserController(UserContext userContext) {
            _userContext = userContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Userr>>> GetUser()
        {
            if(_userContext.users == null)
            {
                return NotFound();
            }
            return await _userContext.users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Userr>> GetUser(short id)
        {
            if (_userContext.users == null)
            {
                return NotFound();
            }
            var userrr = _userContext.users.FindAsync(id);
            if (userrr == null)
            {
                return NotFound();
            }
            return await userrr;
        }

        [HttpPost]
        public async Task<ActionResult<Userr>> PostUser(Userr userr)
        {
            _userContext.users.Add(userr);
            await _userContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUser), new { id = userr.ID }, userr);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutUserr(int id, Userr userr)
        {
            if(id != userr.ID)
            {
                return BadRequest();
            }
            _userContext.Entry(userr).State = EntityState.Modified;
            try
            {
                await _userContext.SaveChangesAsync();
            }catch(DbUpdateConcurrencyException ex)
            {
                throw;
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(short id)
        {
            if(_userContext.users == null)
            {
                return NotFound();
            }
            var userr = await _userContext.users.FindAsync(id);
            if(userr == null) 
            {
                return NotFound();
            }
            _userContext.users.Remove(userr);
            await _userContext.SaveChangesAsync();

            return Ok();
        }
    }
}
