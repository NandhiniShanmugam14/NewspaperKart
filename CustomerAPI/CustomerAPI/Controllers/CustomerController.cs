using CustomerAPI.CTSModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly NewspaperContext db;
        public CustomerController(NewspaperContext _db)

        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            return Ok(await db.Customertbls.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customertbl c)
        {
            db.Customertbls.Add(c);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAccount(int id, Customertbl c)
        {
            //a = await db.Accounts.FindAsync(id);
            db.Entry(c).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            Customertbl c = db.Customertbls.Find(id);
            db.Customertbls.Remove(c);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Customertbl>> GetAccById(int id)
        {
            Customertbl c = await db.Customertbls.FindAsync(id);
            return Ok(c);
        }
    }
}
