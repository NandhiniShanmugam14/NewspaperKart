using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SubscriptionAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly NewspaperContext db;
        public SubscriptionController(NewspaperContext _db)

        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSubscriptions()
        {
            return Ok(await db.Subscriptiontbls.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddSubscription(Subscriptiontbl c)
        {
            db.Subscriptiontbls.Add(c);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSubscription(int id, Subscriptiontbl c)
        {
            //a = await db.Accounts.FindAsync(id);
            db.Entry(c).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteNewspapertbSubscription(int id)
        {
            Subscriptiontbl c = db.Subscriptiontbls.Find(id);
            db.Subscriptiontbls.Remove(c);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Subscriptiontbl>> GetSubscriptionById(int id)
        {
            Subscriptiontbl c = await db.Subscriptiontbls.FindAsync(id);
            return Ok(c);
        }
    }
}
