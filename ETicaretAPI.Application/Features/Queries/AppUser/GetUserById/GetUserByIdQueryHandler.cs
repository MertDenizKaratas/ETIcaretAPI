using ETicaretAPI.Application.Abstractions.Services;
using ETicaretAPI.Application.Features.Queries.AppUser.GetAllUsers;
using ETicaretAPI.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.AppUser.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQueryRequest, GetUserByIdQueryResponse>
    {
        readonly IAuthService _userService;

        public GetUserByIdQueryHandler(IAuthService userService)
        {
            _userService = userService;
        }

        public async Task<GetUserByIdQueryResponse> Handle(GetUserByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.RefreshTokenGetUser(request.RefreshToken);
            return new()
            {
                User = user,
            };
        }
    }
}
