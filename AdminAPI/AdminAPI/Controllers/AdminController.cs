using AdminAPI.CTSModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly NewspaperContext db;
        public AdminController(NewspaperContext _db)

        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAdmin()
        {
            return Ok(await db.Admintbls.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddAdmin(Admintbl c)
        {
            db.Admintbls.Add(c);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAdmin(int id, Admintbl c)
        {
            //a = await db.Accounts.FindAsync(id);
            db.Entry(c).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            Admintbl c = db.Admintbls.Find(id);
            db.Admintbls.Remove(c);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<Admintbl>> GetAdminById(int id)
        {
            Admintbl c = await db.Admintbls.FindAsync(id);
            return Ok(c);
        }
    }
}
