using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataFetch.Data;
using DataFetch.Models;

namespace DataFetch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemDataController : ControllerBase
    {
        private readonly AppDbContext _context = new AppDbContext();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemData>>> GetItems()
        {
            return await _context.ItemData.ToListAsync();
        }
    }
}
