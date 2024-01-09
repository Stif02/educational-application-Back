using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [ApiController]//атрибут указывает, что контроллер отвечает на запросы веб-API
    [Route("api/QSelectOutOfFour")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class QSelectOutOfFourController : ControllerBase
    {
        private readonly dbContext _context; //внедряет контекст базы данных в контроллер с помощью внедрения зависимостей

        public QSelectOutOfFourController(dbContext context)
        {
            _context = context;

            if (_context.QSelectOutOfFours.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.QSelectOutOfFours.Add(new QSelectOutOfFour { task = "Question1" });
                _context.SaveChanges();
            }
        }

        //GET: api/QSelectOutOfFour
        [HttpGet] 
        public IQueryable<QSelectOutOfFourDTO> GetQSelectOutOfFours()
        {
            var qSelectOutOfFours = from b in _context.QSelectOutOfFours
                        select new QSelectOutOfFourDTO()
                        {
                            ID = b.ID,
                            answerString=b.answerString,
                            task = b.task,
                            variant1 = b.variant1,
                            variant2 = b.variant2,
                            variant3 = b.variant3,
                            variant4 = b.variant4
                            
                        };
            return qSelectOutOfFours;
        }



        //GET: api/QSelectOutOfFour/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QSelectOutOfFour>> GetQSelectOutOfFour(int ID)
        {
            Console.WriteLine("Start" + ID);
            var item = await _context.QSelectOutOfFours.FindAsync(ID);

            //var itemdto = await _context.QSelectOutOfFours.Include(b => b.ID).Select(b => new QSelectOutOfFourDTO()
            //{
            //    ID = b.ID,
            //    task = b.task,
            //    variant1 = b.variant1,
            //    variant2 = b.variant2,
            //    variant3 = b.variant3,
            //    variant4 = b.variant4,
            //}).SingleOrDefaultAsync(b => b.ID == ID);

            if (item == null)
                return NotFound();

            //ViewBa
            Console.WriteLine("End" + ID);

            return item;
        }

        //POST: api/QSelectOutOfFour
        [HttpPost]
        public async Task<ActionResult<QSelectOutOfFour>> PostQSelectOutOfFour(QSelectOutOfFour qSelectOutOfFour)
        {
            _context.QSelectOutOfFours.Add(qSelectOutOfFour);
            await _context.SaveChangesAsync();

            var dto = new QSelectOutOfFour()
            {
                ID = qSelectOutOfFour.ID,
                task = qSelectOutOfFour.task,
                answerString = qSelectOutOfFour.answerString,
                variant1=qSelectOutOfFour.variant1,
                variant2=qSelectOutOfFour.variant2,
                variant3=qSelectOutOfFour.variant3,
                variant4=qSelectOutOfFour.variant4
            };

            return CreatedAtAction(nameof(GetQSelectOutOfFour), new { id = qSelectOutOfFour.ID }, dto);// метод CreatedAtAction:
            //возвращает код состояния HTTP 201, представляющий собой стандартный ответ для метода HTTP POST, создающий ресурс на сервере.
            //Добавляет заголовок Location в ответ. Заголовок Location расположения указывает URI вновь созданной задачи.
            //Указывает действие GetTodoItem для создания URI заголовка Location. Ключевое слово nameof C# используется для предотвращения жесткого программирования имени действия в вызове CreatedAtAction.
        }

        //PUT: api/QSelectOutOfFour/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQSelectOutOfFour(int ID, QSelectOutOfFour qSelectOutOfFour)
        {
            if (ID != qSelectOutOfFour.ID)
                return BadRequest();
            _context.Entry(qSelectOutOfFour).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //DELETE: api/QSelectOutOfFour/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQSelectOutOfFour(int ID)
        {
            var qSelectOutOfFour = await _context.QSelectOutOfFours.FindAsync(ID);

            if (qSelectOutOfFour == null)
                return NotFound();

            _context.QSelectOutOfFours.Remove(qSelectOutOfFour);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
