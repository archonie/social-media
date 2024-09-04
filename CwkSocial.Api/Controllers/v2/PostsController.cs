using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V2;

[ApiVersion(2)]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class PostsController : Controller
{
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }
}