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
    [Route("api/QWriteRightAnswer")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class QWriteRightAnswerController : ControllerBase
    {
        private readonly dbContext _context;

        public QWriteRightAnswerController(dbContext context)
        {
            _context = context;
        }

        // GET: api/QWriteRightAnswer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QWriteRightAnswer>>> GetQWriteRightAnswers()
        {
            return await _context.QWriteRightAnswers.ToListAsync();
        }

        // GET: api/QWriteRightAnswer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QWriteRightAnswer>> GetQWriteRightAnswer(int id)
        {
            var qWriteRightAnswer = await _context.QWriteRightAnswers.FindAsync(id);

            if (qWriteRightAnswer == null)
            {
                return NotFound();
            }

            return qWriteRightAnswer;
        }

        // PUT: api/QWriteRightAnswer/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQWriteRightAnswer(int id, QWriteRightAnswer qWriteRightAnswer)
        {
            if (id != qWriteRightAnswer.ID)
            {
                return BadRequest();
            }

            _context.Entry(qWriteRightAnswer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QWriteRightAnswerExists(id))
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

        // POST: api/QWriteRightAnswer
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<QWriteRightAnswer>> PostQWriteRightAnswer(QWriteRightAnswer qWriteRightAnswer)
        {
            _context.QWriteRightAnswers.Add(qWriteRightAnswer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQWriteRightAnswer", new { id = qWriteRightAnswer.ID }, qWriteRightAnswer);
        }

        // DELETE: api/QWriteRightAnswer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QWriteRightAnswer>> DeleteQWriteRightAnswer(int id)
        {
            var qWriteRightAnswer = await _context.QWriteRightAnswers.FindAsync(id);
            if (qWriteRightAnswer == null)
            {
                return NotFound();
            }

            _context.QWriteRightAnswers.Remove(qWriteRightAnswer);
            await _context.SaveChangesAsync();

            return qWriteRightAnswer;
        }

        private bool QWriteRightAnswerExists(int id)
        {
            return _context.QWriteRightAnswers.Any(e => e.ID == id);
        }
    }
}
