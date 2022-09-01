using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]    //کسی نمیتواند به این کنترل دست یابی کند تا این که اهراز هویت شود
    public class MembersController : ControllerBase
    {
        private GymApi_DBContext _context;
        public MembersController(GymApi_DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMember()
        {
            return new ObjectResult(_context.Member);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMember([FromRoute] int id)
        {
            var customer = await _context.Member.SingleOrDefaultAsync(c => c.MemberId == id);
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> PostMember([FromBody] Member member)
        {
            _context.Member.Add(member);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetMember", new { id = member.MemberId }, member);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMember([FromRoute] int id, [FromBody] Member member)
        {
            _context.Entry(member).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(member);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMember([FromRoute] int id)
        {
            var member = await _context.Member.FindAsync(id);
            _context.Member.Remove(member);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}