using Microsoft.AspNetCore.Mvc;
using Blue.Zebra.Domain.Catalog;

[httpGet]
public IActionResult GetItems()
{
    return Ok("hello world.");
}
namespace Blue.Zebra.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CatalogController : ControllerBase
    {

    }
}