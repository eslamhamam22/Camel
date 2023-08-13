using Abp.Application.Services;
using Abp.Dependency;
using CamelSystem.Common.Dto;
using CamelSystem.Lookups.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelSystem.Common
{
    public interface ICommonAppService : IApplicationService, ITransientDependency
    {
        Task<GetDashboardOutput> GetDashboard();
    }
}
