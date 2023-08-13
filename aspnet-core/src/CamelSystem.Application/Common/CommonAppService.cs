using Abp.Domain.Repositories;
using CamelSystem.Authorization.Roles;
using CamelSystem.Authorization.Users;
using CamelSystem.Common.Dto;
using CamelSystem.Lookups;
using CamelSystem.Lookups.Dto;
using CamelSystem.MultiTenancy;
using CamelSystem.Sessions.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelSystem.Common
{
    public class CommonAppService : CamelSystemAppServiceBase, ICommonAppService
    {
        private readonly IRepository<Camel, long> _camelRepository;
        private readonly IRepository<User, long> _userRepository;
        private readonly IRepository<Role, int> _roleRepository;
        private readonly IRepository<Tenant, int> _tenantRepository;
        public CommonAppService(IRepository<Camel, long> camelRepository, IRepository<User, long> userRepository, IRepository<Role, int> roleRepository, IRepository<Tenant, int> tenantRepository)
        {
            _camelRepository = camelRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _tenantRepository = tenantRepository;
        }

        public async Task<GetDashboardOutput> GetDashboard()
        {
            try
            {
                var roles = await _roleRepository.GetAll().CountAsync();
                var tenants = await _tenantRepository.GetAll().CountAsync();
                var users = await _userRepository.GetAll().CountAsync();
                var camels = await _camelRepository.GetAll().CountAsync();
                var list = await _camelRepository.GetAll().Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreationTime).Skip(0).Take(5).ToListAsync();
                var dto = ObjectMapper.Map<List<CamelDto>>(list);
                return new GetDashboardOutput { Camels = dto, CamelsCount = camels, RolesCount = roles, TenantCount = tenants, UsersCount = users };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
