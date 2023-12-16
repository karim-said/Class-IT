using Hikmat2.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Soliev.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrowserController : ControllerBase
    {
        private readonly ILogger<BrowserController> _logger;
        ApplicationDbContext context;
        BrowserMethod method;
        public BrowserController(ILogger<BrowserController> logger, ApplicationDbContext _context, BrowserMethod _method)
        {
            _logger = logger;
            context = _context;
            method = _method;
        }
        [HttpGet("Next")]
        public IActionResult Next(Browser browser)
        {
            var db = new Browser()
            {
                Url = browser.Url,
                CoutOfPage = browser.CoutOfPage,
                CurrentPage = browser.CurrentPage
            };
            context.browser.Add(db);
            context.SaveChanges();
            return Content(method.Next(browser).ToString());
        }
    }
}
