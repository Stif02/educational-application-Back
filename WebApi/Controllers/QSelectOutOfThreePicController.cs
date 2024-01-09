using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/QSelectOutOfThreePic")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class QSelectOutOfThreePicController : ControllerBase
    {
        private readonly dbContext _context;

        public QSelectOutOfThreePicController(dbContext context)
        {
            _context = context;
        }

        // GET: api/QSelectOutOfThreePic
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QSelectOutOfThreePic>>> GetQSelectOutOfThreePics()
        {
            return await _context.QSelectOutOfThreePics.ToListAsync();
        }

        // GET: api/QSelectOutOfThreePic/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QSelectOutOfThreePic>> GetQSelectOutOfThreePic(int id)
        {
            var qSelectOutOfThreePic = await _context.QSelectOutOfThreePics.FindAsync(id);

            if (qSelectOutOfThreePic == null)
            {
                return NotFound();
            }

            return qSelectOutOfThreePic;
        }

        // PUT: api/QSelectOutOfThreePic/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQSelectOutOfThreePic(int id, QSelectOutOfThreePic qSelectOutOfThreePic)
        {
            if (id != qSelectOutOfThreePic.ID)
            {
                return BadRequest();
            }

            _context.Entry(qSelectOutOfThreePic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QSelectOutOfThreePicExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/QSelectOutOfThreePic
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<QSelectOutOfThreePic>> PostQSelectOutOfThreePic(QSelectOutOfThreePic qSelectOutOfThreePic)
        {
            _context.QSelectOutOfThreePics.Add(qSelectOutOfThreePic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQSelectOutOfThreePic", new { id = qSelectOutOfThreePic.ID }, qSelectOutOfThreePic);
        }

        // DELETE: api/QSelectOutOfThreePic/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QSelectOutOfThreePic>> DeleteQSelectOutOfThreePic(int id)
        {
            var qSelectOutOfThreePic = await _context.QSelectOutOfThreePics.FindAsync(id);
            if (qSelectOutOfThreePic == null)
            {
                return NotFound();
            }

            _context.QSelectOutOfThreePics.Remove(qSelectOutOfThreePic);
            await _context.SaveChangesAsync();

            return qSelectOutOfThreePic;
        }

        private bool QSelectOutOfThreePicExists(int id)
        {
            return _context.QSelectOutOfThreePics.Any(e => e.ID == id);
        }
    }
}
