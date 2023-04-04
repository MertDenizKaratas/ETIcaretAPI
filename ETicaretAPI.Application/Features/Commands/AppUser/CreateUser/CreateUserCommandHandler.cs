
using ETicaretAPI.Application.Exceptions;
using ETicaretAPI.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ETicaretAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly UserManager<Domain.Entities.Identity.AppUser> _userService;
        public CreateUserCommandHandler(UserManager<Domain.Entities.Identity.AppUser> userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result = await _userService.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                Email = request.Email,
                NameSurname = request.NameSurname,
                UserName = request.Username,
            }, request.Password);

            CreateUserCommandResponse response = new() { Succeeded= result.Succeeded };

            if (result.Succeeded)
            {
                response.Message = "helal";
            } 
            else
            {
                foreach (var errors in result.Errors)
                {
                    response.Message += $"{errors.Code} - {errors.Description}";
                }
            }
            return response;

            //throw new UserCreateFailedException();
        }
    }
}
