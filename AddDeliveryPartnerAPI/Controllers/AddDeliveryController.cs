using AddDeliveryPartner.NewsModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddDeliveryPartner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddDeliveryController : ControllerBase
    {


        private readonly NewsKartContext db;
        public AddDeliveryController(NewsKartContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDelivery()
        {
            return Ok(await db.AddDeliverytbls.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddDelivery(AddDeliverytbl a)
        {
            db.AddDeliverytbls.Add(a);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDelivery(int id, AddDeliverytbl a)
        {
            db.Entry(a).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDelivery(int id)
        {
            AddDeliverytbl a = db.AddDeliverytbls.Find(id);
            db.AddDeliverytbls.Remove(a);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<AddDeliverytbl>> GetDeliveryId(int id)
        {
            AddDeliverytbl a = await db.AddDeliverytbls.FindAsync(id);
            return Ok(a);
        }
    }
}
