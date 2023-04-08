using ETicaretAPI.Application.DTOs.Configuration;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions.Services.Configurations
{
    public interface IApplicationService
    {
        List<DTOs.Configuration.Menu> GetAuthorizeDefinitionEndpoints(Type type);
    }
}
