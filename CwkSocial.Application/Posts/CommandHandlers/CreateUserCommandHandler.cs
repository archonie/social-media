using CwkSocial.Application.Posts.Commands;
using CwkSocial.Dal;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace CwkSocial.Application.Posts.CommandHandlers;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
{
    private readonly DataContext _ctx;

    public CreateUserCommandHandler(DataContext ctx)
    {
        _ctx = ctx;
    }

    public async Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        
    }
}