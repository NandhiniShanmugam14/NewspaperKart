using DeliveryPartner.NewsModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryPartner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliverypController : ControllerBase
    {
        private readonly NewsKartContext db;
        public DeliverypController(NewsKartContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDeliverypartner()
        {
            return Ok(await db.DeliveryPartnertbls.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddDeliverypartner(DeliveryPartnertbl a)
        {
            db.DeliveryPartnertbls.Add(a);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDeliverypartner(int id, DeliveryPartnertbl d)
        {
            db.Entry(d).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDeliverypartner(int id)
        {
            DeliveryPartnertbl d = db.DeliveryPartnertbls.Find(id);
            db.DeliveryPartnertbls.Remove(d);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<DeliveryPartnertbl>> GetDeliverypatnerById(int id)
        {
            DeliveryPartnertbl d = await db.DeliveryPartnertbls.FindAsync(id);
            return Ok(d);
        }

    }

}

