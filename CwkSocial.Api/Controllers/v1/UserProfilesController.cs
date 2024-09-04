using Asp.Versioning;
using CwkSocial.Api.Contracts.UserProfiles.Requests;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1;

[ApiVersion(1, Deprecated = true)]
[Route(ApiRoutes.BaseRoute)]
[ApiController]
public class UserProfilesController : Controller
{
    private readonly IMediator _mediator;

    public UserProfilesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public Task<IActionResult> GetAllProfiles()
    {
        //TODO: Implement function
        return null;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileCreate profile)
    {
        return null;
    }
}