using FeedbackApi.NewsModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacktblController : ControllerBase
    {
        private readonly NewspaperContext db;
        public FeedbacktblController(NewspaperContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFeedback()
        {
            return Ok(await db.Feedbacktbls.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddFeedback(Feedbacktbl a)
        {
            db.Feedbacktbls.Add(a);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeedback(int id, Feedbacktbl a)
        {
            db.Entry(a).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFeedback(int id)
        {
            Feedbacktbl a = db.Feedbacktbls.Find(id);
            db.Feedbacktbls.Remove(a);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Feedbacktbl>> GetFeedbackById(int id)
        {
            Feedbacktbl a = await db.Feedbacktbls.FindAsync(id);
            return Ok(a);
        }

    }
}
