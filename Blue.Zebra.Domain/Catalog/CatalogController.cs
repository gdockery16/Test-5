using Microsoft.AspNetCore.Mvc;
using Blue.Zebra.Domain.Catalog;

namespace Blue.Zebra.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
      [HttpGet]  
      public IActionResult GetItems()
      {
        return Ok("hello world.");
      }
    }
}