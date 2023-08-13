using CamelSystem.Lookups.Dto;
using CamelSystem.Sessions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelSystem.Common.Dto
{
    public class GetDashboardOutput
    {
        public List<CamelDto> Camels { get; set; }

        public int RolesCount { get; set; }
        public int UsersCount { get; set; }
        public int TenantCount { get; set; }
        public int CamelsCount { get; set; }
    }
}
