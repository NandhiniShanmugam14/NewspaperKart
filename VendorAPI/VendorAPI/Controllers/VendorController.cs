using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorAPI.CTSModel;

namespace VendorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly NewspaperContext db;
        public VendorController(NewspaperContext _db)

        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllVendor()
        {
            return Ok(await db.Vendortbls.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddVendor(Vendortbl c)
        {
            db.Vendortbls.Add(c);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVendor(int id, Vendortbl c)
        {
            //a = await db.Accounts.FindAsync(id);
            db.Entry(c).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVendor(int id)
        {
            Vendortbl c = db.Vendortbls.Find(id);
            db.Vendortbls.Remove(c);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<Vendortbl>> GetVendorById(int id)
        {
            Vendortbl c = await db.Vendortbls.FindAsync(id);
            return Ok(c);
        }
    }
}
