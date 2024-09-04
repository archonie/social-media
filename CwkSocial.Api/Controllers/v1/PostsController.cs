using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1;


[ApiVersion(1, Deprecated = true)]
[Route(ApiRoutes.BaseRoute)]
[ApiController]
public class PostsController : Controller
{
    [HttpGet(ApiRoutes.Posts.GetById)]
    public IActionResult GetById(int id)
    {
        return Ok();
    }
}