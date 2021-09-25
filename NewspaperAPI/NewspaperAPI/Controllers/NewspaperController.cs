using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewspaperAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewspaperController : ControllerBase
    {
        private readonly NewspaperContext db;
        public NewspaperController(NewspaperContext _db)

        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllNewspapers()
        {
            return Ok(await db.Newspapertbls.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddNewspaper(Newspapertbl c)
        {
            db.Newspapertbls.Add(c);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateNewspaper(int id, Newspapertbl c)
        {
            //a = await db.Accounts.FindAsync(id);
            db.Entry(c).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteNewspapertbl(int id)
        {
            Newspapertbl c = db.Newspapertbls.Find(id);
            db.Newspapertbls.Remove(c);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Newspapertbl>> GetNewspaperById(int id)
        {
            Newspapertbl c = await db.Newspapertbls.FindAsync(id);
            return Ok(c);
        }
    }
}
