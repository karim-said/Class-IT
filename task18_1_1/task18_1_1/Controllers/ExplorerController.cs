using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using task18_1_1.Data;
using task18_1_1.Data.Model;
using task18_1_1.Requests;

namespace task18_1_1.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/explorer")]
    public class ExplorerController(ApplicationDataContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<History>>> GetCategories()
        {
            try
            {
                var categories = await context.Histories.AsQueryable().ToListAsync().ConfigureAwait(false);

                return Ok(categories);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<History>> CreateHistory([FromBody] CreateHistoryRequest request)
        {
            try
            {
                var history = new History()
                {
                    Address = request.Address,
                    CreateAt = DateTime.UtcNow
                };

                context.Histories.Add(history);
                await context.SaveChangesAsync().ConfigureAwait(false);

                return CreatedAtAction(nameof(GetHistoryById), new { id = history.Id }, history);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<History>> GetHistoryById(int id)
        {
            try
            {
                var history = await context.Histories.FindAsync(id);

                if (history == null)
                {
                    return NotFound(); 
                }

                return Ok(history);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult<History>> UpdateHistory(int id, [FromBody] UpDateHistoryRequest request)
        {
            try
            {
                var history = await context.Histories.FindAsync(id);


                history.Address = request.Address;
                history.UpDateAt = DateTime.UtcNow;

                context.Entry(history).State = EntityState.Modified;
                await context.SaveChangesAsync().ConfigureAwait(false);

                return Ok(history);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteHistory(int id)
        {
            try
            {
                var history = await context.Histories.FindAsync(id);

                if (history == null)
                {
                    return NotFound();
                }

                context.Histories.Remove(history);
                await context.SaveChangesAsync().ConfigureAwait(false);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}